namespace GestionTransporte
{
    partial class frmCargaAcoplado
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
            this.btnGuardar_unidad = new System.Windows.Forms.Button();
            this.lblDominio = new System.Windows.Forms.Label();
            this.tbDominio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAlt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNro_chasis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAncho_exterior = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLong_plataforma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCapacidad_carga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCant_de_ejes = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAncho_interior = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarTiposDeAcopladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar_unidad
            // 
            this.btnGuardar_unidad.Location = new System.Drawing.Point(302, 412);
            this.btnGuardar_unidad.Name = "btnGuardar_unidad";
            this.btnGuardar_unidad.Size = new System.Drawing.Size(100, 23);
            this.btnGuardar_unidad.TabIndex = 0;
            this.btnGuardar_unidad.Text = "Guardar";
            this.btnGuardar_unidad.UseVisualStyleBackColor = true;
            this.btnGuardar_unidad.Click += new System.EventHandler(this.btnGuardar_unidad_Click);
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(12, 34);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 4;
            this.lblDominio.Text = "Dominio";
            // 
            // tbDominio
            // 
            this.tbDominio.Location = new System.Drawing.Point(12, 54);
            this.tbDominio.Name = "tbDominio";
            this.tbDominio.Size = new System.Drawing.Size(161, 20);
            this.tbDominio.TabIndex = 3;
            this.tbDominio.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 128);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(12, 148);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(161, 20);
            this.tbModelo.TabIndex = 7;
            this.tbModelo.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año";
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(12, 195);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(161, 20);
            this.tbAño.TabIndex = 9;
            this.tbAño.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tara";
            // 
            // tbTara
            // 
            this.tbTara.Location = new System.Drawing.Point(12, 289);
            this.tbTara.Name = "tbTara";
            this.tbTara.Size = new System.Drawing.Size(161, 20);
            this.tbTara.TabIndex = 11;
            this.tbTara.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alt total";
            // 
            // tbAlt_total
            // 
            this.tbAlt_total.Location = new System.Drawing.Point(12, 336);
            this.tbAlt_total.Name = "tbAlt_total";
            this.tbAlt_total.Size = new System.Drawing.Size(161, 20);
            this.tbAlt_total.TabIndex = 15;
            this.tbAlt_total.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAlt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nro_chasis";
            // 
            // tbNro_chasis
            // 
            this.tbNro_chasis.Location = new System.Drawing.Point(12, 383);
            this.tbNro_chasis.Name = "tbNro_chasis";
            this.tbNro_chasis.Size = new System.Drawing.Size(161, 20);
            this.tbNro_chasis.TabIndex = 17;
            this.tbNro_chasis.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbNro_chasis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ancho exterior";
            // 
            // tbAncho_exterior
            // 
            this.tbAncho_exterior.Location = new System.Drawing.Point(221, 101);
            this.tbAncho_exterior.Name = "tbAncho_exterior";
            this.tbAncho_exterior.Size = new System.Drawing.Size(184, 20);
            this.tbAncho_exterior.TabIndex = 21;
            this.tbAncho_exterior.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAncho_exterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Longitud plataforma";
            // 
            // tbLong_plataforma
            // 
            this.tbLong_plataforma.Location = new System.Drawing.Point(221, 148);
            this.tbLong_plataforma.Name = "tbLong_plataforma";
            this.tbLong_plataforma.Size = new System.Drawing.Size(184, 20);
            this.tbLong_plataforma.TabIndex = 23;
            this.tbLong_plataforma.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbLong_plataforma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(221, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Capacidad de carga";
            // 
            // tbCapacidad_carga
            // 
            this.tbCapacidad_carga.Location = new System.Drawing.Point(221, 195);
            this.tbCapacidad_carga.Name = "tbCapacidad_carga";
            this.tbCapacidad_carga.Size = new System.Drawing.Size(184, 20);
            this.tbCapacidad_carga.TabIndex = 25;
            this.tbCapacidad_carga.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbCapacidad_carga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cant de ejes";
            // 
            // tbCant_de_ejes
            // 
            this.tbCant_de_ejes.Location = new System.Drawing.Point(221, 242);
            this.tbCant_de_ejes.Name = "tbCant_de_ejes";
            this.tbCant_de_ejes.Size = new System.Drawing.Size(184, 20);
            this.tbCant_de_ejes.TabIndex = 27;
            this.tbCant_de_ejes.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbCant_de_ejes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(221, 289);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(181, 114);
            this.tbObservaciones.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ancho interior";
            // 
            // tbAncho_interior
            // 
            this.tbAncho_interior.Location = new System.Drawing.Point(221, 54);
            this.tbAncho_interior.Name = "tbAncho_interior";
            this.tbAncho_interior.Size = new System.Drawing.Size(184, 20);
            this.tbAncho_interior.TabIndex = 33;
            this.tbAncho_interior.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            this.tbAncho_interior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(12, 100);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(161, 21);
            this.cbMarca.TabIndex = 35;
            this.cbMarca.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(12, 241);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(161, 21);
            this.cbTipo.TabIndex = 36;
            this.cbTipo.TextChanged += new System.EventHandler(this.tbDominio_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarMarcaToolStripMenuItem,
            this.gestionarTiposDeAcopladoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gestionarMarcaToolStripMenuItem
            // 
            this.gestionarMarcaToolStripMenuItem.Name = "gestionarMarcaToolStripMenuItem";
            this.gestionarMarcaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestionarMarcaToolStripMenuItem.Text = "gestionar marcas...";
            this.gestionarMarcaToolStripMenuItem.Click += new System.EventHandler(this.gestionarMarcaToolStripMenuItem_Click);
            // 
            // gestionarTiposDeAcopladoToolStripMenuItem
            // 
            this.gestionarTiposDeAcopladoToolStripMenuItem.Name = "gestionarTiposDeAcopladoToolStripMenuItem";
            this.gestionarTiposDeAcopladoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestionarTiposDeAcopladoToolStripMenuItem.Text = "gestionar tipos...";
            this.gestionarTiposDeAcopladoToolStripMenuItem.Click += new System.EventHandler(this.gestionarTiposDeAcopladoToolStripMenuItem_Click);
            // 
            // frmCargaAcoplado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 461);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAncho_interior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCant_de_ejes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCapacidad_carga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbLong_plataforma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbAncho_exterior);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDominio);
            this.Controls.Add(this.tbDominio);
            this.Controls.Add(this.btnGuardar_unidad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCargaAcoplado";
            this.Text = "Acoplado";
            this.Load += new System.EventHandler(this.frmCargaAcoplado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar_unidad;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.TextBox tbDominio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAlt_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNro_chasis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAncho_exterior;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLong_plataforma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCapacidad_carga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCant_de_ejes;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAncho_interior;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarTiposDeAcopladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMarcaToolStripMenuItem;
    }
}