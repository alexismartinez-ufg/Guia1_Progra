namespace Ejemplo_2
{
    partial class Ejemplo2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numero2Tb = new System.Windows.Forms.TextBox();
            this.numero1Tb = new System.Windows.Forms.TextBox();
            this.calcularBtn = new System.Windows.Forms.Button();
            this.avanzadaRb = new System.Windows.Forms.RadioButton();
            this.basicasRb = new System.Windows.Forms.RadioButton();
            this.listaAvanzadasLb = new System.Windows.Forms.ListBox();
            this.listaBasicasCb = new System.Windows.Forms.ComboBox();
            this.numero2Lb = new System.Windows.Forms.Label();
            this.numero1Lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numero2Tb);
            this.groupBox1.Controls.Add(this.numero1Tb);
            this.groupBox1.Controls.Add(this.calcularBtn);
            this.groupBox1.Controls.Add(this.avanzadaRb);
            this.groupBox1.Controls.Add(this.basicasRb);
            this.groupBox1.Controls.Add(this.listaAvanzadasLb);
            this.groupBox1.Controls.Add(this.listaBasicasCb);
            this.groupBox1.Controls.Add(this.numero2Lb);
            this.groupBox1.Controls.Add(this.numero1Lb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numero2Tb
            // 
            this.numero2Tb.Location = new System.Drawing.Point(122, 178);
            this.numero2Tb.Name = "numero2Tb";
            this.numero2Tb.Size = new System.Drawing.Size(115, 22);
            this.numero2Tb.TabIndex = 11;
            // 
            // numero1Tb
            // 
            this.numero1Tb.Location = new System.Drawing.Point(122, 119);
            this.numero1Tb.Name = "numero1Tb";
            this.numero1Tb.Size = new System.Drawing.Size(115, 22);
            this.numero1Tb.TabIndex = 10;
            // 
            // calcularBtn
            // 
            this.calcularBtn.Location = new System.Drawing.Point(349, 275);
            this.calcularBtn.Name = "calcularBtn";
            this.calcularBtn.Size = new System.Drawing.Size(102, 36);
            this.calcularBtn.TabIndex = 9;
            this.calcularBtn.Text = "Calcular";
            this.calcularBtn.UseVisualStyleBackColor = true;
            this.calcularBtn.Click += new System.EventHandler(this.calcularBtn_Click);
            // 
            // avanzadaRb
            // 
            this.avanzadaRb.AutoSize = true;
            this.avanzadaRb.Location = new System.Drawing.Point(553, 97);
            this.avanzadaRb.Name = "avanzadaRb";
            this.avanzadaRb.Size = new System.Drawing.Size(96, 20);
            this.avanzadaRb.TabIndex = 8;
            this.avanzadaRb.TabStop = true;
            this.avanzadaRb.Text = "Avanzadas";
            this.avanzadaRb.UseVisualStyleBackColor = true;
            this.avanzadaRb.CheckedChanged += new System.EventHandler(this.avanzadaRb_CheckedChanged);
            // 
            // basicasRb
            // 
            this.basicasRb.AutoSize = true;
            this.basicasRb.Location = new System.Drawing.Point(339, 97);
            this.basicasRb.Name = "basicasRb";
            this.basicasRb.Size = new System.Drawing.Size(77, 20);
            this.basicasRb.TabIndex = 7;
            this.basicasRb.TabStop = true;
            this.basicasRb.Text = "Basicas";
            this.basicasRb.UseVisualStyleBackColor = true;
            this.basicasRb.CheckedChanged += new System.EventHandler(this.basicasRb_CheckedChanged);
            // 
            // listaAvanzadasLb
            // 
            this.listaAvanzadasLb.FormattingEnabled = true;
            this.listaAvanzadasLb.ItemHeight = 16;
            this.listaAvanzadasLb.Location = new System.Drawing.Point(544, 141);
            this.listaAvanzadasLb.Name = "listaAvanzadasLb";
            this.listaAvanzadasLb.Size = new System.Drawing.Size(120, 84);
            this.listaAvanzadasLb.TabIndex = 6;
            // 
            // listaBasicasCb
            // 
            this.listaBasicasCb.FormattingEnabled = true;
            this.listaBasicasCb.Location = new System.Drawing.Point(330, 141);
            this.listaBasicasCb.Name = "listaBasicasCb";
            this.listaBasicasCb.Size = new System.Drawing.Size(121, 24);
            this.listaBasicasCb.TabIndex = 5;
            // 
            // numero2Lb
            // 
            this.numero2Lb.AutoSize = true;
            this.numero2Lb.Location = new System.Drawing.Point(51, 178);
            this.numero2Lb.Name = "numero2Lb";
            this.numero2Lb.Size = new System.Drawing.Size(65, 16);
            this.numero2Lb.TabIndex = 2;
            this.numero2Lb.Text = "Número 2";
            // 
            // numero1Lb
            // 
            this.numero1Lb.AutoSize = true;
            this.numero1Lb.Location = new System.Drawing.Point(51, 119);
            this.numero1Lb.Name = "numero1Lb";
            this.numero1Lb.Size = new System.Drawing.Size(65, 16);
            this.numero1Lb.TabIndex = 1;
            this.numero1Lb.Text = "Número 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA";
            // 
            // Ejemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejemplo2";
            this.Text = "Ejemplo2";
            this.Load += new System.EventHandler(this.Ejemplo2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton avanzadaRb;
        private System.Windows.Forms.RadioButton basicasRb;
        private System.Windows.Forms.ListBox listaAvanzadasLb;
        private System.Windows.Forms.ComboBox listaBasicasCb;
        private System.Windows.Forms.Label numero2Lb;
        private System.Windows.Forms.Label numero1Lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero2Tb;
        private System.Windows.Forms.TextBox numero1Tb;
        private System.Windows.Forms.Button calcularBtn;
    }
}

