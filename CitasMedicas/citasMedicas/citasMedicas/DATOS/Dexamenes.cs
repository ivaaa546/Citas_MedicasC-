using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using citasMedicas.ENTIDADES;

namespace citasMedicas.DATOS
{
    //metodo para buscar
    internal class Dexamenes
    {
       
        //objetod de tipo DataTable
        public DataTable BuscarExamen(int id_paciente)
        {
            //activamos el using System.Data.SqlClient para el SqlDataReader
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable(); //representar una tabla en memoria
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("examenes_buscar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@idPaciente", SqlDbType.Int).Value = id_paciente; //por este medio le mandamos  el valor  a buscar nombre o apellido    
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
        //metodo para insertar informacion examanes 
        public string InsertarExamen(DatosExame Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("examenes_insertar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Obj.Fecha; //por este medio le mandamos  el valor  a buscar nombre o apellido    
                comando.Parameters.Add("@Datos_postivos", SqlDbType.VarChar).Value = Obj.Datos_postivos;
                comando.Parameters.Add("@Examenes_Complementarios", SqlDbType.VarChar).Value = Obj.Examenes_Complementarios;
                comando.Parameters.Add("@Impresion_Clinica", SqlDbType.VarChar).Value = Obj.Impresion_Clinica;
                comando.Parameters.Add("@Tratamiento", SqlDbType.VarChar).Value = Obj.Tratamiento;
                comando.Parameters.Add("@Id_paciente", SqlDbType.Int).Value = Obj.Id_paciente;

                SqlCon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo ingresar el registro";

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
        public string ActualizarExamen(DatosExame Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("examenes_actualizar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@Id_examenes", SqlDbType.Int).Value = Obj.Id_examenes;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Obj.Fecha; //por este medio le mandamos  el valor  a buscar nombre o apellido    
                comando.Parameters.Add("@Datos_postivos", SqlDbType.VarChar).Value = Obj.Datos_postivos;
                comando.Parameters.Add("@Examenes_Complementarios", SqlDbType.VarChar).Value = Obj.Examenes_Complementarios;
                comando.Parameters.Add("@Impresion_Clinica", SqlDbType.VarChar).Value = Obj.Impresion_Clinica;
                comando.Parameters.Add("@Tratamiento", SqlDbType.VarChar).Value = Obj.Tratamiento;
                comando.Parameters.Add("@Id_paciente", SqlDbType.Int).Value = Obj.Id_paciente;

                
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
        public string eliminarExamen(int Id)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Primero debemos conectarnos al metodo getIstancia  para activar el String de conexion a la BD
                SqlCon = Conexion.getIstancia().crearConexion();
                SqlCommand comando = new SqlCommand("examenes_eliminar", SqlCon);
                comando.CommandType = CommandType.StoredProcedure; //le decimos a c# que estamos trabajando con procedimientos almacenados
                comando.Parameters.Add("@Id_examenes", SqlDbType.Int).Value = Id;
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
