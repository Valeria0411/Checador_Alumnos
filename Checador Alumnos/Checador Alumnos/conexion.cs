using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Checador_Alumnos
{
    class conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter dataAdapter;
        
    }
    public conexion()
    {
        try
        {
            /*Aqui me conecte a mi servidor que en mi caso es mi laptop */
            cn = new SqlConnection("Data Source=LAPTOP-CQVS6SHP\\BASEDATOS;Initial Catalog=RegistroAlumnos;Integrated Security=True");
            cn.Open();

            System.Windows.Forms.MessageBox.Show("conectado");
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("no se conecto");
        }
    }
}

