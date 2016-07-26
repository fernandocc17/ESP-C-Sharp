namespace Ejemplo01_Abstraccion
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
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.btn_crear_objeto = new System.Windows.Forms.Button();
            this.cmb_Animal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(120, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(120, 73);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(100, 20);
            this.txt_sexo.TabIndex = 1;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(120, 119);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 38);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(13, 73);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 4;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(16, 119);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_edad.TabIndex = 5;
            this.lbl_edad.Text = "Edad";
            // 
            // btn_crear_objeto
            // 
            this.btn_crear_objeto.Location = new System.Drawing.Point(145, 167);
            this.btn_crear_objeto.Name = "btn_crear_objeto";
            this.btn_crear_objeto.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_objeto.TabIndex = 6;
            this.btn_crear_objeto.Text = "Crear Perro";
            this.btn_crear_objeto.UseVisualStyleBackColor = true;
            this.btn_crear_objeto.Click += new System.EventHandler(this.btn_crear_objeto_Click);
            // 
            // cmb_Animal
            // 
            this.cmb_Animal.FormattingEnabled = true;
            this.cmb_Animal.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cmb_Animal.Location = new System.Drawing.Point(16, 168);
            this.cmb_Animal.Name = "cmb_Animal";
            this.cmb_Animal.Size = new System.Drawing.Size(121, 21);
            this.cmb_Animal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 262);
            this.Controls.Add(this.cmb_Animal);
            this.Controls.Add(this.btn_crear_objeto);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Button btn_crear_objeto;
        private System.Windows.Forms.ComboBox cmb_Animal;
    }
}

