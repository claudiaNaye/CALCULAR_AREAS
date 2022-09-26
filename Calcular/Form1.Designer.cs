namespace Calcular
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
            this.ladotextBox = new System.Windows.Forms.TextBox();
            this.cuadrado = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ladotextBox
            // 
            this.ladotextBox.Location = new System.Drawing.Point(233, 134);
            this.ladotextBox.Name = "ladotextBox";
            this.ladotextBox.Size = new System.Drawing.Size(225, 26);
            this.ladotextBox.TabIndex = 0;
            // 
            // cuadrado
            // 
            this.cuadrado.Location = new System.Drawing.Point(560, 217);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(129, 37);
            this.cuadrado.TabIndex = 1;
            this.cuadrado.Text = "CALCULAR";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.Click += new System.EventHandler(this.CUADRADO_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultado.Location = new System.Drawing.Point(214, 335);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(28, 30);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "0";
            this.resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.ladotextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ladotextBox;
        private System.Windows.Forms.Button cuadrado;
        private System.Windows.Forms.Label resultado;
    }
}

