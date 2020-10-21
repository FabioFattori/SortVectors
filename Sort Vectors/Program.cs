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
                vet[i] = r.Next(-100,100);

            Array.Sort(vet);

            for (int i = 0; i < vet.Length; i++)
            {
                
                Console.WriteLine(vet[i]);
            }



            Console.WriteLine("array ordinato con successo e il valore minimo è" + vet[0]);

            Console.ReadKey();
        }
    }
}
