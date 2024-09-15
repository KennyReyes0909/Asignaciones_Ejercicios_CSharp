// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.WriteLine("ejercicio2");
Console.WriteLine("");
double cantidad1;
double cantidad2;
string operacion;
double resultado;

Console.WriteLine("opercion a realizar");
Console.WriteLine("suma");
Console.WriteLine("resta") ;
Console.WriteLine("multiplicacion");
Console.WriteLine("division");

operacion= Console.ReadLine();

Console.WriteLine("cantida1");
cantidad1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("cantida2");
cantidad2 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

if (operacion == "suma")

{ 
    resultado = cantidad1 + cantidad2;
    Console.WriteLine("el resultado es:" + resultado);
    Console.ReadLine();

}
if (operacion == "resta")

{
    resultado = cantidad1 - cantidad2;
    Console.WriteLine("el resultado es:" + resultado);
    Console.ReadLine();

}
if (operacion == "division")

{
    resultado = cantidad1 / cantidad2;
    Console.WriteLine("el resultado es:" + resultado);
    Console.ReadLine();

}
if (operacion == "multiplicacion")

{
    resultado = cantidad1 * cantidad2;
    Console.WriteLine("el resultado es:" + resultado);
    Console.ReadLine();

}
