using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterfazBD.Clases
{
    public class Conexiones
    {
        public MySqlConnection conexion;

        public Conexiones()
        {
            conexion = new MySqlConnection(server = 12.0.0.1; Post = 3306; database = Usuarios; Uid = admin; pwd = root;);

        }
        public bool AbrirConexion()
    {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
    }
        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
}
