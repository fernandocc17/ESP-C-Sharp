namespace Ejemplo13_List
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_posicion = new System.Windows.Forms.Button();
            this.btn_valor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(26, 36);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(159, 33);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(159, 88);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_posicion
            // 
            this.btn_posicion.Location = new System.Drawing.Point(159, 143);
            this.btn_posicion.Name = "btn_posicion";
            this.btn_posicion.Size = new System.Drawing.Size(75, 23);
            this.btn_posicion.TabIndex = 3;
            this.btn_posicion.Text = "Posicion";
            this.btn_posicion.UseVisualStyleBackColor = true;
            this.btn_posicion.Click += new System.EventHandler(this.btn_posicion_Click);
            // 
            // btn_valor
            // 
            this.btn_valor.Location = new System.Drawing.Point(159, 191);
            this.btn_valor.Name = "btn_valor";
            this.btn_valor.Size = new System.Drawing.Size(75, 23);
            this.btn_valor.TabIndex = 4;
            this.btn_valor.Text = "Valor";
            this.btn_valor.UseVisualStyleBackColor = true;
            this.btn_valor.Click += new System.EventHandler(this.btn_valor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 288);
            this.Controls.Add(this.btn_valor);
            this.Controls.Add(this.btn_posicion);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_posicion;
        private System.Windows.Forms.Button btn_valor;
    }
}

