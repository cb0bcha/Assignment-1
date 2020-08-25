namespace RiverFlowCalculator
{
    partial class RiverFlowCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerText = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.intervalWidthText = new System.Windows.Forms.Label();
            this.sectionDataGridView = new System.Windows.Forms.DataGridView();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumulativeDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthAtStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthAtEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateFlowButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.intervalWidthTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.CausesValidation = false;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(636, 22);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(263, 29);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "River Flow Calculator";
            // 
            // widthText
            // 
            this.widthText.AutoSize = true;
            this.widthText.CausesValidation = false;
            this.widthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthText.Location = new System.Drawing.Point(56, 65);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(246, 20);
            this.widthText.TabIndex = 1;
            this.widthText.Text = "Distance across stream (m)";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTextBox.Location = new System.Drawing.Point(364, 65);
            this.widthTextBox.MaxLength = 6;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(148, 26);
            this.widthTextBox.TabIndex = 2;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // intervalWidthText
            // 
            this.intervalWidthText.AutoSize = true;
            this.intervalWidthText.CausesValidation = false;
            this.intervalWidthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalWidthText.Location = new System.Drawing.Point(56, 113);
            this.intervalWidthText.Name = "intervalWidthText";
            this.intervalWidthText.Size = new System.Drawing.Size(160, 20);
            this.intervalWidthText.TabIndex = 5;
            this.intervalWidthText.Text = "Interval Width (m)";
            // 
            // sectionDataGridView
            // 
            this.sectionDataGridView.AllowUserToAddRows = false;
            this.sectionDataGridView.AllowUserToDeleteRows = false;
            this.sectionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sectionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sectionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interval,
            this.cumulativeDistance,
            this.width,
            this.depthAtStart,
            this.depthAtEnd,
            this.Velocity,
            this.Area,
            this.Discharge});
            this.sectionDataGridView.Location = new System.Drawing.Point(60, 214);
            this.sectionDataGridView.Name = "sectionDataGridView";
            this.sectionDataGridView.RowHeadersWidth = 51;
            this.sectionDataGridView.RowTemplate.Height = 24;
            this.sectionDataGridView.Size = new System.Drawing.Size(1467, 488);
            this.sectionDataGridView.TabIndex = 5;
            this.sectionDataGridView.Visible = false;
            this.sectionDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.sectionDataGridView_CellValueChanged);
            this.sectionDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.sectionDataGridView_EditingControlShowing);
            // 
            // Interval
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval.DefaultCellStyle = dataGridViewCellStyle1;
            this.Interval.HeaderText = "Section #";
            this.Interval.MinimumWidth = 6;
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            this.Interval.Width = 75;
            // 
            // cumulativeDistance
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cumulativeDistance.DefaultCellStyle = dataGridViewCellStyle2;
            this.cumulativeDistance.HeaderText = "Cumulative Distance (m)";
            this.cumulativeDistance.MinimumWidth = 6;
            this.cumulativeDistance.Name = "cumulativeDistance";
            this.cumulativeDistance.ReadOnly = true;
            this.cumulativeDistance.Width = 125;
            // 
            // width
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.width.DefaultCellStyle = dataGridViewCellStyle3;
            this.width.HeaderText = "Width (m)";
            this.width.MinimumWidth = 6;
            this.width.Name = "width";
            this.width.ReadOnly = true;
            this.width.Width = 125;
            // 
            // depthAtStart
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.depthAtStart.DefaultCellStyle = dataGridViewCellStyle4;
            this.depthAtStart.HeaderText = "Depth at Start (m)";
            this.depthAtStart.MaxInputLength = 15;
            this.depthAtStart.MinimumWidth = 6;
            this.depthAtStart.Name = "depthAtStart";
            this.depthAtStart.ReadOnly = true;
            this.depthAtStart.Width = 125;
            // 
            // depthAtEnd
            // 
            dataGridViewCellStyle5.NullValue = "0";
            this.depthAtEnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.depthAtEnd.HeaderText = "Depth at End (m)";
            this.depthAtEnd.MaxInputLength = 10;
            this.depthAtEnd.MinimumWidth = 6;
            this.depthAtEnd.Name = "depthAtEnd";
            this.depthAtEnd.Width = 125;
            // 
            // Velocity
            // 
            dataGridViewCellStyle6.NullValue = "0";
            this.Velocity.DefaultCellStyle = dataGridViewCellStyle6;
            this.Velocity.HeaderText = "Velocity (m/s)";
            this.Velocity.MaxInputLength = 10;
            this.Velocity.MinimumWidth = 6;
            this.Velocity.Name = "Velocity";
            this.Velocity.Width = 125;
            // 
            // Area
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Area.DefaultCellStyle = dataGridViewCellStyle7;
            this.Area.HeaderText = "Area (m2)";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 150;
            // 
            // Discharge
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Discharge.DefaultCellStyle = dataGridViewCellStyle8;
            this.Discharge.HeaderText = "Discharge (m3/s)";
            this.Discharge.MinimumWidth = 6;
            this.Discharge.Name = "Discharge";
            this.Discharge.ReadOnly = true;
            this.Discharge.Width = 150;
            // 
            // calculateFlowButton
            // 
            this.calculateFlowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateFlowButton.Location = new System.Drawing.Point(323, 158);
            this.calculateFlowButton.Name = "calculateFlowButton";
            this.calculateFlowButton.Size = new System.Drawing.Size(242, 38);
            this.calculateFlowButton.TabIndex = 6;
            this.calculateFlowButton.Text = "Calculate Discharge";
            this.calculateFlowButton.UseVisualStyleBackColor = true;
            this.calculateFlowButton.Visible = false;
            this.calculateFlowButton.Click += new System.EventHandler(this.calculateFlowButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(60, 158);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 38);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // intervalWidthTextBox
            // 
            this.intervalWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalWidthTextBox.Location = new System.Drawing.Point(364, 110);
            this.intervalWidthTextBox.MaxLength = 6;
            this.intervalWidthTextBox.Name = "intervalWidthTextBox";
            this.intervalWidthTextBox.Size = new System.Drawing.Size(148, 26);
            this.intervalWidthTextBox.TabIndex = 3;
            this.intervalWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(186, 158);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 38);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // RiverFlowCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 734);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.intervalWidthTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.calculateFlowButton);
            this.Controls.Add(this.sectionDataGridView);
            this.Controls.Add(this.intervalWidthText);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.headerText);
            this.Name = "RiverFlowCalculatorForm";
            this.Text = "River Flow Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label widthText;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label intervalWidthText;
        private System.Windows.Forms.DataGridView sectionDataGridView;
        private System.Windows.Forms.Button calculateFlowButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox intervalWidthTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumulativeDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthAtStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthAtEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discharge;
    }
}

