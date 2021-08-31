using System;
//Creado por : Juan David Ropero
//Grupo:239-2A
//Turno:Diario
public class Punto1
{
 public static void Main(string[] args)
 {
 Console.WriteLine("Escriba el numero para saber su valor absoluto");
 int x = Convert.ToInt32(Console.ReadLine());
 int num;
 if (x < 0)
 {
 num = -x;
 }
 else
 {
 num = x;
 }
 Console.WriteLine("El valor absoluto es {0}", num);
 }
}