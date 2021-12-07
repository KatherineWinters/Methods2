using System;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Multiply(10, 2));
          
        }

            public static int Add(int x, int y)
            {
                return x + y;
            }

            public static int Subtract(int x, int y)
            {
                return x - y;
            }
            public static int Multiply(int x, int y)
            { 
                return x * y;
            }
            public static int Divide(int x, int y)
            {
                return x / y;
            }

        }
    }

