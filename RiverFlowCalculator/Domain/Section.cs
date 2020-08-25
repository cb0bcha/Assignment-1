using System;

namespace RiverFlowCalculator.Domain
{
    public enum SectionType { Trepezoidal, Rectangular };

    public abstract class Section
    {
        protected double? _area;
        private double? _discharge;

        public Section(double width)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width));

            Width = width;
        }

        public Section(double width, double depthAtStart, double depthAtEnd, double velocity) : this(width)
        {
            if (depthAtStart < 0) throw new ArgumentOutOfRangeException(nameof(depthAtStart));
            if (depthAtEnd < 0) throw new ArgumentOutOfRangeException(nameof(depthAtEnd));
            if (velocity < 0) throw new ArgumentOutOfRangeException(nameof(velocity));

            DepthAtStart = depthAtStart;
            DepthAtEnd = depthAtEnd;
            Velocity = velocity;
        }

        public double Width { get; private set; }

        public double DepthAtStart { get; private set; }

        public double DepthAtEnd { get; private set; }

        public double Velocity { get; private set; }

        public abstract double Area { get; }

        public virtual double Discharge
        {
            get
            {
                if (!_discharge.HasValue)
                {
                    _discharge = Area * Velocity;
                }

                return _discharge.Value;
            }
        }
    }
}