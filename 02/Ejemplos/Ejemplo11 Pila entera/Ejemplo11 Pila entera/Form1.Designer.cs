namespace Ejemplo11_Pila_entera
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
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(166, 66);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(75, 23);
            this.btn_push.TabIndex = 0;
            this.btn_push.Text = "Meter valor";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(166, 118);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(75, 23);
            this.btn_pop.TabIndex = 1;
            this.btn_pop.Text = "Sacar valor";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(28, 68);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 298);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.TextBox txt_valor;
    }
}

