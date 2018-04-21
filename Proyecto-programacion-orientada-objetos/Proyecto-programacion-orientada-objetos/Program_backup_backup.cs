using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Program_backup_backup
  {
    /* static void Main(string[] args)
     {
       Console.BackgroundColor = ConsoleColor.Black;
       ConsoleColor color = Console.ForegroundColor;
       Console.ForegroundColor = ConsoleColor.Red;
       Console.WriteLine("\tMódulo de talleres de la Universiad de los Andes\n");

       int opcion = 0;
       List<Sistema> universidades = new List<Sistema>();

       while (true)
       {
         opcion = SeleccionaOpcion(GeneraOpciones());

         switch (opcion)
         {
           case -1:
             // Salir
             return;
           case 2:
             //
             break;
         }
       }
     }

     static public int SeleccionaOpcion(Dictionary<int, String> opcionesValidas)
     {
       int opcion = 0, cnt = 0;
       while (true)
       {
         if (cnt > 0)
         {
           Console.Beep();
           ConsoleColor colour = Console.ForegroundColor;
           Console.WriteLine("Opción ingresada no es válida, por favor intente nuevamente.");
           Console.ForegroundColor = colour;
         }
         ConsoleColor color = Console.ForegroundColor;
         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("\n****Menu Principal****\n");
         Console.ForegroundColor = color;
         Console.WriteLine("Seleccione una de las siguientes opciones:");
         ImprimeMenu(opcionesValidas);
         Console.Write("Opcion: ");
         // Lee la opcion del teclado
         try
         {
           Int32.TryParse(Console.ReadLine(), out opcion);
         }
         catch
         {
           // opcion sigue siendo 0, por lo que se va a repetir el ciclo diciendo que la opcion no es valida.
         }

         // Valida si es una opcion valida
         if (opcionesValidas.ContainsKey(opcion))
           break;
         else
           cnt++;
       }
       return opcion;
     }

     static public Dictionary<int, String> GeneraOpciones(){
       Dictionary<int, String> opcionesValidas = new Dictionary<int, string>();
       opcionesValidas.Add(-1, "Salir");
       opcionesValidas.Add(0, "Crear una Universidad");
       opcionesValidas.Add(1, "Crear un taller");
       //opcionesValidas.Add();
       return opcionesValidas;
     }

     static public void ImprimeMenu(Dictionary<int, String> opcionesValidas){
       foreach (KeyValuePair<int, String> kvp in opcionesValidas)
       {
         Console.WriteLine(kvp.Key + ": " + kvp.Value);
       }
     }*/
  }
}
