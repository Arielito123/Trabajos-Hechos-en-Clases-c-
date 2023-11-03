using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_Con_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero Hijo Pereyra");//la sucesion
            int numero = int.Parse(Console.ReadLine());//parceamos

            Fibonachi(numero);//llamamos al metodo

            Console.ReadKey();
        }

        static void Fibonachi(int numero)//variable para la sucession 
        {
            int primero = 0, segundo = 1, Siguiente;//variables que contienen 0 y 1 y el siguiente para hacer la suma

            for (int i = 0; i <= numero; i++)//for que recorre la secuencia fibonachi de la posicion 0 hasta donde termina el numero 
            {
                if (i <= 1)//preguntamos si i es menos o igual que 1
                {
                    Siguiente = i;//entonces siguiente tendra el valor de i
                }
                else
                {
                    Siguiente = primero + segundo;//de lo contrario se sumara el primero con el segundo
                    primero = segundo;//primero tendra el valor de segundo
                    segundo = Siguiente;//segundo el de siguiente
                }

                Console.Write("{0}-",Siguiente);//representa texto como una serie de caracteres
            }
        }


    }
}
