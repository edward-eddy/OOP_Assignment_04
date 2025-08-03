namespace Demo.Abstraction
{
    internal class Square : Shape
    {
        public override double Perimeter
        {
            get
            {
                return Dim01 * 4;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
