namespace Ejemplo11_Pila_generica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(42, 92);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 4;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(168, 92);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button Agregar;
    }
}

