using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;


namespace InterfazRegistroAlumnos
{

    public partial class DatosAlumnos : Form

    {

        SqlConnection con;
        Conexion c = new Conexion();
        //   private object dataAdapter;
        // private object dataGridView1;

        public DatosAlumnos()

        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           // c.Consultar(txtnombre.Text);

            datosAlumnosTableAdapter.FillBy(RegistroAlumnosDataSet.DatosAlumnos, txtnombre.Text);

            //////////////////////////////////////////////////
            SqlDataReader dr;
            SqlCommand com;
            SqlConnection cnn;
            String sql;

            cnn = new SqlConnection("Data Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=RegistroAlumnos;Integrated Security=True");
            sql = "SELECT Foto FROM DatosAlumnos WHERE Nombre =  ('" + txtnombre.Text + "')";
            cnn.Open();

            com = new SqlCommand(sql, cnn);
            dr = com.ExecuteReader();

            dr.Read();
            label3.Text = dr.GetString(0);//'aca me pone el primer campo del select 
                                          //   pbfotoalumno.BackgroundImage = label3.Text();
            pbfotoalumno.Image = Image.FromFile(label3.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("{0}\t{1}", dr.GetInt32(0),
                        dr.GetString(0));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            try
            {

                MessageBox.Show("Consulta Exitosa");
            }          catch (Exception ex)
            {
                MessageBox.Show("No existe en la Base de Datos");
            }

            //////////////////////////////////////////////////




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbgrado_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbturno_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbgrupo_TextChanged(object sender, EventArgs e)
        {


        }
        private void DatosAlumnos_Load(object sender, EventArgs e)
        {
            /*EnabledCerrar = Boolean();
            System.ComponentModel.DefaultValueAttribute(false);
            System.ComponentModel.DescriptionAttribute();*/
            

            
            this.datosAlumnosTableAdapter.Fill(this.RegistroAlumnosDataSet.DatosAlumnos);
            /*llame a mi constructor (c)*/
            Conexion c = new Conexion();
            //dataMostrarDatos.DataSource = bindingSource1;
            //GetData("SELECT * FROM DatosAlumnos");

        }

        private void GetData(string v)
        {
            // throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            c.Insertar(Convert.ToInt32(txtId.Text), txtnombre.Text, txtapellido.Text, txtturno.Text, txtgrado.Text, txtgrupo.Text, label3.Text);

            try
            {
                
                MessageBox.Show("Registro Completado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se an registrado datos");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbfotoalumno_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {


            try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            //file.Filter = "archivo BMP,JPG|*.bmp,*.JPG";
            file.Filter = "Imagen(JPG, BMP, PNG) | *.JPG,*.BMP,*.PNG | All files(*.*) | *.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbfotoalumno.Image = Image.FromFile(file.FileName);
            }
            label3.Text = (file.FileName);

        }
        //TERMINA EJEMPLO


        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            datosAlumnosTableAdapter.Eliminar(Convert.ToInt32(txtId.Text));
            datosAlumnosTableAdapter.Fill(RegistroAlumnosDataSet.DatosAlumnos);
            try
            {

                MessageBox.Show("Eliminacion Completa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminaron los datos ");
            }
        }

        private void txtgrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtturno_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // datosAlumnosTableAdapter.FillBy(this.registroAlumnosDataSet.DatosAlumnos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datosAlumnosTableAdapter.Actualizar(Convert.ToInt32(txtId.Text), txtnombre.Text, txtapellido.Text, txtturno.Text, txtgrado.Text, txtgrupo.Text, Convert.ToInt32(txtId.Text));
            datosAlumnosTableAdapter.Fill(RegistroAlumnosDataSet.DatosAlumnos);
            try
            {

                MessageBox.Show("Se an Actualizado Datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se an Actualizado datos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtgrado.Clear();
            txtgrupo.Clear();
            txtturno.Clear();
            pbfotoalumno.Image = null;
            dataMostrarDatos.Refresh();
            pbgenerar.Image = null;


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void pbgenerar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && txtgrado.Text != "" && txtgrupo.Text != "" && txtturno.Text != "" )
            {
                var todo = txtId.Text + " " + txtnombre.Text + " " + txtapellido.Text + " " + txtgrado.Text + " " + txtgrupo.Text + " " + txtturno.Text + " " ;
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(todo), 300, 300);
                pbgenerar.Image = bm;
            }
            else
            {
                MessageBox.Show("No deje campos vacios ");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          /* DialogResult dialog = new DialogResult();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imagen (JPG,BMP,PNG)|*.JPG,*.BMP,*.PNG|All files(*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            dialog = file.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                Bitmap bmp;
                bmp = new Bitmap(Image.FromFile(file.FileName));
                bmp = bmp.GetThumbnailImage(480,480, Nothing)
                   
            }


            if (file.ShowDialog() == DialogResult.OK)
            {
                pbfotoalumno.Image = Image.FromFile(file.FileName);
            }
            */

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlCommand com;
            SqlConnection cnn;
            String sql;
            
            cnn = new SqlConnection("Data Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=RegistroAlumnos;Integrated Security=True");
            sql = "SELECT Foto FROM DatosAlumnos WHERE Nombre =  ('" + txtnombre.Text + "')";
            cnn.Open();

            com = new SqlCommand(sql, cnn);
             dr = com.ExecuteReader();

            dr.Read();
            label3.Text = dr.GetString(0);//'aca me pone el primer campo del select 
         //   pbfotoalumno.BackgroundImage = label3.Text();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("{0}\t{1}", dr.GetInt32(0),
                        dr.GetString(0));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            dr.Close();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
           

           dataMostrarDatos.Refresh();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
            int Contraseña = 215638443;

            if (Contraseña<=215638443)
                if (Contraseña >= 0)
                {
                    Console.WriteLine("Contraseña correcta");
                }
                else
                {
                    Console.WriteLine("Contraseña Incorrecta");
                }
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }

    } 
