using Exercise_4;

public class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Radius = 4;
        Console.WriteLine(circle.CalculateArea());

        Rectangle rectangle = new Rectangle();
        rectangle.Width = 3;
        rectangle.Height = 3;
        Console.WriteLine(rectangle.CalculateArea());
    }
}
