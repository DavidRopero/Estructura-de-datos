using System;
//Creado por : Juan David Ropero
//Grupo:239-2ª
//Turno:Diario
public class Punto8
{
public static void Main()
{
char c;
Console.Write("escriba una letra ");
c = char.Parse(Console.ReadLine());
if (char.IsLower(c))
{
Console.WriteLine("La letra es minuscula.");
}
if (char.IsUpper(c))
{
Console.WriteLine("La letra es mayuscula.");
}
if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' ||
c == 'E' || c == 'I' || c == 'O' || c == 'U')
{
Console.WriteLine("Es una vocal.");
}
}
}