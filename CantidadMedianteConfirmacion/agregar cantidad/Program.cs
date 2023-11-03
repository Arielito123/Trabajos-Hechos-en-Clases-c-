using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregar_cantidad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[100];//variable vector string
            string[] apellido = new string[100];//variable vector string
            char[] sexo = new char[100];//variable vector char
            int[] edad = new int[100];//variable vector int
            int cant = 0, k, i;//variable de tipo enteras
            string aux = "";//viriable aux de tipo string
            char confirmacion = 'S';//viariable para confirmar un bucle

            while (confirmacion != 'N')//mientras confirmacion sea distinto de N se ejecutara hasta que el usuario decida
            {
                Console.Write("Ingrese apellido: ");//leyenda para cargar el vector
                apellido[cant] = Console.ReadLine();//guardamos el apellido y le pasamos como posicion nuestro contador
                Console.Write("Ingrese nombre: ");//leyenda para cargar el vector
                nombre[cant] = Console.ReadLine();//guardamos el Nombre y le pasamos como posicion nuestro contador
                Console.Write("Ingrese sexo");//leyenda para cargar el vector
                sexo[cant] = char.Parse(Console.ReadLine());//guardamos el Sexo y lo parceamos,le pasamos como posicion nuestro contador
                Console.Write("Ingrese edad: ");//leyenda para cargar el vector
                edad[cant] = int.Parse(Console.ReadLine());//guardamos la edad y la parceamos,le pasamos como posicion nuestro contador
                cant++;

                //Se pide la confirmación de una nuevo ingreso

                Console.Write("¿Deséa ingresar otra persona: [S=Sí/N=No]: ");//volvemos a ingresar la leyenda
                confirmacion = char.Parse(Console.ReadLine());//guardamos y parseamos la confirmacion
                confirmacion = char.ToUpper(confirmacion);//la convertimos a mayuscula

            }

            for (k =cant-1; k >=0; k--)//usamos el metodo burbuja para ordenar nuestro elemento y le damos k en la posicion cant-1
            {
                for (i = 0; i < k; i++)//otro for que recorra donde termina k
                {
                    if (apellido[i].CompareTo(apellido[i+1]) > 0)//usamos compare to para ordenar la cadena de apellido
                    {
                        aux = apellido[i];//a aux le asignamos apellido en la posicion i
                        apellido[i] = apellido[i + 1];//a apellido en la posicion i le asignamos el apellido en la posicion i+1
                        apellido[i+1] = aux;//apellido en la posicion i+1 el valor que contiene aux;

                    }
                }
            }

            for (i = 0; i < cant; i++)//un for para recorrer la cantidad de personas ingresadas por el usuario
            {
                Console.WriteLine(apellido[i]);//cargamos los apellidos ordenados
            }

           

            Console.ReadKey();//una pausa en el sistema para que no se cierre el programa
        }
    }
}
