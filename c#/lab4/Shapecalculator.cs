
public interface Ishape
{
    double Circle(double r);
    double Triangle(double b, double h);
    double Square(double sideLength);

}

public class Shapecalculator : Ishape
{
    public double Circle(double r)
    {
        return 3.14 * r * r;
    }
    public double Triangle(double b,double h)
    {
        return 0.5 * b * h;
    }
    public double Square(double sideLength)
    {
        return sideLength * sideLength;
    }

}