namespace Shapes;

public class Rectangle : Shape
{
    public double Width { private set; get; }
    public double Height { private set; get; }
    
    public Rectangle(double width, double height)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double CalculateArea()
    {
        return this.Width * this.Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (this.Width + this.Height);
    }

    public override string Draw()
    {
        return $"{base.Draw()}{this.GetType().Name}";
    }
}