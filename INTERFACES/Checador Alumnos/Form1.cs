using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using AForge.Video;
using ZXing;
using AForge;
using ZXing.Aztec;
using AForge.Video.DirectShow;

namespace Checador_Alumnos
{
    public partial class Form1 : Form

    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        //Variable para filtrar dispositivos
        private FilterInfoCollection Dispositivos;
        //Variable para fuente de video 
        private VideoCaptureDevice FuenteDeVideo;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            // HoraDate.Consulta(DataSet1.DatosAlumnosTableAdapter.DatosAlumnosTableAdapterRowChanged, label4.Text);
            /*this.Hide();
            Form2 frm = new Form2();
            frm.Show();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();

            //Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            /* foreach (FilterInfo x in Dispositivos);
             {
                 comboBox1.Items.Add(Name);
             }
             comboBox1.SelectedIndex = 0;*/
          // HoraDate.(Convert.ToInt32(txtId.Text),textBox1.Text );
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // FuenteDeVideo = new VideoCaptureDevice(Dispositivos[comboBox1.SelectedIndex].MonikerString);
            /*videoSourcePlayer1.VideoSource = FuenteDeVideo;
            videoSourcePlayer1.Start();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*videoSourcePlayer1.SignalToStop();*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1_SelectedIndexChanged = DispositivosEscaner;
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {
            //Escaner direccion y con eso vincular 
            //DeviceInformation selectedDevice = (DeviceInformation)((comboBoxItem)_autoDeviceComboBox.SelectedItem).Tag;
            //if (selectedDevice !=null)
            //{
            //    videoSourcePlayer1 = selectedDevice;
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

           // string HORA = DateTime.Now.TimeOfDay.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label6.Text = "";
            textBox1.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
