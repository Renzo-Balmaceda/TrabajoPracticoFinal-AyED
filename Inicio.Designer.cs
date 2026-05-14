

namespace tpfinal
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.barra = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.controles = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.caras = new System.Windows.Forms.Panel();
            this.pathDataSet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.controles.SuspendLayout();
            this.caras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barra.Controls.Add(this.btnclose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(600, 35);
            this.barra.TabIndex = 0;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(565, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // controles
            // 
            this.controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.controles.Controls.Add(this.panel4);
            this.controles.Controls.Add(this.btnIniciar);
            this.controles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controles.Location = new System.Drawing.Point(0, 235);
            this.controles.Name = "controles";
            this.controles.Size = new System.Drawing.Size(600, 65);
            this.controles.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(418, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 30);
            this.panel4.TabIndex = 8;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(422, 19);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(175, 30);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Indexar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(416, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 30);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(422, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Seleccionar...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // caras
            // 
            this.caras.AutoScroll = true;
            this.caras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.caras.Controls.Add(this.panel2);
            this.caras.Controls.Add(this.pathDataSet);
            this.caras.Controls.Add(this.label1);
            this.caras.Controls.Add(this.pictureBox2);
            this.caras.Controls.Add(this.button1);
            this.caras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caras.Location = new System.Drawing.Point(0, 35);
            this.caras.Name = "caras";
            this.caras.Size = new System.Drawing.Size(600, 200);
            this.caras.TabIndex = 7;
            // 
            // pathDataSet
            // 
            this.pathDataSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pathDataSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathDataSet.ForeColor = System.Drawing.Color.White;
            this.pathDataSet.Location = new System.Drawing.Point(8, 152);
            this.pathDataSet.Name = "pathDataSet";
            this.pathDataSet.Size = new System.Drawing.Size(402, 29);
            this.pathDataSet.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Archivo:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tpfinal.Properties.Resources._6133923;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.caras);
            this.Controls.Add(this.controles);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Quien es?";
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.controles.ResumeLayout(false);
            this.caras.ResumeLayout(false);
            this.caras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel barra;
        private PictureBox btnclose;
        private Panel controles;
        private Panel panel4;
        private Button btnIniciar;
        private Panel panel2;
        private Button button1;
        private Panel caras;
        private PictureBox pictureBox2;
        private TextBox pathDataSet;
        private Label label1;
    }
}