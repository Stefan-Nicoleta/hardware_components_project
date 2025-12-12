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
    public partial class VerificareCompatibilitate : Form
    {
        public VerificareCompatibilitate()
        {
            InitializeComponent();
        }

        private void VerificareCompatibilitate_Load(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            userControl1.Dock = DockStyle.Fill;
            this.Controls.Add(userControl1);
        }
    }
}
