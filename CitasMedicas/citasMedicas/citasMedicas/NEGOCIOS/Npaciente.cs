using citasMedicas.DATOS;
using citasMedicas.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citasMedicas.NEGOCIOS
{
    internal class Npaciente
    {
        //metodo para obtener la informacion y listarla
        public static DataTable Listar()
        {
            //creamos una instancia a la clase paciente
            Dpacientes dpaciente = new Dpacientes();
            return dpaciente.Listar();
        }

        //metodo para buscar
        public static DataTable Buscar(string valor)
        {
            //creamos una instancia a la clase paciente
            Dpacientes dpaciente = new Dpacientes();
            return dpaciente.Buscar(valor);
        }

        //metodo para insertar
        public static string Insertar(DateTime Fecha, string Nombres, string Apellidos, string Direccion,
            string telefono, string DPI, string Edad, string PA, string Temp, string Peso)
        {
            Dpacientes datos = new Dpacientes();
            //mandar la informacion a la clase datosPaciente donde estan las propiedad
            DatosPaciente Obj = new DatosPaciente();
            Obj.Fecha = Fecha;
            Obj.Nombres = Nombres;
            Obj.Apellidos = Apellidos;
            Obj.Direccion = Direccion;
            Obj.telefono = telefono;
            Obj.DPI = DPI;
            Obj.Edad = Edad;
            Obj.PA = PA;
            Obj.Temp = Temp;
            Obj.Peso = Peso;
            return datos.Insertar(Obj); //con esto enviamos la informacion de datosPaciente al metodo insertar de la clase Dpaciente
        }

        //metodo para actualizar pacientes
        public static string Actualizar(int Id, DateTime Fecha, string nombreAnt, string Nombres, string Apellidos, string Direccion,
            string telefono, string DPI, string Edad, string PA, string Temp, string Peso)
        {
            Dpacientes datos = new Dpacientes();
            //mandar la informacion a la clase datosPaciente donde estan las propiedad
            DatosPaciente Obj = new DatosPaciente();

            if (nombreAnt.Equals(Nombres))
            {
                Obj.Id_paciente =  Id;
                Obj.Fecha = Fecha;
                Obj.Nombres = Nombres;
                Obj.Apellidos = Apellidos;
                Obj.Direccion = Direccion;
                Obj.telefono = telefono;
                Obj.DPI = DPI;
                Obj.Edad = Edad;
                Obj.PA = PA;
                Obj.Temp = Temp;
                Obj.Peso = Peso;
                return datos.Actualizar(Obj);
            }
            else
            {
                Obj.Id_paciente = Id;
                Obj.Fecha = Fecha;
                Obj.Nombres = Nombres;
                Obj.Apellidos = Apellidos;
                Obj.Direccion = Direccion;
                Obj.telefono = telefono;
                Obj.DPI = DPI;
                Obj.Edad = Edad;
                Obj.PA = PA;
                Obj.Temp = Temp;
                Obj.Peso = Peso;
                return datos.Actualizar(Obj);
            }
        }

        //metodo eliminar pacientes

        public static string Eliminar(int Id)
        {
            Dpacientes dpacientes = new Dpacientes();
            return dpacientes.eliminar(Id);
        }

    }
}
