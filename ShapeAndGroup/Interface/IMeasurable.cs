namespace ShapeAndGroup
{
    public interface IMeasurable
    {
        IMeasure Measure { get; set; }
        double GetMeasure();
    }
}
