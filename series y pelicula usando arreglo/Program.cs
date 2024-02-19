// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mostrar la serie o pelicula y la categoria");
Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese el nombre de la serie de películas " + i + ":");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la categoría de la serie de películas " + i + ":");
    string categoria = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Datos de la serie de películas " + i + ":");
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Categoría: " + categoria);
    Console.WriteLine();
}
   






