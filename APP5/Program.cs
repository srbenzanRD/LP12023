//Sentencias de deciciones
//IF (IF-ELSE), SWITCH()
//Console.WriteLine("TEXTO AQUÍ!");
int A = 1 ,B = 2 ,C = 3;
Console.WriteLine($"{A}, {B}, {C}");
if(!(A != B)) B = 4;
else if(!(C == 3)) A = 0;
if(!(B==2)) A = 5;
else C = 4;
Console.ReadKey();
Console.WriteLine($"{A}, {B}, {C}");