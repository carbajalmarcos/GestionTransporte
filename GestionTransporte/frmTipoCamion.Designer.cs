namespace GestionTransporte
{
    partial class frmTipoCamion
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
            this.dgvTipoCamion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(414, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
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
            this.tbEliminar.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Eliminar";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(414, 130);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "ok";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbModificar
            // 
            this.tbModificar.Location = new System.Drawing.Point(335, 104);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Size = new System.Drawing.Size(154, 20);
            this.tbModificar.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modificar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(414, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "ok";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbAgregar
            // 
            this.tbAgregar.Location = new System.Drawing.Point(335, 28);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Size = new System.Drawing.Size(154, 20);
            this.tbAgregar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Agregar";
            // 
            // dgvTipoCamion
            // 
            this.dgvTipoCamion.AllowUserToAddRows = false;
            this.dgvTipoCamion.AllowUserToDeleteRows = false;
            this.dgvTipoCamion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoCamion.Location = new System.Drawing.Point(12, 12);
            this.dgvTipoCamion.MultiSelect = false;
            this.dgvTipoCamion.Name = "dgvTipoCamion";
            this.dgvTipoCamion.ReadOnly = true;
            this.dgvTipoCamion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoCamion.Size = new System.Drawing.Size(243, 260);
            this.dgvTipoCamion.TabIndex = 11;
            this.dgvTipoCamion.DataSourceChanged += new System.EventHandler(this.dgvTipoCamion_DataSourceChanged);
            this.dgvTipoCamion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoCamion_CellClick);
            // 
            // frmTipoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 304);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.tbModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTipoCamion);
            this.Name = "frmTipoCamion";
            this.Text = "GESTOR TIPO CAMION";
            this.Load += new System.EventHandler(this.frmTipoCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCamion)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTipoCamion;
    }
}