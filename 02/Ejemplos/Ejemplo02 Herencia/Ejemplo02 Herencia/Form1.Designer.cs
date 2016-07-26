namespace Ejemplo02_Herencia
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
            this.btn_crear_objeto = new System.Windows.Forms.Button();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_animal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_crear_objeto
            // 
            this.btn_crear_objeto.Location = new System.Drawing.Point(171, 187);
            this.btn_crear_objeto.Name = "btn_crear_objeto";
            this.btn_crear_objeto.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_objeto.TabIndex = 13;
            this.btn_crear_objeto.Text = "Crear Perro";
            this.btn_crear_objeto.UseVisualStyleBackColor = true;
            this.btn_crear_objeto.Click += new System.EventHandler(this.btn_crear_objeto_Click);
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(42, 139);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_edad.TabIndex = 12;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(39, 93);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 11;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(39, 58);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(146, 139);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 9;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(146, 93);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(100, 20);
            this.txt_sexo.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(146, 52);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // cmb_animal
            // 
            this.cmb_animal.FormattingEnabled = true;
            this.cmb_animal.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cmb_animal.Location = new System.Drawing.Point(45, 188);
            this.cmb_animal.Name = "cmb_animal";
            this.cmb_animal.Size = new System.Drawing.Size(121, 21);
            this.cmb_animal.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmb_animal);
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

        private System.Windows.Forms.Button btn_crear_objeto;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_animal;
    }
}

