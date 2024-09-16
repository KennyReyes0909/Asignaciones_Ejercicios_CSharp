// See https://aka.ms/new-console-template for more information
Console.WriteLine("ejercicio4");
Console.WriteLine("Escribir Numero Entero");
int numero  = int.Parse(Console.ReadLine());
decimal numeroDecimal = (decimal)numero / 10;

Console.WriteLine("Convertido a decimal" +  numeroDecimal);

int numeroconvertido = (int)numeroDecimal;
Console.WriteLine("converido nuevamente a entero" + numeroconvertido);
