using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    [Serializable]
    public partial class Form1 : Form
    {
        private string connStr = "Data Source=proiect.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            errorProvider1 = new ErrorProvider();
            dataGridView1.AllowDrop = true;
            dataGridView1.DragEnter += new DragEventHandler(dataGridView1_DragEnter);
            dataGridView1.DragDrop += new DragEventHandler(dataGridView1_DragDrop);


            this.salvaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.inchidereToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tbId.Text);
            string n = cbNume.Text;
            int p = Convert.ToInt32(nudPret.Value);
            string m = tbModel.Text;
            string c = clbComponente.Text;
            bool es = checkBoxCompatibilitate.Checked;



            nudPret.Maximum = 10000;


            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                errorProvider1.SetError(tbId, "Acest camp nu poate fi gol!");
                MessageBox.Show("Introduceti un id!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.SetError(tbId, "");
            }
            if (!int.TryParse(tbId.Text, out int valoare4))
            {
                errorProvider1.SetError(tbId, "Acest camp nu poate contine litere!");
                MessageBox.Show("Introduceti un id!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.SetError(tbId, "");
            }

            if (string.IsNullOrWhiteSpace(cbNume.Text))
            {
                errorProvider1.SetError(cbNume, "Acest camp nu poate fi gol!");
                MessageBox.Show("Introduceti un nume!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.SetError(cbNume, "");
            }

            if (int.TryParse(n, out int valoare))
            {
                errorProvider1.SetError(cbNume, "Acest camp nu poate contine cifre!");
                MessageBox.Show("Introduceti un nume valid!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.SetError(cbNume, "");
            }

            //nu exista calculator mai ieftin de 1000 de lei
            if (nudPret.Value == 0)
            {
                errorProvider1.SetError(nudPret, "Trebuie sa selectati un pret!");
                MessageBox.Show("Introduceti un pret valid!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                nudPret.Focus();
            }
            else
            {
                errorProvider1.SetError(nudPret, "");
            }

            if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                errorProvider1.SetError(tbModel, "Acest camp nu poate fi gol!");
                MessageBox.Show("Introduceti un model!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.SetError(tbModel, "");
            }

            if (int.TryParse(m, out int valoare1))
            {
                errorProvider1.SetError(tbModel, "Acest camp nu poate contine cifre!");
                MessageBox.Show("Introduceti un model valid!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                errorProvider1.SetError(tbModel, "");
            }

            if (clbComponente.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(clbComponente, "Trebuie sa selectati cel putin un element!");
                MessageBox.Show("Trebuie să selectezi cel puțin un element!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(clbComponente, "");
            }

            if (es == false)
            {
                MessageBox.Show("Trebuie bifata casuta de compatibilitate intre componente si calculator pentru a se trece mai departe", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string componenteText = string.Join(", ", clbComponente.CheckedItems.Cast<object>().Select(item => item.ToString()));


            Calculatoare calculatoare = new Calculatoare(i, n, p, m, componenteText);


            ListViewItem lv = lvCalculatoare.Items.Add(calculatoare.id.ToString());
            lv.SubItems.Add(calculatoare.nume);
            lv.SubItems.Add(calculatoare.pret.ToString());
            lv.SubItems.Add(calculatoare.model);
            lv.SubItems.Add(componenteText);

            lv.Tag = calculatoare;




        }

        private void lvCalculatoare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaComponete_Click(object sender, EventArgs e)
        {
            FormAdaugaComponente f = new FormAdaugaComponente();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Componente compNoua = f.componentaNoua;

                bool exista = clbComponente.Items
    .OfType<Componente>()
    .Any(c => c.NumeComponenta == compNoua.NumeComponenta);

                if (!exista)
                {
                    clbComponente.Items.Add(compNoua);
                }
                else
                {
                    MessageBox.Show("Componenta există deja.");
                }
            }
        }



        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fisiere XML(.XML)|*.xml";
            saveFile.CheckPathExists = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                TextWriter fisier = new StreamWriter(saveFile.FileName);
                XmlSerializer xmlSerializator = new XmlSerializer(typeof(List<Calculatoare>));
                List<Calculatoare> listaCalculatoare = new List<Calculatoare>();
                foreach (ListViewItem item in lvCalculatoare.Items)
                {
                    listaCalculatoare.Add((Calculatoare)item.Tag);
                }
                xmlSerializator.Serialize(fisier, listaCalculatoare);

                fisier.Close();
            }
        }

        private void deschidereXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fisiere xml(.xml)|*.xml";
            openFile.CheckFileExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializator = new XmlSerializer(typeof(List<Calculatoare>));
                FileStream fisier = File.OpenRead(openFile.FileName);
                List<Calculatoare> listaCalculatoare;

                listaCalculatoare = (List<Calculatoare>)xmlSerializator.Deserialize(fisier);

                fisier.Close();
                foreach (Calculatoare c in listaCalculatoare)
                {
                    ListViewItem itm1 = new ListViewItem(new string[] {
                c.nume, c.pret.ToString(),
                c.model, c.componente
            });
                    itm1.Tag = c;
                    lvCalculatoare.Items.Add(itm1);
                }

            }
        }

        private void salvareJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fisiere JSON (*.json)|*.json";
            saveFile.CheckPathExists = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                List<Calculatoare> lista = new List<Calculatoare>();
                foreach (ListViewItem item in lvCalculatoare.Items)
                {
                    if (item.Tag is Calculatoare calc)
                        lista.Add(calc);
                }

                string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(saveFile.FileName, json);
                MessageBox.Show("Datele au fost salvate în fișier JSON.");
            }
        }

        //nu mi afiseaza numele la deschidere!
        private void deschidereJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Fisiere JSON (*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonText = File.ReadAllText(openFile.FileName);
                    List<Calculatoare> lista = JsonSerializer.Deserialize<List<Calculatoare>>(jsonText);

                    lvCalculatoare.Items.Clear();

                    foreach (var calc in lista)
                    {
                        ListViewItem item = new ListViewItem(calc.nume);
                        item.SubItems.Add(calc.pret.ToString());
                        item.SubItems.Add(calc.model);
                        item.SubItems.Add(calc.componente);


                        item.Tag = calc;
                        lvCalculatoare.Items.Add(item);
                    }

                    MessageBox.Show("Datele au fost încărcate cu succes din JSON.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la deserializare: " + ex.Message);
                }
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lvCalculatoare.SelectedItems.Count > 0)
            {
                optiuneStergereUnElement.Enabled = true;
                stergereTotToolStripMenuItem.Enabled = true;
                optiuneStergereUnElement.Visible = true;
                stergereTotToolStripMenuItem.Visible = true;
            }
            else
            {
                optiuneStergereUnElement.Enabled = false;
                stergereTotToolStripMenuItem.Enabled = false;
            }
        }

        private void stergereTotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvCalculatoare.Items.Clear();
        }

        private void optiuneStergereUnElement_Click(object sender, EventArgs e)
        {
            if (lvCalculatoare.SelectedItems.Count > 0)
            {
                lvCalculatoare.SelectedItems[0].Remove();
            }

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void adaugaComponentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdaugaComponete_Click(sender, e);
        }

        private void adaugaGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGrafic_Click(sender, e);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D) // Verificăm dacă s-a apăsat Ctrl + D
            {
                StergeElementSelectat();
            }
        }

        private void StergeElementSelectat()
        {
            // Ștergere din DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Ești sigur că vrei să ștergi această înregistrare?\n Aceasta inregistrare nu va mai putea fi recuperata.", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    DatabaseHelper.StergeCalculator(id);
                    AfiseazaCalculatoare();
                }



            }

            // Ștergere din ListView
            if (lvCalculatoare.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvCalculatoare.SelectedItems)
                {
                    lvCalculatoare.Items.Remove(item);
                }
            }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {

            List<int> preturi = new List<int>();

            foreach (ListViewItem item in lvCalculatoare.Items)
            {
                if (int.TryParse(item.SubItems[2].Text, out int pret))
                {
                    preturi.Add(pret);
                }
            }


            AdaugaGrafic graficForm = new AdaugaGrafic(preturi);
            graficForm.Show();

        }

        private void schimbareFundalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();


            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = this.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float y = 100;
            float x = 100;
            float lineHeight = font.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString("Lista Calculatoare:", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight * 2;

            foreach (ListViewItem item in lvCalculatoare.Items)
            {
                string text = $"Id: {item.SubItems[0].Text}|Nume: {item.SubItems[1].Text} | Pret: {item.SubItems[2].Text} | Model: {item.SubItems[3].Text} | Componente: {item.SubItems[4].Text}";
                e.Graphics.DrawString(text, font, Brushes.Black, x, y);
                y += lineHeight;
            }

            e.HasMorePages = false;
        }

        private void imprimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument1;
            preview.ShowDialog();

        }

        //captura ecran

        private void printScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapturaEcran();
        }
        private void printPage2(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap = null;
        private void CapturaEcran()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        //

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseHelper.GetCalculatoare();
            notifyIcon1.Icon = SystemIcons.Information; // Setează o iconiță standard
            //notifyIcon1.Text = "Proiectul s-a deschis cu succes"; // Textul din System Tray
            notifyIcon1.Visible = true;

            // Afișează o notificare pop-up
            notifyIcon1.ShowBalloonTip(5000, "Notificare", "Proiectul s-a deschis cu succes!", ToolTipIcon.Info);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Actualizare automată a progresului


            timer1.Tick += (s, ev) =>
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value += 1;
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Procesul a fost finalizat!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            timer1.Start();

            timer1.Interval = 1000; // Rulează la fiecare 1 secundă
            timer1.Tick += timer1_Tick; // Adaugă evenimentul Tick
            timer1.Start();




        }



        private void btnAdaugaBD_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbId.Text);
                string nume = cbNume.Text.Trim();
                int pret = (int)nudPret.Value;
                string model = tbModel.Text.Trim();
                string componente = string.Join(", ", clbComponente.CheckedItems.Cast<string>());


                if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(componente))
                {
                    MessageBox.Show("Completează toate câmpurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DatabaseHelper.AdaugaComponenta(id, nume, pret, model, componente);
                MessageBox.Show("Calculator salvat!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbNume.SelectedIndex = -1;
                nudPret.Value = 0;
                tbModel.Clear();
                foreach (int i in clbComponente.CheckedIndices)
                    clbComponente.SetItemChecked(i, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare la salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var calculatoare = DatabaseHelper.GetCalculatoare();
                dataGridView1.DataSource = calculatoare;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afișare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                stergereToolStripMenuItem.Enabled = true;
                stergereToolStripMenuItem.Visible = true;
            }
            else
            {
                stergereToolStripMenuItem.Enabled = false;
                stergereToolStripMenuItem.Visible = false;
            }
        }


        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Ești sigur că vrei să ștergi această înregistrare?\n Aceasta inregistrare nu va mai putea fi recuperata.", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    DatabaseHelper.StergeCalculator(id);
                    AfiseazaCalculatoare();
                }
            }
        }

        private void stergeToateElementeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseHelper.StergeToateCalculatoarele();
            dataGridView1.DataSource = DatabaseHelper.GetCalculatoare();

        }
        private void AfiseazaCalculatoare()
        {
            var calculatoare = DatabaseHelper.GetCalculatoare();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = calculatoare;
        }
        private void lvCalculatoare_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvCalculatoare.SelectedItems.Count > 0)
            {
                var item = lvCalculatoare.SelectedItems[0];
                var data = new string[item.SubItems.Count];

                for (int i = 0; i < item.SubItems.Count; i++)
                    data[i] = item.SubItems[i].Text;

                lvCalculatoare.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string[])))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            var data = (string[])e.Data.GetData(typeof(string[]));

            if (data != null && data.Length == 5)
            {
                DatabaseHelper.AdaugaCalculator(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]), data[3], data[4]);
                dataGridView1.DataSource = DatabaseHelper.GetCalculatoare();
            }
            else
            {
                MessageBox.Show($"Eroare: Datele nu corespund cu structura tabelului! Așteptate: 5, primite: {data.Length}.",
                    "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Datele au fost salvate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inchidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnTestareCompatibilitate_Click(object sender, EventArgs e)
        {

            VerificareCompatibilitate v = new VerificareCompatibilitate();
            v.Show();
            //UserControl1 userControl1 = new UserControl1();
            //userControl1.Dock = DockStyle.Fill;
            //this.Controls.Add(userControl1);
        }

        private void adaugareChartBdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareChart adaugareChart = new AdaugareChart();
            adaugareChart.Show();
        }

        
    }
}
