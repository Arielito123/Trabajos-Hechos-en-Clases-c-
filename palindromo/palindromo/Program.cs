using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;//variable de tipo string
            int longitud,cont = 0;//variable de tipo entera que contendra la longitud, y un contador
            bool palindromo = true;
            
            Console.Write(" Ingrese una palabra ");//leyenda
            palabra = Console.ReadLine();//parseamos el string
            palabra = palabra.ToUpperInvariant();//convertimos el string a mayuscula
            longitud=palabra.Length;//guaramos la longitud de la palabra


            for (int i = longitud - 1; i >= 0; i--) //esto pregunta que i es igual a longitud en la posicion menos 1 que seria la ultima posicion 
            {  // que mientras indice no sea menor o igual a 0 
                //indice decrementa hasta llegar a la posicion 0

                if (palabra[i]!=palabra[cont]) 
                {
                    palindromo = false; // igual cambia a falso
                    break;//corta el ciclo de repeticion
 
                }
                cont++;//incrementa la posicion de cont
 
            }

            if (palindromo == true) //paldrindomo es verdadero entonces habra encontrado una coincidencia en la palabra de adelante al reves
            {
                Console.WriteLine(" La Palabra es palindromo "); //leyenda diciendo q es palindromo
            }
            else //de lo contrario
            {
                Console.WriteLine(" La palabra no es palindromo ");//la palabra no es palindromo
            }



            Console.ReadKey();//pausa
        

        }
    }
}
