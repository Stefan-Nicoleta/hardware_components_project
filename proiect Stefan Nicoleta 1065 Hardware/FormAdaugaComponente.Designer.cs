namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    partial class FormAdaugaComponente
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
            tbDenumire = new TextBox();
            label2 = new Label();
            btnAduagaComponenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 38);
            label1.Name = "label1";
            label1.Size = new Size(485, 46);
            label1.TabIndex = 0;
            label1.Text = "Adaugare Componenta Noua";
            label1.Click += label1_Click;
            // 
            // tbDenumire
            // 
            tbDenumire.Font = new Font("Segoe UI", 14F);
            tbDenumire.Location = new Point(211, 153);
            tbDenumire.Name = "tbDenumire";
            tbDenumire.Size = new Size(147, 39);
            tbDenumire.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 156);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 2;
            label2.Text = "Denumire:";
            // 
            // btnAduagaComponenta
            // 
            btnAduagaComponenta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAduagaComponenta.Location = new Point(47, 285);
            btnAduagaComponenta.Name = "btnAduagaComponenta";
            btnAduagaComponenta.Size = new Size(162, 59);
            btnAduagaComponenta.TabIndex = 5;
            btnAduagaComponenta.Text = "Adauaga";
            btnAduagaComponenta.UseVisualStyleBackColor = true;
            btnAduagaComponenta.Click += btnAduagaComponenta_Click;
            // 
            // FormAdaugaComponente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_05_26_161755;
            ClientSize = new Size(704, 405);
            Controls.Add(btnAduagaComponenta);
            Controls.Add(label2);
            Controls.Add(tbDenumire);
            Controls.Add(label1);
            Name = "FormAdaugaComponente";
            Text = "FormAdaugaComponente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDenumire;
        private Label label2;
        private Button btnAduagaComponenta;
    }
}