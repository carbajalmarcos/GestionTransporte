namespace GestionTransporte
{
    partial class frmTipoAcoplado
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbEliminar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTipo_Acoplado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo_Acoplado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(414, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "ok";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbEliminar
            // 
            this.tbEliminar.Location = new System.Drawing.Point(335, 178);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.ReadOnly = true;
            this.tbEliminar.Size = new System.Drawing.Size(154, 20);
            this.tbEliminar.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Eliminar";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(414, 130);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "ok";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbModificar
            // 
            this.tbModificar.Location = new System.Drawing.Point(335, 104);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Size = new System.Drawing.Size(154, 20);
            this.tbModificar.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modificar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(414, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "ok";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbAgregar
            // 
            this.tbAgregar.Location = new System.Drawing.Point(335, 28);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Size = new System.Drawing.Size(154, 20);
            this.tbAgregar.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Agregar";
            // 
            // dgvTipo_Acoplado
            // 
            this.dgvTipo_Acoplado.AllowUserToAddRows = false;
            this.dgvTipo_Acoplado.AllowUserToDeleteRows = false;
            this.dgvTipo_Acoplado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipo_Acoplado.Location = new System.Drawing.Point(12, 12);
            this.dgvTipo_Acoplado.MultiSelect = false;
            this.dgvTipo_Acoplado.Name = "dgvTipo_Acoplado";
            this.dgvTipo_Acoplado.ReadOnly = true;
            this.dgvTipo_Acoplado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo_Acoplado.Size = new System.Drawing.Size(243, 260);
            this.dgvTipo_Acoplado.TabIndex = 22;
            this.dgvTipo_Acoplado.DataSourceChanged += new System.EventHandler(this.dgvTipo_Acoplado_DataSourceChanged);
            this.dgvTipo_Acoplado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipo_Acoplado_CellClick);
            // 
            // frmTipoAcoplado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 303);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.tbModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTipo_Acoplado);
            this.Name = "frmTipoAcoplado";
            this.Text = "GESTOR TIPO ACOPLADO";
            this.Load += new System.EventHandler(this.frmTipoAcoplado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo_Acoplado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipo_Acoplado;
    }
}