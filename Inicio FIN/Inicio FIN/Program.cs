using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_FIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio=100, fin=200;//pongo los valores en el main

           Lista(inicio,fin);//Llamo Al Metodo lista 

            Console.ReadKey();
          


        }

        static void Lista(int n1,int n2) //solo nombro las variables
        {
           int i=0;

          

           Console.WriteLine(n1);
            if (n1 == n2) 
           {
               return;
           }
           else 
           {
               Lista(n1+1,n2);
           }
        
         
        }
    }
}
