
namespace ShapeAndGroup
{
    public interface IShape : IMeasurable
    {
        IPoint StartPosition { get; set; }
    }
}
