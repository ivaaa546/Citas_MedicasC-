namespace citasMedicas.PRESENTACION
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkSelccionar = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupExamen = new System.Windows.Forms.GroupBox();
            this.lblTotalExamenes = new System.Windows.Forms.Label();
            this.btnEliminarEx = new System.Windows.Forms.Button();
            this.chkSelecionarEx = new System.Windows.Forms.CheckBox();
            this.btnGuardarEx = new System.Windows.Forms.Button();
            this.btnActualizarEx = new System.Windows.Forms.Button();
            this.dgExamenes = new System.Windows.Forms.DataGridView();
            this.Examenes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtImpresionClinica = new System.Windows.Forms.TextBox();
            this.txtExamenesCom = new System.Windows.Forms.TextBox();
            this.txtDatosPositivos = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaExamenes = new System.Windows.Forms.DateTimePicker();
            this.txtIDEx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActivarExamenes = new System.Windows.Forms.Button();
            this.groupPaciente = new System.Windows.Forms.GroupBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.paciente_buscarTableAdapter1 = new citasMedicas.REPORTES.dstReporte1TableAdapters.paciente_buscarTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupExamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExamenes)).BeginInit();
            this.Panel1.SuspendLayout();
            this.groupPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeneral.Location = new System.Drawing.Point(12, 15);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1295, 960);
            this.tabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.btnRegresar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.btnNuevoRegistro);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.chkSelccionar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.dgListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1287, 927);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LISTADO DE PACIENTES";
            this.toolTip1.SetToolTip(this.tabPage1, "Regresar al inicio");
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(17, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(262, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Ingrese el nombre del paciente:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(1007, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Inicio:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegresar.BackgroundImage = global::citasMedicas.Properties.Resources.register_internet_direction_web_right_button_enter_arrow_login_icon_210831;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.Location = new System.Drawing.Point(1070, 18);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(59, 35);
            this.btnRegresar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnRegresar, "Regresar al inicio");
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(1088, 642);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(165, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Resgistros:";
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevoRegistro.BackgroundImage = global::citasMedicas.Properties.Resources.anadir1;
            this.btnNuevoRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(932, 20);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(54, 35);
            this.btnNuevoRegistro.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnNuevoRegistro, "Registra Paciente o Examen");
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackgroundImage = global::citasMedicas.Properties.Resources.iconfinder_trash_4341321_120557;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Location = new System.Drawing.Point(157, 631);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 35);
            this.btnEliminar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar Paciente");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(794, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nuevo Registro:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackgroundImage = global::citasMedicas.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Location = new System.Drawing.Point(710, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 35);
            this.btnBuscar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Paciente");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkSelccionar
            // 
            this.chkSelccionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkSelccionar.AutoSize = true;
            this.chkSelccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkSelccionar.Location = new System.Drawing.Point(21, 631);
            this.chkSelccionar.Name = "chkSelccionar";
            this.chkSelccionar.Size = new System.Drawing.Size(140, 28);
            this.chkSelccionar.TabIndex = 1;
            this.chkSelccionar.Text = "Seleccionar";
            this.toolTip1.SetToolTip(this.chkSelccionar, "Seleccionar Pacientes");
            this.chkSelccionar.UseVisualStyleBackColor = true;
            this.chkSelccionar.CheckedChanged += new System.EventHandler(this.chkSelccionar_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(283, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(421, 29);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgListado
            // 
            this.dgListado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgListado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgListado.Location = new System.Drawing.Point(21, 59);
            this.dgListado.Name = "dgListado";
            this.dgListado.Size = new System.Drawing.Size(1232, 534);
            this.dgListado.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgListado, "Doble click para ver datos  del paciente");
            this.dgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellContentClick);
            this.dgListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupExamen);
            this.tabPage2.Controls.Add(this.Panel1);
            this.tabPage2.Controls.Add(this.groupPaciente);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1287, 927);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ACTUALIZACIÓN DE DATOS";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupExamen
            // 
            this.groupExamen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupExamen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupExamen.Controls.Add(this.lblTotalExamenes);
            this.groupExamen.Controls.Add(this.btnEliminarEx);
            this.groupExamen.Controls.Add(this.chkSelecionarEx);
            this.groupExamen.Controls.Add(this.btnGuardarEx);
            this.groupExamen.Controls.Add(this.btnActualizarEx);
            this.groupExamen.Controls.Add(this.dgExamenes);
            this.groupExamen.Controls.Add(this.txtTratamiento);
            this.groupExamen.Controls.Add(this.txtImpresionClinica);
            this.groupExamen.Controls.Add(this.txtExamenesCom);
            this.groupExamen.Controls.Add(this.txtDatosPositivos);
            this.groupExamen.Controls.Add(this.label17);
            this.groupExamen.Controls.Add(this.label16);
            this.groupExamen.Controls.Add(this.label15);
            this.groupExamen.Controls.Add(this.label14);
            this.groupExamen.Controls.Add(this.dtFechaExamenes);
            this.groupExamen.Controls.Add(this.txtIDEx);
            this.groupExamen.Controls.Add(this.label13);
            this.groupExamen.Location = new System.Drawing.Point(24, 449);
            this.groupExamen.Name = "groupExamen";
            this.groupExamen.Size = new System.Drawing.Size(1257, 471);
            this.groupExamen.TabIndex = 2;
            this.groupExamen.TabStop = false;
            this.groupExamen.Text = "CONTROL CLINICO DE EXÁMENES";
            this.groupExamen.Enter += new System.EventHandler(this.groupExamen_Enter);
            // 
            // lblTotalExamenes
            // 
            this.lblTotalExamenes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalExamenes.AutoSize = true;
            this.lblTotalExamenes.Location = new System.Drawing.Point(910, 438);
            this.lblTotalExamenes.Name = "lblTotalExamenes";
            this.lblTotalExamenes.Size = new System.Drawing.Size(137, 20);
            this.lblTotalExamenes.TabIndex = 32;
            this.lblTotalExamenes.Text = "Total Examanes";
            // 
            // btnEliminarEx
            // 
            this.btnEliminarEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarEx.BackgroundImage = global::citasMedicas.Properties.Resources.iconfinder_trash_4341321_120557;
            this.btnEliminarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarEx.Location = new System.Drawing.Point(573, 427);
            this.btnEliminarEx.Name = "btnEliminarEx";
            this.btnEliminarEx.Size = new System.Drawing.Size(54, 35);
            this.btnEliminarEx.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnEliminarEx, "Eliminar Examen");
            this.btnEliminarEx.UseVisualStyleBackColor = true;
            this.btnEliminarEx.Click += new System.EventHandler(this.btnEliminarEx_Click);
            // 
            // chkSelecionarEx
            // 
            this.chkSelecionarEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkSelecionarEx.AutoSize = true;
            this.chkSelecionarEx.Location = new System.Drawing.Point(454, 433);
            this.chkSelecionarEx.Name = "chkSelecionarEx";
            this.chkSelecionarEx.Size = new System.Drawing.Size(113, 24);
            this.chkSelecionarEx.TabIndex = 30;
            this.chkSelecionarEx.Text = "Selecionar";
            this.toolTip1.SetToolTip(this.chkSelecionarEx, "Seleccionar Exámenes");
            this.chkSelecionarEx.UseVisualStyleBackColor = true;
            this.chkSelecionarEx.CheckedChanged += new System.EventHandler(this.chkSelecionarEx_CheckedChanged);
            // 
            // btnGuardarEx
            // 
            this.btnGuardarEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarEx.BackgroundImage = global::citasMedicas.Properties.Resources.Save_icon_icons_com_73702;
            this.btnGuardarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEx.Location = new System.Drawing.Point(1133, 121);
            this.btnGuardarEx.Name = "btnGuardarEx";
            this.btnGuardarEx.Size = new System.Drawing.Size(92, 61);
            this.btnGuardarEx.TabIndex = 26;
            this.btnGuardarEx.Text = "Guardar";
            this.btnGuardarEx.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnGuardarEx, "Guardar Examen");
            this.btnGuardarEx.UseVisualStyleBackColor = true;
            this.btnGuardarEx.Click += new System.EventHandler(this.btnGuardarEx_Click);
            // 
            // btnActualizarEx
            // 
            this.btnActualizarEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarEx.BackgroundImage = global::citasMedicas.Properties.Resources.arrow_refresh_15732;
            this.btnActualizarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizarEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEx.Location = new System.Drawing.Point(1133, 195);
            this.btnActualizarEx.Name = "btnActualizarEx";
            this.btnActualizarEx.Size = new System.Drawing.Size(92, 61);
            this.btnActualizarEx.TabIndex = 27;
            this.btnActualizarEx.Text = "Actualizar";
            this.btnActualizarEx.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnActualizarEx, "Actualizar Examen");
            this.btnActualizarEx.UseVisualStyleBackColor = true;
            this.btnActualizarEx.Click += new System.EventHandler(this.btnActualizarEx_Click);
            // 
            // dgExamenes
            // 
            this.dgExamenes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgExamenes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Examenes});
            this.dgExamenes.Location = new System.Drawing.Point(413, 100);
            this.dgExamenes.Name = "dgExamenes";
            this.dgExamenes.Size = new System.Drawing.Size(703, 322);
            this.dgExamenes.TabIndex = 25;
            this.toolTip1.SetToolTip(this.dgExamenes, "Doble Click Para ver datos de los exámenes");
            this.dgExamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExamenes_CellContentClick);
            this.dgExamenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExamenes_CellDoubleClick);
            // 
            // Examenes
            // 
            this.Examenes.HeaderText = "Examenes";
            this.Examenes.Name = "Examenes";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTratamiento.Location = new System.Drawing.Point(12, 405);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTratamiento.Size = new System.Drawing.Size(348, 53);
            this.txtTratamiento.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtTratamiento, "Ingresar Tratamiento del Paciente");
            // 
            // txtImpresionClinica
            // 
            this.txtImpresionClinica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImpresionClinica.Location = new System.Drawing.Point(16, 319);
            this.txtImpresionClinica.Multiline = true;
            this.txtImpresionClinica.Name = "txtImpresionClinica";
            this.txtImpresionClinica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImpresionClinica.Size = new System.Drawing.Size(344, 48);
            this.txtImpresionClinica.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtImpresionClinica, "Ingresar Impresión Clínica");
            // 
            // txtExamenesCom
            // 
            this.txtExamenesCom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExamenesCom.Location = new System.Drawing.Point(20, 225);
            this.txtExamenesCom.Multiline = true;
            this.txtExamenesCom.Name = "txtExamenesCom";
            this.txtExamenesCom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExamenesCom.Size = new System.Drawing.Size(342, 56);
            this.txtExamenesCom.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtExamenesCom, "Ingresar Exámanes Complementarios");
            // 
            // txtDatosPositivos
            // 
            this.txtDatosPositivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDatosPositivos.Location = new System.Drawing.Point(18, 134);
            this.txtDatosPositivos.Multiline = true;
            this.txtDatosPositivos.Name = "txtDatosPositivos";
            this.txtDatosPositivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatosPositivos.Size = new System.Drawing.Size(342, 48);
            this.txtDatosPositivos.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtDatosPositivos, "Ingresar Datos Positivos");
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 382);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Tratamiento:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Impresión Clínica:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Exámanes Complementarios(*):";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Datos Positivos(*):";
            // 
            // dtFechaExamenes
            // 
            this.dtFechaExamenes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFechaExamenes.Location = new System.Drawing.Point(100, 45);
            this.dtFechaExamenes.Name = "dtFechaExamenes";
            this.dtFechaExamenes.Size = new System.Drawing.Size(334, 26);
            this.dtFechaExamenes.TabIndex = 16;
            // 
            // txtIDEx
            // 
            this.txtIDEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDEx.Location = new System.Drawing.Point(474, 45);
            this.txtIDEx.Name = "txtIDEx";
            this.txtIDEx.Size = new System.Drawing.Size(109, 26);
            this.txtIDEx.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Fecha(*)";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel1.Controls.Add(this.btnGuardar);
            this.Panel1.Controls.Add(this.btnActualizar);
            this.Panel1.Controls.Add(this.btnCancelar);
            this.Panel1.Controls.Add(this.btnActivarExamenes);
            this.Panel1.Location = new System.Drawing.Point(27, 365);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(406, 68);
            this.Panel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::citasMedicas.Properties.Resources.Save_icon_icons_com_73702;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 61);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Paciente");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::citasMedicas.Properties.Resources.arrow_refresh_15732;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(101, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 61);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnActualizar, "Actualizar Paciente");
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::citasMedicas.Properties.Resources.icons8_cancelar_48;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(199, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 61);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar Acción");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActivarExamenes
            // 
            this.btnActivarExamenes.BackgroundImage = global::citasMedicas.Properties.Resources.icons8_archivo_de_verificación_48;
            this.btnActivarExamenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActivarExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarExamenes.Location = new System.Drawing.Point(297, 3);
            this.btnActivarExamenes.Name = "btnActivarExamenes";
            this.btnActivarExamenes.Size = new System.Drawing.Size(92, 61);
            this.btnActivarExamenes.TabIndex = 3;
            this.btnActivarExamenes.Text = "Activar Examenes";
            this.btnActivarExamenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnActivarExamenes, "Mostrar Grupo Exámenes");
            this.btnActivarExamenes.UseVisualStyleBackColor = true;
            this.btnActivarExamenes.Click += new System.EventHandler(this.btnActivarExamenes_Click_1);
            // 
            // groupPaciente
            // 
            this.groupPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.groupPaciente.Controls.Add(this.txtPeso);
            this.groupPaciente.Controls.Add(this.txtTemp);
            this.groupPaciente.Controls.Add(this.txtPA);
            this.groupPaciente.Controls.Add(this.txtEdad);
            this.groupPaciente.Controls.Add(this.label12);
            this.groupPaciente.Controls.Add(this.label11);
            this.groupPaciente.Controls.Add(this.label10);
            this.groupPaciente.Controls.Add(this.label9);
            this.groupPaciente.Controls.Add(this.dtFecha);
            this.groupPaciente.Controls.Add(this.label8);
            this.groupPaciente.Controls.Add(this.txtID);
            this.groupPaciente.Controls.Add(this.txtDPI);
            this.groupPaciente.Controls.Add(this.txtTelefono);
            this.groupPaciente.Controls.Add(this.txtDireccion);
            this.groupPaciente.Controls.Add(this.txtApellidos);
            this.groupPaciente.Controls.Add(this.txtNombres);
            this.groupPaciente.Controls.Add(this.label7);
            this.groupPaciente.Controls.Add(this.label6);
            this.groupPaciente.Controls.Add(this.label5);
            this.groupPaciente.Controls.Add(this.label4);
            this.groupPaciente.Controls.Add(this.label3);
            this.groupPaciente.Controls.Add(this.label2);
            this.groupPaciente.Location = new System.Drawing.Point(24, 17);
            this.groupPaciente.Name = "groupPaciente";
            this.groupPaciente.Size = new System.Drawing.Size(1257, 342);
            this.groupPaciente.TabIndex = 0;
            this.groupPaciente.TabStop = false;
            this.groupPaciente.Text = "DATOS PACIENTE";
            this.groupPaciente.Enter += new System.EventHandler(this.groupPaciente_Enter);
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeso.Location = new System.Drawing.Point(691, 175);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(433, 26);
            this.txtPeso.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtPeso, "Ingresar Peso");
            // 
            // txtTemp
            // 
            this.txtTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTemp.Location = new System.Drawing.Point(691, 130);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(433, 26);
            this.txtTemp.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtTemp, "Ingresar Temperatura");
            // 
            // txtPA
            // 
            this.txtPA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPA.Location = new System.Drawing.Point(691, 83);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(433, 26);
            this.txtPA.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtPA, "Ingresar Presion Arterial");
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEdad.Location = new System.Drawing.Point(691, 34);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(433, 26);
            this.txtEdad.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtEdad, "Ingresar Edad");
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Peso";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(625, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Temp";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "PA";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Edad";
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFecha.Location = new System.Drawing.Point(121, 34);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(338, 26);
            this.dtFecha.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Campo obligatorio (*)";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(474, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 26);
            this.txtID.TabIndex = 11;
            // 
            // txtDPI
            // 
            this.txtDPI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDPI.Location = new System.Drawing.Point(121, 259);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(442, 26);
            this.txtDPI.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtDPI, "Ingresar DPI");
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.Location = new System.Drawing.Point(121, 221);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(442, 26);
            this.txtTelefono.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtTelefono, "Ingresar Teléfono");
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.Location = new System.Drawing.Point(121, 176);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(442, 26);
            this.txtDireccion.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtDireccion, "Ingresar Dirección");
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos.Location = new System.Drawing.Point(121, 129);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(442, 26);
            this.txtApellidos.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtApellidos, "Ingresar Apellidos");
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.Location = new System.Drawing.Point(121, 80);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(442, 26);
            this.txtNombres.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtNombres, "Ingresar Nombres");
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "DPI(*)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Teléfono(*)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos(*)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres(*)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha(*)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // paciente_buscarTableAdapter1
            // 
            this.paciente_buscarTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1319, 976);
            this.Controls.Add(this.tabGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupExamen.ResumeLayout(false);
            this.groupExamen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExamenes)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.groupPaciente.ResumeLayout(false);
            this.groupPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.GroupBox groupPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.FlowLayoutPanel Panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActivarExamenes;
        private System.Windows.Forms.GroupBox groupExamen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkSelccionar;
        private System.Windows.Forms.DateTimePicker dtFechaExamenes;
        private System.Windows.Forms.TextBox txtIDEx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtImpresionClinica;
        private System.Windows.Forms.TextBox txtExamenesCom;
        private System.Windows.Forms.TextBox txtDatosPositivos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgExamenes;
        private System.Windows.Forms.Button btnGuardarEx;
        private System.Windows.Forms.Button btnActualizarEx;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Examenes;
        private REPORTES.dstReporte1TableAdapters.paciente_buscarTableAdapter paciente_buscarTableAdapter1;
        private System.Windows.Forms.CheckBox chkSelecionarEx;
        private System.Windows.Forms.Button btnEliminarEx;
        private System.Windows.Forms.Label lblTotalExamenes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label19;
    }
}