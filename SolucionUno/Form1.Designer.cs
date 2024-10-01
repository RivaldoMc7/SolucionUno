namespace SolucionUno
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
            this.intro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.envio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intro
            // 
            this.intro.Location = new System.Drawing.Point(257, 135);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(100, 26);
            this.intro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // envio
            // 
            this.envio.Location = new System.Drawing.Point(438, 77);
            this.envio.Name = "envio";
            this.envio.Size = new System.Drawing.Size(90, 40);
            this.envio.TabIndex = 2;
            this.envio.Text = "enviar";
            this.envio.UseVisualStyleBackColor = true;
            this.envio.Click += new System.EventHandler(this.envio_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(282, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.envio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button envio;
        private System.Windows.Forms.Label label2;
    }
}

