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
    public partial class frmFechas : Form
    {
        private readonly object dtsReporteRangoFechasTableAdapter;

        public frmFechas()
        {
            InitializeComponent();
        }

        private void frmFechas_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtNombre.Visible = false;
            // this.reportViewer1.RefreshReport();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        { 

            string valor = txtNombre.Text;
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFinal = dateTimePicker2.Value;

                /*this.buscarxamanes_refechaNombreTableAdapter.Fill(this.dtsReporteRangoFechas.buscarxamanes_fechaNombre, valor, fechaInicio, fechaFinal);
                this.reportViewer1.RefreshReport();*/

                this.rangodeFechasTableAdapter.Fill(this.dtsReporteRangoFechas1.rangodeFechas, fechaInicio, fechaFinal,valor );
                this.reportViewer1.RefreshReport();
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
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
