//using System;

namespace APP3.Models;

public class Vehiculo{
    public string Matricula { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public void Encender()
    {
        Console.WriteLine($"Se ha encendido el vehículo el {Marca} {Modelo} matricula {Matricula}.");
    }
    public void Apagar()
    {
        Console.WriteLine($"Se ha apagado el vehículo el {Marca} {Modelo} matricula {Matricula}.");
    }
}