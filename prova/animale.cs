using System;
using System.Collections.Generic;
using System.Text;

namespace prova
{
    abstract class Animale : IAnimal, IEssereVivente
    {




        int IAnimal.Zampe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.Orecchie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IAnimal.Occhi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IEssereVivente.Occhi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Animale()
        {
            Zampe = 4;
            occhi = 5;
        }
        public virtual void DiIlTuoNome()
        {
            Zampe = 5;
            occhi = 3;
            Console.WriteLine("Animale");
        }

        void IAnimal.FaiIlTuoVerso()
        {
            throw new NotImplementedException();
        }

        void IAnimal.Mangia()
        {
            throw new NotImplementedException();
        }

        void IAnimal.Dormi()
        {
            throw new NotImplementedException();
        }
    }
}
