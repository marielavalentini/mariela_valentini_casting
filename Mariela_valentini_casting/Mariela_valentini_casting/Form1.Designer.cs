namespace Mariela_valentini_casting
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
            this.btnConversionImplicita = new System.Windows.Forms.Button();
            this.btnConversionExplicita = new System.Windows.Forms.Button();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConversionImplicita
            // 
            this.btnConversionImplicita.Location = new System.Drawing.Point(94, 144);
            this.btnConversionImplicita.Name = "btnConversionImplicita";
            this.btnConversionImplicita.Size = new System.Drawing.Size(302, 23);
            this.btnConversionImplicita.TabIndex = 0;
            this.btnConversionImplicita.Text = "Ejemplo de conversion implicita";
            this.btnConversionImplicita.UseVisualStyleBackColor = true;
            this.btnConversionImplicita.Click += new System.EventHandler(this.btnConversionImplicita_Click);
            // 
            // btnConversionExplicita
            // 
            this.btnConversionExplicita.Location = new System.Drawing.Point(117, 265);
            this.btnConversionExplicita.Name = "btnConversionExplicita";
            this.btnConversionExplicita.Size = new System.Drawing.Size(293, 23);
            this.btnConversionExplicita.TabIndex = 1;
            this.btnConversionExplicita.Text = "Ejemplo de conversion explita";
            this.btnConversionExplicita.UseVisualStyleBackColor = true;
            this.btnConversionExplicita.Click += new System.EventHandler(this.btnConversionExplicita_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(114, 228);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(168, 16);
            this.lblDecimal.TabIndex = 2;
            this.lblDecimal.Text = "Ingrese un numero decimal";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(310, 225);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 22);
            this.txtDecimal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.btnConversionExplicita);
            this.Controls.Add(this.btnConversionImplicita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConversionImplicita;
        private System.Windows.Forms.Button btnConversionExplicita;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox txtDecimal;
    }
}

