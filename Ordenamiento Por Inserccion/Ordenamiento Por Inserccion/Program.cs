using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Por_Inserccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];//declaro la variable que usare como vector
            int i, x, aux;//declaro la variable del for i y x y la que usaremos como

            for (i = 0; i < 5; i++) 
            {
                Console.WriteLine("Ingrese numeros al vector");
                v[i] = int.Parse(Console.ReadLine());
                
                
            }


            for (i = 1; i < 5; i++) 
            {
                aux = v[i];
                x = i - 1;

                while (x >= 0 && aux < v[x]) 
                {
                    v[x + 1] = v[x];
                    x--;
                }
                v[x + 1] = aux;
            }

            for (i = 0; i < 5; i++) 
            {
                Console.WriteLine(v[i]);
            }

            Console.ReadKey();

        }
    }
}
