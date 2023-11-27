using System;
namespace Uppgift_5_A6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 tal separerade med asterisker");
            float produkt = 1;
            while (true)
            {
                try
                {
                    string problem = Console.ReadLine();
                    string[] faktorerStr = problem.Split('*');

                    float[] faktorer = new float[faktorerStr.Length];
                    for (int i = 0; i < faktorerStr.Length;i++)
                    {
                        faktorer[i] = float.Parse(faktorerStr[i]);
                    }

                    foreach (float tal in faktorer)
                    {
                        produkt *= tal;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Det är inte ett giltigt problem! Försök igen.");
                }
            }

            Console.WriteLine($"Produkt: {produkt}.");

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}