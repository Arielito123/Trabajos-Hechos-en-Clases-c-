using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo_Metodo_
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int longitud;
            bool palindromo = true;

            Console.Write("Ingrese una palabra: ");
            palabra = Console.ReadLine();//Parseo el string
            palabra = palabra.ToUpperInvariant();//String a mayuscula para que no interfiera en el ingreso
            longitud = palabra.Length;//Guardo el n° de la palabra en longitud

            palindromo = Program.Palindromo(longitud, palabra);//CUANOD LO LLAMO AL METODO, LO QUE DEVUELVA SE VA A GUARDAR EN ESA NUEVA VARIABLE.

            if (palindromo == true)//Determina que opcion mostrar.
            {
                Console.WriteLine("La palabra " + palabra + " es un palindromo. ");
            }
            else
            {
                Console.WriteLine("La palabra " + palabra + " no es un palindromo. ");
            }
            Console.ReadKey();//una pausa
        }


        static bool Palindromo(int largo, string pal)
        {
            bool PALIND = true;
            int CONTADOR = 0;

            for (int i = largo - 1; i >= 0; i--)
            {
                if (pal[i] != pal[CONTADOR])
                {
                    PALIND = false; // Si se cumple la condicion, vale false
                    break;

                }
                CONTADOR++;
            }
            return PALIND;

        }

    }
}
