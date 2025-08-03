namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 4. Abstraction
            // 4. Abstraction :
            // abstract : C# Keyword [class - methods - properties]
            // abstract class
            // abstract method
            // abstract property

            // 2D Shape


            // Shape shape = new Shape();
            // NOTE : Can't Create Object From Abstract Class

            //shape.GetArea();

            //Rectangle rectangle = new Rectangle() { Dim01 = 12, Dim02 = 3 };

            //rectangle.Perimeter = 12;

            //Console.WriteLine(rectangle.Perimeter);

            //Console.WriteLine(rectangle.GetArea());

            //rectangle.Print(); 
            #endregion

            #region Interface Vs Abstract Class
            // Interface -----------Vs----------> Abstract Class
            // Code Contract --> Kind of Class
            // Implement only --> Inheret and Implement
            /*
              Default Access Modifire :
                Public --> Private
            */
            /* Can Create : 
             * Interface : 
                1- Signature of Method
                2- Signature Of Property
                3- Default Implemented Method
             * Abstract Class : 
             *  1- Attribute
             *  2- Method
             *  3- Property
             *  4- Event
             *  5, 6 - Abstract Method or Property
            */
            #endregion

            #region Operator Overloading
            // Operator Overloading

            // + - * / % > < >= <= !=== || && ! | & ! ^ >>

            // +

            //int X = 3 +4;
            //string Y = "Hello " + "World";

            // Complex Number : Real + Imag

            // 4 + 3 i
            // 4 + 3 ت

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            //Complex C03;

            //C03 = C01 + C02;
            //Console.WriteLine(C03);

            //C03 = C01 - C02;
            //Console.WriteLine(C03);

            //C03 = C01 - null;
            //Console.WriteLine(C03);


            // ++ --
            // Unary Operator

            // intX = 12;

            // X++;

            //Console.WriteLine(X);


            //Console.WriteLine(C01);
            //Complex C03 = C01++;

            //Console.WriteLine(C03);

            //C03 = C01--;

            //Console.WriteLine(C03);

            //if (C01 > C02)
            //{
            //    Console.WriteLine(value: "C01 is greater than C02");
            //}
            //else
            //{
            //    Console.WriteLine(value: "C01 is NOT greater than C02");
            //} 
            #endregion

            #region User-Defined Casting Operator & Mapping
            //double X =12;

            //int Y = (int) x;
            //// (int) : Casting Operator

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };

            //string S = (string) C01;
            // (string) : Convert Complex Number To String

            // Operator Overloading
            // User-Defined Casting Operator

            //Console.WriteLine(S);

            //int X = (int)C01;

            //Console.WriteLine(X);

            //int X = (int)new Complex() { Real = 4, Imag = 7 };



            // Mapping : Convert From Datatype To Datatype

            // Code First
            //// DB First

            // User [Id, Name, Email, Password, UserName, PhoneNumber, CardNumber, ExipreDate]

            // UserViewModel
            // UserDto
            // [Name, Email, PhoneNumber]


            //User user = new User(); // From DB

            //// Mannual Mapping
            //UserDto userDto = new UserDto()
            //{
            //    Name = user.Name,
            //    Email = user.Email,
            //    PhoneNumber = user.PhoneNumber
            //};

            // Casting Operator

            // Automapper : Automatic Mapping 
            #endregion














        }
    }
}
