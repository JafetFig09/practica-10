namespace practica10
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
            panel1 = new Panel();
            tbNumero = new TextBox();
            btnPintarArreglo = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbNumero);
            panel1.Controls.Add(btnPintarArreglo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(210, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 428);
            panel1.TabIndex = 0;
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(267, 37);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(90, 27);
            tbNumero.TabIndex = 3;
            tbNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPintarArreglo
            // 
            btnPintarArreglo.BackColor = SystemColors.ActiveCaption;
            btnPintarArreglo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPintarArreglo.ForeColor = SystemColors.ButtonHighlight;
            btnPintarArreglo.Location = new Point(416, 27);
            btnPintarArreglo.Name = "btnPintarArreglo";
            btnPintarArreglo.Size = new Size(114, 41);
            btnPintarArreglo.TabIndex = 2;
            btnPintarArreglo.Text = "Dibujar";
            btnPintarArreglo.UseVisualStyleBackColor = false;
            btnPintarArreglo.Click += btnPintarArreglo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 1;
            label1.Text = "Escriba la longitud de su matriz";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(59, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(418, 284);
            listBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(444, 50);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "PRACTICA 10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 625);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tbNumero;
        private Button btnPintarArreglo;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
    }
}