namespace Ejemplo05_Sobrecarga_y_sobreescritura
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
            this.cmb_animal = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_animal
            // 
            this.cmb_animal.FormattingEnabled = true;
            this.cmb_animal.Items.AddRange(new object[] {
            "Gato",
            "Perro"});
            this.cmb_animal.Location = new System.Drawing.Point(13, 64);
            this.cmb_animal.Name = "cmb_animal";
            this.cmb_animal.Size = new System.Drawing.Size(121, 21);
            this.cmb_animal.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(67, 118);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(67, 145);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 124);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(13, 151);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_edad.TabIndex = 4;
            this.lbl_edad.Text = "Edad";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(165, 62);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 5;
            this.btn_crear.Text = "Crear animal";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmb_animal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_animal;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Button btn_crear;

    }
}

