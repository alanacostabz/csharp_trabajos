namespace VentanaPrincipal
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
            this.clbDocumentos = new System.Windows.Forms.CheckedListBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.cbFemenino = new System.Windows.Forms.CheckBox();
            this.cbMasculino = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbDocumentos
            // 
            this.clbDocumentos.FormattingEnabled = true;
            this.clbDocumentos.Items.AddRange(new object[] {
            "Acta de nacimiento",
            "Ceritificado",
            "CURP",
            "INE"});
            this.clbDocumentos.Location = new System.Drawing.Point(12, 18);
            this.clbDocumentos.Name = "clbDocumentos";
            this.clbDocumentos.Size = new System.Drawing.Size(120, 64);
            this.clbDocumentos.TabIndex = 0;
            this.clbDocumentos.Visible = false;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(144, 18);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 1;
            this.calendario.Visible = false;
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Items.AddRange(new object[] {
            "Agua Prieta",
            "Cajeme",
            "Hermosillo",
            "Navojoa",
            "Nogales",
            "Caborca",
            "Santa Ana"});
            this.cbCampus.Location = new System.Drawing.Point(12, 114);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(120, 21);
            this.cbCampus.TabIndex = 2;
            this.cbCampus.Text = "Hermosillo";
            this.cbCampus.Visible = false;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(191, 223);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(154, 27);
            this.btnHabilitar.TabIndex = 5;
            this.btnHabilitar.Text = "Habilitar/Deshabilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // cbFemenino
            // 
            this.cbFemenino.AutoSize = true;
            this.cbFemenino.Checked = true;
            this.cbFemenino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFemenino.Enabled = false;
            this.cbFemenino.Location = new System.Drawing.Point(6, 14);
            this.cbFemenino.Name = "cbFemenino";
            this.cbFemenino.Size = new System.Drawing.Size(72, 17);
            this.cbFemenino.TabIndex = 6;
            this.cbFemenino.Text = "Femenino";
            this.cbFemenino.UseVisualStyleBackColor = true;
            this.cbFemenino.CheckedChanged += new System.EventHandler(this.cbFemenino_CheckedChanged);
            // 
            // cbMasculino
            // 
            this.cbMasculino.AutoSize = true;
            this.cbMasculino.Enabled = false;
            this.cbMasculino.Location = new System.Drawing.Point(6, 37);
            this.cbMasculino.Name = "cbMasculino";
            this.cbMasculino.Size = new System.Drawing.Size(74, 17);
            this.cbMasculino.TabIndex = 7;
            this.cbMasculino.Text = "Masculino";
            this.cbMasculino.UseVisualStyleBackColor = true;
            this.cbMasculino.CheckedChanged += new System.EventHandler(this.cbMasculino_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMasculino);
            this.groupBox1.Controls.Add(this.cbFemenino);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(225, 194);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 265);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.cbCampus);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.clbDocumentos);
            this.Name = "Form1";
            this.Text = "Ventana Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbDocumentos;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.CheckBox cbFemenino;
        private System.Windows.Forms.CheckBox cbMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
    }
}

