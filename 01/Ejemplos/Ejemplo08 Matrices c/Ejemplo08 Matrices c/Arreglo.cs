using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo08_Matrices_c
{
    class Arreglo
    {
    //Arreglo donde vamos a almacenar los valores dados por el usuario
      String [,]Cliente;
    //Constantes que nos van a servir para saber el tamaño del arreglo
      readonly int FILA_CLIENTE;
      readonly int COLUMNA_CLIENTE;

    //variables que indican la posicion actual en el arreglo
      int columna=0, fila = 0;

      public Arreglo(int filas,int columnas)
      {
        //Asignamos los valores dados por el usuario a las constantes
          FILA_CLIENTE = filas;
          COLUMNA_CLIENTE = columnas;

          //Definicion de la matriz
          Cliente = new String[FILA_CLIENTE, COLUMNA_CLIENTE];
      }

      public void agregar(string valor)
      {
      }



    }
}
