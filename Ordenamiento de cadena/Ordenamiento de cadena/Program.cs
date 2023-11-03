using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_de_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables

            string[] ape=new string[3];
            string[] nombre = new string[3];
            string auxiliar;
            int i, k; 

            //ingreso de datos apellido y nombre

            for (i = 0; i < 3; i++) 
            {
                Console.WriteLine("Ingrese el apellido");
                ape[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre");
                nombre[i] = Console.ReadLine();


            }

            //ordenamiento por metodo burbuja utilizando compaareto ()

            for (k = 2; k >= 0; k--) 
            {
                for (i = 0; i < k; i++) 
                {
                    if (ape[i].CompareTo(ape[i + 1]) > 0) 
                    {
                        auxiliar = ape[i];
                        ape[i] = ape[i + 1];
                        ape[i + 1] = auxiliar;
                        auxiliar = nombre[i];
                        nombre[i] = nombre[i + 1];
                        nombre[i + 1] = auxiliar;
                    }
                }
            }

            //Sacados Datos por Pantalla

            for (i = 0; i < 3; i++) 
            {
                Console.WriteLine(ape[i]);
                Console.WriteLine(nombre[i]);
            }

            Console.ReadKey();//pausa
        }
    }
}
