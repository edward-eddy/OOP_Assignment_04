namespace Demo.Static
{
    // Static [Helper] Class
    internal static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        private static double pi;

        //public Utilities()
        //{
        //    pi = 3.14;
        //}

        static Utilities()
        {
            pi = 3.14;
        }

        // Static Method : Class Member Method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        // 3.14
        // Static Property
        public static double PI
        {
            get
            {
                return pi;
            }
        }

    }
}
