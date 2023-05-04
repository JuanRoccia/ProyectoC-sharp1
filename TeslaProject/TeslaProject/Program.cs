﻿namespace TeslaProject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //creo listas que van a contener los datos de cada tesla
            List<string> tesla1 = new List<string>() { "S", "2021", "10000", "15000", "blue", "Pedro Perez" };
            List<string> tesla2 = new List<string>() { "X", "2021", "20000", "25000", "grey", "Rodrigo Ramirez" };
            List<string> tesla3 = new List<string>() { "Y", "2017", "30000", "35000", "red", "Pablo Torres" };
            List<string> tesla4 = new List<string>() { "3", "2016", "40000", "45000", "green", "Ezequiel Ramirez" };
            List<string> tesla5 = new List<string>() { "Y", "2017", "50000", "55000", "black", "Franco Ramirez" };

            //creo una lista de listas para ir guardando listas pertenecientes a cada tesla
            List<List<string>> listOfTeslas = new List<List<string>>();
            listOfTeslas.Add(tesla1);
            listOfTeslas.Add(tesla2);
            listOfTeslas.Add(tesla3);
            listOfTeslas.Add(tesla4);
            listOfTeslas.Add(tesla5);

            while (true)
            {
                Console.WriteLine("BIENVENIDO AL PROGRAMA DE TESLA, INGRESE LA OPCION QUE DESEA REALIZAR");
                Console.WriteLine("=======================================================================");
                Console.WriteLine("1 - dar de alta un tesla");
                Console.WriteLine("2 - eliminar un tesla");
                Console.WriteLine("3 - mostrar listado tesla ordenado por año");
                Console.WriteLine("4 - mostrar listado tesla ordenado por kilometros");
                Console.WriteLine("5 - mostrar el tesla con mas km");
                Console.WriteLine("6 - mostrar la descripción de un tesla");
                Console.WriteLine("7 - salir del programa");
                Console.WriteLine("8 - ver lista completa de teslas");
                Console.WriteLine("=======================================================================");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    //creo una lista para ir guardando los datos del tesla que voy a dar de alta
                    List<string> newTesla = new List<string>() { };

                    Console.WriteLine("Va a dar de alta un tesla");

                    //voy asignando variables para dar Add a la lista newTesla creada anteriormente
                    Console.WriteLine("paso 1 de 6, ingrese el modelo:");
                    string modelo = Console.ReadLine();
                    newTesla.Add(modelo);

                    Console.WriteLine("paso 2 de 6, ingrese el año: ");
                    string year = Console.ReadLine();
                    newTesla.Add(year);

                    Console.WriteLine("paso 3 de 6, ingrese el nombre y apellido del dueño: ");
                    string owner = Console.ReadLine();
                    newTesla.Add(owner);
                    Console.WriteLine("paso 4 de 6, ingrese el color: ");
                    string color = Console.ReadLine();
                    newTesla.Add(color);

                    Console.WriteLine("paso 5 de 6, ingrese el kilometraje actual del vehiculo: ");
                    string kmActual = Console.ReadLine();
                    newTesla.Add(kmActual);

                    Console.WriteLine("paso 6 de 6, ingrese el kilometraje para realizar el proximo service: ");
                    string kmService = Console.ReadLine();
                    newTesla.Add(kmService);


                    //agrego la lista newTesla a la lista de teslas general(listOfTeslas)
                    listOfTeslas.Add(newTesla);

                    Console.WriteLine("Agrego un tesla correctamente");

                }
                else if
                    (respuesta == "2")
                {
                    //voy a eliminar por indice de la lista listOfTeslas con RemoveAt(), convirtiendo el input en int
                    Console.WriteLine("Ingrese el numero de tesla que desea eliminar");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    listOfTeslas.RemoveAt(valor);

                }
                else if (respuesta == "3")
                {
                    Console.WriteLine("listado de tesla ordenados por año");
                }
                else if (respuesta == "4")
                {
                    Console.WriteLine("listado de tesla ordenados por kilometraje");
                }
                else if (respuesta == "5")
                {
                    Console.WriteLine("tesla con mas kilometros");
                }
                else if (respuesta == "6")
                {

                    Console.WriteLine("6");
                }
                else if (respuesta == "7")
                {
                    Console.WriteLine("Hasta luego");
                    break;

                }
                else if (respuesta == "8")
                {
                    foreach (var list in listOfTeslas)
                    {
                        Console.WriteLine(String.Join(", ", list));
                    }
                }
                else
                {
                    Console.WriteLine("La opción ingresada no es valida");
                }

            }

        }

    }

}