public abstract class Shape
{
    protected string color = "red";
    protected bool filled = true;

    public Shape()
    {
    }
    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public bool isFilled()
    {
        if (filled == true)
        {
            return true;
        }
        return false;
    }
    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();


    public override string ToString()
    {
        return $"Shape [color = {color}, filled = {filled}]";
    }

}