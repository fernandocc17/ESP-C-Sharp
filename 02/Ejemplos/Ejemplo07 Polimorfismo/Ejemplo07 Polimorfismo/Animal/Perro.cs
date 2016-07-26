using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo05_Abstract_y_Sealed
{
    sealed class Perro : Animal
    {
        
        
        public Perro(String nombre, int edad, String sexo):base(nombre,edad,sexo)
        {
/*            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
 */
        }
        public void ladrar()
        {
            System.Windows.Forms.MessageBox.Show("Estoy ladrando");
        }
        protected internal override void dormir()
        {
            System.Windows.Forms.MessageBox.Show("Estoy durmiendo en la noche");
        }

        protected internal override void aparear(){
            System.Windows.Forms.MessageBox.Show("Me quedo pegado apareandome");
        }

    }
}