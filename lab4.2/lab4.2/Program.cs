using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие: \n1) +\n2) -\n3) *\n4) /");
            int C = int.Parse(Console.ReadLine());

            switch (C)
            {
                case 1:
                    plus(A, B);
                    break;
                case 2:
                    minus(A, B);
                    break;
                case 3:
                    umn(A, B);
                    break;
                case 4:
                    del(A, B);
                    break;
            }

            void plus(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            void minus(int a, int b)
            {
                Console.WriteLine(a - b);
            }

            void umn(int a, int b)
            {
                Console.WriteLine(a * b);
            }

            void del(int a, int b)
            {
                double _1 = (double)a;
                double _2 = (double)b;
                Console.WriteLine(_1 / _2);

                Console.WriteLine('"');
            }
        }
    }
}
