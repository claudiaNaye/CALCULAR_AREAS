namespace CIRCULO
{
    partial class CIRCULOS
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
            this.radio = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio
            // 
            this.radio.Location = new System.Drawing.Point(180, 48);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(145, 26);
            this.radio.TabIndex = 0;
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(295, 161);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(147, 43);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resultado.Location = new System.Drawing.Point(219, 114);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(27, 28);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "0";
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSize = true;
            this.NOMBRE.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOMBRE.Location = new System.Drawing.Point(55, 53);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(75, 24);
            this.NOMBRE.TabIndex = 3;
            this.NOMBRE.Text = "RADIO";
            // 
            // circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 242);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.radio);
            this.Name = "circulo";
            this.Text = "AREA DEL CIRCULO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radio;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label NOMBRE;
    }
}

