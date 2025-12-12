namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    partial class Introducere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            informatiiProiectToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            cerintaProiectToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 57);
            label1.Name = "label1";
            label1.Size = new Size(525, 46);
            label1.TabIndex = 0;
            label1.Text = "Proiect componente Hardware";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(581, 121);
            label2.Name = "label2";
            label2.Size = new Size(244, 28);
            label2.TabIndex = 1;
            label2.Text = "de Stefan Nicoleta-Cristina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(716, 171);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 2;
            label3.Text = "grupa 1065";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(533, 287);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "2024-2025";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.WindowText;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(887, 396);
            button1.Name = "button1";
            button1.Size = new Size(132, 67);
            button1.TabIndex = 4;
            button1.Text = "Next->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { informatiiProiectToolStripMenuItem, cerintaProiectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1071, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // informatiiProiectToolStripMenuItem
            // 
            informatiiProiectToolStripMenuItem.Name = "informatiiProiectToolStripMenuItem";
            informatiiProiectToolStripMenuItem.Size = new Size(139, 24);
            informatiiProiectToolStripMenuItem.Text = "Informatii proiect";
            informatiiProiectToolStripMenuItem.Click += informatiiProiectToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_05_23_191516;
            pictureBox1.Location = new Point(0, 278);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1047, 211);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cerintaProiectToolStripMenuItem
            // 
            cerintaProiectToolStripMenuItem.Name = "cerintaProiectToolStripMenuItem";
            cerintaProiectToolStripMenuItem.Size = new Size(121, 24);
            cerintaProiectToolStripMenuItem.Text = "Cerinta proiect";
            cerintaProiectToolStripMenuItem.Click += cerintaProiectToolStripMenuItem_Click;
            // 
            // Introducere
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1071, 475);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Introducere";
            Text = "Introducere";
            Load += Introducere_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem informatiiProiectToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem cerintaProiectToolStripMenuItem;
    }
}