using RiverFlowCalculator.Common;
using RiverFlowCalculator.Properties;
using System;

namespace RiverFlowCalculator.Domain
{
    public class CrossSection : ICrossSectionOperations
    {
        private Section[] _sections;
        private ISectionFactory _sectionFactory;

        public CrossSection(ISectionFactory sectionFactory, double width, double interval)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width));
            if (interval <= 0) throw new ArgumentOutOfRangeException(nameof(interval));

            _sectionFactory = sectionFactory;
            Width = width;
            Interval = interval;
            
            NumberOfSections = (int)Math.Ceiling(Width / Interval);

            if (NumberOfSections < 5) throw new Exception(string.Format(Resources.NOT_ENOUGH_SECTIONS_ERROR, AppConstants.MINIMUM_NUMBER_OF_SECTIONS));
            if (NumberOfSections > 200) throw new Exception(string.Format(Resources.MORE_THAN_ENOUGH_SECTIONS_ERROR, AppConstants.MAXIMUM_NUMBER_OF_SECTIONS));

            CreateSections();
        }

        public double Width { get; private set; }

        public double Interval { get; private set; } 

        public int NumberOfSections { get; private set; }

        public Section this[int index]
        {
            get
            {
                return _sections?[index];
            }
        }

        public double GetCumulativeDistance(int index)
        {
            double distance = 0;

            for (int i = 0; i <= index; i++)
            {
                distance += _sections[i].Width;
            }

            return distance;
        }

        public void UpdateSection(int index, double width, double depthAtStart, double depthAtEnd, double velocity)
        {
            _sections[index] = _sectionFactory.GetSection(SectionType.Trepezoidal, width, depthAtStart, depthAtEnd, velocity);
        }

        public double CalculateTotalArea()
        {
            double totalArea = 0;

            foreach (var section in _sections)
            {
                totalArea += section.Area;
            }

            return totalArea;
        }

        public double CalculateTotalDischarge()
        {
            double totalDischarge = 0;
            
            foreach (var section in _sections)
            {
                totalDischarge += section.Discharge;
            }

            return totalDischarge;
        }

        private void CreateSections()
        {
            _sections = new Section[NumberOfSections];

            double remainingWidth = Width;

            for (int i = 0; i < NumberOfSections; i++)
            {
                if (remainingWidth >= Interval)
                {
                    _sections[i] = _sectionFactory.GetSection(SectionType.Trepezoidal, Interval);
                    remainingWidth -= Interval;
                }
                else
                {
                    _sections[i] = _sectionFactory.GetSection(SectionType.Trepezoidal, remainingWidth);
                }
            }
        }
    }
}