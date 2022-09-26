namespace CALCULOS_EN_GENERAL
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
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lado = new System.Windows.Forms.TextBox();
            this.Base = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.radio = new System.Windows.Forms.TextBox();
            this.resultadoCuadrado = new System.Windows.Forms.Label();
            this.resultadotriangulo = new System.Windows.Forms.Label();
            this.resultadocirculo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(543, 499);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(156, 46);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "CALCULAR";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUADRADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "LADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(165, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "TRIANGULO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(32, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "BASE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(32, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "ALTURA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(165, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "CIRCULO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(43, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "RADIO";
            // 
            // lado
            // 
            this.lado.Location = new System.Drawing.Point(147, 73);
            this.lado.Name = "lado";
            this.lado.Size = new System.Drawing.Size(196, 26);
            this.lado.TabIndex = 8;
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(147, 189);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(196, 26);
            this.Base.TabIndex = 9;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(147, 261);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(196, 26);
            this.altura.TabIndex = 10;
            // 
            // radio
            // 
            this.radio.Location = new System.Drawing.Point(147, 394);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(196, 26);
            this.radio.TabIndex = 11;
            // 
            // resultadoCuadrado
            // 
            this.resultadoCuadrado.AutoSize = true;
            this.resultadoCuadrado.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoCuadrado.ForeColor = System.Drawing.Color.Purple;
            this.resultadoCuadrado.Location = new System.Drawing.Point(537, 68);
            this.resultadoCuadrado.Name = "resultadoCuadrado";
            this.resultadoCuadrado.Size = new System.Drawing.Size(31, 31);
            this.resultadoCuadrado.TabIndex = 12;
            this.resultadoCuadrado.Text = "0";
            // 
            // resultadotriangulo
            // 
            this.resultadotriangulo.AutoSize = true;
            this.resultadotriangulo.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadotriangulo.ForeColor = System.Drawing.Color.Purple;
            this.resultadotriangulo.Location = new System.Drawing.Point(537, 225);
            this.resultadotriangulo.Name = "resultadotriangulo";
            this.resultadotriangulo.Size = new System.Drawing.Size(31, 31);
            this.resultadotriangulo.TabIndex = 13;
            this.resultadotriangulo.Text = "0";
            // 
            // resultadocirculo
            // 
            this.resultadocirculo.AutoSize = true;
            this.resultadocirculo.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadocirculo.ForeColor = System.Drawing.Color.Purple;
            this.resultadocirculo.Location = new System.Drawing.Point(537, 390);
            this.resultadocirculo.Name = "resultadocirculo";
            this.resultadocirculo.Size = new System.Drawing.Size(31, 31);
            this.resultadocirculo.TabIndex = 14;
            this.resultadocirculo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(465, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "RESULTADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 579);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultadocirculo);
            this.Controls.Add(this.resultadotriangulo);
            this.Controls.Add(this.resultadoCuadrado);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.lado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.Text = "CALCULAR AREAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lado;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox radio;
        private System.Windows.Forms.Label resultadoCuadrado;
        private System.Windows.Forms.Label resultadotriangulo;
        private System.Windows.Forms.Label resultadocirculo;
        private System.Windows.Forms.Label label8;
    }
}

