namespace RiverFlowCalculator.Domain
{
    public interface ICrossSectionOperations
    {
        int NumberOfSections { get; }

        Section this[int index] { get; }

        double GetCumulativeDistance(int index);

        void UpdateSection(int index, double width, double depthAtStart, double depthAtEnd, double velocity);

        double CalculateTotalArea();

        double CalculateTotalDischarge();
    }
}
