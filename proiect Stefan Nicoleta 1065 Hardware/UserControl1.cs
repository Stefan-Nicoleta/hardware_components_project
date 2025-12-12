using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click1(object sender, EventArgs e)
        {
            
        }

        private void btnVerifica_Click_1(object sender, EventArgs e)
        {
            string calc = cbCalculatoare.Text;
            string comp = cbComponente.Text;

           

            if (CompatibilitateHelper.compatibilitate.ContainsKey("Lenovo"))
            {
                lblStatus.Text = "✅ Compatibil!";
            }
            if(CompatibilitateHelper.compatibilitate.ContainsKey("Microsoft"))
            {
                lblStatus.Text = "❌ Nu este compatibil!";
            }
        }

        

    }
}
