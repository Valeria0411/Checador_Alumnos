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
using System.IO;
using ZXing;


namespace Checador_Alumnos
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DataRow Rows;   
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT TOP Grado FROM Checador_RegistroAlumnos WHERE Grado = Grado";
            using (SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true"));
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                string codmax = Convert.ToString(cmd.ExecuteScalar());
                int cod = Convert.ToInt32(codmax) + 1;
                textBox3.Text = Convert.ToString(cod);
            }
            textBox3.Text = "";
             /*if(SqlConnection = con )
            {

            }*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Ingresa de forma aleatoria el horario
            //textBox5.Text = Convert.ToDateTime(Row["HoraE"]).ToString("HH:mm");
            //using (SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true"));
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            string sql = @"INSERT INTO HoraE(HoraE) values(@HoraE)";

            //registra el dia 
            DateTime Fecha = Convert.ToDateTime(dateTimePicker1.Text);
           //using (SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true"));
            //SqlConnection con = new SqlConnection(sql, con);
            con.Open();
            //string sql = @"INSERT INTO AsistenciaD(Fecha) values(@Fecha)";
            SqlCommand query = new SqlCommand(sql, con);
            query.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = Fecha;
            query.ExecuteNonQuery();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Limpiar cada 10 o menos segundos de toda la información
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT TOP Nombre FROM TBL Checador_RegistroAlumnos WHERE Nombre = Nombre";
            using (SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true"));
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                string codmax = Convert.ToString(cmd.ExecuteScalar());
                int cod = Convert.ToInt32(codmax)+1;
                textBox1.Text = Convert.ToString(cod);
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT TOP Apellido FROM TBL Checador_RegistroAlumnos WHERE Apellido = Apellido";
            using (SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true"));
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                string codmax = Convert.ToString(cmd.ExecuteScalar());
                int cod = Convert.ToInt32(codmax) + 1;
                textBox2.Text = Convert.ToString(cod); 
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT TOP Turno FROM TBL Checador_RegistroAlumnos WHERE Turno = Turno";
            using (SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true"));
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                string codmax = Convert.ToString(cmd.ExecuteScalar());
                int cod = Convert.ToInt32(codmax) + 1;
                textBox4.Text = Convert.ToString(cod);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
            //Obtener ruta de la imagen y mostrarla aquí
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //visualizar imagen predeterminada dependiendo el codigo
            SqlConnection con = new SqlConnection("Data Source=Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=ResgitroAlumnos; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("SELECT foto FROM RegistroAlumnos WHERE imagen=1"/*connect*/);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("Foto");

            byte[] MisDatos = new Byte[0];
            dataAdapter.Fill(ds, "Foto");
            DataRow myRow = ds.Tables["foto"].Rows[0];
            MisDatos = (byte[])myRow["foto"];
            MemoryStream ms = new MemoryStream(MisDatos);
            pictureBox1.Image = Image.FromStream(ms); 
           }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
