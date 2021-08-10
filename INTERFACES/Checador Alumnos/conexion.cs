using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Checador_Alumnos
{
    class conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dataAdapter; 
    
    public conexion()
        {
             try
            {
               /* con = new SqlConnection("Data Source=(localdb)\\BASEDATOS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");*/
                con = new SqlConnection("Data Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=RegistroAlumnos;Integrated Security=True");
                con.Open();
                 MessageBox.Show("Conectado");
            }
            catch (Exception)
             {
                MessageBox.Show("No se logro conectar");
            }
         }
        }
}
