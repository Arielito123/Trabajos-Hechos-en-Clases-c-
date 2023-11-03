using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucession_De_Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para poder hacer la sucesion");//le decimos al usuario que ingrese un numero para hacer la susecion con esos elementos a partir de 0 y 1
            int numero = int.Parse(Console.ReadLine());//parseamos el entero

            Fibonacci(numero);//llamamos al metodo Fibonachi

            Console.ReadKey();
        }

        public static void Fibonacci(int numerosElementos)//Metodo fibonachi con Parametro de enteros
        {
            int[] arreglo = new int[numerosElementos];//le decimos al vector que su dimension va a ser igual a numeros elementos
            arreglo[0] = 0;//que el vector en sub cero iniciara en 0
            arreglo[1] = 1;//mientras que el vector en sub 1 iniciara en uno

            for (int i = 2; i < numerosElementos; i++)//iniciamos la secuencia en la posicion 2 y terminamos en los numeros elementos
            {
                arreglo[i] = arreglo[i - 1] + arreglo[i - 2];//decimos que arreglo sub i es igual a i-1 + arreglo sub i-2 ejem 0,1,1,2 sumando el 0 con el 1 y asi sucesivamente
            }

            Console.WriteLine(string.Join(",", arreglo));//usamos string join para separar los elementos del arreglo el 0 y el 1
        }
    }
}
