using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using citasMedicas.ENTIDADES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using citasMedicas.DATOS;

namespace citasMedicas.DATOS
{
    public class Dpacientes
    {
        //metodo para listar los pacientes de la base de datos

        //objetod de tipo DataTable
        public DataTable Listar()
        {
            //activamos el using System.Data.SqlClient para el SqlDataReader
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable(); //representar una tabla en memoria
            SqlConnection SqlCon = new SqlConnection();
         
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("paciente_listar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                SqlCon.Open();
                Resultado =  comando.ExecuteReader(); //lee toda la informacion de la tabla sql
                Tabla.Load(Resultado); //llenamos el objeto DataTabla llamado Tabla con la informacio del sqlDateReader
                return Tabla;
                
            }

            catch(Exception ex)
            {
                throw ex;   
               
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close(); //estamos cerrando la conexion a la BD
            }
        }

        //metodo que permite buscar nombre o apellidos a los pacientes
        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable(); //representar una tabla en memoria
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("paciente_buscar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor; //por este medio le mandamos  el valor  a buscar nombre o apellido    
                SqlCon.Open();
                Resultado = comando.ExecuteReader(); //lee toda la informacion de la tabla sql
                Tabla.Load(Resultado); //llenamos el objeto DataTabla llamado Tabla con la informacio del sqlDateReader
                return Tabla;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        //metodo para insertar informacion pacientes
        public string Insertar(DatosPaciente Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("paciente_insertar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Obj.Fecha; //por este medio le mandamos  el valor  a buscar nombre o apellido    
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = Obj.Nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = Obj.Apellidos;
                comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.telefono;
                comando.Parameters.Add("@DPI", SqlDbType.VarChar).Value = Obj.DPI;
                comando.Parameters.Add("@Edad", SqlDbType.VarChar).Value = Obj.Edad;
                comando.Parameters.Add("@PA", SqlDbType.VarChar).Value = Obj.PA;
                comando.Parameters.Add("@Temp", SqlDbType.VarChar).Value = Obj.Temp;
                comando.Parameters.Add("@Peso", SqlDbType.VarChar).Value = Obj.Peso;
                SqlCon.Open();
                rpta = comando.ExecuteNonQuery() == 1? "Ok" : "No se pudo ingresar el registro";

            }

            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //metodo para actualizar los datos del pacientes
        public string Actualizar(DatosPaciente Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("paciente_actualizar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@Id_paciente", SqlDbType.Int).Value = Obj.Id_paciente;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Obj.Fecha; //por este medio le mandamos  el valor  a buscar nombre o apellido    
                comando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = Obj.Nombres;
                comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = Obj.Apellidos;
                comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.telefono;
                comando.Parameters.Add("@DPI", SqlDbType.VarChar).Value = Obj.DPI;
                comando.Parameters.Add("@Edad", SqlDbType.VarChar).Value = Obj.Edad;
                comando.Parameters.Add("@PA", SqlDbType.VarChar).Value = Obj.PA;
                comando.Parameters.Add("@Temp", SqlDbType.VarChar).Value = Obj.Temp;
                comando.Parameters.Add("@Peso", SqlDbType.VarChar).Value = Obj.Peso;
                SqlCon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar el registro";

            }

            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //metodo para eliminar los metodos del paciente
        public string eliminar(int Id)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("eliminar_paciente", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@Id_paciente", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo eliminar el registro";

            }

            catch (Exception ex)
            {
                rpta = ex.Message;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }

}



