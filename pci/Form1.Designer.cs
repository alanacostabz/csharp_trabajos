namespace pci
{
    partial class Form1
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
            this.rb = new System.Windows.Forms.GroupBox();
            this.mesesLaboralesAnio = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.semanasLaboralesAnio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.diasLaboralesAnio = new System.Windows.Forms.TextBox();
            this.aggh = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nivelServicio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cargoMantenerUnidadPorcentaje = new System.Windows.Forms.TextBox();
            this.cargoMantenerUnidadDinero = new System.Windows.Forms.TextBox();
            this.costoColocarOrden = new System.Windows.Forms.TextBox();
            this.desvEstandar = new System.Windows.Forms.TextBox();
            this.tiempoEntrega = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opcionUnidades = new System.Windows.Forms.GroupBox();
            this.rbAnio = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbSemana = new System.Windows.Forms.RadioButton();
            this.rbDias = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.demanda = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.GroupBox();
            this.rhPunto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.inventarioSS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cantidadOptima = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.desvEstTiempo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.costoTotalInventario = new System.Windows.Forms.TextBox();
            this.rb.SuspendLayout();
            this.opcionUnidades.SuspendLayout();
            this.label22.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb
            // 
            this.rb.Controls.Add(this.label21);
            this.rb.Controls.Add(this.desvEstTiempo);
            this.rb.Controls.Add(this.label20);
            this.rb.Controls.Add(this.mesesLaboralesAnio);
            this.rb.Controls.Add(this.label19);
            this.rb.Controls.Add(this.semanasLaboralesAnio);
            this.rb.Controls.Add(this.label18);
            this.rb.Controls.Add(this.diasLaboralesAnio);
            this.rb.Controls.Add(this.aggh);
            this.rb.Controls.Add(this.label12);
            this.rb.Controls.Add(this.nivelServicio);
            this.rb.Controls.Add(this.label11);
            this.rb.Controls.Add(this.label10);
            this.rb.Controls.Add(this.label9);
            this.rb.Controls.Add(this.cargoMantenerUnidadPorcentaje);
            this.rb.Controls.Add(this.cargoMantenerUnidadDinero);
            this.rb.Controls.Add(this.costoColocarOrden);
            this.rb.Controls.Add(this.desvEstandar);
            this.rb.Controls.Add(this.tiempoEntrega);
            this.rb.Controls.Add(this.label8);
            this.rb.Controls.Add(this.label7);
            this.rb.Controls.Add(this.label6);
            this.rb.Controls.Add(this.label5);
            this.rb.Controls.Add(this.label4);
            this.rb.Controls.Add(this.label3);
            this.rb.Controls.Add(this.opcionUnidades);
            this.rb.Controls.Add(this.label2);
            this.rb.Controls.Add(this.label1);
            this.rb.Controls.Add(this.demanda);
            this.rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb.Location = new System.Drawing.Point(7, 2);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(570, 277);
            this.rb.TabIndex = 0;
            this.rb.TabStop = false;
            this.rb.Text = "Sistema de inventarios con revisión continua";
            this.rb.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // mesesLaboralesAnio
            // 
            this.mesesLaboralesAnio.Location = new System.Drawing.Point(429, 126);
            this.mesesLaboralesAnio.Name = "mesesLaboralesAnio";
            this.mesesLaboralesAnio.Size = new System.Drawing.Size(123, 26);
            this.mesesLaboralesAnio.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(229, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Meses laborales al año";
            // 
            // semanasLaboralesAnio
            // 
            this.semanasLaboralesAnio.Location = new System.Drawing.Point(428, 96);
            this.semanasLaboralesAnio.Name = "semanasLaboralesAnio";
            this.semanasLaboralesAnio.Size = new System.Drawing.Size(123, 26);
            this.semanasLaboralesAnio.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(242, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Sem laborales al año";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(610, 397);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 32);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // diasLaboralesAnio
            // 
            this.diasLaboralesAnio.Location = new System.Drawing.Point(429, 64);
            this.diasLaboralesAnio.Name = "diasLaboralesAnio";
            this.diasLaboralesAnio.Size = new System.Drawing.Size(123, 26);
            this.diasLaboralesAnio.TabIndex = 23;
            this.diasLaboralesAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiasLaboralesAnio_KeyPress);
            // 
            // aggh
            // 
            this.aggh.AutoSize = true;
            this.aggh.ForeColor = System.Drawing.Color.Black;
            this.aggh.Location = new System.Drawing.Point(245, 70);
            this.aggh.Name = "aggh";
            this.aggh.Size = new System.Drawing.Size(177, 20);
            this.aggh.TabIndex = 22;
            this.aggh.Text = "Dias laborales al año";
            this.aggh.Click += new System.EventHandler(this.Aggh_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(610, 354);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 32);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(528, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 20;
            // 
            // nivelServicio
            // 
            this.nivelServicio.Location = new System.Drawing.Point(390, 34);
            this.nivelServicio.Name = "nivelServicio";
            this.nivelServicio.Size = new System.Drawing.Size(162, 26);
            this.nivelServicio.TabIndex = 19;
            this.nivelServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NivelServicio_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(187, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(187, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(187, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "$";
            // 
            // cargoMantenerUnidadPorcentaje
            // 
            this.cargoMantenerUnidadPorcentaje.Location = new System.Drawing.Point(59, 231);
            this.cargoMantenerUnidadPorcentaje.Name = "cargoMantenerUnidadPorcentaje";
            this.cargoMantenerUnidadPorcentaje.Size = new System.Drawing.Size(122, 26);
            this.cargoMantenerUnidadPorcentaje.TabIndex = 15;
            this.cargoMantenerUnidadPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CargoMantenerUnidadPorcentaje_KeyPress);
            // 
            // cargoMantenerUnidadDinero
            // 
            this.cargoMantenerUnidadDinero.Location = new System.Drawing.Point(59, 196);
            this.cargoMantenerUnidadDinero.Name = "cargoMantenerUnidadDinero";
            this.cargoMantenerUnidadDinero.Size = new System.Drawing.Size(122, 26);
            this.cargoMantenerUnidadDinero.TabIndex = 14;
            this.cargoMantenerUnidadDinero.TextChanged += new System.EventHandler(this.CargoMantenerUnidadDinero_TextChanged);
            this.cargoMantenerUnidadDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CargoMantenerUnidadDinero_KeyPress);
            // 
            // costoColocarOrden
            // 
            this.costoColocarOrden.Location = new System.Drawing.Point(59, 164);
            this.costoColocarOrden.Name = "costoColocarOrden";
            this.costoColocarOrden.Size = new System.Drawing.Size(122, 26);
            this.costoColocarOrden.TabIndex = 13;
            this.costoColocarOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostoColocarOrden_KeyPress);
            // 
            // desvEstandar
            // 
            this.desvEstandar.Location = new System.Drawing.Point(59, 64);
            this.desvEstandar.Name = "desvEstandar";
            this.desvEstandar.Size = new System.Drawing.Size(122, 26);
            this.desvEstandar.TabIndex = 12;
            this.desvEstandar.TextChanged += new System.EventHandler(this.DesvEstandar_TextChanged);
            this.desvEstandar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DesvEstandar_KeyPress);
            // 
            // tiempoEntrega
            // 
            this.tiempoEntrega.Location = new System.Drawing.Point(59, 96);
            this.tiempoEntrega.Name = "tiempoEntrega";
            this.tiempoEntrega.Size = new System.Drawing.Size(122, 26);
            this.tiempoEntrega.TabIndex = 11;
            this.tiempoEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TiempoEntrega_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "I";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(354, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Z";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-1, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "D.E.D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "T";
            // 
            // opcionUnidades
            // 
            this.opcionUnidades.Controls.Add(this.rbAnio);
            this.opcionUnidades.Controls.Add(this.rbMes);
            this.opcionUnidades.Controls.Add(this.rbSemana);
            this.opcionUnidades.Controls.Add(this.rbDias);
            this.opcionUnidades.Location = new System.Drawing.Point(235, 209);
            this.opcionUnidades.Name = "opcionUnidades";
            this.opcionUnidades.Size = new System.Drawing.Size(318, 62);
            this.opcionUnidades.TabIndex = 4;
            this.opcionUnidades.TabStop = false;
            this.opcionUnidades.Text = "Seleccione unidad de la demanda";
            this.opcionUnidades.Enter += new System.EventHandler(this.OpcionUnidades_Enter);
            // 
            // rbAnio
            // 
            this.rbAnio.AutoSize = true;
            this.rbAnio.ForeColor = System.Drawing.Color.Black;
            this.rbAnio.Location = new System.Drawing.Point(235, 25);
            this.rbAnio.Name = "rbAnio";
            this.rbAnio.Size = new System.Drawing.Size(59, 24);
            this.rbAnio.TabIndex = 4;
            this.rbAnio.Text = "Año";
            this.rbAnio.UseVisualStyleBackColor = true;
            this.rbAnio.CheckedChanged += new System.EventHandler(this.RbAnio_CheckedChanged);
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.ForeColor = System.Drawing.Color.Black;
            this.rbMes.Location = new System.Drawing.Point(173, 25);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(60, 24);
            this.rbMes.TabIndex = 3;
            this.rbMes.Text = "Mes";
            this.rbMes.UseVisualStyleBackColor = true;
            this.rbMes.CheckedChanged += new System.EventHandler(this.RbMes_CheckedChanged);
            // 
            // rbSemana
            // 
            this.rbSemana.AutoSize = true;
            this.rbSemana.ForeColor = System.Drawing.Color.Black;
            this.rbSemana.Location = new System.Drawing.Point(74, 25);
            this.rbSemana.Name = "rbSemana";
            this.rbSemana.Size = new System.Drawing.Size(93, 24);
            this.rbSemana.TabIndex = 2;
            this.rbSemana.Text = "Semana";
            this.rbSemana.UseVisualStyleBackColor = true;
            this.rbSemana.CheckedChanged += new System.EventHandler(this.RbSemana_CheckedChanged);
            // 
            // rbDias
            // 
            this.rbDias.AutoSize = true;
            this.rbDias.Checked = true;
            this.rbDias.ForeColor = System.Drawing.Color.Black;
            this.rbDias.Location = new System.Drawing.Point(11, 25);
            this.rbDias.Name = "rbDias";
            this.rbDias.Size = new System.Drawing.Size(63, 24);
            this.rbDias.TabIndex = 0;
            this.rbDias.TabStop = true;
            this.rbDias.Text = "Dias";
            this.rbDias.UseVisualStyleBackColor = true;
            this.rbDias.CheckedChanged += new System.EventHandler(this.RbDias_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(187, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uds.";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "D";
            // 
            // demanda
            // 
            this.demanda.Location = new System.Drawing.Point(59, 29);
            this.demanda.Name = "demanda";
            this.demanda.Size = new System.Drawing.Size(122, 26);
            this.demanda.TabIndex = 0;
            this.demanda.TextChanged += new System.EventHandler(this.Demanda_TextChanged);
            this.demanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Demanda_KeyPress);
            // 
            // label22
            // 
            this.label22.Controls.Add(this.costoTotalInventario);
            this.label22.Controls.Add(this.label14);
            this.label22.Controls.Add(this.rhPunto);
            this.label22.Controls.Add(this.label17);
            this.label22.Controls.Add(this.inventarioSS);
            this.label22.Controls.Add(this.label16);
            this.label22.Controls.Add(this.cantidadOptima);
            this.label22.Controls.Add(this.label13);
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 285);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(567, 144);
            this.label22.TabIndex = 1;
            this.label22.TabStop = false;
            this.label22.Text = "Respuestas";
            this.label22.Enter += new System.EventHandler(this.Label22_Enter);
            // 
            // rhPunto
            // 
            this.rhPunto.Enabled = false;
            this.rhPunto.Location = new System.Drawing.Point(198, 85);
            this.rhPunto.Name = "rhPunto";
            this.rhPunto.Size = new System.Drawing.Size(350, 26);
            this.rhPunto.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(59, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Punto de reorden (rh)";
            // 
            // inventarioSS
            // 
            this.inventarioSS.Enabled = false;
            this.inventarioSS.Location = new System.Drawing.Point(198, 53);
            this.inventarioSS.Name = "inventarioSS";
            this.inventarioSS.Size = new System.Drawing.Size(350, 26);
            this.inventarioSS.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(18, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Inventario de seguridad (ss)";
            // 
            // cantidadOptima
            // 
            this.cantidadOptima.Enabled = false;
            this.cantidadOptima.Location = new System.Drawing.Point(198, 21);
            this.cantidadOptima.Name = "cantidadOptima";
            this.cantidadOptima.Size = new System.Drawing.Size(350, 26);
            this.cantidadOptima.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(4, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Cantidad óptima a ordenar (Q)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.op3);
            this.groupBox1.Controls.Add(this.op2);
            this.groupBox1.Controls.Add(this.op1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(586, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demanda - Entrega";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter_1);
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Checked = true;
            this.op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.ForeColor = System.Drawing.Color.Black;
            this.op1.Location = new System.Drawing.Point(7, 22);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(147, 20);
            this.op1.TabIndex = 0;
            this.op1.TabStop = true;
            this.op1.Text = "Variable - Constante";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.CheckedChanged += new System.EventHandler(this.Op1_CheckedChanged);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.ForeColor = System.Drawing.Color.Black;
            this.op2.Location = new System.Drawing.Point(6, 48);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(147, 20);
            this.op2.TabIndex = 1;
            this.op2.Text = "Constante - Variable";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.CheckedChanged += new System.EventHandler(this.Op2_CheckedChanged);
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.ForeColor = System.Drawing.Color.Black;
            this.op3.Location = new System.Drawing.Point(6, 74);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(138, 20);
            this.op3.TabIndex = 2;
            this.op3.Text = "Variable - Variable";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.CheckedChanged += new System.EventHandler(this.Op3_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(187, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 20);
            this.label20.TabIndex = 29;
            this.label20.Text = "Uds.";
            // 
            // desvEstTiempo
            // 
            this.desvEstTiempo.Enabled = false;
            this.desvEstTiempo.Location = new System.Drawing.Point(59, 129);
            this.desvEstTiempo.Name = "desvEstTiempo";
            this.desvEstTiempo.Size = new System.Drawing.Size(122, 26);
            this.desvEstTiempo.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(2, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 20);
            this.label21.TabIndex = 31;
            this.label21.Text = "D.E.T";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Costo total del sistema inventario";
            // 
            // costoTotalInventario
            // 
            this.costoTotalInventario.Enabled = false;
            this.costoTotalInventario.Location = new System.Drawing.Point(211, 114);
            this.costoTotalInventario.Name = "costoTotalInventario";
            this.costoTotalInventario.Size = new System.Drawing.Size(337, 26);
            this.costoTotalInventario.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(757, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.rb);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "PCI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rb.ResumeLayout(false);
            this.rb.PerformLayout();
            this.opcionUnidades.ResumeLayout(false);
            this.opcionUnidades.PerformLayout();
            this.label22.ResumeLayout(false);
            this.label22.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nivelServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cargoMantenerUnidadDinero;
        private System.Windows.Forms.TextBox costoColocarOrden;
        private System.Windows.Forms.TextBox desvEstandar;
        private System.Windows.Forms.TextBox tiempoEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox opcionUnidades;
        private System.Windows.Forms.RadioButton rbDias;
        public System.Windows.Forms.TextBox demanda;
        private System.Windows.Forms.Label aggh;
        private System.Windows.Forms.TextBox diasLaboralesAnio;
        public System.Windows.Forms.TextBox cargoMantenerUnidadPorcentaje;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.GroupBox label22;
        public System.Windows.Forms.TextBox cantidadOptima;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox rhPunto;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox inventarioSS;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rbSemana;
        private System.Windows.Forms.TextBox mesesLaboralesAnio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox semanasLaboralesAnio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbAnio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox desvEstTiempo;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox costoTotalInventario;
        private System.Windows.Forms.Label label14;
    }
}

