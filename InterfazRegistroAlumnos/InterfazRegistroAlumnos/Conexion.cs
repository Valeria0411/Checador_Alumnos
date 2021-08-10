using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;






namespace InterfazRegistroAlumnos
{
    class Conexion
    {
       
        /*Aqui cn, cmd y dr son para constructores para poder leer, agregar y modificar en la base de datos*/
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public object DataGridView1 { get; private set; }

        public Conexion()
        {
            try
            {
                /*Aqui me conecte a mi servidor que en mi caso es mi laptop */
               cn = new SqlConnection("Data Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=RegistroAlumnos;Integrated Security=True");
                cn.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto");
            }
        }
        /*Aqui es para iniciar la conexion entre los botones de registro, consulta, etc...*/
        public string Insertar( int id, string Nombre, string Apellido, string Turno, string Grado, string Grupo, string Foto)
        {
            string salida = "Se an ingresado datos";
            try
            {
                
                cmd = new SqlCommand("INSERT INTO DatosAlumnos (id,Nombre,Apellido,Turno,Grado,Grupo,Foto) VALUES (" + id + ",'" + Nombre + "','" + Apellido + "','" + Turno + "','" + Grado + "','" + Grupo + "','" + Foto + "')", cn);
                cmd.ExecuteNonQuery();
            }
            
            /*Esto lo pongo para capurar un posble error al ingresar algun registro en la base de datos y no estar sin saber cual es el problema*/
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string Consultar(string Nombre)

        {
             string salida = "Se an consultado datos";
            try
            {
                cmd = new SqlCommand("SELECT (Nombre,Apellido) FROM DatosAlumnos WHERE = '"+Nombre+ "')", cn);
                
                cmd.ExecuteReader();
                                   
            }
        
            catch (Exception ex)
            {
                 salida= "No se conecto: " + ex.ToString();
            }
            return salida;
        }
       /* public string Actualizar(string Nombre)

        {
            string salida = "Se an consultado datos";
            try
            {
                cmd = new SqlCommand("SELECT (Nombre,Apellido) FROM DatosAlumnos WHERE = '" + Nombre + "')", cn);

                cmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }*/
        private static void OpenSqlConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
                Console.WriteLine("DataSource: {0}", connection.DataSource);
            }
        }


        private void  GetData(string selectCommand)
        {
            try
            {


                // Cree un nuevo adaptador de datos basándose en la consulta especificada.
                dataAdapter = new SqlDataAdapter(selectCommand, cn);

              
                /*Crear un generador de comandos para generar actualización de SQL, insertar y
                eliminar comandos basados en SelectCommand. Estos se utilizan para
                actualizar la base de datos.*/
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Rellenar una nueva tabla de datos y enlazarla al BindingSource.
                DataTable table = new DataTable ();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                

            }
            catch (SqlException)
           {
                MessageBox.Show("Para ejecutar este ejemplo, reemplace el valor de " +
                     "variable connectionString con una cadena de conexión que es" +
                     "válido para su sistema.");
            }
        }
        /*esto es para que no se vuelva a registar un alumno si ya esta registrado*/
        public int AlumnoRegistrado(int id)
        {
            int contador = 1;
            try    
            {
                cmd = new SqlCommand("Select * from RegistroAlumnos where id="+id+",cn");
                dr = cmd.ExecuteReader();
                /*Aqui hice un ciclo que es el que va a leer los datos y si es que estan va a volver a 0 y consultar de nuevo*/
                while (dr.Read()) ;
                {
                    contador++;
                }
                dr.Close();
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar:" +ex.ToString());
            }
            return contador;
        }
        
       
        
        //codigo de ejemplo para conectar la imagen a la BD este es una prueba
        void ConectarImagen()
        {
            SqlConnection con;
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();

            cs.DataSource = @"LAPTOP-CQVS6SHP\BASEDATOS";
            cs.InitialCatalog = "RegistroAlumnos";
          
            con = new  SqlConnection(cs.ConnectionString);
        }

        internal string Insertar(string text1, string text2, string text3, string text4, string text5, string imageLocation)
        {
            throw new NotImplementedException();
        }
    }
}
