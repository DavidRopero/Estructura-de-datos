using System;
//Creado por : Juan David Ropero
//Grupo:239-2ª
//Turno:Diario
 
public class Punto4
{
 public static void Main()
 {
 int a, b;
 Console.WriteLine("escribe un numero");
 a = int.Parse(Console.ReadLine());
 b=a;
 if (a == 1)
 {
 Console.WriteLine("el primer valor es 1");
 
 }
 else
 {
 Console.WriteLine("el resultado es");
 
 
 while (b > 1)
 
 {
 if (b % 2 == 0)
 
 
 {
 b = (b / 2);
 Console.WriteLine("{0}", b);
 
 }
 else
 {
 b = (b * 3) + 1;
 Console.WriteLine("{0}", b);
 }
 }
 }
 }
}