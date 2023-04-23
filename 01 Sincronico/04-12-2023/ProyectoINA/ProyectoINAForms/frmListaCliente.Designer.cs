
namespace ProyectoINAForms
{
    partial class frmListaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCliente));
            this.lstvClientes = new System.Windows.Forms.ListView();
            this.colCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvClientes
            // 
            this.lstvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colApellido2});
            this.lstvClientes.FullRowSelect = true;
            this.lstvClientes.GridLines = true;
            this.lstvClientes.HideSelection = false;
            this.lstvClientes.Location = new System.Drawing.Point(6, 85);
            this.lstvClientes.MultiSelect = false;
            this.lstvClientes.Name = "lstvClientes";
            this.lstvClientes.Size = new System.Drawing.Size(700, 464);
            this.lstvClientes.TabIndex = 0;
            this.lstvClientes.UseCompatibleStateImageBehavior = false;
            this.lstvClientes.View = System.Windows.Forms.View.Details;
            this.lstvClientes.SelectedIndexChanged += new System.EventHandler(this.lstvClientes_SelectedIndexChanged);
            this.lstvClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvClientes_MouseDoubleClick);
            // 
            // colCedula
            // 
            this.colCedula.Text = "Cedula";
            this.colCedula.Width = 100;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 200;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Primer Apellido";
            this.colApellido.Width = 200;
            // 
            // colApellido2
            // 
            this.colApellido2.Text = "Segundo Apellido";
            this.colApellido2.Width = 200;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(627, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 53);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregrar_Click);
            // 
            // frmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(718, 561);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstvClientes);
            this.Name = "frmListaCliente";
            this.Text = "Mantenimiento:Lista Clientes";
            this.Load += new System.EventHandler(this.frmListaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvClientes;
        private System.Windows.Forms.ColumnHeader colCedula;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colApellido2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAgregar;
    }
}