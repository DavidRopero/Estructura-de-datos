using System;
//Creado por : Juan David Ropero
//Grupo:239-2ª
//Turno:Diario
 
 
public class Punto5
{
 public static void Main()
 {
 double num = 0;
 string val = "";
 double raiz = 0;
 Console.WriteLine("ingresa el numero para sacar su raiz cuadrada");
 val = Console.ReadLine();
 num = Convert.ToDouble(val);
 raiz=Math.Sqrt(num);
 Console.WriteLine("el resultado es {0}", raiz);
 }
}
