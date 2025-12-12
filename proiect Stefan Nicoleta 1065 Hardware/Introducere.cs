using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    public partial class Introducere : Form
    {

        public Introducere()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();




        }

        private void Introducere_Load(object sender, EventArgs e)
        {

        }

        private void informatiiProiectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformatiiProiect informatiiProiect = new InformatiiProiect();
            informatiiProiect.Show();


        }

        private void cerintaProiectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "file:///C:/Users/LENOVO/Desktop/PAW/Proiect%20PAW/Proiecte_PAW_2025.pdf",
                UseShellExecute = true
            });
        }
    }
}
