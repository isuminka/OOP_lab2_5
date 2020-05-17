using System;

namespace OOP_lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмiри матрицi: ");

            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] A = new int[int.Parse(elements[0])][];

            var random = new Random();

            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = new int[int.Parse(elements[1])];

                for (int j = 0; j < A[i].Length; ++j)
                {
                    A[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -5}", A[i][j]);
                }

                Console.WriteLine();
            }

            int d = 1;

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    d *= A[i][j];
                }
            }

            int a = A.Length * A[0].Length;

            if ((d < 0) && (a % 2 == 0))
            {
                Console.WriteLine("Не iснує!");
            }
            else
            {
                Console.WriteLine("sg = {0:f4}", Math.Pow(d, 1.0 / a));
            }
        }
    }
}
