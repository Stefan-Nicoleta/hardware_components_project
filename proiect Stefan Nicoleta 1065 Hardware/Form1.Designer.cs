namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            nudPret = new NumericUpDown();
            tbModel = new TextBox();
            lvCalculatoare = new ListView();
            ID = new ColumnHeader();
            Nume = new ColumnHeader();
            Pret = new ColumnHeader();
            Model = new ColumnHeader();
            Componente = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            stergereToolStripMenuItem = new ToolStripMenuItem();
            optiuneStergereUnElement = new ToolStripMenuItem();
            stergereTotToolStripMenuItem = new ToolStripMenuItem();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            adaugaComponentaToolStripMenuItem = new ToolStripMenuItem();
            adaugaGraficToolStripMenuItem = new ToolStripMenuItem();
            clbComponente = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdaugaCalculatoare = new Button();
            errorProvider1 = new ErrorProvider(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            tbId = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            stergeToolStripMenuItem = new ToolStripMenuItem();
            stergeToateElementeleToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnAdaugaBD = new Button();
            fisiereToolStripMenuItem = new ToolStripMenuItem();
            salvareXMLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deschidereXMLToolStripMenuItem = new ToolStripMenuItem();
            salvareJSONToolStripMenuItem = new ToolStripMenuItem();
            deschidereJSONToolStripMenuItem = new ToolStripMenuItem();
            salvaToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripDropDownMenu();
            schimbareFundalToolStripMenuItem = new ToolStripMenuItem();
            imprimaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            inchidereToolStripMenuItem = new ToolStripMenuItem();
            cbNume = new ComboBox();
            checkBoxCompatibilitate = new CheckBox();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            label8 = new Label();
            progressBar1 = new ProgressBar();
            btnTestareCompatibilitate = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPret).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 76);
            label1.Name = "label1";
            label1.Size = new Size(924, 46);
            label1.TabIndex = 0;
            label1.Text = "Informatii despre calculatoarele vandute in aceasta luna";
            // 
            // nudPret
            // 
            nudPret.Location = new Point(165, 274);
            nudPret.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPret.Name = "nudPret";
            nudPret.Size = new Size(220, 27);
            nudPret.TabIndex = 2;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(165, 341);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(220, 27);
            tbModel.TabIndex = 3;
            // 
            // lvCalculatoare
            // 
            lvCalculatoare.Columns.AddRange(new ColumnHeader[] { ID, Nume, Pret, Model, Componente });
            lvCalculatoare.ContextMenuStrip = contextMenuStrip1;
            lvCalculatoare.Location = new Point(476, 240);
            lvCalculatoare.Name = "lvCalculatoare";
            lvCalculatoare.Size = new Size(648, 398);
            lvCalculatoare.TabIndex = 4;
            lvCalculatoare.UseCompatibleStateImageBehavior = false;
            lvCalculatoare.View = View.Details;
            lvCalculatoare.SelectedIndexChanged += lvCalculatoare_SelectedIndexChanged;
            lvCalculatoare.MouseDown += lvCalculatoare_MouseDown;
            // 
            // ID
            // 
            ID.Text = "Id";
            ID.Width = 80;
            // 
            // Nume
            // 
            Nume.Text = "Nume";
            Nume.TextAlign = HorizontalAlignment.Center;
            Nume.Width = 80;
            // 
            // Pret
            // 
            Pret.Text = "Pret";
            Pret.TextAlign = HorizontalAlignment.Center;
            Pret.Width = 80;
            // 
            // Model
            // 
            Model.Text = "Model";
            Model.TextAlign = HorizontalAlignment.Center;
            Model.Width = 80;
            // 
            // Componente
            // 
            Componente.Text = "Componente";
            Componente.TextAlign = HorizontalAlignment.Center;
            Componente.Width = 200;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { stergereToolStripMenuItem, adaugaToolStripMenuItem, adaugaComponentaToolStripMenuItem, adaugaGraficToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(217, 100);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // stergereToolStripMenuItem
            // 
            stergereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optiuneStergereUnElement, stergereTotToolStripMenuItem });
            stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            stergereToolStripMenuItem.Size = new Size(216, 24);
            stergereToolStripMenuItem.Text = "stergere";
            stergereToolStripMenuItem.Click += stergereToolStripMenuItem_Click;
            // 
            // optiuneStergereUnElement
            // 
            optiuneStergereUnElement.Name = "optiuneStergereUnElement";
            optiuneStergereUnElement.Size = new Size(251, 26);
            optiuneStergereUnElement.Text = "sterge un element";
            optiuneStergereUnElement.Click += optiuneStergereUnElement_Click;
            // 
            // stergereTotToolStripMenuItem
            // 
            stergereTotToolStripMenuItem.Name = "stergereTotToolStripMenuItem";
            stergereTotToolStripMenuItem.Size = new Size(251, 26);
            stergereTotToolStripMenuItem.Text = "stergere toate elemente";
            stergereTotToolStripMenuItem.Click += stergereTotToolStripMenuItem_Click;
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(216, 24);
            adaugaToolStripMenuItem.Text = "adauga calculator";
            adaugaToolStripMenuItem.Click += adaugaToolStripMenuItem_Click_1;
            // 
            // adaugaComponentaToolStripMenuItem
            // 
            adaugaComponentaToolStripMenuItem.Name = "adaugaComponentaToolStripMenuItem";
            adaugaComponentaToolStripMenuItem.Size = new Size(216, 24);
            adaugaComponentaToolStripMenuItem.Text = "adauga componenta";
            adaugaComponentaToolStripMenuItem.Click += adaugaComponentaToolStripMenuItem_Click;
            // 
            // adaugaGraficToolStripMenuItem
            // 
            adaugaGraficToolStripMenuItem.Name = "adaugaGraficToolStripMenuItem";
            adaugaGraficToolStripMenuItem.Size = new Size(216, 24);
            adaugaGraficToolStripMenuItem.Text = "adauga grafic";
            adaugaGraficToolStripMenuItem.Click += adaugaGraficToolStripMenuItem_Click;
            // 
            // clbComponente
            // 
            clbComponente.FormattingEnabled = true;
            clbComponente.Items.AddRange(new object[] { "Placa de baza", "CPU", "Memorie RAM", "Placa Video", "Placa Video dedicata", "DVD/CD", "SO (sistem de operare)", "HDD/SSD", "Sursa de alimentare", "Ventilator si sitem de racire", "Sistem de racire cu lichid", "Ecran Tactil", "Carcasa", "Placa de sunet", "Placa de retea", "Conectivitate WI-FI" });
            clbComponente.Location = new Point(163, 412);
            clbComponente.Name = "clbComponente";
            clbComponente.Size = new Size(220, 334);
            clbComponente.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 220);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 6;
            label2.Text = "Nume:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 277);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 7;
            label3.Text = "Pret:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 344);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 8;
            label4.Text = "Model: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 554);
            label5.Name = "label5";
            label5.Size = new Size(145, 24);
            label5.TabIndex = 9;
            label5.Text = "Componente:";
            // 
            // btnAdaugaCalculatoare
            // 
            btnAdaugaCalculatoare.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdaugaCalculatoare.Location = new Point(727, 670);
            btnAdaugaCalculatoare.Name = "btnAdaugaCalculatoare";
            btnAdaugaCalculatoare.Size = new Size(224, 107);
            btnAdaugaCalculatoare.TabIndex = 10;
            btnAdaugaCalculatoare.Text = "Adauga Calculatoare";
            btnAdaugaCalculatoare.UseVisualStyleBackColor = true;
            btnAdaugaCalculatoare.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // tbId
            // 
            tbId.Location = new Point(165, 156);
            tbId.Name = "tbId";
            tbId.Size = new Size(220, 27);
            tbId.TabIndex = 16;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { stergeToolStripMenuItem, stergeToateElementeleToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(237, 52);
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // stergeToolStripMenuItem
            // 
            stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            stergeToolStripMenuItem.Size = new Size(236, 24);
            stergeToolStripMenuItem.Text = "sterge";
            stergeToolStripMenuItem.Click += stergeToolStripMenuItem_Click;
            // 
            // stergeToateElementeleToolStripMenuItem
            // 
            stergeToateElementeleToolStripMenuItem.Name = "stergeToateElementeleToolStripMenuItem";
            stergeToateElementeleToolStripMenuItem.Size = new Size(236, 24);
            stergeToateElementeleToolStripMenuItem.Text = "sterge toate elementele";
            stergeToateElementeleToolStripMenuItem.Click += stergeToateElementeleToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 159);
            label6.Name = "label6";
            label6.Size = new Size(37, 24);
            label6.TabIndex = 19;
            label6.Text = "Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            dataGridView1.Location = new Point(1201, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(606, 398);
            dataGridView1.TabIndex = 20;
            // 
            // btnAdaugaBD
            // 
            btnAdaugaBD.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdaugaBD.Location = new Point(1389, 669);
            btnAdaugaBD.Name = "btnAdaugaBD";
            btnAdaugaBD.Size = new Size(262, 107);
            btnAdaugaBD.TabIndex = 21;
            btnAdaugaBD.Text = "Adaugare in BD";
            btnAdaugaBD.UseVisualStyleBackColor = true;
            btnAdaugaBD.Click += btnAdaugaBD_Click_1;
            // 
            // fisiereToolStripMenuItem
            // 
            fisiereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareXMLToolStripMenuItem, deschidereXMLToolStripMenuItem, salvareJSONToolStripMenuItem, deschidereJSONToolStripMenuItem });
            fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            fisiereToolStripMenuItem.Size = new Size(46, 24);
            fisiereToolStripMenuItem.Text = "File";
            fisiereToolStripMenuItem.Click += fisiereToolStripMenuItem_Click;
            // 
            // salvareXMLToolStripMenuItem
            // 
            salvareXMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            salvareXMLToolStripMenuItem.Size = new Size(205, 26);
            salvareXMLToolStripMenuItem.Text = "Salvare XML";
            salvareXMLToolStripMenuItem.Click += salvareXMLToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(71, 6);
            // 
            // deschidereXMLToolStripMenuItem
            // 
            deschidereXMLToolStripMenuItem.Name = "deschidereXMLToolStripMenuItem";
            deschidereXMLToolStripMenuItem.Size = new Size(205, 26);
            deschidereXMLToolStripMenuItem.Text = "Deschidere XML";
            deschidereXMLToolStripMenuItem.Click += deschidereXMLToolStripMenuItem_Click;
            // 
            // salvareJSONToolStripMenuItem
            // 
            salvareJSONToolStripMenuItem.Name = "salvareJSONToolStripMenuItem";
            salvareJSONToolStripMenuItem.Size = new Size(205, 26);
            salvareJSONToolStripMenuItem.Text = "Salvare JSON";
            salvareJSONToolStripMenuItem.Click += salvareJSONToolStripMenuItem_Click;
            // 
            // deschidereJSONToolStripMenuItem
            // 
            deschidereJSONToolStripMenuItem.Name = "deschidereJSONToolStripMenuItem";
            deschidereJSONToolStripMenuItem.Size = new Size(205, 26);
            deschidereJSONToolStripMenuItem.Text = "Deschidere JSON";
            deschidereJSONToolStripMenuItem.Click += deschidereJSONToolStripMenuItem_Click;
            // 
            // salvaToolStripMenuItem
            // 
            salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            salvaToolStripMenuItem.Size = new Size(71, 24);
            salvaToolStripMenuItem.Text = "Salvare";
            salvaToolStripMenuItem.Click += salvaToolStripMenuItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.AllowDrop = true;
            toolStripTextBox1.AutoClose = false;
            toolStripTextBox1.ImageScalingSize = new Size(20, 20);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.OwnerItem = salvaToolStripMenuItem;
            toolStripTextBox1.Size = new Size(61, 4);
            // 
            // schimbareFundalToolStripMenuItem
            // 
            schimbareFundalToolStripMenuItem.Name = "schimbareFundalToolStripMenuItem";
            schimbareFundalToolStripMenuItem.Size = new Size(139, 24);
            schimbareFundalToolStripMenuItem.Text = "Schimbare fundal";
            schimbareFundalToolStripMenuItem.Click += schimbareFundalToolStripMenuItem_Click;
            // 
            // imprimaToolStripMenuItem
            // 
            imprimaToolStripMenuItem.Name = "imprimaToolStripMenuItem";
            imprimaToolStripMenuItem.Size = new Size(92, 24);
            imprimaToolStripMenuItem.Text = "Imprimare";
            imprimaToolStripMenuItem.Click += imprimaToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisiereToolStripMenuItem, salvaToolStripMenuItem, schimbareFundalToolStripMenuItem, imprimaToolStripMenuItem, inchidereToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1821, 30);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // inchidereToolStripMenuItem
            // 
            inchidereToolStripMenuItem.Name = "inchidereToolStripMenuItem";
            inchidereToolStripMenuItem.Size = new Size(84, 24);
            inchidereToolStripMenuItem.Text = "Inchidere";
            inchidereToolStripMenuItem.Click += inchidereToolStripMenuItem_Click;
            // 
            // cbNume
            // 
            cbNume.FormattingEnabled = true;
            cbNume.Items.AddRange(new object[] { "Lenovo", "Dell", "Apple", "HP", "Asus", "Acer", "Microsoft" });
            cbNume.Location = new Point(165, 216);
            cbNume.Name = "cbNume";
            cbNume.Size = new Size(220, 28);
            cbNume.TabIndex = 22;
            // 
            // checkBoxCompatibilitate
            // 
            checkBoxCompatibilitate.AutoSize = true;
            checkBoxCompatibilitate.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxCompatibilitate.Location = new Point(198, 768);
            checkBoxCompatibilitate.Name = "checkBoxCompatibilitate";
            checkBoxCompatibilitate.Size = new Size(262, 44);
            checkBoxCompatibilitate.TabIndex = 24;
            checkBoxCompatibilitate.Text = "Componentele selectate \r\nsunt compatibile cu calculatorul";
            checkBoxCompatibilitate.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1757, 44);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 25;
            label7.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1713, 44);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 26;
            label8.Text = "Ora:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1660, 76);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(147, 29);
            progressBar1.TabIndex = 27;
            // 
            // btnTestareCompatibilitate
            // 
            btnTestareCompatibilitate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestareCompatibilitate.Location = new Point(1563, 125);
            btnTestareCompatibilitate.Name = "btnTestareCompatibilitate";
            btnTestareCompatibilitate.Size = new Size(244, 81);
            btnTestareCompatibilitate.TabIndex = 28;
            btnTestareCompatibilitate.Text = "Testare Compatibilitate";
            btnTestareCompatibilitate.UseVisualStyleBackColor = true;
            btnTestareCompatibilitate.Click += btnTestareCompatibilitate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 1003);
            Controls.Add(btnTestareCompatibilitate);
            Controls.Add(progressBar1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkBoxCompatibilitate);
            Controls.Add(cbNume);
            Controls.Add(btnAdaugaBD);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(tbId);
            Controls.Add(btnAdaugaCalculatoare);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clbComponente);
            Controls.Add(lvCalculatoare);
            Controls.Add(tbModel);
            Controls.Add(nudPret);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudPret).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudPret;
        private TextBox tbModel;
        private ListView lvCalculatoare;
        private CheckedListBox clbComponente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdaugaCalculatoare;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem stergereToolStripMenuItem;
        private ToolStripMenuItem optiuneStergereUnElement;
        private ToolStripMenuItem stergereTotToolStripMenuItem;
        private ToolStripMenuItem adaugaToolStripMenuItem;
        private ToolStripMenuItem adaugaComponentaToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox tbId;
        private ColumnHeader ID;
        private ColumnHeader Nume;
        private ColumnHeader Pret;
        private ColumnHeader Model;
        private ColumnHeader Componente;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem stergeToolStripMenuItem;
        private ToolStripMenuItem adaugaGraficToolStripMenuItem;
        private Label label6;
        private Button btnAdaugaBD;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisiereToolStripMenuItem;
        private ToolStripMenuItem salvareXMLToolStripMenuItem;
        private ToolStripMenuItem deschidereXMLToolStripMenuItem;
        private ToolStripMenuItem salvareJSONToolStripMenuItem;
        private ToolStripMenuItem deschidereJSONToolStripMenuItem;
        private ToolStripMenuItem salvaToolStripMenuItem;
        private ToolStripMenuItem schimbareFundalToolStripMenuItem;
        private ToolStripMenuItem imprimaToolStripMenuItem;
        private ToolStripDropDownMenu toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem inchidereToolStripMenuItem;
        private ComboBox cbNume;
        private ToolStripMenuItem stergeToateElementeleToolStripMenuItem;
        private CheckBox checkBoxCompatibilitate;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label8;
        private ProgressBar progressBar1;
        private Button btnTestareCompatibilitate;
    }
}
