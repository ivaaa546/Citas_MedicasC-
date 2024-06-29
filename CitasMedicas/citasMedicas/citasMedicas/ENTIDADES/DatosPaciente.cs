using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citasMedicas.ENTIDADES
{
    public class DatosPaciente
    {
        //crear las propiedades para enviar y recibir informacion
        public int Id_paciente { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string telefono { get; set; }
        public string DPI { get; set; }
        public string Edad { get; set; }
        public string PA { get; set; }
        public string Temp { get; set; }
        public string Peso { get; set; }

    }
}
