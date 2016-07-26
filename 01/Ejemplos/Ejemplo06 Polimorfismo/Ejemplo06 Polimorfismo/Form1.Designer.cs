namespace Ejemplo06_Polimorfismo
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
            this.SuspendLayout();
            // 
            // cmb_animal
            // 
            this.cmb_animal.FormattingEnabled = true;
            this.cmb_animal.Items.AddRange(new object[] {
            "Gato",
            "Perro"});
            this.cmb_animal.Location = new System.Drawing.Point(12, 67);
            this.cmb_animal.Name = "cmb_animal";
            this.cmb_animal.Size = new System.Drawing.Size(121, 21);
            this.cmb_animal.TabIndex = 1;
            this.cmb_animal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmb_animal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_animal;

    }
}

