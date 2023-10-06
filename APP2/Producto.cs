namespace APP2;

public class Producto
{
    public string Nombre { get; set; } = null!;
    public float Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal SubTotal => (decimal)Cantidad * Precio;
    public override string ToString()
    {
        //2.00x - Jamon -> $250
        return $"{Cantidad.ToString("N2")}x - {Nombre} -> ${Precio.ToString("N2")} ({SubTotal.ToString("N2")})";
    }
}