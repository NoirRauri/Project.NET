namespace ProyectoINAForms
{
    partial class frmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearUsuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pBFoto = new System.Windows.Forms.PictureBox();
            this.dTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCoontraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCedulaUsers = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(285, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 18);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Crear Usuario";
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.label8);
            this.gbxCliente.Controls.Add(this.pBFoto);
            this.gbxCliente.Controls.Add(this.dTPFechaNacimiento);
            this.gbxCliente.Controls.Add(this.cbGenero);
            this.gbxCliente.Controls.Add(this.txtApellido2);
            this.gbxCliente.Controls.Add(this.txtApellido1);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.label6);
            this.gbxCliente.Controls.Add(this.label5);
            this.gbxCliente.Controls.Add(this.label4);
            this.gbxCliente.Controls.Add(this.label3);
            this.gbxCliente.Controls.Add(this.label2);
            this.gbxCliente.Controls.Add(this.dTPFechaIngreso);
            this.gbxCliente.Controls.Add(this.cbRol);
            this.gbxCliente.Controls.Add(this.txtContra);
            this.gbxCliente.Controls.Add(this.txtNombreUsuario);
            this.gbxCliente.Controls.Add(this.lblFechaIngreso);
            this.gbxCliente.Controls.Add(this.lblRol);
            this.gbxCliente.Controls.Add(this.lblCoontraseña);
            this.gbxCliente.Controls.Add(this.lblNombre);
            this.gbxCliente.Controls.Add(this.label1);
            this.gbxCliente.Controls.Add(this.mskCedulaUsers);
            this.gbxCliente.Location = new System.Drawing.Point(12, 24);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(694, 321);
            this.gbxCliente.TabIndex = 19;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos  de Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Foto";
            // 
            // pBFoto
            // 
            this.pBFoto.Location = new System.Drawing.Point(483, 171);
            this.pBFoto.Name = "pBFoto";
            this.pBFoto.Size = new System.Drawing.Size(136, 94);
            this.pBFoto.TabIndex = 31;
            this.pBFoto.TabStop = false;
            // 
            // dTPFechaNacimiento
            // 
            this.dTPFechaNacimiento.Location = new System.Drawing.Point(483, 134);
            this.dTPFechaNacimiento.Name = "dTPFechaNacimiento";
            this.dTPFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dTPFechaNacimiento.TabIndex = 30;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "No especificado"});
            this.cbGenero.Location = new System.Drawing.Point(483, 107);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 28;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(483, 71);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 27;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(483, 40);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(483, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // dTPFechaIngreso
            // 
            this.dTPFechaIngreso.Location = new System.Drawing.Point(148, 107);
            this.dTPFechaIngreso.Name = "dTPFechaIngreso";
            this.dTPFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dTPFechaIngreso.TabIndex = 15;
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "No especificado"});
            this.cbRol.Location = new System.Drawing.Point(148, 180);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(121, 21);
            this.cbRol.TabIndex = 13;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(148, 139);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(148, 75);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 10;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(13, 107);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 6;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(13, 183);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Rol";
            // 
            // lblCoontraseña
            // 
            this.lblCoontraseña.AutoSize = true;
            this.lblCoontraseña.Location = new System.Drawing.Point(13, 142);
            this.lblCoontraseña.Name = "lblCoontraseña";
            this.lblCoontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblCoontraseña.TabIndex = 4;
            this.lblCoontraseña.Text = "Contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = " Nombre de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // mskCedulaUsers
            // 
            this.mskCedulaUsers.Location = new System.Drawing.Point(148, 44);
            this.mskCedulaUsers.Mask = "#.####.####";
            this.mskCedulaUsers.Name = "mskCedulaUsers";
            this.mskCedulaUsers.Size = new System.Drawing.Size(100, 20);
            this.mskCedulaUsers.TabIndex = 0;
            this.mskCedulaUsers.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(435, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 69);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(538, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 69);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearUsuario";
            this.Text = "frmCrearUsuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.DateTimePicker dTPFechaIngreso;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCedulaUsers;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblCoontraseña;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBFoto;
        private System.Windows.Forms.DateTimePicker dTPFechaNacimiento;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}