namespace Ejemplo14_List
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
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_valor = new System.Windows.Forms.Button();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.btn_posicion = new System.Windows.Forms.Button();
            this.lbl_mostrar = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lbl_agregar = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(261, 169);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(0, 13);
            this.lbl_valor.TabIndex = 17;
            // 
            // btn_valor
            // 
            this.btn_valor.Location = new System.Drawing.Point(143, 163);
            this.btn_valor.Name = "btn_valor";
            this.btn_valor.Size = new System.Drawing.Size(75, 23);
            this.btn_valor.TabIndex = 16;
            this.btn_valor.Text = "Valor";
            this.btn_valor.UseVisualStyleBackColor = true;
            this.btn_valor.Click += new System.EventHandler(this.btn_valor_Click);
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Location = new System.Drawing.Point(261, 140);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(0, 13);
            this.lbl_posicion.TabIndex = 15;
            // 
            // btn_posicion
            // 
            this.btn_posicion.Location = new System.Drawing.Point(143, 134);
            this.btn_posicion.Name = "btn_posicion";
            this.btn_posicion.Size = new System.Drawing.Size(75, 23);
            this.btn_posicion.TabIndex = 14;
            this.btn_posicion.Text = "Posicion";
            this.btn_posicion.UseVisualStyleBackColor = true;
            this.btn_posicion.Click += new System.EventHandler(this.btn_posicion_Click);
            // 
            // lbl_mostrar
            // 
            this.lbl_mostrar.AutoSize = true;
            this.lbl_mostrar.Location = new System.Drawing.Point(261, 111);
            this.lbl_mostrar.Name = "lbl_mostrar";
            this.lbl_mostrar.Size = new System.Drawing.Size(0, 13);
            this.lbl_mostrar.TabIndex = 13;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(143, 105);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 12;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lbl_agregar
            // 
            this.lbl_agregar.AutoSize = true;
            this.lbl_agregar.Location = new System.Drawing.Point(261, 82);
            this.lbl_agregar.Name = "lbl_agregar";
            this.lbl_agregar.Size = new System.Drawing.Size(0, 13);
            this.lbl_agregar.TabIndex = 11;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(24, 76);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 10;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(143, 76);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 306);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.btn_valor);
            this.Controls.Add(this.lbl_posicion);
            this.Controls.Add(this.btn_posicion);
            this.Controls.Add(this.lbl_mostrar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.lbl_agregar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_valor;
        internal System.Windows.Forms.Button btn_valor;
        internal System.Windows.Forms.Label lbl_posicion;
        internal System.Windows.Forms.Button btn_posicion;
        internal System.Windows.Forms.Label lbl_mostrar;
        internal System.Windows.Forms.Button btn_mostrar;
        internal System.Windows.Forms.Label lbl_agregar;
        internal System.Windows.Forms.TextBox txt_valor;
        internal System.Windows.Forms.Button btn_agregar;
    }
}

