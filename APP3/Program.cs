/*
Desarrollar un algoritmo que permita guardar 
estudiantes en una lista.
Criterios a almacenar (Matricula, Nombre, 
Año de Nacimiento...)
SOLO GUARDAR
*/
using APP3.Models;
var autos = new List<Vehiculo>(){
    new Vehiculo(){Marca = "Honda",    Modelo = "Civic",    Matricula = "EsoNoSeDa"},
    new Vehiculo(){Marca = "Honda",    Modelo = "CRV",    Matricula = "EsoNoSeDa2"}
};
/*
Console.WriteLine("Que deseas realizar:\n[1] Encender\n[2] Apagar");
var accion = Console.ReadLine();
if(accion == "1") auto.Encender();
else auto.Apagar();
*/
autos.ForEach(auto=>{ auto.Encender(); });