namespace Guia1_Progra
{
    partial class Form2
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
            this.salirForm2Btn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salirForm2Btn
            // 
            this.salirForm2Btn.Location = new System.Drawing.Point(189, 129);
            this.salirForm2Btn.Name = "salirForm2Btn";
            this.salirForm2Btn.Size = new System.Drawing.Size(75, 23);
            this.salirForm2Btn.TabIndex = 0;
            this.salirForm2Btn.Text = "Salir";
            this.salirForm2Btn.UseVisualStyleBackColor = true;
            this.salirForm2Btn.Click += new System.EventHandler(this.salirForm2Btn_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.Location = new System.Drawing.Point(39, 38);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(384, 30);
            this.messageLbl.TabIndex = 1;
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 166);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.salirForm2Btn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salirForm2Btn;
        private System.Windows.Forms.Label messageLbl;
    }
}