using System;

namespace TypeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            int number1 = 10;//32 Bit
            long number2 = 10;//64 Bit
            short number3 = 10;//16 Bit
            byte number4 = 10;//8 Bit
            double number5 = 4.5; //32 bit
            decimal number6 = 4.2;//64 Bit

            bool condition = false;
            char charcters = 'A';

            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.ReadLine();

        }
    }

    enum Days
    {
        Monday,
        Tuesday

    }
}
