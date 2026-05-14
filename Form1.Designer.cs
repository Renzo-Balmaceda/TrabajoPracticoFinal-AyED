

namespace tpfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barra = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.controles = new System.Windows.Forms.Panel();
            this.Metodo = new System.Windows.Forms.GroupBox();
            this.otroOp = new System.Windows.Forms.RadioButton();
            this.heapOp = new System.Windows.Forms.RadioButton();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_consulta3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_consulta2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_consulta1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.caras = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.controles.SuspendLayout();
            this.Metodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.caras.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barra.Controls.Add(this.btnclose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1166, 35);
            this.barra.TabIndex = 0;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1134, 6);
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
            this.controles.Controls.Add(this.Metodo);
            this.controles.Controls.Add(this.txtDist);
            this.controles.Controls.Add(this.trackBar1);
            this.controles.Controls.Add(this.panel6);
            this.controles.Controls.Add(this.btn_consulta3);
            this.controles.Controls.Add(this.panel5);
            this.controles.Controls.Add(this.btn_consulta2);
            this.controles.Controls.Add(this.panel3);
            this.controles.Controls.Add(this.btn_consulta1);
            this.controles.Controls.Add(this.panel1);
            this.controles.Controls.Add(this.button2);
            this.controles.Controls.Add(this.panel4);
            this.controles.Controls.Add(this.btnNo);
            this.controles.Controls.Add(this.panel2);
            this.controles.Controls.Add(this.button1);
            this.controles.Dock = System.Windows.Forms.DockStyle.Left;
            this.controles.Location = new System.Drawing.Point(0, 35);
            this.controles.Name = "controles";
            this.controles.Size = new System.Drawing.Size(276, 617);
            this.controles.TabIndex = 4;
            // 
            // Metodo
            // 
            this.Metodo.Controls.Add(this.otroOp);
            this.Metodo.Controls.Add(this.heapOp);
            this.Metodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Metodo.ForeColor = System.Drawing.Color.White;
            this.Metodo.Location = new System.Drawing.Point(12, 3);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(261, 103);
            this.Metodo.TabIndex = 25;
            this.Metodo.TabStop = false;
            this.Metodo.Text = "Metodo";
            // 
            // otroOp
            // 
            this.otroOp.AutoSize = true;
            this.otroOp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otroOp.ForeColor = System.Drawing.Color.White;
            this.otroOp.Location = new System.Drawing.Point(159, 39);
            this.otroOp.Name = "otroOp";
            this.otroOp.Size = new System.Drawing.Size(60, 25);
            this.otroOp.TabIndex = 26;
            this.otroOp.Text = "Otro";
            this.otroOp.UseVisualStyleBackColor = true;
            // 
            // heapOp
            // 
            this.heapOp.AutoSize = true;
            this.heapOp.Checked = true;
            this.heapOp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heapOp.ForeColor = System.Drawing.Color.White;
            this.heapOp.Location = new System.Drawing.Point(41, 39);
            this.heapOp.Name = "heapOp";
            this.heapOp.Size = new System.Drawing.Size(64, 25);
            this.heapOp.TabIndex = 25;
            this.heapOp.TabStop = true;
            this.heapOp.Text = "Heap";
            this.heapOp.UseVisualStyleBackColor = true;
            // 
            // txtDist
            // 
            this.txtDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDist.ForeColor = System.Drawing.Color.White;
            this.txtDist.Location = new System.Drawing.Point(7, 122);
            this.txtDist.Name = "txtDist";
            this.txtDist.ReadOnly = true;
            this.txtDist.Size = new System.Drawing.Size(110, 22);
            this.txtDist.TabIndex = 22;
            this.txtDist.Text = "Resultados: 1";
            this.txtDist.TextChanged += new System.EventHandler(this.txtDist_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(117, 122);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(152, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(113, 557);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 30);
            this.panel6.TabIndex = 19;
            // 
            // btn_consulta3
            // 
            this.btn_consulta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_consulta3.FlatAppearance.BorderSize = 0;
            this.btn_consulta3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_consulta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta3.ForeColor = System.Drawing.Color.White;
            this.btn_consulta3.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta3.Image")));
            this.btn_consulta3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta3.Location = new System.Drawing.Point(117, 557);
            this.btn_consulta3.Name = "btn_consulta3";
            this.btn_consulta3.Size = new System.Drawing.Size(197, 30);
            this.btn_consulta3.TabIndex = 18;
            this.btn_consulta3.Text = "Consulta 3";
            this.btn_consulta3.UseVisualStyleBackColor = false;
            this.btn_consulta3.Click += new System.EventHandler(this.btn_consulta3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(113, 495);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 30);
            this.panel5.TabIndex = 17;
            // 
            // btn_consulta2
            // 
            this.btn_consulta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_consulta2.FlatAppearance.BorderSize = 0;
            this.btn_consulta2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_consulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta2.ForeColor = System.Drawing.Color.White;
            this.btn_consulta2.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta2.Image")));
            this.btn_consulta2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta2.Location = new System.Drawing.Point(117, 495);
            this.btn_consulta2.Name = "btn_consulta2";
            this.btn_consulta2.Size = new System.Drawing.Size(197, 30);
            this.btn_consulta2.TabIndex = 16;
            this.btn_consulta2.Text = "Consulta 2";
            this.btn_consulta2.UseVisualStyleBackColor = false;
            this.btn_consulta2.Click += new System.EventHandler(this.btn_consulta2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(113, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 30);
            this.panel3.TabIndex = 15;
            // 
            // btn_consulta1
            // 
            this.btn_consulta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_consulta1.FlatAppearance.BorderSize = 0;
            this.btn_consulta1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_consulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta1.ForeColor = System.Drawing.Color.White;
            this.btn_consulta1.Image = ((System.Drawing.Image)(resources.GetObject("btn_consulta1.Image")));
            this.btn_consulta1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta1.Location = new System.Drawing.Point(117, 431);
            this.btn_consulta1.Name = "btn_consulta1";
            this.btn_consulta1.Size = new System.Drawing.Size(197, 30);
            this.btn_consulta1.TabIndex = 14;
            this.btn_consulta1.Text = "Consulta 1";
            this.btn_consulta1.UseVisualStyleBackColor = false;
            this.btn_consulta1.Click += new System.EventHandler(this.btn_consulta1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(75, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 30);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(79, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Consultas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(75, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 30);
            this.panel4.TabIndex = 8;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(79, 249);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(197, 30);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "Limpiar";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(75, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 30);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(79, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // caras
            // 
            this.caras.AutoScroll = true;
            this.caras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.caras.Controls.Add(this.flowLayoutPanel1);
            this.caras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caras.Location = new System.Drawing.Point(276, 35);
            this.caras.Name = "caras";
            this.caras.Size = new System.Drawing.Size(890, 617);
            this.caras.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(890, 617);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 652);
            this.Controls.Add(this.caras);
            this.Controls.Add(this.controles);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Quien es?";
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.controles.ResumeLayout(false);
            this.controles.PerformLayout();
            this.Metodo.ResumeLayout(false);
            this.Metodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.caras.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private Panel barra;
        private PictureBox btnclose;
        private Panel controles;
        private Panel panel4;
        private Button btnNo;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Button btn_consulta1;
        private Panel panel6;
        private Button btn_consulta3;
        private Panel panel5;
        private Button btn_consulta2;
        private Panel caras;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDist;
        private TrackBar trackBar1;
        private GroupBox Metodo;
        private RadioButton otroOp;
        private RadioButton heapOp;
    }
}