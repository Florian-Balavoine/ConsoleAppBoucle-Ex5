using System;
namespace ConsoleAppBoucle_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consommation = 1;   
            double objectif = 2;       
            int annees = 0;

            while (consommation < objectif)
            {
                consommation = consommation * 1.08;   
                annees = annees + 1;
            }

            Console.WriteLine("La consommation double au bout de " + annees + " ans.");
        }
    }
}
