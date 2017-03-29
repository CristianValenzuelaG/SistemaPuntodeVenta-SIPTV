namespace SiPTV
{
    partial class Form1
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chStatus = new System.Windows.Forms.CheckBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 18);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(494, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // chStatus
            // 
            this.chStatus.AutoSize = true;
            this.chStatus.Checked = true;
            this.chStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chStatus.Location = new System.Drawing.Point(429, 286);
            this.chStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chStatus.Name = "chStatus";
            this.chStatus.Size = new System.Drawing.Size(75, 24);
            this.chStatus.TabIndex = 3;
            this.chStatus.Text = "Status";
            this.chStatus.UseVisualStyleBackColor = true;
            this.chStatus.CheckedChanged += new System.EventHandler(this.chStatus_CheckedChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 281);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(110, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:XXX";
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "PrecioUnitario";
            this.precioUnitario.HeaderText = "Precio";
            this.precioUnitario.Name = "precioUnitario";
            // 
            // bStatus
            // 
            this.bStatus.DataPropertyName = "bStatus";
            this.bStatus.HeaderText = "Status";
            this.bStatus.Name = "bStatus";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // pkCodigo
            // 
            this.pkCodigo.DataPropertyName = "pkCodigo";
            this.pkCodigo.HeaderText = "Codigo";
            this.pkCodigo.Name = "pkCodigo";
            // 
            // grdDatos
            // 
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkCodigo,
            this.nombre,
            this.bStatus,
            this.precioUnitario});
            this.grdDatos.Location = new System.Drawing.Point(18, 54);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.Size = new System.Drawing.Size(494, 222);
            this.grdDatos.TabIndex = 1;
            this.grdDatos.DataSourceChanged += new System.EventHandler(this.grdDatos_DataSourceChanged);
            this.grdDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 328);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.chStatus);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chStatus;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn bStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkCodigo;
        private System.Windows.Forms.DataGridView grdDatos;
    }
}

