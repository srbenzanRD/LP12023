var numeros = new List<int>()
{1,2,3,40,5,6,7,8,9,100};
var arreglo = new int[10]{1,2,3,4,5,6,7,8,9,10};
//PARA N = 1 HASTA 10 CON PASO 1
//INICIO;HASTA;PASO i = i + 1
//Recorrer una lista en si misma
numeros.ForEach(numero=>{ 
    Console.WriteLine($"Valor: {numero}");
  });
//Recorrer cada elemento de la lista con FOREACH
foreach(int numero in numeros){
    Console.WriteLine($"Valor: {numero}");
}
//Recorrer cada elemento de la lista con FOR
for(int i = 0;i<numeros.Count;i++ ){
    //Bloque de codigo
    Console.WriteLine($"Valor: {numeros[i]}");
}
