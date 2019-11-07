using System;
using System.Collections.Generic;
using System.Text;

namespace prova
{
    abstract class Animale
    {
        public virtual void DiIlTuoNome()
        {
            Console.WriteLine("Animale");
        }

        public abstract void FaiILTuoVerso();

    }
}
