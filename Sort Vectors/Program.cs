using System;

namespace Sort_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int massimo;
            Random r = new Random();

            for (int i = 0; i < vet.Length; i++)
                vet[i] = r.Next(int.MinValue,int.MaxValue);

            Array.Sort(vet);

            foreach (int a in vet)
                Console.WriteLine(a);

            Console.WriteLine("array ordinato con successo");

            massimo = Massimo(vet);
            Console.WriteLine("valore massimo = " + massimo);

            static int Massimo (int[] v)
            {
                int tmp;
                tmp = v[v.Length - 1];
                return tmp;
            }

            Console.ReadKey();

        }
    }
}
