using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citasMedicas.ENTIDADES
{
    public class DatosExame
    {
        //crear las propiedades para enviar y recibir informacion
        public int Id_examenes { get; set; }
        public DateTime Fecha { get; set; }
        public string Datos_postivos { get; set; }
        public string Examenes_Complementarios { get; set; }
        public string Impresion_Clinica { get; set; }
        public string Tratamiento { get; set; }
        public int Id_paciente { get; set; }
    }
}
