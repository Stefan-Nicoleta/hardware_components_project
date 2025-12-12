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
    public partial class AdaugaGrafic : Form
    {
        private List<int> preturi;

        public AdaugaGrafic(List<int> preturi)
        {
            InitializeComponent();
            this.preturi = preturi;
            panelGrafic.Paint += panelGrafic_Paint;
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            DeseneazaGrafic(e.Graphics, panelGrafic.ClientRectangle, preturi);
        }

        private void DeseneazaGrafic(Graphics g, Rectangle zona, List<int> date)
        {

            int padding = 40;
            int width = zona.Width - 2 * padding;
            int height = zona.Height - 2 * padding;

            g.Clear(Color.White);

            // Axe
            Pen axaPen = new Pen(Color.Black, 2);
            g.DrawLine(axaPen, padding, padding, padding, padding + height);
            g.DrawLine(axaPen, padding, padding + height, padding + width, padding + height);

            if (date.Count < 2)
                return;

            int max = date.Max();
            float dx = (float)width / (date.Count - 1);
            float dy = (float)height / Math.Max(1, max);

            Pen linie = new Pen(Color.Blue, 2);
            for (int i = 0; i < date.Count - 1; i++)
            {
                float x1 = padding + i * dx;
                float y1 = padding + height - date[i] * dy;
                float x2 = padding + (i + 1) * dx;
                float y2 = padding + height - date[i + 1] * dy;
                g.DrawLine(linie, x1, y1, x2, y2);
            }

            // Puncte și etichete
            for (int i = 0; i < date.Count; i++)
            {
                float x = padding + i * dx;
                float y = padding + height - date[i] * dy;
                g.FillEllipse(Brushes.Red, x - 3, y - 3, 6, 6);
                g.DrawString(date[i].ToString(), this.Font, Brushes.Black, x - 10, y - 20);
            }
        }
    }
}

