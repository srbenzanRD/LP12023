namespace APP1;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; internal set; }

    public string NombreCompleto(){
        return Nombre + " " + Apellido;
    }
}