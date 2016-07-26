namespace Ejemplo08_Matrices_c
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
            this.btn_crear = new System.Windows.Forms.Button();
            this.lbl_columnas_buscar = new System.Windows.Forms.Label();
            this.lbl_filas_buscar = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_columnas_buscar = new System.Windows.Forms.TextBox();
            this.txt_filas_buscar = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_columnas_crear = new System.Windows.Forms.Label();
            this.lbl_filas_crear = new System.Windows.Forms.Label();
            this.txt_agregar = new System.Windows.Forms.TextBox();
            this.txt_columnas_crear = new System.Windows.Forms.TextBox();
            this.txt_filas_crear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(201, 33);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 23;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // lbl_columnas_buscar
            // 
            this.lbl_columnas_buscar.AutoSize = true;
            this.lbl_columnas_buscar.Location = new System.Drawing.Point(34, 193);
            this.lbl_columnas_buscar.Name = "lbl_columnas_buscar";
            this.lbl_columnas_buscar.Size = new System.Drawing.Size(53, 13);
            this.lbl_columnas_buscar.TabIndex = 22;
            this.lbl_columnas_buscar.Text = "Columnas";
            // 
            // lbl_filas_buscar
            // 
            this.lbl_filas_buscar.AutoSize = true;
            this.lbl_filas_buscar.Location = new System.Drawing.Point(31, 162);
            this.lbl_filas_buscar.Name = "lbl_filas_buscar";
            this.lbl_filas_buscar.Size = new System.Drawing.Size(28, 13);
            this.lbl_filas_buscar.TabIndex = 21;
            this.lbl_filas_buscar.Text = "Filas";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Location = new System.Drawing.Point(214, 155);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_columnas_buscar
            // 
            this.txt_columnas_buscar.Location = new System.Drawing.Point(94, 195);
            this.txt_columnas_buscar.Name = "txt_columnas_buscar";
            this.txt_columnas_buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_columnas_buscar.TabIndex = 19;
            // 
            // txt_filas_buscar
            // 
            this.txt_filas_buscar.Location = new System.Drawing.Point(94, 155);
            this.txt_filas_buscar.Name = "txt_filas_buscar";
            this.txt_filas_buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_filas_buscar.TabIndex = 18;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(439, 88);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // lbl_columnas_crear
            // 
            this.lbl_columnas_crear.AutoSize = true;
            this.lbl_columnas_crear.Location = new System.Drawing.Point(34, 88);
            this.lbl_columnas_crear.Name = "lbl_columnas_crear";
            this.lbl_columnas_crear.Size = new System.Drawing.Size(53, 13);
            this.lbl_columnas_crear.TabIndex = 16;
            this.lbl_columnas_crear.Text = "Columnas";
            // 
            // lbl_filas_crear
            // 
            this.lbl_filas_crear.AutoSize = true;
            this.lbl_filas_crear.Location = new System.Drawing.Point(31, 34);
            this.lbl_filas_crear.Name = "lbl_filas_crear";
            this.lbl_filas_crear.Size = new System.Drawing.Size(28, 13);
            this.lbl_filas_crear.TabIndex = 15;
            this.lbl_filas_crear.Text = "Filas";
            // 
            // txt_agregar
            // 
            this.txt_agregar.Location = new System.Drawing.Point(333, 88);
            this.txt_agregar.Name = "txt_agregar";
            this.txt_agregar.Size = new System.Drawing.Size(100, 20);
            this.txt_agregar.TabIndex = 14;
            // 
            // txt_columnas_crear
            // 
            this.txt_columnas_crear.Location = new System.Drawing.Point(94, 81);
            this.txt_columnas_crear.Name = "txt_columnas_crear";
            this.txt_columnas_crear.Size = new System.Drawing.Size(100, 20);
            this.txt_columnas_crear.TabIndex = 13;
            // 
            // txt_filas_crear
            // 
            this.txt_filas_crear.Location = new System.Drawing.Point(94, 34);
            this.txt_filas_crear.Name = "txt_filas_crear";
            this.txt_filas_crear.Size = new System.Drawing.Size(100, 20);
            this.txt_filas_crear.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_columnas_buscar);
            this.Controls.Add(this.lbl_filas_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_columnas_buscar);
            this.Controls.Add(this.txt_filas_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_columnas_crear);
            this.Controls.Add(this.lbl_filas_crear);
            this.Controls.Add(this.txt_agregar);
            this.Controls.Add(this.txt_columnas_crear);
            this.Controls.Add(this.txt_filas_crear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_crear;
        internal System.Windows.Forms.Label lbl_columnas_buscar;
        internal System.Windows.Forms.Label lbl_filas_buscar;
        internal System.Windows.Forms.Button btn_buscar;
        internal System.Windows.Forms.TextBox txt_columnas_buscar;
        internal System.Windows.Forms.TextBox txt_filas_buscar;
        internal System.Windows.Forms.Button btn_agregar;
        internal System.Windows.Forms.Label lbl_columnas_crear;
        internal System.Windows.Forms.Label lbl_filas_crear;
        internal System.Windows.Forms.TextBox txt_agregar;
        internal System.Windows.Forms.TextBox txt_columnas_crear;
        internal System.Windows.Forms.TextBox txt_filas_crear;
    }
}

