using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    class Compatibilitati
    {
        bool esteCompatibil;

        public Compatibilitati()
        {
            this.esteCompatibil = false;
        }

        public Compatibilitati(bool esteCompatibil)
        {
            this.esteCompatibil = esteCompatibil;
        }


        public bool EsteCompatibil
        {
            get{ return this.esteCompatibil; }
            set{
                this.esteCompatibil = value;
            }
        }


        public override string ToString()
        {
            return "Este Componenta Compatibila cu Calculatorul? " + this.esteCompatibil;
        }
    }
}
