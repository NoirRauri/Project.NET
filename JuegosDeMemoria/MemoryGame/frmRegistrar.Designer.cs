namespace MemoryGame
{
    partial class frmRegistrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskCedula);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtApellido2);
            this.groupBox1.Controls.Add(this.txtApellido1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(30, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Jugador";
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(170, 40);
            this.mskCedula.Mask = "#-####-####";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(156, 30);
            this.mskCedula.TabIndex = 1;
            this.mskCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCedula.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 286);
            this.txtPassword.MaxLength = 14;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 30);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(170, 236);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(156, 30);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(170, 186);
            this.txtApellido2.MaxLength = 50;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(156, 30);
            this.txtApellido2.TabIndex = 4;
            this.txtApellido2.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(170, 136);
            this.txtApellido1.MaxLength = 50;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(156, 30);
            this.txtApellido1.TabIndex = 3;
            this.txtApellido1.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 86);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 30);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cedula";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(95)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(313, 455);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 36);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(95)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(200, 455);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(436, 512);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}