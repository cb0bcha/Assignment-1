namespace RiverFlowCalculator.Domain
{
    public sealed class TrapezoidalSection : Section
    {
        public TrapezoidalSection(double width) : base(width)
        {
        }

        public TrapezoidalSection(double width, double depthAtStart, double depthAtEnd, double velocity) : base(width, depthAtStart, depthAtEnd, velocity)
        {

        }

        public override double Area 
        {
            get
            {
                if (!_area.HasValue)
                {
                    _area = (DepthAtStart + DepthAtEnd) * Width / 2;
                }

                return _area.Value;
            }
        }
    }
}