namespace ShapeAndGroup
{
    public abstract class Shape2D : IShape
    {
        public IPoint StartPosition { get; set; }

        public double Heigth { get; private set; }

        public double Width { get; private set; }

        public virtual IMeasure Measure { get; set; }

        public double GetMeasure()
        {
            return Measure.GetResult(this);
        }

        public Shape2D(IPoint startPosition, double Heigth, double Width, IMeasure Measure)
        {
            StartPosition = startPosition;
            this.Heigth = Heigth;
            this.Width = Width;
            this.Measure = Measure;
        }
    }
}
