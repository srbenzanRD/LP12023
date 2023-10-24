// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa un valor");
string valor_dado_por_usuario = Console.ReadLine();
// 22.5.6
var a_convertir ="0";
var punto = ',';
int puntos = 0;
foreach (char letra in valor_dado_por_usuario)
{
    if(char.IsDigit(letra) || (letra == punto && puntos == 0)) {
        if(letra == punto) puntos++;
        a_convertir += letra;
    }
}
double.TryParse(a_convertir,out double );
Console.WriteLine($"Cometiste un error en darme tu numero: {a_convertir}");

