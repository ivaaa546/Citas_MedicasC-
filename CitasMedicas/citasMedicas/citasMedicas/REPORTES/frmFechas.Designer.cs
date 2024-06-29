namespace citasMedicas.REPORTES
{
    partial class frmFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechas));
            this.rangodeFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReporteRangoFechas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReporteRangoFechas1 = new citasMedicas.REPORTES.dtsReporteRangoFechas1();
            this.buscarxamanesfechaNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReporteRangoFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsReporteRangoFechas = new citasMedicas.REPORTES.dtsReporteRangoFechas();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarxamanes_fechaNombreTableAdapter = new citasMedicas.REPORTES.dtsReporteRangoFechasTableAdapters.buscarxamanes_fechaNombreTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarxamanesfechaNombreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rangodeFechasTableAdapter = new citasMedicas.REPORTES.dtsReporteRangoFechas1TableAdapters.rangodeFechasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rangodeFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarxamanesfechaNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarxamanesfechaNombreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rangodeFechasBindingSource
            // 
            this.rangodeFechasBindingSource.DataMember = "rangodeFechas";
            this.rangodeFechasBindingSource.DataSource = this.dtsReporteRangoFechas1BindingSource;
            // 
            // dtsReporteRangoFechas1BindingSource
            // 
            this.dtsReporteRangoFechas1BindingSource.DataSource = this.dtsReporteRangoFechas1;
            this.dtsReporteRangoFechas1BindingSource.Position = 0;
            // 
            // dtsReporteRangoFechas1
            // 
            this.dtsReporteRangoFechas1.DataSetName = "dtsReporteRangoFechas1";
            this.dtsReporteRangoFechas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarxamanesfechaNombreBindingSource
            // 
            this.buscarxamanesfechaNombreBindingSource.DataMember = "buscarxamanes_fechaNombre";
            this.buscarxamanesfechaNombreBindingSource.DataSource = this.dtsReporteRangoFechasBindingSource;
            // 
            // dtsReporteRangoFechasBindingSource
            // 
            this.dtsReporteRangoFechasBindingSource.DataSource = this.dtsReporteRangoFechas;
            this.dtsReporteRangoFechasBindingSource.Position = 0;
            // 
            // dtsReporteRangoFechas
            // 
            this.dtsReporteRangoFechas.DataSetName = "dtsReporteRangoFechas";
            this.dtsReporteRangoFechas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPaciente.BackgroundImage = global::citasMedicas.Properties.Resources.lupa2;
            this.btnBuscarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(960, 65);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(70, 43);
            this.btnBuscarPaciente.TabIndex = 9;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscarPaciente, "Buscar paciente y examen");
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rangodeFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "citasMedicas.REPORTES.ReporteRangoFechas1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(179, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(981, 598);
            this.reportViewer1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Ingrese la fecha de inicio");
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese la fecha de inicio";
            // 
            // buscarxamanes_fechaNombreTableAdapter
            // 
            this.buscarxamanes_fechaNombreTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = global::citasMedicas.Properties.Resources.register_internet_direction_web_right_button_enter_arrow_login_icon_210831;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(1051, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.button1, "Regresar al inicio");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(743, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.dateTimePicker2, "Ingrese la fecha final");
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(1127, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(33, 13);
            this.txtNombre.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese nombre o apellido del paciente");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingrese la fecha final";
            // 
            // buscarxamanesfechaNombreBindingSource1
            // 
            this.buscarxamanesfechaNombreBindingSource1.DataMember = "buscarxamanes_fechaNombre";
            this.buscarxamanesfechaNombreBindingSource1.DataSource = this.dtsReporteRangoFechasBindingSource;
            // 
            // rangodeFechasTableAdapter
            // 
            this.rangodeFechasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar por Fecha";
            // 
            // frmFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Pacientes";
            this.toolTip1.SetToolTip(this, "Ingrese nombre o apellido del paciente");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rangodeFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarxamanesfechaNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReporteRangoFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarxamanesfechaNombreBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPaciente;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dtsReporteRangoFechasBindingSource;
        private dtsReporteRangoFechas dtsReporteRangoFechas;
        private System.Windows.Forms.BindingSource buscarxamanesfechaNombreBindingSource;
        private dtsReporteRangoFechasTableAdapters.buscarxamanes_fechaNombreTableAdapter buscarxamanes_fechaNombreTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dtsReporteRangoFechas1BindingSource;
        private dtsReporteRangoFechas1 dtsReporteRangoFechas1;
        private System.Windows.Forms.BindingSource rangodeFechasBindingSource;
        private System.Windows.Forms.BindingSource buscarxamanesfechaNombreBindingSource1;
        private dtsReporteRangoFechas1TableAdapters.rangodeFechasTableAdapter rangodeFechasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}