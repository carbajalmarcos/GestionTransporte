namespace GestionTransporte
{
    partial class frmCargaCamion
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
            this.lblDominio = new System.Windows.Forms.Label();
            this.tbDominio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLong_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAncho_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNro_chasis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAlt_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar_unidad = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNro_motor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(34, 35);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 31;
            this.lblDominio.Text = "Dominio";
            // 
            // tbDominio
            // 
            this.tbDominio.Location = new System.Drawing.Point(34, 55);
            this.tbDominio.Name = "tbDominio";
            this.tbDominio.Size = new System.Drawing.Size(164, 20);
            this.tbDominio.TabIndex = 30;
            this.tbDominio.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Longitud total";
            // 
            // tbLong_total
            // 
            this.tbLong_total.Location = new System.Drawing.Point(232, 196);
            this.tbLong_total.Name = "tbLong_total";
            this.tbLong_total.Size = new System.Drawing.Size(164, 20);
            this.tbLong_total.TabIndex = 69;
            this.tbLong_total.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbLong_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Ancho total";
            // 
            // tbAncho_total
            // 
            this.tbAncho_total.Location = new System.Drawing.Point(232, 149);
            this.tbAncho_total.Name = "tbAncho_total";
            this.tbAncho_total.Size = new System.Drawing.Size(164, 20);
            this.tbAncho_total.TabIndex = 67;
            this.tbAncho_total.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAncho_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Nro_chasis";
            // 
            // tbNro_chasis
            // 
            this.tbNro_chasis.Location = new System.Drawing.Point(232, 55);
            this.tbNro_chasis.Name = "tbNro_chasis";
            this.tbNro_chasis.Size = new System.Drawing.Size(164, 20);
            this.tbNro_chasis.TabIndex = 63;
            this.tbNro_chasis.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Alt total";
            // 
            // tbAlt_total
            // 
            this.tbAlt_total.Location = new System.Drawing.Point(34, 292);
            this.tbAlt_total.Name = "tbAlt_total";
            this.tbAlt_total.Size = new System.Drawing.Size(164, 20);
            this.tbAlt_total.TabIndex = 61;
            this.tbAlt_total.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAlt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tara";
            // 
            // tbTara
            // 
            this.tbTara.Location = new System.Drawing.Point(34, 339);
            this.tbTara.Name = "tbTara";
            this.tbTara.Size = new System.Drawing.Size(164, 20);
            this.tbTara.TabIndex = 57;
            this.tbTara.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Año";
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(34, 197);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(164, 20);
            this.tbAño.TabIndex = 55;
            this.tbAño.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(34, 130);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 54;
            this.lblModelo.Text = "Modelo";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(34, 150);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(164, 20);
            this.tbModelo.TabIndex = 53;
            this.tbModelo.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Marca";
            // 
            // btnGuardar_unidad
            // 
            this.btnGuardar_unidad.Location = new System.Drawing.Point(296, 372);
            this.btnGuardar_unidad.Name = "btnGuardar_unidad";
            this.btnGuardar_unidad.Size = new System.Drawing.Size(100, 23);
            this.btnGuardar_unidad.TabIndex = 48;
            this.btnGuardar_unidad.Text = "Guardar";
            this.btnGuardar_unidad.UseVisualStyleBackColor = true;
            this.btnGuardar_unidad.Click += new System.EventHandler(this.btnGuardar_unidad_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(34, 102);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(164, 21);
            this.cbMarca.TabIndex = 77;
            this.cbMarca.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(34, 244);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(164, 21);
            this.cbTipo.TabIndex = 78;
            this.cbTipo.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMarcasToolStripMenuItem,
            this.gestionarTipoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // agregarMarcasToolStripMenuItem
            // 
            this.agregarMarcasToolStripMenuItem.Name = "agregarMarcasToolStripMenuItem";
            this.agregarMarcasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarMarcasToolStripMenuItem.Text = "gestionar marcas...";
            this.agregarMarcasToolStripMenuItem.Click += new System.EventHandler(this.agregarMarcasToolStripMenuItem_Click);
            // 
            // gestionarTipoToolStripMenuItem
            // 
            this.gestionarTipoToolStripMenuItem.Name = "gestionarTipoToolStripMenuItem";
            this.gestionarTipoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestionarTipoToolStripMenuItem.Text = "gestionar tipos...";
            this.gestionarTipoToolStripMenuItem.Click += new System.EventHandler(this.gestionarTipoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nro_motor";
            // 
            // tbNro_motor
            // 
            this.tbNro_motor.Location = new System.Drawing.Point(232, 102);
            this.tbNro_motor.Name = "tbNro_motor";
            this.tbNro_motor.Size = new System.Drawing.Size(164, 20);
            this.tbNro_motor.TabIndex = 80;
            this.tbNro_motor.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(232, 243);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(164, 116);
            this.tbObservaciones.TabIndex = 82;
            // 
            // frmCargaCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNro_motor);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbLong_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAncho_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNro_chasis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAlt_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar_unidad);
            this.Controls.Add(this.lblDominio);
            this.Controls.Add(this.tbDominio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCargaCamion";
            this.Text = "CAMION";
            this.Load += new System.EventHandler(this.frmCargaCamion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.TextBox tbDominio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLong_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAncho_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNro_chasis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAlt_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar_unidad;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarTipoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNro_motor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObservaciones;
    }
}