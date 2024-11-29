namespace TestProject
{
    public class Triangle(double FirstSide, double SecondSide, double ThirdSide) : IShape
    {
        public double FirstSide { get; set; } = FirstSide;
        public double SecondSide { get; set; } = SecondSide;
        public double ThirdSide { get; set; } = ThirdSide;

        public double CalculateArea()
        {
            double s = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(s * (s - FirstSide) * (s - SecondSide) * (s - ThirdSide));
        }

        public bool IsAngleRight()
        {
            var sides = new double[] { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}