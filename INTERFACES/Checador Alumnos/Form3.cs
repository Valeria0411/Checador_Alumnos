using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador_Alumnos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            serialPort1.Close();
            pictureBox1.Visible = true;
            label1.Visible = true;
            textBox1.BackColor = Color.GreenYellow;
            textBox1.Text = "Encendido";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
            pictureBox1.Visible = false;
            textBox1.BackColor = Color.Red;
            textBox1.Text = "Apagado";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Establecer estado inicial para cada herramienta al iniciar el programa
            pictureBox1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false; 

        }
    }
}
