using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first whole interger");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your operator (+, -, x, or %");
            string oper = Console.ReadLine();
            Console.WriteLine("Please enter your second whole interger");
            int two = int.Parse(Console.ReadLine());

            if (oper == "+")
            {               
                Console.WriteLine(Sum(one, two));
            }


        } //Method Line ----------------------------------------------------------------------------------------  
        public virtual int Sum(int one, int two)
        {
            int add = one + two;
            return add;
        }
    }
}

