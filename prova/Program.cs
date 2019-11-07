using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Gatto gatto = new Gatto();

            Cane cane = new Cane();

            gatto.DiIlTuoNome();

            cane.DiIlTuoNome();

            gatto.FaiILTuoVerso();

            cane.FaiILTuoVerso();

            Mucca carolina = new Mucca();

            Animale[] animali = { gatto, cane, carolina, new Gallina() };

            foreach (Animale animale in animali)
            {
                animale.FaiILTuoVerso();

            }


            Gatto nuovoGatto = (Gatto)animali[0];

            

            Animale animale0 = animali[0];

            nuovoGatto.FaiILTuoVerso();

            animale0.FaiILTuoVerso();







        }
    }
}
