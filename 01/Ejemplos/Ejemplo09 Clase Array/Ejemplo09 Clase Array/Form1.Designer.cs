namespace Ejemplo09_Clase_Array
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
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(192, 50);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar\r\n";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(41, 52);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 1;
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(192, 102);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(75, 23);
            this.btn_ordenar.TabIndex = 2;
            this.btn_ordenar.Text = "Ordenar";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(192, 157);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 3;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 305);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button btn_mostrar;
    }
}

