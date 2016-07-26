using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo05_Abstract_y_Sealed
{
    sealed class Gato : Animal
    {
        public Gato(String nombre, int edad, String sexo):base(nombre,edad,sexo)
        {
            /*this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
             * */
        }
        //Metodo constructor que sobrecarga al metodo constructor anterior
        //dandonos la posibilidad de crear un gato sin darle valores
        //Siempre tomara unos por default
        public Gato():this("Fluffy", 3, "FEMENINO") {
            /*this.nombre = "Fluffy";
            this.edad = 3;
            this.sexo = "FEMENINO";*/
            System.Windows.Forms.MessageBox.Show("Soy el gato" + nombre);
            
        }
        protected internal override void dormir()
        {
            base.dormir();
            System.Windows.Forms.MessageBox.Show("Estoy durmiendo en el dia");
        }
        public void maullar()
        {
            System.Windows.Forms.MessageBox.Show("Estoy maullando");
        }
        public int jugar(String juguete)
        {
            System.Windows.Forms.MessageBox.Show("Estoy jugando con " + juguete);
            return 0;
        }
        protected internal override void aparear() {
            System.Windows.Forms.MessageBox.Show("La gata se lastima");
        }
    }
}
