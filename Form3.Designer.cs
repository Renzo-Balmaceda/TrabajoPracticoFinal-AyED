namespace tpfinal
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.barra = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.caras = new System.Windows.Forms.Panel();
            this.txt_datos = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.caras.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barra.Controls.Add(this.textBox1);
            this.barra.Controls.Add(this.btnclose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(800, 35);
            this.barra.TabIndex = 0;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(9, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Consultas";
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(763, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // caras
            // 
            this.caras.AutoScroll = true;
            this.caras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.caras.Controls.Add(this.txt_datos);
            this.caras.Controls.Add(this.button2);
            this.caras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caras.Location = new System.Drawing.Point(0, 35);
            this.caras.Name = "caras";
            this.caras.Size = new System.Drawing.Size(800, 515);
            this.caras.TabIndex = 3;
            // 
            // txt_datos
            // 
            this.txt_datos.Location = new System.Drawing.Point(12, 21);
            this.txt_datos.Name = "txt_datos";
            this.txt_datos.Size = new System.Drawing.Size(776, 431);
            this.txt_datos.TabIndex = 3;
            this.txt_datos.Text = "";
            this.txt_datos.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(748, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.caras);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas";
            this.Text = "Resultado";
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.caras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel barra;
        private PictureBox btnclose;
        private TextBox textBox1;
        private Form1 Parent;
        private Panel caras;
        private RichTextBox txt_datos;
        private Button button2;
    }
}
