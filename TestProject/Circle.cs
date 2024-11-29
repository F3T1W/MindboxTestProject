namespace TestProject
{
    public class Circle(double radius) : IShape
    {
        public double Radius { get; set; } = radius;

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}