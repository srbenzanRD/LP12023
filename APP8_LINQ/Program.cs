/*EL dia de hoy estaremos trabajando con LINQ y el manejo 
de colecciones de datos (Partiendo desde el concepto de la programacion 
orientada a objetos)
 */
 using System.Collections;

 namespace APP8_LINQ;
 
internal class Program
{
    private static void Main(string[] args)
    {
        //Declaro mi coleccion de datos de tipo Producto
        var productos = new List<Producto>();
        //Genero mi primero producto
        var producto = CrearProducto();
        //Agrego mi primer producto a la lista de productos
        productos.Add(producto);

        Console.WriteLine($"Hola actualmente hay ({productos.Count}) productos registrados");
        MostrarProductos(productos);
    }

    private static Producto CrearProducto()
    {
        //Declaro la variable para el producto
        var producto = new Producto();
        //Solicitar el codigo
        CODIGO:
        Console.WriteLine("Cual es el código del producto: ");
        var codigo = Console.ReadLine();
        if(codigo!=null) producto.Codigo = codigo;
        else {
            Console.WriteLine($"Usted no ingresó el codigo, favor intente de nuevo...");
            goto CODIGO;
        }
        //Solicitar el nombre
        NOMBRE:
        Console.WriteLine($"Cual es el nombre del producto ({producto.Codigo}): ");
        var nombre = Console.ReadLine();
        if(nombre != null) producto.Nombre = nombre;
        else {
            Console.WriteLine($"Usted no ingresó el nombre, favor intente de nuevo...");
            goto NOMBRE;
        }
        //Solicitar el precio
        PRECIO:
        Console.WriteLine($"Cual es el precio del producto ({producto.Codigo} - {producto.Nombre}): ");
        if(decimal.TryParse(Console.ReadLine(),out decimal precio)){
            producto.Precio = precio;
        }
        else //No fue posible convertir el precio, favor intente de nuevo
        {
            Console.WriteLine($"No fue posible convertir el precio, favor intente de nuevo...");
            goto PRECIO;
        }
        //Retornar el producto que acabo de crear...
        return producto;
    }
    private static void MostrarProductos(List<Producto> data){
        foreach(var producto in data){
            Console.WriteLine(producto.Informacion);
        }
    }
}

public class Producto
{
    //Columnas
    #region Propiedades 
    public string Codigo { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public decimal Precio { get; set; }
    #endregion
    #region  Metodos
    public string Informacion => $"({Codigo}) {Nombre} [${Precio.ToString("N2")}]";
    #endregion
}