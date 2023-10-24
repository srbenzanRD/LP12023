using System;

Console.WriteLine("Hola como estas?\n[B]Bien\n[M]Mal :");
var estado = Console.ReadLine();
var mensaje =                                   //Asignacion
    estado?.ToUpper() == "B" ?                  //Condicion logica
    "Me alegra saber, que te encuentras bien!"  //Verdadero
    :
    "Fran presta dinero, alegrate!";            //Falso

Console.WriteLine(mensaje);