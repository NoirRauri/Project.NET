namespace ProyectoINAForms
{
    partial class frmListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaUsuarios));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstvUsuarios = new System.Windows.Forms.ListView();
            this.colCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(12, 12);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(140, 20);
            this.txtb1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(173, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(596, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 53);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstvUsuarios
            // 
            this.lstvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCedula,
            this.colApellido1,
            this.colApellido2,
            this.colNombreUsuario,
            this.colRol});
            this.lstvUsuarios.FullRowSelect = true;
            this.lstvUsuarios.GridLines = true;
            this.lstvUsuarios.HideSelection = false;
            this.lstvUsuarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstvUsuarios.Location = new System.Drawing.Point(0, 71);
            this.lstvUsuarios.MultiSelect = false;
            this.lstvUsuarios.Name = "lstvUsuarios";
            this.lstvUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstvUsuarios.Size = new System.Drawing.Size(734, 212);
            this.lstvUsuarios.TabIndex = 5;
            this.lstvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lstvUsuarios.View = System.Windows.Forms.View.Details;
            this.lstvUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvUsuarios_MouseDoubleClick);
            // 
            // colCedula
            // 
            this.colCedula.Text = "Cedula";
            this.colCedula.Width = 27;
            // 
            // colApellido1
            // 
            this.colApellido1.Text = "PrimerApellido";
            this.colApellido1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colApellido1.Width = 200;
            // 
            // colApellido2
            // 
            this.colApellido2.Text = "Segundo Apellido";
            this.colApellido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colApellido2.Width = 200;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.Text = "Nombre de Usuario";
            this.colNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colNombreUsuario.Width = 200;
            // 
            // colRol
            // 
            this.colRol.Text = "Rol";
            this.colRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRol.Width = 100;
            // 
            // frmListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvUsuarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtb1);
            this.Name = "frmListaUsuarios";
            this.Text = "frmListaUsuarios";
            this.Load += new System.EventHandler(this.frmListaUsuarios_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lstvUsuarios;
        private System.Windows.Forms.ColumnHeader colCedula;
        private System.Windows.Forms.ColumnHeader colApellido1;
        private System.Windows.Forms.ColumnHeader colApellido2;
        private System.Windows.Forms.ColumnHeader colNombreUsuario;
        private System.Windows.Forms.ColumnHeader colRol;
    }
}