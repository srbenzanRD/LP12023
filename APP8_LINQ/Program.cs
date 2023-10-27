/*EL dia de hoy estaremos trabajando con LINQ y el manejo 
de colecciones de datos (Partiendo desde el concepto de la programacion 
orientada a objetos)
 */
 using System.Collections;
 using System.Threading.Tasks;

 namespace APP8_LINQ;
 
internal class Program
{
    public static List<Producto> Productos { get; set; } = new List<Producto>();
    private static void Main(string[] args)
    {
        Productos = new List<Producto>();
        while(true){
            Console.WriteLine("Inventario de productos");
        //Declaro mi coleccion de datos de tipo Producto
        //Presentarle opciones al usuario asi:
        var opcion = MostrarMenu(); 
        switch(opcion){
            case Opciones.Salir: return;
            case Opciones.MostrarProductos: MostrarProductos(); break;
            case Opciones.RegistrarProductos: CrearProducto(); break;
            case Opciones.EliminarProductos: EliminarProducto(); break;
            case Opciones.BuscarProductos: BuscarProducto(); break;
            default: Console.WriteLine("Operacion no solortada"); break;
        }
        //[B] Buscar  Producto
        //[X] Salir
        }
    }
    public static async Task LimpiarConsola(){
        for(int tiempo = 3; tiempo>0; tiempo--)
        {
            Console.WriteLine($"({tiempo}s) para limpiar la pantalla...");
            await Task.Delay(1000);
        }
        Console.WriteLine("--------------------------------------------------------");

    }
    private static string? MostrarMenu()
    {
        Console.WriteLine("Seleccione una opcion [M, +, -, B, X]:");
        Console.WriteLine("[M] Mostrar Productos");
        Console.WriteLine("[+] Agregar Producto");
        Console.WriteLine("[-] Eliminar Producto");
        Console.WriteLine("[B] Buscar Producto");
        Console.WriteLine("[X] Salir");
        Console.WriteLine("Que elijes: ");
        return Console.ReadLine();
    }
    private static async void CrearProducto()
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
        Productos.Add(producto);
        Console.WriteLine("✅ Agregado exitosamente");
        
        LimpiarConsola().Wait();
    }
    private static void MostrarProductos(){
         Console.WriteLine($"Hola actualmente hay ({Productos.Count}) productos registrados:");
        int posicion = 0;
        foreach(var producto in Productos){
            posicion++;
            Console.WriteLine($"{posicion}) {producto.Informacion}");
        }
    }
    private static void EliminarProducto()
    {
        Console.WriteLine("Que producto deseas eliminar? Selecciona un indice: ");
        MostrarProductos();
        int.TryParse(Console.ReadLine(),out int indice);
        indice--;
        if(indice>-1 && Productos.Count>0)
        {
            Productos.RemoveAt(indice);
            Console.WriteLine("✅ Eliminado exitosamente...");
        }
        else if(Productos.Count == 0)
            Console.WriteLine("No existe producros que puedas eliminar... 😒");
        else Console.WriteLine("No encontre el producto... 😅");
    
        LimpiarConsola().Wait();
    }
    //Uso de LINQ para realizar busquedas
    private static void BuscarProducto()
    {
        Console.WriteLine("Que estas buscando: ");
        var filtro = Console.ReadLine();
        var ProductosEncontrados =
        Productos
        .Where
        (
            p //P representa el Producto (objeto) en la Lista (List)
        => 
            p.Codigo.Contains(filtro) ||
            p.Nombre.Contains(filtro) 
        )
        .ToList();
        Console.WriteLine($"Existe ({ProductosEncontrados.Count}) segun la busqueda...");+
    }

}
public class Opciones
{
    public const string MostrarProductos    = "M";
    public const string RegistrarProductos  = "+";
    public const string EliminarProductos   = "-";
    public const string BuscarProductos     = "B";
    public const string Salir               = "X";
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