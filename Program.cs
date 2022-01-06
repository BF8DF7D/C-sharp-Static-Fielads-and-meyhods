using System;

namespace C_sharp_Static_Fielads_and_meyhods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Disease one = new Disease();
            Console.WriteLine($" Колиичество смертей до создания объекта№1       : {Disease.GetDeaths()}");
            one.ChangeDeaths(200);
            Console.WriteLine($" Колиичество смертей после создания объекта№1    : {Disease.GetDeaths()}");
            Disease two = new Disease();
            two.ChangeDeaths(400);
            Console.WriteLine($" Колиичество смертей после создания объекта№2    : {Disease.GetDeaths()}");
            Console.WriteLine($" Колиичество смертей после объекта№2 в объекте№1 : {two.GetDiseaseDeaths()}");
            Console.ReadKey();
        }
    }
}
