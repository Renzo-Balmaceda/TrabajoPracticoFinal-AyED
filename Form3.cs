using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace tpfinal
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public Consultas(Form1 form1, string datos)
        {
            InitializeComponent();
            this.Parent = form1;
            this.txt_datos.Text = datos;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Parent.Show();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void barra_MouseDown(object sender, MouseEventArgs e)
        {


            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Parent.Show();
        }
    }
}

