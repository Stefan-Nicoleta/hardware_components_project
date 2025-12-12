namespace proiect_Stefan_Nicoleta_1065_Hardware
{
    partial class AdaugaGrafic
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
            panelGrafic = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // panelGrafic
            // 
            panelGrafic.Location = new Point(23, 140);
            panelGrafic.Name = "panelGrafic";
            panelGrafic.Size = new Size(745, 269);
            panelGrafic.TabIndex = 0;
            panelGrafic.Paint += panelGrafic_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 53);
            label1.Name = "label1";
            label1.Size = new Size(749, 46);
            label1.TabIndex = 1;
            label1.Text = "Grafic realizat dupa vanzarea calculatoarelor";
            // 
            // AdaugaGrafic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panelGrafic);
            Name = "AdaugaGrafic";
            Text = "AdaugaGrafic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGrafic;
        private Label label1;
    }
}