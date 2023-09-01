// See https://aka.ms/new-console-template for more information
using Laboratorio1_C;
Automovil automovil = new Automovil("Toyota", "Corolla", 2022, "Gasolina");
Camion camion = new Camion("Ford", "F-150", 2021, 5000);

Flota flota = new Flota();


Console.WriteLine("-----------------------------");
Console.WriteLine("Ingrese una de las opciones");
Console.WriteLine("-----------------------------");
Console.WriteLine("A: Mostrar información de los vehiculos");
Console.WriteLine("B: Calcular costo del viaje");

Console.WriteLine("S: Salir ");

string opcion = Console.ReadLine();

if (opcion.ToUpper() == "A")
{
    Console.WriteLine("Información de la Flota:");
    flota.MostrarFlota();
}
else if (opcion.ToUpper() == "S")
{
    // Opción para salir
    Console.WriteLine("Saliendo del programa...");
}
else
{
    Console.WriteLine("Opción no válida.");
}