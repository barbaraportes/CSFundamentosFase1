Console.WriteLine("## Nullable Types ##\n");

//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

//forma simplificada
int? a = null;
int b = a ?? 0;
//operador de coalescencia nula
//se a = null > atribui 0
//se a != null > atribui valor de a
Console.WriteLine(b);

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

//propriedades somente leitura usadas para examinar e obter valor de nullable type: HasValue e Value

int? exemplo = 100;
if(exemplo.HasValue)
{
    Console.WriteLine($"valor do exemplo = {exemplo.Value}");
}
else
{
    Console.WriteLine("exemplo não possui valor (null)");
}


Console.ReadKey();
