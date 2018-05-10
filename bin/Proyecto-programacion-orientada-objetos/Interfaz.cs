﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entrega_2
{
  class Interfaz
  {
    /*
    public Interfaz() { }

    public List<String> LogInLogOut()
    {
        //List<String> studentsMenu = new List<String>() { "Mostrar talleres Disponibles", "Incribir Taller", "Ver Talleres Inscritos", "Salir" };
        //List<String> studentsSubMenuListWs = new List<String>() { "Seleccionar Taller", "Eliminar Taller", "Volver a Menu" };
        //List<String> studentsSubMenuWs = new List<String>() { "Ver Foros", "Ver Encuesta", "Volver a Lista Talleres" };
        //List<String> studentsSubMenuForum = new List<String>() { "Enviar Mensaje", "Volver a Taller" };
        //List<String> studentsSubMenuEnc = new List<String>() { "Responder Encuesta", "Volver a Taller" };
        //List<Boolean> studentOption = new List<Boolean>() { false, false, false ,false };
  ////// professor
  */
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
    /*
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
        GreenColorConsole("\nTaller: " + ws.nombre + "\n");

        foreach (String day in ws.GetHorario().Keys)
            for (int i = 0; i < ws.GetHorario()[day].Count; i++)
                if (ws.GetHorario()[day][i]) schedule = String.Concat(schedule, "| ", day + ": " + bloques[i]);
        WhiteColorConsole("Horario: " + schedule + "\n");
        WhiteColorConsole("Cupos Disponibles: " + ws.GetCuposDisponibles().ToString());
        WhiteColorConsole("Encuestas: " + ws.GetEncuestas().Count);
        WhiteColorConsole("Foros: " + ws.GetForos().Count + "\n");
    }
    */
    //////// merge
    public int StudentsMenu(List<String> studentsMenu)
    {
      int i = 1;
      int option = 0;
      RedColorConsole("\n\tMenu Estudiante\n");
      GreenColorConsole("Seleccione Opcion:\n");
      if (studentsMenu.Count > 1)
        foreach (String index in studentsMenu) WhiteColorConsole("(" + (i++) + ") " + index);
      else
        WhiteColorConsole(studentsMenu[0]);
      while (!Int32.TryParse(Console.ReadLine(), out option))
      {
        ErrorColorConsole("Ingrese opcion valida\n");
        WhiteColorConsole(studentsMenu[0]);
      }
      return option - 1;
    }
    public int AdminsMenu(List<String> adminsMenu)
    {
      int i = 1;
      RedColorConsole("\tMenu Administrador\n");
      GreenColorConsole("Seleccione Opcion:\n");
      foreach (String index in adminsMenu) WhiteColorConsole("(" + (i++) + ") " + index);
      return Int32.Parse(Console.ReadLine()) - 1;
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
      GreenColorConsole("\nTaller: " + ws.nombre + "\n");

      foreach (String day in ws.GetHorario().Keys)
        for (int i = 0; i < ws.GetHorario()[day].Count; i++)
          if (ws.GetHorario()[day][i]) schedule = String.Concat(schedule, "| ", day + ": " + bloques[i]);
      WhiteColorConsole("Horario: " + schedule + "\n");
      WhiteColorConsole("Cupos Disponibles: " + ws.GetCuposDisponibles().ToString());
      //WhiteColorConsole("Encuestas: "+ws.GetEncuestas().Count);
      WhiteColorConsole("Foros: " + ws.GetForos().Count + "\n");
    }
    //////// end conflict

    public void ShowStudentWS(List<Taller> talleres)
    {
      int i = 1;
      GreenColorConsole("\nTalleres Inscritos:\n");
      foreach (Taller ws in talleres) WhiteColorConsole("(" + (i++) + ") " + ws.nombre);
      WhiteColorConsole("\n");
    }
    ////// professor
    /*
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
              int i = 1;
              foreach (Taller t in talleres)
              {
                  Console.WriteLine("({0}){1}", i, t.nombre);
                  i += 1;
              }

          }
          */
    public void MostrarForos(Taller taller)
    {
      string head = "Foros del taller " + taller.nombre.ToString();
      GreenColorConsole(head);
      List<Foro> foros = taller.GetForos();
      int i = 1;
      foreach (Foro foro in foros)
      {
        Console.WriteLine("({0}){1}", i, foro.tema);
        i += 1;

      }
    }
    public void LeerForo(Foro foro)
    {
      string head = "Mensajes del foro " + foro.tema.ToString();
      GreenColorConsole(head);
      List<Mensaje> mensajes = foro.GetMensajes();
      int i = 1;
      foreach (Mensaje mensaje in mensajes)
      {
        Console.WriteLine("({4})|{0},{1}:{2}|:{3}", mensaje.fecha.ToShortDateString(), mensaje.fecha.Hour, mensaje.fecha.Minute, mensaje.texto, i);
        i += 1;
      }
    }

    public string PedirTextoMensaje()
    {
      Console.WriteLine("Escriba aquí su mensaje:");
      string texto = Console.ReadLine();
      return texto;
    }
    public string PedirForo()
    {
      Console.WriteLine("Tema del Foro:");
      string tema = Console.ReadLine();
      return tema;
    }
    public void MostrarParticipantes(List<Alumno> alumnos, Taller taller)
    {
      List<Alumno> inscritos = new List<Alumno>();
      string nombreTaller = taller.nombre;
      foreach (Alumno a in alumnos)
      {
        foreach (Taller t in a.talleresInscritos)
        {
          if (t.nombre == nombreTaller)
          {
            inscritos.Add(a);
          }
        }

      }
      Console.WriteLine("Participantes del Taller {0}", nombreTaller);
      foreach (Alumno a in inscritos)
      {
        Console.WriteLine("| {0} {1} | {2}", a.nombre, a.apellido, a.email);
      }
    }


    //// merge        
    public void WorkShopAvailable(Dictionary<Taller, List<String>> wsAvaliable)
    {
      int i = 1;
      String schedule = "";
      if (wsAvaliable.Count > 0)
      {
        GreenColorConsole("\nTalleres Disponibles:\n");
        foreach (Taller ws in wsAvaliable.Keys)
        {
          schedule = "";
          foreach (String blocks in wsAvaliable[ws]) schedule = String.Concat(schedule, "| ", blocks);
          WhiteColorConsole("(" + (i++) + ") " + ws.nombre + ", Horario: " + schedule + "\n");
        }
      }
      else ErrorColorConsole("\nERROR: No existen talleres en horario disponible.\n");
    }
    public void MostrarTalleres(List<Taller> talleres)
    {
      int i = 1;
      foreach (Taller ws in talleres)
      {
        WhiteColorConsole("(" + (i++) + ") " + ws.nombre);// + ", Horario: " + schedule + "\n");
      }
    }

    public void MostrarAlumnos(List<Alumno> alumnos)
    {
      for (int i = 0; i < alumnos.Count; i++)
        WhiteColorConsole("(" + (i + 1) + ") " + alumnos[i].GetApellido() + ", " + alumnos[i].GetNombre());
    }

    public void MostrarProfesores(List<Profesor> profesores)
    {
      int i = 0;
      foreach (Profesor p in profesores)
      {
        WhiteColorConsole("(" + (i + 1) + ") " + p.GetApellido() + ", " + p.GetNombre());
        i++;
      }
    }

    public void AdminMostrarTalleres(List<Taller> talleres)
    {
      GreenColorConsole("\nTalleres:\n");
      MostrarTalleres(talleres);
    }

    public int AdminEliminarTaller(List<Taller> talleres)
    {
      GreenColorConsole("\nSeleccione el taller a eliminar\n");
      MostrarTalleres(talleres);
      return Int32.Parse(Console.ReadLine());
    }

    public void AdminMostrarProfesores(List<Profesor> profesores)
    {
      GreenColorConsole("\nProfesores vigentes:\n");
      MostrarProfesores(profesores);
    }

    public void AdminMostrarAlumnos(List<Alumno> alumnos)
    {
      GreenColorConsole("\nAlumnos vigentes:\n");
      MostrarAlumnos(alumnos);
    }

    public int AdminEliminarAlumno(List<Alumno> alumnos)
    {
      GreenColorConsole("\nSeleccione el alumno a eliminar\n");
      MostrarAlumnos(alumnos);
      return Int32.Parse(Console.ReadLine());
    }

    public Taller AgregarTaller(Sala sala)
    {
      GreenColorConsole("\nAgregar Taller:\n");
      WhiteColorConsole("Ingrese el nombre del taller: ");
      String nombre = Console.ReadLine();
      WhiteColorConsole("Ingrese la cantidad de cupos: ");
      int cupos = Int32.Parse(Console.ReadLine());
      WhiteColorConsole("Ingrese el precio (sin decimales): ");
      int precio = Int32.Parse(Console.ReadLine());
      Dictionary<String, List<Boolean>> horario = GenerarHorario(0.95);
      return new Taller(nombre, cupos, precio, horario, sala, new Categoria());
    }

    public int AdminEliminarProfesor(List<Profesor> profesores)
    {
      GreenColorConsole("\nSelecione el profesor a eliminar\n");
      MostrarProfesores(profesores);
      return Int32.Parse(Console.ReadLine());
    }

    public Sala AdminAgregarSala()
    {
      GreenColorConsole("\nAgregar Sala\n");
      WhiteColorConsole("Ingrese el nombre de la sala: ");
      String nombre = Console.ReadLine();
      return new Sala(nombre, GenerarHorario(0.75));
    }

    public Alumno AdminAgregarAlumno()
    {
      GreenColorConsole("\nAgregar alumno\n");
      //Alumno alumno1 = new Alumno("18884427-8", "Israel", "Cea", "i@m.cl", "+56999404286", "1234", scheduleb);
      WhiteColorConsole("Ingrese el rut: ");
      String rut = Console.ReadLine();
      WhiteColorConsole("Ingrese el nombre: ");
      String nombre = Console.ReadLine();
      WhiteColorConsole("Ingrese el apellido: ");
      String apellido = Console.ReadLine();
      WhiteColorConsole("Ingrese el mail: ");
      String mail = Console.ReadLine();
      WhiteColorConsole("Ingrese el teléfono: ");
      String telefono = Console.ReadLine();
      WhiteColorConsole("Ingrese la clave de acceso: ");
      String clave = Console.ReadLine();
      Dictionary<String, List<Boolean>> horario = GenerarHorario(0.5);
      return new Alumno(rut, nombre, apellido, mail, telefono, clave, horario);
    }

    public Profesor AdminAgregarProfesor()
    {
      //Profesor profesor1 = new Profesor("18234567-8", "Andres", "Howard", "a@m.cl", "+5699293949596", "1234",talleresD);
      GreenColorConsole("\nAgregar profesor\n");
      WhiteColorConsole("Ingrese el rut: ");
      String rut = Console.ReadLine();
      WhiteColorConsole("Ingrese el nombre: ");
      String nombre = Console.ReadLine();
      WhiteColorConsole("Ingrese el apellido: ");
      String apellido = Console.ReadLine();
      WhiteColorConsole("Ingrese el mail: ");
      String mail = Console.ReadLine();
      WhiteColorConsole("Ingrese el teléfono: ");
      String telefono = Console.ReadLine();
      WhiteColorConsole("Ingrese la clave de acceso: ");
      String clave = Console.ReadLine();
      Dictionary<String, List<Boolean>> horario = GenerarHorario(0.4);
      return new Profesor(rut, nombre, apellido, mail, telefono, clave, new List<Taller>());
    }

    public void MostrarSalas(List<Sala> salas)
    {
      GreenColorConsole("\nSalas:\n");
      int i = 1;
      foreach (Sala s in salas)
      {
        WhiteColorConsole("(" + (i++) + ") " + s.GetNombre());
      }
    }

    public int AdminSeleccionarSala(List<Sala> salas)
    {
      GreenColorConsole("\nSeleccione una sala:\n");
      if (salas.Count > 0)
      {
        MostrarSalas(salas);
        return Int32.Parse(Console.ReadLine());
      }
      else
        return -1;
    }

    public Dictionary<String, List<Boolean>> GenerarHorario(double probability)
    {
      Dictionary<String, List<Boolean>> ret = new Dictionary<String, List<Boolean>>(){
      {"Lunes", GenerarRandomBooleanList(probability) },
      { "Martes", GenerarRandomBooleanList(probability) },
      { "Miercoles", GenerarRandomBooleanList(probability) },
      { "Jueves", GenerarRandomBooleanList(probability) },
      { "Viernes", GenerarRandomBooleanList(probability)}};
      return ret;
    }

    public List<Boolean> GenerarRandomBooleanList(double probability)
    {
      List<Boolean> ret = new List<Boolean>();
      Random random = new Random();
      int temp = 0;
      for (int i = 0; i < 5; i++)
      {
        temp = random.Next(0, 100);
        if (temp >= probability * 100)
          ret.Add(true);
        else
          ret.Add(false);
      }
      return ret;
    }

    public void ShowForums(List<Foro> foros)
    {
      GreenColorConsole("\nSeleccionar foro a ingresar:\n");
      int i = 1;
      foreach (Foro foro in foros)
        if (!foro.privacidad)
          WhiteColorConsole("(" + (i++) + ") " + foro.tema);
    }

    public void ShowForumMessages(List<Mensaje> mesagges)
    {
      int i = 1;
      RedColorConsole(("\n-------------------------------------------------------------------------"));
      GreenColorConsole(("Mensajes en foro:\n"));
      foreach (Mensaje mensaje in mesagges)
      {
        GreenColorConsole("\n(" + (i++) + ") Por " + mensaje.autor.GetNombre() + " " + mensaje.autor.apellido + " - " + mensaje.fecha + ":\n");
        WhiteColorConsole(mensaje.texto);
      }
      RedColorConsole(("\n-------------------------------------------------------------------------\n"));
    }


    public String GetForumMessage()
    {
      WhiteColorConsole("\nIngrese mensaje que desea agregar al foro\n");
      return Console.ReadLine();
    }

    public String GetForumName()
    {
      WhiteColorConsole("\nIngrese nombre del nuevo foro\n");
      return Console.ReadLine();
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
      Thread.Sleep(350);
    }
    public void SuccesColorConsole(String s)
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine(s);
      Console.Beep();
      Console.ResetColor();
      Console.BackgroundColor = ConsoleColor.Black;
      Thread.Sleep(350);
    }
  }
}
