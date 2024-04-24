namespace Shapes;

public class Circle : Shape
{
    public double Radius { private set; get; }
    
    public Circle(double raduis)
    {
        this.Radius = raduis;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public override string Draw()
    {
        return $"{base.Draw()}{this.GetType().Name}";
    }
}