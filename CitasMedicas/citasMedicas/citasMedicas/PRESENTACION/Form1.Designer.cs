namespace citasMedicas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMENOMBREPACIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROSToolStripMenuItem,
            this.iNFORMESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGISTROSToolStripMenuItem
            // 
            this.rEGISTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pACIENTESToolStripMenuItem,
            this.toolStripSeparator1,
            this.sALIRToolStripMenuItem});
            this.rEGISTROSToolStripMenuItem.Image = global::citasMedicas.Properties.Resources.records_folders_icon_220713;
            this.rEGISTROSToolStripMenuItem.Name = "rEGISTROSToolStripMenuItem";
            this.rEGISTROSToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.rEGISTROSToolStripMenuItem.Text = "REGISTROS";
            // 
            // pACIENTESToolStripMenuItem
            // 
            this.pACIENTESToolStripMenuItem.Name = "pACIENTESToolStripMenuItem";
            this.pACIENTESToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pACIENTESToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.pACIENTESToolStripMenuItem.Text = "PACIENTES";
            this.pACIENTESToolStripMenuItem.ToolTipText = "Registrar o actualizar pacientes y exámenes ";
            this.pACIENTESToolStripMenuItem.Click += new System.EventHandler(this.pACIENTESToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.ToolTipText = "Salir";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFORMENOMBREPACIENTEToolStripMenuItem,
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem,
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem});
            this.iNFORMESToolStripMenuItem.Image = global::citasMedicas.Properties.Resources.marketing_14138892;
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // iNFORMENOMBREPACIENTEToolStripMenuItem
            // 
            this.iNFORMENOMBREPACIENTEToolStripMenuItem.Name = "iNFORMENOMBREPACIENTEToolStripMenuItem";
            this.iNFORMENOMBREPACIENTEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.iNFORMENOMBREPACIENTEToolStripMenuItem.Size = new System.Drawing.Size(463, 30);
            this.iNFORMENOMBREPACIENTEToolStripMenuItem.Text = "PACIENTE";
            this.iNFORMENOMBREPACIENTEToolStripMenuItem.ToolTipText = "Informe del paciente";
            this.iNFORMENOMBREPACIENTEToolStripMenuItem.Click += new System.EventHandler(this.iNFORMENOMBREPACIENTEToolStripMenuItem_Click);
            // 
            // iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem
            // 
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem.Name = "iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem";
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem.Size = new System.Drawing.Size(463, 30);
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem.Text = "EXÁMENES ASOCIADOS PACIENTE ";
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem.ToolTipText = "Informe del paciente con exámenes asociados";
            this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem.Click += new System.EventHandler(this.iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem_Click);
            // 
            // búsquedaPorIntervalosDeFechasToolStripMenuItem
            // 
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem.Name = "búsquedaPorIntervalosDeFechasToolStripMenuItem";
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem.Size = new System.Drawing.Size(463, 30);
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem.Text = "POR INTERVALOS DE FECHAS";
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem.ToolTipText = "Informe del paciente con exámenes asociados por busqueda de fechas";
            this.búsquedaPorIntervalosDeFechasToolStripMenuItem.Click += new System.EventHandler(this.búsquedaPorIntervalosDeFechasToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1120, 710);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas Medicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMENOMBREPACIENTEToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem iNFORMEDELPACIENTEEXÁMENESASOCIADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaPorIntervalosDeFechasToolStripMenuItem;
    }
}

