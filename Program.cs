using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("Universidad Tecnologica de Santiago");
            Console.WriteLine("UTESA - Sistema Corporativo");
            Console.WriteLine("Entrega final de Algoritmos y estructura de Datos");
            Console.WriteLine("===============================================");
            Console.WriteLine("\nMENU PRINCIPAL");
            Console.WriteLine("1. Numeros");
            Console.WriteLine("2. Estadistica");
            Console.WriteLine("3. Conversion");
            Console.WriteLine("4. Metodos de ordenamiento");
            Console.WriteLine("5. Recursividad");
            Console.WriteLine("6. Arbol de decisiones");
            Console.WriteLine("7. Grafos");
            Console.WriteLine("0. Salir");
            Console.Write("\nDigita la opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Seleccionaste Numeros.");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste Estadistica.");
                    break;
                case 3:
                    Console.WriteLine("Seleccionaste Conversion.");
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste Metodos de ordenamiento.");
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste Recursividad.");
                    break;
                case 6:
                    Console.WriteLine("Seleccionaste Arbol de decisiones.");
                    break;
                case 7:
                    Console.WriteLine("Seleccionaste Grafos.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Intenta de nuevo.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}
