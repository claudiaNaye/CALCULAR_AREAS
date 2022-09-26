namespace Cliente_Calcula
{
    partial class CUADRADO
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
            this.lado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadoCuadrado = new System.Windows.Forms.Label();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lado
            // 
            this.lado.Location = new System.Drawing.Point(165, 40);
            this.lado.Name = "lado";
            this.lado.Size = new System.Drawing.Size(202, 26);
            this.lado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LADO";
            // 
            // resultadoCuadrado
            // 
            this.resultadoCuadrado.AutoSize = true;
            this.resultadoCuadrado.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoCuadrado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultadoCuadrado.Location = new System.Drawing.Point(221, 104);
            this.resultadoCuadrado.Name = "resultadoCuadrado";
            this.resultadoCuadrado.Size = new System.Drawing.Size(27, 28);
            this.resultadoCuadrado.TabIndex = 2;
            this.resultadoCuadrado.Text = "0";
            // 
            // CALCULAR
            // 
            this.CALCULAR.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(188, 161);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(138, 37);
            this.CALCULAR.TabIndex = 3;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 6;
            // 
            // CUADRADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.resultadoCuadrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lado);
            this.Name = "CUADRADO";
            this.Text = "AREA DE CUADRADO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultadoCuadrado;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Label label2;
    }
}

