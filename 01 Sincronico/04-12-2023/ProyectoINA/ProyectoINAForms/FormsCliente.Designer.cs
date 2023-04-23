namespace ProyectoINAForms
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.nUDDescuento = new System.Windows.Forms.NumericUpDown();
            this.pBFoto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.nUDDescuento);
            this.gbxCliente.Controls.Add(this.pBFoto);
            this.gbxCliente.Controls.Add(this.label9);
            this.gbxCliente.Controls.Add(this.dTPFechaNacimiento);
            this.gbxCliente.Controls.Add(this.cbTipoCliente);
            this.gbxCliente.Controls.Add(this.cbGenero);
            this.gbxCliente.Controls.Add(this.txtApellido2);
            this.gbxCliente.Controls.Add(this.txtApellido1);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.label8);
            this.gbxCliente.Controls.Add(this.label7);
            this.gbxCliente.Controls.Add(this.label6);
            this.gbxCliente.Controls.Add(this.label5);
            this.gbxCliente.Controls.Add(this.label4);
            this.gbxCliente.Controls.Add(this.label3);
            this.gbxCliente.Controls.Add(this.label2);
            this.gbxCliente.Controls.Add(this.label1);
            this.gbxCliente.Controls.Add(this.mskCedula);
            this.gbxCliente.Location = new System.Drawing.Point(12, 23);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(672, 423);
            this.gbxCliente.TabIndex = 0;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos  de Cliente";
            // 
            // nUDDescuento
            // 
            this.nUDDescuento.Location = new System.Drawing.Point(122, 278);
            this.nUDDescuento.Name = "nUDDescuento";
            this.nUDDescuento.Size = new System.Drawing.Size(120, 20);
            this.nUDDescuento.TabIndex = 17;
            // 
            // pBFoto
            // 
            this.pBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBFoto.Location = new System.Drawing.Point(122, 304);
            this.pBFoto.Name = "pBFoto";
            this.pBFoto.Size = new System.Drawing.Size(121, 113);
            this.pBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBFoto.TabIndex = 16;
            this.pBFoto.TabStop = false;
            this.pBFoto.Click += new System.EventHandler(this.pBFoto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Descuento";
            // 
            // dTPFechaNacimiento
            // 
            this.dTPFechaNacimiento.Location = new System.Drawing.Point(122, 207);
            this.dTPFechaNacimiento.Name = "dTPFechaNacimiento";
            this.dTPFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dTPFechaNacimiento.TabIndex = 15;
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Location = new System.Drawing.Point(122, 243);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCliente.TabIndex = 14;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Indefinido"});
            this.cbGenero.Location = new System.Drawing.Point(122, 180);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 13;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(122, 144);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 12;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(122, 113);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Foto";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(122, 44);
            this.mskCedula.Mask = "#.####.####";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(100, 20);
            this.mskCedula.TabIndex = 0;
            this.mskCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(285, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 18);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Crear Cliente";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(586, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 69);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(472, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 69);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(698, 536);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBFoto;
        private System.Windows.Forms.DateTimePicker dTPFechaNacimiento;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nUDDescuento;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}