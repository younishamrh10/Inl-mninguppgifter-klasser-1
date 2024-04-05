using System;

namespace Inlämninguppgifter_klasser_1
{
    class program
    {
        static void main(string[] args)
        {
            Class1 bil1 = new Class1("BMW", "m5", 2024, 500, 360);
            Console.WriteLine("Bil 1:");
            Console.WriteLine("Märke: " + bil1.Märke);
            Console.WriteLine("Modell: " + bil1.Modell);
            Console.WriteLine("Årsmodell: " + bil1.Årsmodell);
            Console.WriteLine("Hästrkrafter: " + bil1.Hästkrafter);
            Console.WriteLine(" MAxhastighet: " + bil1.Maxhastighet); 
        }
    }
}