public class Circle : Shape
{
    protected double radius = 1.0;

    public Circle() { }

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return radius * radius * 3.14;
    }
    public override double GetPerimeter()
    {
        return 2 * 3.14;
    }
    public override string ToString()
    {
        return $"Circle [{base.ToString()},radius = {radius}]";
    }

}