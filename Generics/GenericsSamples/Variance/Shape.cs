namespace Wrox.ProCSharp.Generics
{
    public abstract class Shape
    {
        public Shape(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Width { get;  }
        public double Height { get; }

        public override string ToString() => $"Width: {Width}, Height: {Height}";
    }
}