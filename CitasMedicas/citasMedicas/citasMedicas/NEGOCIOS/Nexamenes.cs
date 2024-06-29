using citasMedicas.DATOS;
using citasMedicas.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citasMedicas.NEGOCIOS
{
    internal class Nexamenes
    {
        //metodo para buscar
        public static DataTable BuscarExamen(int IDPaciente)
        {
            //creamos una instancia a la clase paciente
            Dexamenes dexamenes = new Dexamenes();
            return dexamenes.BuscarExamen(IDPaciente);
        }

        //metodo para insertar
        public static string InsertarExamen(DateTime Fecha, string Datos_postivos, string Examenes_Complementarios, string Impresion_Clinica,
        string Tratamiento, int Id_paciente)
        {
            Dexamenes datos = new Dexamenes();
            //mandar la informacion a la clase datosPaciente donde estan las propiedad
            DatosExame Obj = new DatosExame();
            Obj.Fecha = Fecha;
            Obj.Datos_postivos = Datos_postivos;
            Obj.Examenes_Complementarios = Examenes_Complementarios;
            Obj.Impresion_Clinica = Impresion_Clinica;
            Obj.Tratamiento = Tratamiento;
            Obj.Id_paciente = Id_paciente;

            return datos.InsertarExamen(Obj); //con esto enviamos la informacion de datosPaciente al metodo insertar de la clase Dpaciente
        }

        //metodo para actualizar examanes
        public static string ActualizarExamen( int Id_examanes, DateTime Fecha, string Datos_postivos, string Examenes_Complementarios, string Impresion_Clinica,
        string Tratamiento, int Id_paciente)
        {
            Dexamenes datos = new Dexamenes();
            //mandar la informacion a la clase datosPaciente donde estan las propiedad
            DatosExame Obj = new DatosExame();
            Obj.Id_examenes = Id_examanes;
            Obj.Fecha = Fecha;
            Obj.Datos_postivos = Datos_postivos;
            Obj.Examenes_Complementarios= Examenes_Complementarios;
            Obj.Impresion_Clinica = Impresion_Clinica;
            Obj.Tratamiento = Tratamiento;
            Obj.Id_paciente= Id_paciente;
            return datos.ActualizarExamen(Obj);
        }

        //metodo para eliminar los metodos del examen
        public static string eliminarExamen(int Id)
        {
            Dexamenes dexamenes = new Dexamenes();
            return dexamenes.eliminarExamen(Id);
        }
    }
}
