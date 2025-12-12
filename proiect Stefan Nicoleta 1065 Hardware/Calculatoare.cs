using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    public class Calculatoare
    {
        public int id;
        public string nume;
        public int pret;
        public string model;
        public string componente;
        

        public Calculatoare()
        {
            this.id = 0;
            this.nume = "";
            this.pret = 0;
            this.model = "";
            this.componente = "";
            
        }

        public Calculatoare(int _id,string _nume, int _pret, string _model, string _lista)
        {
            this.id = _id;
            this.nume = _nume;
            this.pret = _pret;
            this.model = _model;
            this.componente = _lista;
            

        }



        public string Nume
        {
            get { return this.nume; }
            set
            {
                if (value.Length < 0)
                {
                    this.nume = value;
                }
            }
        }

        public int Pret
        {
            get { return pret; }
            set
            {
                if (value != 0)
                {
                    this.pret = value;
                }
            }
        }


        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length > 0)
                {
                    this.model = value;
                }
            }
        }

        public string Lista
        {
            get { return this.componente; }
            set
            {
                this.componente = value;
            }
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }

      

        public override string ToString()
        {
            return "ID: " +this.id+ "Nume: " + this.nume + " ,Pret: " + this.pret + " ,Model: " + this.model + "Componente: " + this.componente;
        }





    }
}
