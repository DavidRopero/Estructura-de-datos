using System;
public class Punto3
//Creado por : Juan David Ropero
//Grupo:239-2A
//Turno:Diario
{
 public static void Main(string[] args)
 { 
 int nota1;
 int nota2;
 int nota3;
 int nota4;
 int res1;
 int res2;
 Console.Write("Ingrese la primera nota ");
 nota1 = int.Parse(Console.ReadLine());
 Console.Write("Ingrese la segunda nota ");
 nota2 = int.Parse(Console.ReadLine());
 Console.Write("Ingrese la tercera nota ");
 nota3 = int.Parse(Console.ReadLine());
 Console.Write("Ingrese la cuarta nota ");
 nota4 = int.Parse(Console.ReadLine());
 
 res1 = nota1 + nota2 + nota3 + nota4 ;
 res2 = res1/4;
 Console.WriteLine("el promedio de las notas es {0} ",res2);
 
 if (nota1 > nota2 && nota1 > nota3 && nota1 > nota4)
 {
 Console.WriteLine("la nota mas alta es {0} ", nota1);
 }
 
 if (nota2 > nota1 && nota2 > nota3 && nota2 > nota4)
 {
 Console.WriteLine("la nota mas alta es {0} ", nota2);
 }
 if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
 {
 Console.WriteLine("la nota mas alta es {0}", nota3);
 }
 if (nota4 > nota1 && nota4 > nota2 && nota4 > nota3)
 {
 Console.WriteLine("la nota mas alta es {0} ", nota4);
 }
 if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4)
 {
 Console.WriteLine("la nota mas baja es {0} ", nota1);
 }
 if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
 {
 Console.WriteLine("la nota mas baja es {0} ", nota2);
 }
 if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
 {
 Console.WriteLine("la nota mas baja es {0}", nota3);
 }
 if (nota4 < nota1 && nota4 < nota2 && nota4 < nota3)
 {
 Console.WriteLine("la nota mas baja es {0} ", nota4);
 }
 }
}