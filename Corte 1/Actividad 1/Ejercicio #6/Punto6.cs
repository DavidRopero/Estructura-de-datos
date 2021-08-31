using System;
//Creado por : Juan David Ropero
//Grupo:239-2ª
//Turno:Diario
 
 
public class Punto6
{
 public static void Main()
 {
 
 string seg;
 double seg1;
 double dias;
 double horas;
 double mins;
 Console.WriteLine("ingresa el numero en segundos para convertirlos a dias, horas y minutos ");
 seg = Console.ReadLine();
 seg1= Convert.ToDouble(seg);
 mins= seg1 / 60;
 horas= mins / 60;
 dias= horas / 24;
 Console.WriteLine(" Los segundos ingresados en segundos son {0} minutos,{1} horas y {2} dias", mins, horas, dias);
 }
}
