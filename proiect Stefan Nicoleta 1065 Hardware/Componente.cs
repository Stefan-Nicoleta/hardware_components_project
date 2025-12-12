using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    public class Componente
    {
        public string numeComponenta;
        //public string dimensiune;

        public Componente()
        {
            this.numeComponenta = "";
            //this.dimensiune = "";
        }

        public Componente(string numeComponenta)
        {
            this.numeComponenta = numeComponenta;
            //this.dimensiune = dimensiune;
        }

        public string NumeComponenta
        {
            get { return this.numeComponenta; }
            set
            {
                this.numeComponenta = value;
            }
        }

        //public string Dimensiune
        //{
        //    get { return this.dimensiune; }
        //    set
        //    {
        //        this.dimensiune = value;
        //    }
        //}

        public override string ToString()
        {
            return this.numeComponenta;
        }

    }
}
