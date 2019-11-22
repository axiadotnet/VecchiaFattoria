using System;
using System.Collections.Generic;
using System.Text;

namespace prova
{
    interface IAnimal
    {

        int Zampe { get; set; }
        int Orecchie { get; set; }
        int Occhi { get; set; }
        void FaiIlTuoVerso();
        void Mangia();
        void Dormi();
        
    }
}
