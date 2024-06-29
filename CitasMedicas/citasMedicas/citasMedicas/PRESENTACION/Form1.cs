using citasMedicas.PRESENTACION;
using citasMedicas.REPORTES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citasMedicas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {

           
        }

        private void pACIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //generar instancia al formulario pacientes
            frmPacientes fp = new frmPacientes();
            this.Hide(); //oculto formulario principal
            fp.ShowDialog();
            this.Show(); //muestro formulario actual
        }

        private void iNFORMENOMBREPACIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            frminformePacientes fc = new frminformePacientes();
            this.Hide(); //oculto formulario principal
            fc.ShowDialog(); //muestro el formulario
            this.Show(); //muestro formulario actual


        }

        private void búsquedaPorIntervalosDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFechas fg = new frmFechas();
            this.Hide(); //oculto formulario principal
            fg.ShowDialog();
            this.Show(); //muestro formulario actual
        }

        private void iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //oculto formulario principal
            frmExamenesPacientes fd = new frmExamenesPacientes();
            fd.ShowDialog();
            this.Show(); //muestro formulario actual
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
