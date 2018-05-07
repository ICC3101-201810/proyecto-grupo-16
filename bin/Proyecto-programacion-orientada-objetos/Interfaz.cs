using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_2
{
  class Interfaz
  {
    //List<String> studentsMenu = new List<String>() { "Mostrar talleres Disponibles", "Incribir Taller", "Ver Talleres Inscritos", "Salir" };
    //List<String> studentsSubMenuListWs = new List<String>() { "Seleccionar Taller", "Eliminar Taller", "Volver a Menu" };
    //List<String> studentsSubMenuWs = new List<String>() { "Ver Foros", "Ver Encuesta", "Volver a Lista Talleres" };
    //List<String> studentsSubMenuForum = new List<String>() { "Enviar Mensaje", "Volver a Taller" };
    //List<String> studentsSubMenuEnc = new List<String>() { "Responder Encuesta", "Volver a Taller" };
    //List<Boolean> studentOption = new List<Boolean>() { false, false, false ,false };

    public Interfaz() { }

    public List<String> LogInLogOut()
    {
      List<String> credenciales = new List<string>();
      Console.BackgroundColor = ConsoleColor.Black;
      RedColorConsole("\tMódulo de talleres de la Universidad de los Andes\n");
      GreenColorConsole("Inicio de Sesión\n");
      WhiteColorConsole("Ingrese Usuario: ");
      credenciales.Add(Console.ReadLine());
      WhiteColorConsole("Ingrese contraseña: ");
      credenciales.Add(Console.ReadLine());
      return credenciales;
    }
    public void ErrorCredenciales(Boolean verifyUser)
    {
      if (!verifyUser) ErrorColorConsole("\tERROR: Usuario/Contraseña Incorrecta\n");
    }

    public List<Boolean> StudentsMenu(List<String> studentsMenu, List<Boolean> studentsOption)
    {
      int i = 1;
      for (int j = 0; j < studentsOption.Count; j++) studentsOption[j] = false;
      RedColorConsole("\tMenu Estudiante\n");
      GreenColorConsole("Seleccione Opcion:\n");
      foreach (String index in studentsMenu) WhiteColorConsole("(" + (i++) + ") " + index);
      studentsOption[Int32.Parse(Console.ReadLine()) - 1] = true;
      return studentsOption;
    }
    public List<Boolean> TeachersMenu(List<String> teachersMenu, List<Boolean> teachersOption)
    {
      int i = 1;
      for (int j = 0; j < teachersOption.Count; j++) teachersOption[j] = false;
      RedColorConsole("\tMenu Profesor\n");
      GreenColorConsole("Seleccione Opcion:\n");
      foreach (String index in teachersMenu) WhiteColorConsole("(" + (i++) + ") " + index);
      teachersOption[Int32.Parse(Console.ReadLine()) - 1] = true;
      return teachersOption;

    }
    public void ShowWS(Taller ws, List<String> bloques)
    {
            string schedule = "";
            GreenColorConsole("\nTaller: " + ws.nombre+"\n");

            foreach (String day in ws.GetHorario().Keys)
                for (int i=0; i< ws.GetHorario()[day].Count; i++)
                    if (ws.GetHorario()[day][i]) schedule = String.Concat(schedule, "| ",day+": "+ bloques[i]);
            WhiteColorConsole("Horario: " + schedule + "\n");
            WhiteColorConsole("Cupos Disponibles: "+ws.GetCuposDisponibles().ToString());
            WhiteColorConsole("Encuestas: "+ws.GetEncuestas().Count);
            WhiteColorConsole("Foros: " + ws.GetForos().Count+"\n");
        }

    public void ShowStudentWS(List<Taller> talleres)
    {
      int i = 1;
      GreenColorConsole("\nTalleres Inscritos:\n");
      foreach (Taller ws in talleres) WhiteColorConsole("(" + (i++) + ") " + ws.nombre);
      WhiteColorConsole("\n");
    }



    public void WorkShopAvailable(Dictionary<Taller, List<String>> wsAvaliable)
    {
      int i = 1;
      String schedule = "";
            if (wsAvaliable.Count > 0)
            {
                GreenColorConsole("\nTalleres Disponibles:\n");
                foreach (Taller ws in wsAvaliable.Keys)
                {
                    foreach (String blocks in wsAvaliable[ws]) schedule = String.Concat(schedule, "| ", blocks);
                    WhiteColorConsole("(" + (i++) + ") " + ws.nombre + ", Horario: " + schedule + "\n");
                }
            }
            else ErrorColorConsole("\nERROR: No existen talleres en horario disponible.\n");
    }
    public void MostrarTalleres(List<Taller> talleres)
    {
      int i=1;
      foreach(Taller t in talleres)
      {
        Console.WriteLine("({0}){1}", i,t.nombre);
        i += 1;
      }
        
    }


    public void RedColorConsole(String s)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(s);
      Console.ResetColor();
      Console.BackgroundColor = ConsoleColor.Black;
    }
    public void WhiteColorConsole(String s)
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(s);
      Console.ResetColor();
      Console.BackgroundColor = ConsoleColor.Black;
    }
    public void GreenColorConsole(String s)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(s);
      Console.ResetColor();
      Console.BackgroundColor = ConsoleColor.Black;
    }
    public void ErrorColorConsole(String s)
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.Red;
      Console.WriteLine(s);
      Console.Beep();
      Console.Beep();
      Console.ResetColor();
      Console.BackgroundColor = ConsoleColor.Black;
    }
    public void SuccesColorConsole(String s)
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine(s);
      Console.Beep();
      Console.ResetColor();
      Console.BackgroundColor = ConsoleColor.Black;
    }
  }
}
