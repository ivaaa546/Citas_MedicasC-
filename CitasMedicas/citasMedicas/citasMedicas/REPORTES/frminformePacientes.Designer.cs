namespace citasMedicas.REPORTES
{
    partial class frminformePacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminformePacientes));
            this.pacientebuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstReporte1 = new citasMedicas.REPORTES.dstReporte1();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paciente_buscarTableAdapter = new citasMedicas.REPORTES.dstReporte1TableAdapters.paciente_buscarTableAdapter();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.paciente_buscarTableAdapter1 = new citasMedicas.REPORTES.dstReporte1TableAdapters.paciente_buscarTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pacientebuscarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstReporte1)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientebuscarBindingSource
            // 
            this.pacientebuscarBindingSource.DataMember = "paciente_buscar";
            this.pacientebuscarBindingSource.DataSource = this.dstReporte1;
            // 
            // dstReporte1
            // 
            this.dstReporte1.DataSetName = "dstReporte1";
            this.dstReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por nombre o apellidos del paciente a buscar:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(599, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 20);
            this.txtNombre.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese nombre o apellido del  paciente");
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pacientebuscarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "citasMedicas.REPORTES.reportePacientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(87, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(978, 899);
            this.reportViewer1.TabIndex = 4;
            // 
            // paciente_buscarTableAdapter
            // 
            this.paciente_buscarTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPaciente.BackgroundImage = global::citasMedicas.Properties.Resources.lupa2;
            this.btnBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(906, 29);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(70, 43);
            this.btnBuscarPaciente.TabIndex = 3;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscarPaciente, "Buscar Paciente");
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // paciente_buscarTableAdapter1
            // 
            this.paciente_buscarTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = global::citasMedicas.Properties.Resources.register_internet_direction_web_right_button_enter_arrow_login_icon_210831;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(995, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button1, "Regresar al inicio");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frminformePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 813);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frminformePacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientebuscarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstReporte1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pacientebuscarBindingSource;
        private dstReporte1 dstReporte1;
        private dstReporte1TableAdapters.paciente_buscarTableAdapter paciente_buscarTableAdapter;
        private dstReporte1TableAdapters.paciente_buscarTableAdapter paciente_buscarTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}