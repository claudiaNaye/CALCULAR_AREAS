namespace TRIANGULO
{
    partial class TRIANGULO
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
            this.calcular = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(301, 221);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(156, 48);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(166, 63);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(213, 26);
            this.Base.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "BASE";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resultado.Location = new System.Drawing.Point(240, 178);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(27, 28);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "0";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(166, 115);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(213, 26);
            this.altura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ALTURA";
            // 
            // TRIANGULO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.calcular);
            this.Name = "TRIANGULO";
            this.Text = "AREA DEL TRIANGULO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Label label2;
    }
}

