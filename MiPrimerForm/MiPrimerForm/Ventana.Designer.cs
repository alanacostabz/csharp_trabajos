namespace MiPrimerForm
{
    partial class Ventana
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
            this.llamaVentana = new System.Windows.Forms.Button();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // llamaVentana
            // 
            this.llamaVentana.Location = new System.Drawing.Point(191, 34);
            this.llamaVentana.Name = "llamaVentana";
            this.llamaVentana.Size = new System.Drawing.Size(207, 23);
            this.llamaVentana.TabIndex = 0;
            this.llamaVentana.Text = "Llama Ventana secundaria";
            this.llamaVentana.UseVisualStyleBackColor = true;
            this.llamaVentana.Click += new System.EventHandler(this.llamaVentana_Click);
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            "Red dead redemption 2",
            "Fifa 19",
            "God of war",
            "Resident evil 2",
            "Spider-man"});
            this.cbItem.Location = new System.Drawing.Point(202, 63);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(179, 21);
            this.cbItem.TabIndex = 1;
            this.cbItem.Text = "Videojuegos";
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 137);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.llamaVentana);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button llamaVentana;
        private System.Windows.Forms.ComboBox cbItem;
    }
}