using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first whole interger");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second whole interger");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your operator (+, -, x, or /)");
            string oper = Console.ReadLine();           

            if (oper == "+")
            {               
                Console.WriteLine(Sum(one, two));
            }
            if (oper == "-")
            {
                Console.WriteLine(Sub(one, two));
            }

            if (oper == "x")
            {
                Console.WriteLine(Multiply(one, two));
            }

            if (oper == "/")
            {
                Console.WriteLine(Divide(one, two));
            }


        } //Method Line ----------------------------------------------------------------------------------------  
        public static int Sum(int one, int two)
        {
            int add = one + two;
            return add;
        }

        public static int Sub(int one, int two)
        {
            int min = one - two;
            return min;
        }

        public static int Multiply(int one, int two)
        {
            int mult = one * two;
            return mult;
        }

        public static int Divide(int one, int two)
        {
            int div = one/two;
            return div;
        }
    }
}

