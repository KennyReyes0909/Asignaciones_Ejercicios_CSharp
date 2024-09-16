// See https://aka.ms/new-console-template for more information
Console.WriteLine("ejercicio25!");

Console.WriteLine("Ingrese la edad de la persona (o deje en blanco para nulo):");
string entrada = Console.ReadLine();

int? edad = null;
if (!string.IsNullOrEmpty(entrada))
{
    int edadInt;
    if (int.TryParse(entrada, out edadInt))
    {
        edad = edadInt;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
    }
}
if (edad.HasValue)
{
    Console.WriteLine($"La edad ingresada es: {edad}");
}
else
{
    Console.WriteLine("No se ingresó una edad válida.");
}
