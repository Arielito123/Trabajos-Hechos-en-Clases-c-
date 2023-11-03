using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            //ordenamiento por el metodo Burbuja

            int[] vec = new int[5];//carga del vector
            int i, k, aux;//carga de i y k para ciclo de repeticion y aux para el ordenamiento del vector

            for (i = 0; i < 5; i++) 
            {
                Console.Write(" carga un numero entero al vector " + (i + 1)+" ");
                vec[i] = int.Parse(Console.ReadLine());//cargamos el vector y lo recorremos mediante nuestro ciclo for
            }

            for (k = 4; k >= 0; k--) //cargamos el primer for y lo inicializamos en 4 para que ordene de atras para adelante
            {
                for (i = 0; i < k; i++) //segundo for para que ordene simultaneamente con el primero
                {
                    if (vec[i] > vec[i + 1])//comparamos el primer posicion del vector con la que le sigue para ver si es menor 
                    {//recalcar en caso de ordenar de mayor a menor hay que cambiar el simbolo >para el otro lado <
                        aux = vec[i];//luego hacemos pasaje de variable para re ordenar nuestros datos dentro
                        vec[i] = vec[i + 1];// de la array hasta que terminen los ciclos for
                        vec[i + 1] = aux;
                    }
                }
            }

            for (i = 0; i < 5; i++)   {
            
                Console.Write(vec[i]);//Mostramos el vector ya Ordenado de Menor  mayor
            }
            Console.ReadKey();
        }
       }
}
