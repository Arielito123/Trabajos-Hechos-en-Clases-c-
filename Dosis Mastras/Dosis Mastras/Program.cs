using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosis_Mastras
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //declaracion de variable
            

            string[] Ape = new string[3];
            string[] Nombre = new string[3];
            string[] Dni = new string[3];
            char[] Sexo = new char[3];
            int[] Edad = new int[3];
            int[] CantidadDosis = new int[3];
            int i, k, contD = 0,aux=0,porcentaje=0,cantidadD=0;
            string aux1="";
            char auxS = 'a',salir;
            char opc='A';

            Console.CursorVisible = false;

            //cargamos los datos al vector 

            for (i = 0; i < 3; i++) 
            {
                Console.Write("Ingrese el Apellido de la persona N° " + (i + 1) + ": ");
                Ape[i] = Console.ReadLine();
                Ape[i] = Ape[i].ToUpperInvariant();
                Console.Write("Ingrese el Nombre de la persona N° " + (i + 1) + ": ");
                Nombre[i] = Console.ReadLine();
                Nombre[i] = Nombre[i].ToUpperInvariant();
                Console.Write("Ingrese el DNI de la persona N° " + (i + 1) + ": ");
                Dni[i] = Console.ReadLine();

                while (Dni[i].Length != 7 && Dni[i].Length != 8) 
                {
                    Console.WriteLine("Digitos del dni mal ingresados son 7 u 8 digitos");
                    Dni[i] = Console.ReadLine();
                }

                Console.WriteLine("Ingrese la edad de la persona n° "+(i+1));
                Edad[i] = int.Parse(Console.ReadLine());

                while(Edad[i]<3||Edad[i]>105)
                {
                    Console.WriteLine("Edad invalida vuelva a ingresar");
                    Edad[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el Sexo f o m n° "+(i+1));
                Sexo[i] = char.Parse(Console.ReadLine());
                Sexo[i]=char.ToUpper(Sexo[i]);

                while (Sexo[i] != 'F' && Sexo[i] != 'M') 
                {
                    Console.WriteLine("Sexo Invalido Vuelva a ingresa F O M");
                    Sexo[i] = char.Parse(Console.ReadLine());
                    Sexo[i] = char.ToUpper(Sexo[i]);
                }

                Console.WriteLine("Cantidad de dosis contra el covid");
                CantidadDosis[i] =int.Parse(Console.ReadLine());

                if (CantidadDosis[i] == 3||CantidadDosis[i] == 4) 
                {
                    contD++;
 
                }
                

            }
            Console.Clear();//limpieza de datos en la pantalla

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("<<<A>>>Listado completo de la población consultada ordenado por apellido todos los datos <<<A>>>");
            Console.SetCursorPosition(22, 5);
            Console.WriteLine("<<<B>>> Listado de personas de sexo femenino con 4 dosis <<<B>>>");
            Console.SetCursorPosition(22, 7);
            Console.WriteLine("<<<C>>>Listado de personas de sexo masculino con 4 dosis<<<C>>>");
            Console.SetCursorPosition(22, 9);
            Console.WriteLine("<<<D>>>Porcentaje de personas con 3 y 4 dosis.<<<D>>>");
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("<<<E>>>Listado de personas que no han sido vacunadas ordenadas por DNI<<<E>>>");
            opc = char.Parse(Console.ReadLine());
            opc = char.ToUpper(opc);


             switch (opc) 
            {
                case 'A':
                     //ORDENAMIENTO DE CADENA POR COMPARE TO()
                    for (k = 2; k >= 0; k--) 
                    {
                        for (i = 0; i < k; i++) 
                        {
                            if (Ape[i].CompareTo(Ape[i + 1]) >0)
                            {

                                aux1=Ape[i];
                                Ape[i] = Ape[i + 1];
                                Ape[i + 1] = aux1;

                                 aux1 =Nombre[i];
                                Nombre[i] = Nombre[i + 1];
                                Nombre[i + 1] = aux1;

                                aux1 =Dni[i] ;
                                Dni[i] = Dni[i + 1];
                                Dni[i + 1] = aux1;

                                aux =Edad[i];
                                Edad[i] = Edad[i + 1];
                                Edad[i + 1] = aux;

                                Sexo[i]= auxS;
                                Sexo[i] = Sexo[i + 1];
                                Sexo[i + 1] = auxS;

                                aux=CantidadDosis[i];
                                CantidadDosis[i] = CantidadDosis[i + 1];
                                CantidadDosis[i + 1] = aux;
                                


                            }
                        }
                    }

                    for (i = 0; i < 3; i++) 
                    {
                       
                        Console.WriteLine("Apellido : "+Ape[i]+" Nombre: "+Nombre[i]+" Dni: "+Dni[i]+" Edad: "+Edad[i]+" Sexo "+Sexo[i]+" C.Dosis "+CantidadDosis[i]);
                        Console.WriteLine(" "); 
                    }

                        break;

                 case 'B':
                        for (i = 0; i < 3; i++)
                        {
                            if (Sexo[i] == 'F')
                            {
                                if (CantidadDosis[i] == 4)
                                {
                                    Console.WriteLine(Ape[i] + "     " + Nombre[i] + "    " + Edad[i] + "    " + Dni[i] + "    " + Sexo[i] + "    " + CantidadDosis[i] + "\n");
                                }
                            }
                        }

                            break;

                 case 'C':
                            for (i = 0; i < 3; i++) 
                            {
                                if (Sexo[i] == 'M') 
                                {
                                    Console.WriteLine(Ape[i] + "     " + Nombre[i] + "    " + Edad[i] + "    " + Dni[i] + "    " + Sexo[i] + "    " + CantidadDosis[i] + "\n");
                                }
                            }

                                break;

                 case 'D':

                                porcentaje = (contD * 100) / 3;

                                Console.WriteLine("porcentaje con personas entre 3 o 4 vacunas: "+"  "+porcentaje+"%");

                     break;

                 case 'E':

                     for (k =2 ; k>=0; k--) 
                     {
                         for (i = 0; i < k; i++) 
                         {
                             if (CantidadDosis[i] == 0) 
                             {
                                 if(Dni[i].CompareTo(Dni[i+1])>0)
                                 {
                                     aux1 = Dni[i];
                                     Dni[i] = Dni[i + 1];
                                     Dni[i + 1] = aux1;

                                     aux1 = Ape[i];
                                     Ape[i] = Ape[i + 1];
                                     Ape[i + 1] = aux1;


                                     aux1 = Nombre[i];
                                     Nombre[i] = Nombre[i + 1];
                                     Nombre[i + 1] = aux1;

                                     aux = Edad[i];
                                     Edad[i] = Edad[i + 1];
                                     Edad[i + 1] = aux;

                                     auxS = Sexo[i];
                                     Sexo[i] = Sexo[i + 1];
                                     Sexo[i + 1] = auxS;

                                     aux = CantidadDosis[i];
                                     CantidadDosis[i] = CantidadDosis[i + 1];
                                     CantidadDosis[i + 1] = aux;
                                 }
                             }
                         }
                        
                       
                         
                     }

                     

                     for (i = 0; i < 3; i++) 
                     {
                         if (CantidadDosis[i]==0) 
                         {
                             Console.WriteLine(Dni[i] + " " + Ape[i] + " " + Nombre[i] + " " + Edad[i] + " " + Sexo[i] + CantidadDosis[i]);
                         }

                         if (CantidadDosis[i] != 0) 
                         {
                             cantidadD = CantidadDosis[i];
                            
                         }
                     }
                     Console.WriteLine("se encontraron "+cantidadD+"personas ya vacunadas");

                         break;
            }

          



            Console.ReadKey();
            
        }


    

    }
    }
