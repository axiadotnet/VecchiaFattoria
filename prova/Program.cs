using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {

            Gatto g = new Gatto();

            g.Zampe = 7;

            g.occhi = 2;

            Animale[] animali = { new Gatto(), new Cane(), new Mucca() , new Gallina(), new Maiale() };

            foreach (Animale animale in animali)
            {
                animale.FaiILTuoVerso();
            }












        }
    }
}
