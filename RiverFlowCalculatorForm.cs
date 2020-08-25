using RiverFlowCalculator.Common;
using RiverFlowCalculator.Domain;
using RiverFlowCalculator.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RiverFlowCalculator
{
    public partial class RiverFlowCalculatorForm : Form
    {
        private ICrossSectionOperations _crossSection;
        private ISectionFactory _sectionFactory;

        public RiverFlowCalculatorForm()
        {
            InitializeComponent();

            _sectionFactory = new SectionFactory();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            submitButton.Enabled = false;

            try
            {
                _crossSection = new CrossSection(_sectionFactory, Double.Parse(widthTextBox.Text), Double.Parse(intervalWidthTextBox.Text));

                CreateDataGrid();

                sectionDataGridView.Visible = true;
                calculateFlowButton.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.APPLICATION_TITLE);
                submitButton.Enabled = true;
            }
        }

        private void calculateFlowButton_Click(object sender, EventArgs e)
        {
            double width, depthAtStart, depthAtEnd, velocity = 0;
            DataGridViewRow row;

            for (int i = 0; i < _crossSection.NumberOfSections; i++)
            {
                row = sectionDataGridView.Rows[i];

                width = Convert.ToDouble(row.Cells[2].Value);
                depthAtStart = Convert.ToDouble(row.Cells[3].Value);
                depthAtEnd = Convert.ToDouble(row.Cells[4].Value);
                velocity = Convert.ToDouble(row.Cells[5].Value);

                _crossSection.UpdateSection(i, width, depthAtStart, depthAtEnd, velocity);

                row.Cells[6].Value = _crossSection[i].Area;
                row.Cells[7].Value = _crossSection[i].Discharge;
            }

            CalculateResults();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sectionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;

            if (e.ColumnIndex == 4 && e.RowIndex < gridView.Rows.Count - 1)
            {
                gridView.Rows[e.RowIndex + 1].Cells[3].Value = gridView.Rows[e.RowIndex].Cells[4].Value;
            }
        }

        private void sectionDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress);

            if (sectionDataGridView.CurrentCell.ColumnIndex == 4 || sectionDataGridView.CurrentCell.ColumnIndex == 5)
            {
                TextBox tb = e.Control as TextBox;

                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sectionDataGridView.Rows.Clear();
            sectionDataGridView.Visible = false;
            calculateFlowButton.Visible = false;
            submitButton.Enabled = true;
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            var width = Double.Parse(((TextBox)widthTextBox).Text);
            intervalWidthTextBox.Text = (width / AppConstants.MINIMUM_NUMBER_OF_SECTIONS).ToString();
        }

        private void CreateDataGrid()
        {
            var numberOfSections = _crossSection.NumberOfSections;
            sectionDataGridView.Rows.Add(numberOfSections);

            var lastRow = sectionDataGridView.Rows[numberOfSections - 1];
            lastRow.Cells[4].ReadOnly = true;
            lastRow.Cells[4].Style.BackColor = Color.LightGray;

            Section section;
            DataGridViewRow row;

            for (int i = 0; i < numberOfSections; i++)
            {
                row = sectionDataGridView.Rows[i];
                section = _crossSection[i];

                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = _crossSection.GetCumulativeDistance(i);
                row.Cells[2].Value = section.Width;
                row.Cells[3].Value = section.DepthAtStart;
                row.Cells[4].Value = section.DepthAtEnd;
                row.Cells[5].Value = section.Velocity;
                row.Cells[6].Value = section.Area;
                row.Cells[7].Value = section.Discharge;
            }
        }

        private void CalculateResults()
        {
            if (sectionDataGridView.Rows.Count == _crossSection.NumberOfSections)
            {
                CreateResultsRow();
            }

            var resultsRow = sectionDataGridView.Rows[sectionDataGridView.Rows.Count - 1];
            resultsRow.Cells[6].Value = _crossSection.CalculateTotalArea();
            resultsRow.Cells[7].Value = _crossSection.CalculateTotalDischarge();
        }

        private void CreateResultsRow()
        {
            sectionDataGridView.Rows.Add();
            var resultsRow = sectionDataGridView.Rows[sectionDataGridView.Rows.Count - 1];
            resultsRow.Cells[6].Style.BackColor = Color.LightBlue;
            resultsRow.Cells[7].Style.BackColor = Color.LightBlue;
        }
    }
}
