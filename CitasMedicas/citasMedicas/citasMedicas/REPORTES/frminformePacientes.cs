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
    public partial class frminformePacientes : Form
    {
        public frminformePacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string valor = txtNombre.Text;
            this.paciente_buscarTableAdapter.Fill(this.dstReporte1.paciente_buscar, valor);
            this.reportViewer1.RefreshReport();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
