namespace Ejemplo08_Vector
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(166, 97);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(44, 97);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 4;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(166, 149);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 3;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_mostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_agregar;
        internal System.Windows.Forms.TextBox txt_valor;
        internal System.Windows.Forms.Button btn_mostrar;
    }
}

