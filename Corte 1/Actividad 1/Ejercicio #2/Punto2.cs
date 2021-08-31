using System;
public class Punto2
//Creado por : Juan David Ropero
//Grupo:239-2A
//Turno:Diario
{
 public static void Main(string[] args)
 { 
 int Pel1;
 int Pel2;
 int Pel3;
 int Op1;
 int Op2;
 int Op3;
 Console.Write("Ingrese el primer precio ");
 Pel1 = int.Parse(Console.ReadLine());
 Console.Write("Ingrese el segundo precio ");
 Pel2 = int.Parse(Console.ReadLine());
 Console.Write("Ingrese el tercer precio ");
 Pel3 = int.Parse(Console.ReadLine());
 
 if (Pel1 > Pel2 && Pel1 > Pel3)
 {
 Op1 = Pel2 + Pel3;
 Console.WriteLine("La promoción es {0} ", Op1);
 }
 
 else if (Pel2 > Pel1 && Pel2 > Pel3)
 {
 Op2 = Pel1 + Pel3;
 Console.WriteLine("El precio de la promoción es {0}", Op2);
 }
 else
 {
 Op3 = Pel2 + Pel1;
 Console.WriteLine("El precio de la promoción es {0}", Op3);
 }
 
 }
}