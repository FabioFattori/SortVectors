using System;

namespace Sort_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[15];

            Random r = new Random();

            for (int i = 0; i < vet.Length; i++)
                vet[i] = r.Next(int.MinValue,int.MaxValue);

            Array.Sort(vet);

            foreach (int a in vet)
                Console.WriteLine(a);

            Console.WriteLine("array ordinato con successo");
            Console.WriteLine("massimo: " + RicercaMassimo(vet));
            Console.ReadKey();
        }

        public static int RicercaMassimo(int[] vet)
        {
            int massimo = int.MinValue;
            foreach(int a in vet)
            {
                if (a > massimo)
                {
                    massimo = a;
                }
            }
            return massimo;
        }
    }
}
