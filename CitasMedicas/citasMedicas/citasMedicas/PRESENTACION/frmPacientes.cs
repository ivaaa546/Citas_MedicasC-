using citasMedicas.DATOS;
using citasMedicas.NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citasMedicas.PRESENTACION
{

    public partial class frmPacientes : Form
    {
        private string NombreAnt;

        public frmPacientes()
        {
            InitializeComponent();
        }
        //metodo para listar los elementos de la tabla paciente
        private void Listar()
        {
            try
            {
                dgListado.DataSource = Npaciente.Listar();
                lblTotal.Text = "Total Registros: " + Convert.ToString(dgListado.Rows.Count - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //formato del datagrid
        private void formato()
        {
            dgListado.Columns[0].Visible = false;
            dgListado.Columns[1].Visible = false;

            dgListado.Columns[2].Width = 100;
            dgListado.Columns[3].Width = 150;
            dgListado.Columns[4].Width = 150;
            dgListado.Columns[5].Width = 100;
            dgListado.Columns[6].Width = 100;
            dgListado.Columns[7].Width = 100;
            dgListado.Columns[8].Width = 100;
            dgListado.Columns[9].Width = 100;
            dgListado.Columns[10].Width = 150;
            dgListado.Columns[11].Width = 150;

            /*dgExamenes.Columns[0].Width = 150;
            dgExamenes.Columns[1].Width = 150;
            dgExamenes.Columns[2].Width = 150;
            dgExamenes.Columns[3].Width = 150;
            dgExamenes.Columns[4].Width = 150;
            dgExamenes.Columns[5].Width = 150;
            dgExamenes.Columns[6].Width = 150;
            dgExamenes.Columns[7].Width = 150;*/
        }

        private void FormatoExamen()
        {
            dgExamenes.Columns[0].Visible = false;
            dgExamenes.Columns[1].Visible = false;
            dgExamenes.Columns[0].Width = 150;
            dgExamenes.Columns[1].Width = 150;
            dgExamenes.Columns[2].Width = 150;
            dgExamenes.Columns[3].Width = 150;
            dgExamenes.Columns[4].Width = 150;
            dgExamenes.Columns[5].Width = 150;
            dgExamenes.Columns[6].Width = 150;
            dgExamenes.Columns[7].Width = 150;
        }


        //metodo para buscar los pacientes
        private void Buscar()
        {
            try
            {
                dgListado.DataSource = Npaciente.Buscar(txtBuscar.Text);
                this.formato();
                lblTotal.Text = "Total Registros: " + Convert.ToString(dgListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BuscarExamen(int idPaciente)
        {
            try
            {
                dgExamenes.DataSource = Nexamenes.BuscarExamen(Convert.ToInt32(txtID.Text));
                lblTotalExamenes.Text = "Total de Examanes: " + Convert.ToString(dgExamenes.Rows.Count - 1);
                this.FormatoExamen();
               // txtIDEx.Text = Convert.ToString(dgExamenes.Columns[1]);
                //lblTotal.Text = "Total Registros: " + Convert.ToString(dgListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void frmPacientes_Load(object sender, EventArgs e)
        {
            //llamamos al metodo listar
            Listar();
            this.formato();

            //ocultar txtId
            txtID.Visible = false;
            txtIDEx.Visible = false;
            btnActualizarEx.Enabled = false;
            //ocultamos  el grupo examenes
            groupExamen.Visible = false;
            //ocultamos boton elimiar
            btnEliminar.Visible = false;
            btnActualizar.Enabled = false;//desactivamos el boton actualizar
            btnGuardarEx.Enabled = true;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        //metodo para el control de los mensajes del control
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "citasMedicas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo par el control de los mensajes de informacion
        private void MesanjeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "citasMedicas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //metodo para limpiar los compos
        private void limpiar()
        {
            txtBuscar.Clear();
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDPI.Clear();
            txtPA.Clear();
            txtEdad.Clear();
            txtTemp.Clear();
            txtPeso.Clear();

            txtImpresionClinica.Clear();
            txtExamenesCom.Clear();
            txtIDEx.Clear();
            txtTratamiento.Clear();
            txtDatosPositivos.Clear();

            dtFecha.Value = DateTime.Now; //mostrar fecha actual del sistema
            dtFechaExamenes.Value = DateTime.Now;
            btnEliminar.Visible = false;
            chkSelccionar.Checked = false;
            btnEliminarEx.Visible = false;
            chkSelecionarEx.Checked = false;
        }
        
        private void limipiarExamen()
        {
            txtDatosPositivos.Clear();
            txtImpresionClinica.Clear();
            txtExamenesCom.Clear();
            txtTratamiento.Clear();
            txtIDEx.Clear();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            tabGeneral.SelectedIndex = 1; //lleva al registro de pacientes
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnActualizarEx.Enabled = false;
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)//
        {
            try
            {
                //validacioes 
                string rpta = "";
                if (txtNombres.Text == string.Empty || txtApellidos.Text == string.Empty || txtTelefono.Text == string.Empty || txtDPI.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán indicados.");
                    errorProvider1.SetError(txtNombres, "Ingrese el nombre del paciente.");
                    errorProvider1.SetError(txtApellidos, "Ingrese el apellido del paciente.");
                    errorProvider1.SetError(txtTelefono, "Ingrese el telefono del paciente.");
                    errorProvider1.SetError(txtDPI, "Ingrese el DPI del paciente.");

                }
                else
                {
                    DateTime feha = dtFecha.Value;
                    rpta = Npaciente.Insertar(feha, txtNombres.Text.Trim(), txtApellidos.Text.Trim(), txtDireccion.Text.Trim(),
                        txtTelefono.Text.Trim(), txtDPI.Text.Trim(), txtEdad.Text.Trim(), txtPA.Text.Trim(), txtTemp.Text.Trim(), txtPeso.Text.Trim());
                    if (rpta.Equals("Ok"))
                    {   
                        this.MesanjeOk("Se inserto el registro del paciente de forma correcta");
                        errorProvider1.Clear();
                        this.limpiar();
                        this.Listar();
                        this.tabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(rpta);
                        txtNombres.Clear();
                        txtNombres.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabGeneral.SelectedIndex = 0;
            this.limpiar();
            this.limipiarExamen();
            dgExamenes.DataSource = null;
            errorProvider1.Clear();

        }

        private void chkSelccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelccionar.Checked)
            {
                dgListado.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgListado.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }

        }
        int idExamen; //variable para buscar los examenes del paciente
        private void dgListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.limpiar();
                btnActualizar.Enabled = true;
                btnGuardar.Enabled = false;
                txtID.Text = Convert.ToString(dgListado.CurrentRow.Cells["Id_Paciente"].Value);
                dtFecha.Value = Convert.ToDateTime(dgListado.CurrentRow.Cells["Fecha"].Value);
                txtNombres.Text = Convert.ToString(dgListado.CurrentRow.Cells["Nombres"].Value);
                this.NombreAnt = Convert.ToString(dgListado.CurrentRow.Cells["Nombres"].Value);
                txtApellidos.Text = Convert.ToString(dgListado.CurrentRow.Cells["Apellidos"].Value);
                txtDireccion.Text = Convert.ToString(dgListado.CurrentRow.Cells["Direccion"].Value);
                txtTelefono.Text = Convert.ToString(dgListado.CurrentRow.Cells["Telefono"].Value);
                txtDPI.Text = Convert.ToString(dgListado.CurrentRow.Cells["DPI"].Value);
                txtEdad.Text = Convert.ToString(dgListado.CurrentRow.Cells["Edad"].Value);
                txtPA.Text = Convert.ToString(dgListado.CurrentRow.Cells["PA"].Value);
                txtTemp.Text = Convert.ToString(dgListado.CurrentRow.Cells["Temp"].Value);
                txtPeso.Text = Convert.ToString(dgListado.CurrentRow.Cells["Peso"].Value);
                //txtIDEx.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["Id_examenes"].Value);
                tabGeneral.SelectedIndex = 1;
                groupExamen.Visible = false;
                idExamen = Convert.ToInt32(txtID.Text);

                txtIDEx.Text = Convert.ToString(txtID.Text);
                //txtDatosPositivos = Convert.ToString();
                //groupExamen.Visible = true; //mostramos grupo de examanes
                //llamar metodo para buscar examen  
                BuscarExamen(idExamen); //23:00


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //validacioes 
                string rpta = "";
                if (txtNombres.Text == string.Empty || txtApellidos.Text == string.Empty || txtTelefono.Text == string.Empty || txtDPI.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán indicados.");
                    errorProvider1.SetError(txtNombres, "Ingrese el nombre del paciente.");
                    errorProvider1.SetError(txtApellidos, "Ingrese el apellido del paciente.");
                    errorProvider1.SetError(txtTelefono, "Ingrese el telefono del paciente.");
                    errorProvider1.SetError(txtDPI, "Ingrese el DPI del paciente.");
                }
                else
                {
                    DateTime feha = dtFecha.Value;
                    rpta = Npaciente.Actualizar(Convert.ToInt32(txtID.Text), feha, NombreAnt, txtNombres.Text.Trim(), txtApellidos.Text.Trim(), txtDireccion.Text.Trim(),
                        txtTelefono.Text.Trim(), txtDPI.Text.Trim(), txtEdad.Text.Trim(), txtPA.Text.Trim(), txtTemp.Text.Trim(), txtPeso.Text.Trim());
                    if (rpta.Equals("Ok"))
                    {
                        this.MesanjeOk("Se actualizo el registro del paciente de forma correcta");
                        errorProvider1.Clear();
                        this.limpiar();
                        this.Listar();
                        this.tabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(rpta);
                        txtNombres.Clear();
                        txtNombres.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chekEliminar = (DataGridViewCheckBoxCell)dgListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chekEliminar.Value = !Convert.ToBoolean(chekEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente deseas eliminar el (los) registros?", "citasMedicas",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string rpta = "";
                    //necesitamos recorrer cada una de las filas del datagrid
                    foreach (DataGridViewRow row in dgListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = Npaciente.Eliminar(Codigo);
                            if (rpta.Equals("Ok"))
                            {
                                this.MesanjeOk("Se elimino el registro del paciente: " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnActivarExamenes_Click_1(object sender, EventArgs e)
        {
            groupExamen.Visible = true;
            btnGuardarEx.Enabled = true;
            btnActualizarEx.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void btnGuardarEx_Click(object sender, EventArgs e)
        {
            try
            {
                //validacioes 
                string rpta = "";
                if (txtDatosPositivos.Text == string.Empty || txtExamenesCom.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán indicados.");
                    errorProvider1.SetError(txtDatosPositivos, "Ingrese los datos positivos del paciente.");
                    errorProvider1.SetError(txtExamenesCom, "Ingrese los examanes complementarios paciente.");
                }
                else { 
                    DateTime feha = dtFechaExamenes.Value;
                   
                    rpta = Nexamenes.InsertarExamen(feha, txtDatosPositivos.Text.Trim(), txtExamenesCom.Text.Trim(),txtImpresionClinica.Text.Trim(),
                        txtTratamiento.Text.Trim(), Convert.ToInt32(txtID.Text));
                    if (rpta.Equals("Ok"))
                    {
                        this.MesanjeOk("Se inserto el registro del examen de forma correcta");
                        errorProvider1.Clear();
                        //this.limpiar();
                        //this.Listar();
                        this.tabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(rpta);
                        txtDatosPositivos.Clear();
                        txtExamenesCom.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizarEx_Click(object sender, EventArgs e)
        {
            try
            {
                //validacioes 
                string rpta = "";
                if (txtDatosPositivos.Text == string.Empty || txtExamenesCom.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán indicados.");
                    errorProvider1.SetError(txtDatosPositivos, "Ingrese los datos positivos del paciente.");
                    errorProvider1.SetError(txtExamenesCom, "Ingrese los examanes complementarios paciente.");
                }
                else { 
                DateTime feha = dtFechaExamenes.Value;
                    rpta = Nexamenes.ActualizarExamen(Convert.ToInt32(txtIDEx.Text),feha, txtDatosPositivos.Text.Trim(), txtExamenesCom.Text.Trim(), txtImpresionClinica.Text.Trim(),
                        txtTratamiento.Text.Trim(), Convert.ToInt32(txtID.Text));
                    if (rpta.Equals("Ok"))
                    {
                        this.MesanjeOk("Se actualizo el registro de examanes de forma correcta");
                        errorProvider1.Clear();
                        this.limpiar();
                        this.Listar();
                        this.tabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(rpta);
                       // txtDatosPositivos.Clear();
                       // txtExamenesCom.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkSelecionarEx_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelecionarEx.Checked)
            {
                dgExamenes.Columns[0].Visible = true;
                btnEliminarEx.Visible = true;
            }
            else
            {
                dgExamenes.Columns[0].Visible = false;
                btnEliminarEx.Visible = false;
            }
        }

        private void btnEliminarEx_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente deseas eliminar el (los) registros?", "citasMedicas",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string rpta = "";
                    //necesitamos recorrer cada una de las filas del datagrid
                    foreach (DataGridViewRow row in dgExamenes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = Nexamenes.eliminarExamen(Codigo);
                            if (rpta.Equals("Ok"))
                            {
                                this.MesanjeOk("Se elimino el registro de examen del paciente: " + txtNombres.Text);
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }

                    }
                    tabGeneral.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void groupExamen_Enter(object sender, EventArgs e)
        {

        }

        private void dgExamenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.limipiarExamen();
                btnActualizarEx.Enabled = true;
                btnGuardarEx.Enabled = false;
                txtIDEx.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["id_examenes"].Value);
                txtDatosPositivos.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["Datos_postivos"].Value);
                txtExamenesCom.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["Examenes_Complementarios"].Value);
                txtImpresionClinica.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["Impresion_Clinica"].Value);
                txtTratamiento.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["Tratamiento"].Value);
                
                // txtIDEx.Text = Convert.ToString(dgExamenes.CurrentRow.Cells["Id_paciente"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgExamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgExamenes.Columns["Examenes"].Index)
            {
                DataGridViewCheckBoxCell chekEliminarExamen = (DataGridViewCheckBoxCell)dgExamenes.Rows[e.RowIndex].Cells["Examenes"];
                chekEliminarExamen.Value = !Convert.ToBoolean(chekEliminarExamen.Value);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupPaciente_Enter(object sender, EventArgs e)
        {

        }
    }
}
