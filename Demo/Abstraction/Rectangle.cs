namespace Demo.Abstraction
{
    // Concret Class : Fully Implemented Class
    internal class Rectangle : Shape /* : Implement And Inherit From Shape */
    {
        public override double Perimeter
        {
            get
            {
                return 2 * (Dim01 + Dim02);
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
