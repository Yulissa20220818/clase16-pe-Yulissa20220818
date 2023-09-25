using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //declaracion de variable int para opciones

            int opciones;

            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. Programa que muestre de n al 1 de manera descendente");
                Console.WriteLine("2. Programa que muestre los numeros de 1 a 5 con while");
                Console.WriteLine("3. Programa que muestre el numero minim de una lista ");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opion (1-4): ");


                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                          case 1: 


                            numerosDescentes();
                            break;

                        case 2: 
                             

                            numerosWhile();
                            break;


                        case 3:
                             
                            minimoLista();
                            break;

                        case 4:

                           break;
                        default:
                          Console.WriteLine("opcion no valida, por favor, selecciona una opcion vvalida (1-4");
                          break;
                    }
                }
                else{
                    Console.WriteLine("Entrada no valida. Ingrese un numero de (1-4).");
                }
            } while (opciones !=4);
        }//FIN DE MAIN

        static void numerosDescentes()
        {
            Console.Write("\n Ingrese un numero (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >=1)
            {
                for (int i =n; i >= 1; i--)
                {
                    Console.WriteLine($"Numero > {1}");
                }
            }
            else{
                 Console.WriteLine("Ingresar un numero mayor a 1");
            }
        }//Fin de numeroDescendentes

        static void numerosWhile(){
            int contador = 1;

            while (contador <= 5)
            {
                 Console.Write($"Numero >>{contador}");
                 contador++;
            }
        }//Fin de numerosWhile

        static void minimoLista(){
            list<int> numeros = new list<int> {24, 15, 45, 35, 14, 10}; 

            int minimo = numeros[0]; //inicializar con valor del indice 0

            foreach (int numero1 in numeros)
            {
                if (numero1 < minimo)
                {
                    minimo = numero1; //actualizar el valor minimo
                }
            }

             Console.WriteLine("el numero mas pequeño en la lista es > " + minimo);

        }//fin de minimoLista 
    }
}
