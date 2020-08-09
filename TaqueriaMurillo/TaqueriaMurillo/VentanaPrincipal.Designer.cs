namespace TaqueriaMurillo
{
    partial class VentanaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.botAgregar = new System.Windows.Forms.Button();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.OrdenNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rbPropina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colPrecio,
            this.colDescripcion});
            this.dgvMenu.Location = new System.Drawing.Point(12, 12);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(598, 115);
            this.dgvMenu.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 69;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Format = "C0";
            dataGridViewCellStyle17.NullValue = "0";
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle17;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 62;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(167, 142);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(109, 145);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 2;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // botAgregar
            // 
            this.botAgregar.Location = new System.Drawing.Point(460, 142);
            this.botAgregar.Name = "botAgregar";
            this.botAgregar.Size = new System.Drawing.Size(150, 23);
            this.botAgregar.TabIndex = 3;
            this.botAgregar.Text = "Agregar a la Orden";
            this.botAgregar.UseVisualStyleBackColor = true;
            this.botAgregar.Click += new System.EventHandler(this.botAgregar_Click);
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToAddRows = false;
            this.dgvOrden.AllowUserToDeleteRows = false;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenNombre,
            this.OrdenCantidad,
            this.OrdenPrecio,
            this.OrdenSubtotal});
            this.dgvOrden.Location = new System.Drawing.Point(12, 198);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.RowHeadersVisible = false;
            this.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrden.Size = new System.Drawing.Size(598, 185);
            this.dgvOrden.TabIndex = 4;
            // 
            // OrdenNombre
            // 
            this.OrdenNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrdenNombre.HeaderText = "Nombre";
            this.OrdenNombre.Name = "OrdenNombre";
            this.OrdenNombre.ReadOnly = true;
            this.OrdenNombre.Width = 69;
            // 
            // OrdenCantidad
            // 
            this.OrdenCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = "0";
            this.OrdenCantidad.DefaultCellStyle = dataGridViewCellStyle18;
            this.OrdenCantidad.HeaderText = "Cantidad";
            this.OrdenCantidad.Name = "OrdenCantidad";
            this.OrdenCantidad.ReadOnly = true;
            this.OrdenCantidad.Width = 74;
            // 
            // OrdenPrecio
            // 
            this.OrdenPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Format = "C0";
            dataGridViewCellStyle19.NullValue = "0";
            this.OrdenPrecio.DefaultCellStyle = dataGridViewCellStyle19;
            this.OrdenPrecio.HeaderText = "Precio";
            this.OrdenPrecio.Name = "OrdenPrecio";
            this.OrdenPrecio.ReadOnly = true;
            this.OrdenPrecio.Width = 62;
            // 
            // OrdenSubtotal
            // 
            this.OrdenSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Format = "C0";
            dataGridViewCellStyle20.NullValue = "0";
            this.OrdenSubtotal.DefaultCellStyle = dataGridViewCellStyle20;
            this.OrdenSubtotal.HeaderText = "Subtotal";
            this.OrdenSubtotal.Name = "OrdenSubtotal";
            this.OrdenSubtotal.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(510, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(470, 400);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total:";
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(389, 394);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCuenta.TabIndex = 7;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Checked = true;
            this.rb0.Location = new System.Drawing.Point(58, 400);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(39, 17);
            this.rb0.TabIndex = 8;
            this.rb0.TabStop = true;
            this.rb0.Text = "0%";
            this.rb0.UseVisualStyleBackColor = true;
            this.rb0.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(103, 400);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(45, 17);
            this.rb10.TabIndex = 9;
            this.rb10.Text = "10%";
            this.rb10.UseVisualStyleBackColor = true;
            this.rb10.CheckedChanged += new System.EventHandler(this.rb10_CheckedChanged);
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(154, 400);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(45, 17);
            this.rb15.TabIndex = 10;
            this.rb15.Text = "15%";
            this.rb15.UseVisualStyleBackColor = true;
            this.rb15.CheckedChanged += new System.EventHandler(this.rb15_CheckedChanged);
            // 
            // rbPropina
            // 
            this.rbPropina.AutoSize = true;
            this.rbPropina.Location = new System.Drawing.Point(12, 400);
            this.rbPropina.Name = "rbPropina";
            this.rbPropina.Size = new System.Drawing.Size(46, 13);
            this.rbPropina.TabIndex = 11;
            this.rbPropina.Text = "Propina:";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(629, 432);
            this.Controls.Add(this.rbPropina);
            this.Controls.Add(this.rb15);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb0);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.botAgregar);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvMenu);
            this.Name = "VentanaPrincipal";
            this.Text = "Taquería Murillo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button botAgregar;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenSubtotal;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.Label rbPropina;
    }
}

