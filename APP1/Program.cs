// See https://aka.ms/new-console-template for more information
using APP1;
int N1 = 2;
decimal N2 = 5.2m;
decimal D = (N2/N1);

Persona persona = new Persona();
Console.WriteLine("Cual es su nombre: ");
persona.Nombre = Console.ReadLine()!;
Console.WriteLine("Cual es su apellido: ");
persona.Apellido = Console.ReadLine()!;
Console.WriteLine("Hola "+ persona.NombreCompleto());