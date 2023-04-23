namespace ProyectoINAForms
{
    partial class frmListaClientes
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
            this.lstvClientes = new System.Windows.Forms.ListView();
            this.colCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstvClientes
            // 
            this.lstvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCedula,
            this.colName,
            this.colApellido1,
            this.colApellido2});
            this.lstvClientes.GridLines = true;
            this.lstvClientes.HideSelection = false;
            this.lstvClientes.Location = new System.Drawing.Point(12, 52);
            this.lstvClientes.Name = "lstvClientes";
            this.lstvClientes.Size = new System.Drawing.Size(713, 381);
            this.lstvClientes.TabIndex = 0;
            this.lstvClientes.UseCompatibleStateImageBehavior = false;
            this.lstvClientes.View = System.Windows.Forms.View.Details;
            // 
            // colCedula
            // 
            this.colCedula.Text = "Cedula";
            this.colCedula.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 200;
            // 
            // colApellido1
            // 
            this.colApellido1.Text = "Primer apellido";
            this.colApellido1.Width = 200;
            // 
            // colApellido2
            // 
            this.colApellido2.Text = "Segundo apellido";
            this.colApellido2.Width = 200;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 445);
            this.Controls.Add(this.lstvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimieto lista clientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvClientes;
        private System.Windows.Forms.ColumnHeader colCedula;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colApellido1;
        private System.Windows.Forms.ColumnHeader colApellido2;
    }
}