using System.Collections.Generic;

namespace InterfazBD.Clases
{
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }



        public usuario()
        {
        }

        public usuario(int pIdUsuario, string pNombre, string pApellido, string pEmail)
        {
            this.id_usuario = id_usuario;
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.email = pEmail;
        }

       //public static int AgregarUsuario()
       // {


       // }

       // public static int ActualizarUsuario()
       // {

        
       // }
       // public static int EliminarUsuario()
       // {

       // }
        public static IList<Usuario> Buscar(MySqlconnection conexion, string pNombre, string pApellido, string pEmail)
        {
            List<usuario> lista = new List<usuario>;

            MySqlCommand comando = new MySqlCommand(("*SELECT id_usuario, nombre, apellido, email, from usuario WHERE nombre LIKE ('%(0)%') AND apellido('%(1)%') AND email LIKE('%(2)%')", pNombre, pApellido, pEmail), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                usuario pUsuario = new usuario();
                pUsuario.id_usuario = reader.GetInt32(0);
                pUsuario.nombre = reader.GetString(1);
                pUsuario.apellido = reader.GetString(2); 
                pUsuario.id_email = reader.GetString(3);

                lista.Add(pUsuario);
            }
            return lista;
        }

    

    }



}
