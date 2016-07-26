namespace Ejemplo02_Los_3_basicos
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
            this.btn_pasar = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txt_palabra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_pasar
            // 
            this.btn_pasar.Location = new System.Drawing.Point(152, 80);
            this.btn_pasar.Name = "btn_pasar";
            this.btn_pasar.Size = new System.Drawing.Size(75, 23);
            this.btn_pasar.TabIndex = 0;
            this.btn_pasar.Text = "Pasar texto";
            this.btn_pasar.UseVisualStyleBackColor = true;
            this.btn_pasar.Click += new System.EventHandler(this.btn_pasar_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(254, 89);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(35, 13);
            this.lbl_texto.TabIndex = 1;
            this.lbl_texto.Text = "label1";
            // 
            // txt_palabra
            // 
            this.txt_palabra.Location = new System.Drawing.Point(21, 82);
            this.txt_palabra.Name = "txt_palabra";
            this.txt_palabra.Size = new System.Drawing.Size(100, 20);
            this.txt_palabra.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 295);
            this.Controls.Add(this.txt_palabra);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_pasar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pasar;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txt_palabra;
    }
}

