using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    public partial class FormAdaugaComponente : Form
    {
        public Componente componentaNoua { get; set; }
        public FormAdaugaComponente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAduagaComponenta_Click(object sender, EventArgs e)
        {
            string denumire = tbDenumire.Text;
           ;

            if (string.IsNullOrEmpty(tbDenumire.Text))
            {
                MessageBox.Show("Introduceti o componenta!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if(int.TryParse(denumire, out int valoare))
            {
                MessageBox.Show("Introduceti o denumire valida!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            //if (!int.TryParse(dimensiune, out int dim) || dim <= 0)
            //{
            //    MessageBox.Show("Introduceți o dimensiune validă!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    return;
            //}

            //componentaNoua = new Componente(denumire, dimensiune);
            componentaNoua = new Componente(denumire);

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
