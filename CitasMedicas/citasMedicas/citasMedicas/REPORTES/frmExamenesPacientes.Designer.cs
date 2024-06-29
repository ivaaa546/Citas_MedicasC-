namespace citasMedicas.REPORTES
{
    partial class frmExamenesPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamenesPacientes));
            this.buscar_examenes_por_nombre_apellidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstReporte2 = new citasMedicas.REPORTES.dstReporte2();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buscarexamenespornombreapellidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstReporte2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscar_examenes_por_nombre_apellidoTableAdapter = new citasMedicas.REPORTES.dstReporte2TableAdapters.buscar_examenes_por_nombre_apellidoTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_examenes_por_nombre_apellidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstReporte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarexamenespornombreapellidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstReporte2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar_examenes_por_nombre_apellidoBindingSource
            // 
            this.buscar_examenes_por_nombre_apellidoBindingSource.DataMember = "buscar_examenes_por_nombre_apellido";
            this.buscar_examenes_por_nombre_apellidoBindingSource.DataSource = this.dstReporte2;
            // 
            // dstReporte2
            // 
            this.dstReporte2.DataSetName = "dstReporte2";
            this.dstReporte2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPaciente.BackgroundImage = global::citasMedicas.Properties.Resources.lupa2;
            this.btnBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(1013, 24);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(70, 43);
            this.btnBuscarPaciente.TabIndex = 6;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscarPaciente, "Buscar paciente y examen");
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(668, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 20);
            this.txtNombre.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese nombre o apellido del paciente");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por nombre o apellidos del paciente a buscar:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.buscar_examenes_por_nombre_apellidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "citasMedicas.REPORTES.reporteExPaciente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(156, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1015, 741);
            this.reportViewer1.TabIndex = 7;
            // 
            // buscarexamenespornombreapellidoBindingSource
            // 
            this.buscarexamenespornombreapellidoBindingSource.DataMember = "buscar_examenes_por_nombre_apellido";
            this.buscarexamenespornombreapellidoBindingSource.DataSource = this.dstReporte2BindingSource;
            // 
            // dstReporte2BindingSource
            // 
            this.dstReporte2BindingSource.DataSource = this.dstReporte2;
            this.dstReporte2BindingSource.Position = 0;
            // 
            // buscar_examenes_por_nombre_apellidoTableAdapter
            // 
            this.buscar_examenes_por_nombre_apellidoTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1309, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolTip1.SetToolTip(this.toolStrip1, "Buscar Paciente");
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = global::citasMedicas.Properties.Resources.register_internet_direction_web_right_button_enter_arrow_login_icon_210831;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(1089, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button1, "Regresar al inicio");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmExamenesPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamenesPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExamenesPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscar_examenes_por_nombre_apellidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstReporte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarexamenespornombreapellidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstReporte2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarexamenespornombreapellidoBindingSource;
        private System.Windows.Forms.BindingSource dstReporte2BindingSource;
        private dstReporte2 dstReporte2;
        private dstReporte2TableAdapters.buscar_examenes_por_nombre_apellidoTableAdapter buscar_examenes_por_nombre_apellidoTableAdapter;
        private System.Windows.Forms.BindingSource buscar_examenes_por_nombre_apellidoBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button button1;
    }
}