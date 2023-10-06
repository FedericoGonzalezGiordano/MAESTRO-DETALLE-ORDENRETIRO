namespace ModeloParcialApp.Presentacion
{
    partial class FrmOrdenRegistro
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
            this.TxtResponsable = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblResponsable = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CboMateriales = new System.Windows.Forms.ComboBox();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvOrdenDetalle = new System.Windows.Forms.DataGridView();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtResponsable
            // 
            this.TxtResponsable.Location = new System.Drawing.Point(105, 53);
            this.TxtResponsable.Name = "TxtResponsable";
            this.TxtResponsable.Size = new System.Drawing.Size(288, 20);
            this.TxtResponsable.TabIndex = 0;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(44, 25);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // LblResponsable
            // 
            this.LblResponsable.AutoSize = true;
            this.LblResponsable.Location = new System.Drawing.Point(12, 53);
            this.LblResponsable.Name = "LblResponsable";
            this.LblResponsable.Size = new System.Drawing.Size(69, 13);
            this.LblResponsable.TabIndex = 2;
            this.LblResponsable.Text = "Responsable";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(105, 25);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(83, 20);
            this.DtpFecha.TabIndex = 3;
            // 
            // CboMateriales
            // 
            this.CboMateriales.FormattingEnabled = true;
            this.CboMateriales.Location = new System.Drawing.Point(15, 79);
            this.CboMateriales.Name = "CboMateriales";
            this.CboMateriales.Size = new System.Drawing.Size(248, 21);
            this.CboMateriales.TabIndex = 4;
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(273, 79);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(120, 20);
            this.NudCantidad.TabIndex = 5;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(408, 76);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(123, 23);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvOrdenDetalle
            // 
            this.DgvOrdenDetalle.AllowUserToAddRows = false;
            this.DgvOrdenDetalle.AllowUserToDeleteRows = false;
            this.DgvOrdenDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColStock,
            this.ColCantidad,
            this.ColAcciones});
            this.DgvOrdenDetalle.Location = new System.Drawing.Point(15, 105);
            this.DgvOrdenDetalle.Name = "DgvOrdenDetalle";
            this.DgvOrdenDetalle.ReadOnly = true;
            this.DgvOrdenDetalle.Size = new System.Drawing.Size(519, 150);
            this.DgvOrdenDetalle.TabIndex = 7;
            this.DgvOrdenDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrdenDetalle_CellContentClick);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(117, 271);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(123, 28);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(314, 271);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 28);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Material";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 180;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // FrmOrdenRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 306);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.DgvOrdenDetalle);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.CboMateriales);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.LblResponsable);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtResponsable);
            this.Name = "FrmOrdenRegistro";
            this.Text = "FrmOrdenRegistro";
            this.Load += new System.EventHandler(this.FrmOrdenRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResponsable;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblResponsable;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CboMateriales;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvOrdenDetalle;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}