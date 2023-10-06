using APP2;
using System.Collections.Generic;

List<Producto> productos = new List<Producto>();
Producto producto = new Producto();
Console.WriteLine("Vamos a agregar un producto");
Console.WriteLine("Cual es el nombre: ");
producto.Nombre = Console.ReadLine()!;
Console.WriteLine("Que cantidad posee: ");
producto.Cantidad = float.Parse(Console.ReadLine()!);
Console.WriteLine("Cual es el precio: ");
producto.Precio = decimal.Parse(Console.ReadLine()!);
productos.Add(producto);
Console.WriteLine(producto);
productos.Remove(producto);