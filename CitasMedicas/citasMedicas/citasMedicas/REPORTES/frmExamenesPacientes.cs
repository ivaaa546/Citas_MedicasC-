using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citasMedicas.REPORTES
{
    public partial class frmExamenesPacientes : Form
    {
        public frmExamenesPacientes()
        {
            InitializeComponent();
        }

        private void frmExamenesPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dstReporte2.buscar_examenes_por_nombre_apellido' Puede moverla o quitarla según sea necesario.
          //  this.buscar_examenes_por_nombre_apellidoTableAdapter.Fill(this.dstReporte2.buscar_examenes_por_nombre_apellido);


            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string valor = txtNombre.Text;
            this.buscar_examenes_por_nombre_apellidoTableAdapter.Fill(this.dstReporte2.buscar_examenes_por_nombre_apellido, valor);
            this.reportViewer1.RefreshReport();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
