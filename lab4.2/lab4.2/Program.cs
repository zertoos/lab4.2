using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
