using System.Reflection.Metadata.Ecma335;

public class Square : Rectangle
{
    public Square() { }
    public Square(double side)
    {
        this.width = side;
    }
    public Square(double side, string color, bool filled)
    {
    }

    public double GetSide()
    {
        return width;
    }
    public void SetSide(double side)
    {
        width = side;
    }
    public override void SetWidth(double width)
    {
        this.width = width;
    }
    public override void SetLength(double length)
    {
        this.length = length;
    }
    public override string ToString()
    {
        return $"Square [{base.ToString()}]";
    }

}