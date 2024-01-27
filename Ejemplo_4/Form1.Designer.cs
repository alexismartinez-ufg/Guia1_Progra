namespace Ejemplo_4
{
    partial class Form1
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
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.usuarioTxb = new System.Windows.Forms.TextBox();
            this.contraseñaTxb = new System.Windows.Forms.TextBox();
            this.ingresoBtn = new System.Windows.Forms.Button();
            this.registroBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(72, 99);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(54, 16);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "Usuario";
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(50, 190);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(76, 16);
            this.contraseñaLabel.TabIndex = 1;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // usuarioTxb
            // 
            this.usuarioTxb.Location = new System.Drawing.Point(168, 96);
            this.usuarioTxb.Name = "usuarioTxb";
            this.usuarioTxb.Size = new System.Drawing.Size(215, 22);
            this.usuarioTxb.TabIndex = 2;
            // 
            // contraseñaTxb
            // 
            this.contraseñaTxb.Location = new System.Drawing.Point(168, 187);
            this.contraseñaTxb.Name = "contraseñaTxb";
            this.contraseñaTxb.Size = new System.Drawing.Size(215, 22);
            this.contraseñaTxb.TabIndex = 3;
            this.contraseñaTxb.UseSystemPasswordChar = true;
            // 
            // ingresoBtn
            // 
            this.ingresoBtn.Location = new System.Drawing.Point(88, 290);
            this.ingresoBtn.Name = "ingresoBtn";
            this.ingresoBtn.Size = new System.Drawing.Size(75, 23);
            this.ingresoBtn.TabIndex = 4;
            this.ingresoBtn.Text = "Ingreso";
            this.ingresoBtn.UseVisualStyleBackColor = true;
            this.ingresoBtn.Click += new System.EventHandler(this.ingresoBtn_Click);
            // 
            // registroBtn
            // 
            this.registroBtn.Location = new System.Drawing.Point(298, 290);
            this.registroBtn.Name = "registroBtn";
            this.registroBtn.Size = new System.Drawing.Size(75, 23);
            this.registroBtn.TabIndex = 5;
            this.registroBtn.Text = "Registro";
            this.registroBtn.UseVisualStyleBackColor = true;
            this.registroBtn.Click += new System.EventHandler(this.registroBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(189, 372);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(75, 23);
            this.salirBtn.TabIndex = 6;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(469, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.registroBtn);
            this.Controls.Add(this.ingresoBtn);
            this.Controls.Add(this.contraseñaTxb);
            this.Controls.Add(this.usuarioTxb);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Name = "Form1";
            this.Text = "Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.TextBox usuarioTxb;
        private System.Windows.Forms.TextBox contraseñaTxb;
        private System.Windows.Forms.Button ingresoBtn;
        private System.Windows.Forms.Button registroBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

