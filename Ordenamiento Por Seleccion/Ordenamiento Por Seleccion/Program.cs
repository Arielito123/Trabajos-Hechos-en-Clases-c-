using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Por_Seleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = new int[5];
            int i, k, x, aux;

            for (i = 0; i < 5; i++) 
            {
                Console.Write(" Carga un numero entero al vector "+(i+1)+" ");
                vec[i]=int.Parse(Console.ReadLine());//cargamos nuestro vector mediante ciclo de repeticion
            }

            for (i = 0; i < 4; i++) //iniciamos el ciclo for
            {//apertura del primer for
                k = i;//k valdra lo mismo que i

                for (x = i + 1; x < 5; x++) // x en las pasadas valdra siempre uno mas que i
                {//apertura for
                    if (vec[x] < vec[k]) //usamos un if para comparar las posiciones del vector 1 a una y encontrar el menor
                    {//apertura if
                        k = x;//una ves encontrada le asignamos a k el valor de x  entonces procederemos con otro paso fuera de for
                    }//cierre if
                   
                }//cierre del segundo for aninadado
                aux = vec[i];//el valor de la posicion i la metemos en el auxiliar
                vec[i] = vec[k];//i al ya no tener valor le damos el valor donde se encuentra almacenado el numero menor que ordenaremos
                vec[k] = aux;//k le damos el valor de auxiliar que contenia anteriormente el valor de i
            }//se vuelve a repetir el ciclo para ir por el siguiente numero menor y asi susesivamente hasta 5

            for (i = 0; i < 5; i++) 
            {
                Console.WriteLine(vec[i]);
            }

            Console.ReadKey();
        }
    }
}
