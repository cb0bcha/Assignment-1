namespace RiverFlowCalculator.Domain
{
    public interface ISectionFactory
    {
        Section GetSection(SectionType sectionType, double width);

        Section GetSection(SectionType sectionType, double width, double depthAtStart, double depthAtEnd, double velocity);
    }
}
