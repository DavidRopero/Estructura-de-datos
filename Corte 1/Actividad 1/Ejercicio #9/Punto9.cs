using System;
//Creado por : Juan David Ropero
//Grupo:239-2ª
//Turno:Diario
 
public class Punto9
{
 public static void Main(string[] args)
 { 
 int año1;
 double res1;
 double res2;
 Console.Write("Ingrese la edad el perro en años ");
 año1 = int.Parse(Console.ReadLine());
 
 if (año1 <= 2 )
 {
 res1 = 10.5 * año1;
 Console.WriteLine("La edad del perro es {0} ", res1);
 }
 
 else if (año1>=3)
 {
 res2 = 21 + ((año1 - 2)*4);
 Console.WriteLine("La edad del perro es {0}", res2);
 }
 
 
 }
}