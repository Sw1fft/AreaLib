namespace ShapeAreaLib
{
    public class Triangle : Shape
    {
        public double ValueA { get; set; }
        public double ValueB { get; set; }
        public double ValueC { get; set; }

        public Triangle(double valueA, double valueB, double valueC)
        {
            ValueA = valueA;
            ValueB = valueB;
            ValueC = valueC;
        }

        public override double GetArea()
        {
            double p = (ValueA + ValueB + ValueC) / 2;

            return Math.Sqrt(p * (p - ValueA) * (p - ValueB) * (p - ValueC));
        }
    }
}
