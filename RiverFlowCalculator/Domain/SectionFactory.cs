using RiverFlowCalculator.Properties;
using System;

namespace RiverFlowCalculator.Domain
{
    public class SectionFactory : ISectionFactory
    {
        public Section GetSection(SectionType sectionType, double width)
        {
            switch (sectionType)
            {
                case SectionType.Trepezoidal:
                    return new TrapezoidalSection(width);
                case SectionType.Rectangular:
                    throw new NotImplementedException(Resources.RECTANGULAR_SECTION_NOT_IMPLEMENTED_ERROR);
                default:
                    throw new NotSupportedException(string.Format(Resources.ENUM_VALUE_NOT_SUPPORTED_ERROR, sectionType.ToString()));
            }
        }

        public Section GetSection(SectionType sectionType, double width, double depthAtStart, double depthAtEnd, double velocity)
        {
            switch (sectionType)
            {
                case SectionType.Trepezoidal:
                    return new TrapezoidalSection(width, depthAtStart, depthAtEnd, velocity);
                case SectionType.Rectangular:
                    throw new NotImplementedException(Resources.RECTANGULAR_SECTION_NOT_IMPLEMENTED_ERROR);
                default:
                    throw new NotSupportedException(string.Format(Resources.ENUM_VALUE_NOT_SUPPORTED_ERROR, sectionType.ToString()));
            }
        }
    }
}
