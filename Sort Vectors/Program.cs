using System;

namespace Sort_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            Random r = new Random();

            for (int i = 0; i < vet.Length; i++)
                vet[i] = r.Next(int.MinValue,int.MaxValue);

            foreach (int a in vet)
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
