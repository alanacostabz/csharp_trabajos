namespace RentaVideojuegos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.rentaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRentar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colGenero,
            this.colPrecio,
            this.colExistencia,
            this.colPlataforma});
            this.dgvCatalogo.Location = new System.Drawing.Point(24, 27);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(487, 150);
            this.dgvCatalogo.TabIndex = 0;
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogo_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 69;
            // 
            // colGenero
            // 
            this.colGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 67;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 62;
            // 
            // colExistencia
            // 
            this.colExistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colExistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.colExistencia.HeaderText = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.ReadOnly = true;
            this.colExistencia.Width = 80;
            // 
            // colPlataforma
            // 
            this.colPlataforma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlataforma.HeaderText = "Plataforma";
            this.colPlataforma.Name = "colPlataforma";
            this.colPlataforma.ReadOnly = true;
            // 
            // dgvRenta
            // 
            this.dgvRenta.AllowUserToAddRows = false;
            this.dgvRenta.AllowUserToDeleteRows = false;
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentaNombre,
            this.rentaPrecio,
            this.rentaFecha,
            this.rentaFechaEntrega,
            this.rentaPlataforma});
            this.dgvRenta.Location = new System.Drawing.Point(24, 229);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.ReadOnly = true;
            this.dgvRenta.RowHeadersVisible = false;
            this.dgvRenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRenta.Size = new System.Drawing.Size(487, 236);
            this.dgvRenta.TabIndex = 1;
            // 
            // rentaNombre
            // 
            this.rentaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentaNombre.HeaderText = "Nombre";
            this.rentaNombre.Name = "rentaNombre";
            this.rentaNombre.ReadOnly = true;
            this.rentaNombre.Width = 69;
            // 
            // rentaPrecio
            // 
            this.rentaPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.rentaPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            this.rentaPrecio.HeaderText = "Precio";
            this.rentaPrecio.Name = "rentaPrecio";
            this.rentaPrecio.ReadOnly = true;
            this.rentaPrecio.Width = 62;
            // 
            // rentaFecha
            // 
            this.rentaFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.rentaFecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.rentaFecha.HeaderText = "Fecha";
            this.rentaFecha.Name = "rentaFecha";
            this.rentaFecha.ReadOnly = true;
            this.rentaFecha.Width = 62;
            // 
            // rentaFechaEntrega
            // 
            this.rentaFechaEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.rentaFechaEntrega.DefaultCellStyle = dataGridViewCellStyle5;
            this.rentaFechaEntrega.HeaderText = "Fecha Devolución";
            this.rentaFechaEntrega.Name = "rentaFechaEntrega";
            this.rentaFechaEntrega.ReadOnly = true;
            this.rentaFechaEntrega.Width = 109;
            // 
            // rentaPlataforma
            // 
            this.rentaPlataforma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentaPlataforma.HeaderText = "Plataforma";
            this.rentaPlataforma.Name = "rentaPlataforma";
            this.rentaPlataforma.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(545, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRentar
            // 
            this.btnRentar.Location = new System.Drawing.Point(141, 200);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(75, 23);
            this.btnRentar.TabIndex = 3;
            this.btnRentar.Text = "Rentar";
            this.btnRentar.UseVisualStyleBackColor = true;
            this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(276, 200);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 529);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnRentar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.dgvCatalogo);
            this.Name = "VentanaPrincipal";
            this.Text = "Renta  de Videojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlataforma;
        private System.Windows.Forms.Button btnRentar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaPlataforma;
    }
}

