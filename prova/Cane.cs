using System;
using System.Collections.Generic;
using System.Text;

namespace prova
{
    class Cane : Animale
    {
        public override void DiIlTuoNome()
        {
            Console.WriteLine("cane");
        }

        public override void FaiILTuoVerso()
        {
            Console.WriteLine("bau");
        }
    }
}
