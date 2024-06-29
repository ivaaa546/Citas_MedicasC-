using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace citasMedicas.DATOS
{
    public class Conexion
    {
        //declarar nuestras variables privadas
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        //crear objeto estatico de tipo conexion, nos genera una instancia al objeto
        //tipo de conexion
        private static Conexion con = null;
        //creamos un constructor
        private Conexion()
        {
            this.Base = "citasMedicas_IvanIco";
            this.Servidor = "DESKTOP-JIA76VC";
            this.Usuario = "sa";
            this.Clave = "1234";
            this.Seguridad = true;

        }

        //definir tipo de metodo que utilizaremos para la conexion a la base de datos
        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            
            try
            {   //agregar el string de conexion
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {   
                    //autenticacion de Windows                          
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";    
                }

                else
                { //autenticacion sqlServer
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }

            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        //metodo para genera una instancia constructor de la clase conexion
        public static Conexion getIstancia()
        {
            if(con == null)
            {
                con = new Conexion();   
            }
            return con;
        }
    }
}
