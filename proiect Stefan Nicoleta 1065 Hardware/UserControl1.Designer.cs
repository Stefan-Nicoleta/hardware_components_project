namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            btnVerifica = new Button();
            cbCalculatoare = new ComboBox();
            cbComponente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(98, 113);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(29, 31);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "...";
            // 
            // btnVerifica
            // 
            btnVerifica.Location = new Point(587, 241);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(94, 29);
            btnVerifica.TabIndex = 3;
            btnVerifica.Text = "Verifica";
            btnVerifica.UseVisualStyleBackColor = true;
            btnVerifica.Click += btnVerifica_Click_1;
            // 
            // cbCalculatoare
            // 
            cbCalculatoare.FormattingEnabled = true;
            cbCalculatoare.Items.AddRange(new object[] { "Lenovo", "Dell", "Apple", "HP", "Asus", "Acer", "Microsoft" });
            cbCalculatoare.Location = new Point(587, 63);
            cbCalculatoare.Name = "cbCalculatoare";
            cbCalculatoare.Size = new Size(151, 28);
            cbCalculatoare.TabIndex = 4;
            // 
            // cbComponente
            // 
            cbComponente.FormattingEnabled = true;
            cbComponente.Items.AddRange(new object[] { "RAM DDR4", "RAM DDR5", "CPU", "Placa video integrata", "SSD NVMe PCle", "GPU", "Tastatura", "Mouse" });
            cbComponente.Location = new Point(587, 142);
            cbComponente.Name = "cbComponente";
            cbComponente.Size = new Size(151, 28);
            cbComponente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 71);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Nume calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 150);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 7;
            label2.Text = "Componenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(382, 41);
            label3.TabIndex = 8;
            label3.Text = "Verificare Compatibilitate";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbComponente);
            Controls.Add(cbCalculatoare);
            Controls.Add(btnVerifica);
            Controls.Add(lblStatus);
            Name = "UserControl1";
            Size = new Size(1228, 361);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStatus;
        private Button btnVerifica;
        private ComboBox cbCalculatoare;
        private ComboBox cbComponente;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
