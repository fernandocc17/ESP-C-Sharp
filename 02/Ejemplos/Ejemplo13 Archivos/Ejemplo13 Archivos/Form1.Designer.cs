namespace Ejemplo13_Archivos
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.btn_escribir = new System.Windows.Forms.Button();
            this.btn_leer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(146, 62);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Text = " ";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(146, 105);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(47, 68);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(47, 112);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_edad.TabIndex = 3;
            this.lbl_edad.Text = "Edad";
            // 
            // btn_escribir
            // 
            this.btn_escribir.Location = new System.Drawing.Point(50, 185);
            this.btn_escribir.Name = "btn_escribir";
            this.btn_escribir.Size = new System.Drawing.Size(75, 23);
            this.btn_escribir.TabIndex = 4;
            this.btn_escribir.Text = "Escribir";
            this.btn_escribir.UseVisualStyleBackColor = true;
            this.btn_escribir.Click += new System.EventHandler(this.btn_escribir_Click);
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(188, 185);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(75, 23);
            this.btn_leer.TabIndex = 5;
            this.btn_leer.Text = " Leer";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 381);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.btn_escribir);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Button btn_escribir;
        private System.Windows.Forms.Button btn_leer;
    }
}

