// See https://aka.ms/new-console-template for more information
Console.WriteLine("ejercicio10");

Console.WriteLine("Escirbir oracion");
string oracion = Console.ReadLine();
int contador = 0;

for (int i = 0; i < oracion.Length; i++)
{
    if (oracion[i] == 'a' || oracion[i] == 'e' || oracion[i] == 'i' || oracion[i] == 'o' || oracion[i] == 'u')
    {  contador++; }
}
Console.WriteLine("la catidad de vocales: " + contador);