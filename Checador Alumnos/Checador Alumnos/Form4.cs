using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Checador_Alumnos
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña;
            contraseña = textBox1.Text;

            if (contraseña == "AccesoSeguro")
            {
                Application.Exit();

            }
            if (contraseña == "")
            {
                MessageBox.Show("Debes insertar la contraseña");
            }
            
            else
            {
                MessageBox.Show("Sistema bloqueado" + contraseña);
            }

             textBox1.Text = "AccesoSeguro"; 
             textBox1.PasswordChar = '*';
             textBox1.MaxLength = 14;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
