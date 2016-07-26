namespace Ejemplo12_Archivos
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_leer = new System.Windows.Forms.Button();
            this.btn_escribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(32, 120);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Edad";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Nombre";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(80, 114);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(80, 65);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(180, 173);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(75, 23);
            this.btn_leer.TabIndex = 7;
            this.btn_leer.Text = "Leer";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // btn_escribir
            // 
            this.btn_escribir.Location = new System.Drawing.Point(80, 174);
            this.btn_escribir.Name = "btn_escribir";
            this.btn_escribir.Size = new System.Drawing.Size(75, 23);
            this.btn_escribir.TabIndex = 6;
            this.btn_escribir.Text = "Escribir";
            this.btn_escribir.UseVisualStyleBackColor = true;
            this.btn_escribir.Click += new System.EventHandler(this.btn_escribir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.btn_escribir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_edad;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.Button btn_leer;
        internal System.Windows.Forms.Button btn_escribir;
    }
}

