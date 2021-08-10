using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Aqui agrege esta referencia que es la que convierte los cogigos QR*/
using ZXing;

namespace CodigosQR
{
    public partial class CodigosQR : Form
    {
        public CodigosQR()
        {
            InitializeComponent();
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* Aqui agrege la sentencia para que lo que tengo en mi texbox se vaya a un picturebox y se convierta en QR */
            if (txtnombre.Text !="")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtnombre.Text), 300, 300);
                pbgenerar.Image = bm;
            }
            
        }

        private void LdatosAlumnos_Click(object sender, EventArgs e)
        {

        }
    }
}
