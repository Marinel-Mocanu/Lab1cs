using System;

namespace HelloWorld
{
    class Salariu
    {
        public double Tarif_Ora;
        public int Ore_Lucrate;

        public Salariu(double tarif_Ora, int ore_Lucrate)
        {
            Tarif_Ora = tarif_Ora;//double
            Ore_Lucrate = ore_Lucrate;
        }

        public double calculezaSalariu()
        {
            double salariul= Tarif_Ora * Ore_Lucrate;
            if (salariul > 3000)
            {
                Console.WriteLine("salariu mare");
                return salariul;
            }
            else
            {
                Console.WriteLine("ati lucrat prea puține ore pentru a avea un salariu mare!");
                return salariul;
            }
        }

        static void Main()
        {
            Salariu s = new Salariu(25.5, 200);
            double rezultat = s.calculezaSalariu();
            Console.WriteLine("salariu=" + rezultat);
        }
    }
}