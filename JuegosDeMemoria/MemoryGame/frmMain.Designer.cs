namespace MemoryGame
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGameMemory = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lbNickname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.panelSubMenu);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.Enabled = false;
            this.btnRecord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecord.Location = new System.Drawing.Point(0, 377);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(230, 48);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Records";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.btnGame2);
            this.panelSubMenu.Controls.Add(this.btnGameMemory);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 288);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(230, 89);
            this.panelSubMenu.TabIndex = 1;
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(95)))));
            this.btnGame2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame2.FlatAppearance.BorderSize = 0;
            this.btnGame2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.btnGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGame2.Location = new System.Drawing.Point(0, 42);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGame2.Size = new System.Drawing.Size(230, 42);
            this.btnGame2.TabIndex = 1;
            this.btnGame2.Text = "Juego Memoria Numeros";
            this.btnGame2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame2.UseVisualStyleBackColor = false;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGameMemory
            // 
            this.btnGameMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(95)))));
            this.btnGameMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGameMemory.FlatAppearance.BorderSize = 0;
            this.btnGameMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.btnGameMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameMemory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGameMemory.Location = new System.Drawing.Point(0, 0);
            this.btnGameMemory.Name = "btnGameMemory";
            this.btnGameMemory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGameMemory.Size = new System.Drawing.Size(230, 42);
            this.btnGameMemory.TabIndex = 0;
            this.btnGameMemory.Text = "Juego Memoria Iconos";
            this.btnGameMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameMemory.UseVisualStyleBackColor = false;
            this.btnGameMemory.Click += new System.EventHandler(this.btnGameMemory_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Location = new System.Drawing.Point(0, 240);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(230, 48);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Juegos";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 240);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MemoryGame.Properties.Resources.Rauri_create_avatar_of_me_4k_young_men_anime_by_white_hair_roun_ac4fae23_9bbd_41e7_9992_1b4df1be7932__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(105)))));
            this.panelChildForm.Controls.Add(this.lbNickname);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(230, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(704, 561);
            this.panelChildForm.TabIndex = 1;
            // 
            // lbNickname
            // 
            this.lbNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.lbNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNickname.Location = new System.Drawing.Point(363, 73);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(150, 35);
            this.lbNickname.TabIndex = 2;
            this.lbNickname.Text = "_________";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(222, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::MemoryGame.Properties.Resources.brain_icon_png_2544;
            this.pictureBox2.Location = new System.Drawing.Point(226, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoirGame";
            this.panel1.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGameMemory;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRecord;
    }
}

