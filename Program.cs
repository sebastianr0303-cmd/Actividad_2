Console.WriteLine("Inicio del Programa");

//VARIABLES
int Valor, i=1;



Console.WriteLine("\nDigite un numero entero positivo:");
Valor = Convert.ToInt32(Console.ReadLine());

while (i <= Valor)
{
    Console.WriteLine($"\n{i}");
    i++;
}
