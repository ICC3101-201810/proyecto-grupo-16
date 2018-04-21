using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entrega_2
{
  class Sistema
  {
    List<Usuario> usuarios;
    List<Administrador> administradores;
    List<Profesor> profesores;
    List<Alumno> alumnos;
    List<Taller> talleres;
    List<Categoria> categorias;
    List<Sala> salas;
    List<String> bloques;

    //Menu estudiante
    List<String> studentsMenu;
    List<String> studentsSubMenuListWs;
    List<String> studentsSubMenuWs;
    List<String> studentsSubMenuForum;
    List<String> studentsSubMenuEnc;
    List<Boolean> studentOptionMenu;
    List<Boolean> studentOptionListWs;
    List<Boolean> studentOptionMenuWs;
    List<Boolean> studentOptionForum;
    List<Boolean> studentOptionEnc;



    public Sistema()
    {
      usuarios = new List<Usuario>();
      administradores = new List<Administrador>();
      profesores = new List<Profesor>();
      alumnos = new List<Alumno>();
      talleres = new List<Taller>();
      categorias = new List<Categoria>();
      salas = new List<Sala>();
      bloques = new List<String>() { "8:30-10:30", "10:30-12:30", "12:30-14:30", "14:30-16:30", "16:30-18:30" };

      //Menu estudiante
      studentsMenu = new List<String>() { "Mostrar talleres Disponibles", "Incribir Taller", "Ver Talleres Inscritos", "Salir" };
      studentOptionMenu = CreateListOption(studentsMenu.Count);
      studentsSubMenuListWs = new List<String>() { "Seleccionar Taller", "Eliminar Taller", "Volver a Menu" };
      studentOptionListWs = CreateListOption(studentsSubMenuListWs.Count);
      studentsSubMenuWs = new List<String>() { "Ver Foros", "Ver Encuesta", "Volver a Lista Talleres" };
      studentOptionMenuWs = CreateListOption(studentsSubMenuWs.Count);
      studentsSubMenuForum = new List<String>() { "Enviar Mensaje", "Volver a Taller" };
      studentOptionForum = CreateListOption(studentsSubMenuForum.Count);
      studentsSubMenuEnc = new List<String>() { "Responder Encuesta", "Volver a Taller" };
      studentOptionEnc = CreateListOption(studentsSubMenuEnc.Count);

    }


    public bool InscribirAlumno(Alumno alumno, Taller taller)
    {
      if (taller.Inscribible())
      {
        taller.Inscribir();
        alumno.InscribirTaller(taller);
        return true;
      }
      return false;
    }
    public Dictionary<Taller, List<String>> GetTallerresDisponibles(Alumno alumno)
    {
      Dictionary<Taller, List<String>> disponibles = new Dictionary<Taller, List<String>>();
      Dictionary<String, List<Boolean>> studentSchedule = alumno.GetHorario();
      Dictionary<String, List<Boolean>> wsSchedule = new Dictionary<string, List<bool>>();

      foreach (Taller ws in talleres)
      {
        wsSchedule = ws.GetHorario();
        List<String> avaliableBlocks = new List<String>();
        foreach (String day in wsSchedule.Keys)
        {
          for(int i=0; i<studentSchedule[day].Count;i++) if (studentSchedule[day][i] && wsSchedule[day][i])
            {
              avaliableBlocks.Add(String.Concat(day, ": ", bloques[i]));
            }
        }
        disponibles.Add(ws, avaliableBlocks);
      }

      return disponibles;
    }
    public bool CrearForo(Taller taller, string nombreForo, bool privacidad)
    {
      taller.CrearForo(nombreForo, privacidad);
      return true;
    }
    public List<Mensaje> LeerForo(Taller taller, Foro foro)
    {
      return foro.GetMensajes();
    }
    //No deberia pasarse el taller
    public bool EnviarMensaje(Taller taller, Foro foro, string texto, Usuario usuario, List<Media> media)
    {
      foro.AgregarMensaje(usuario, texto, media);
      return true;
    }
    public bool RegistrarAlumno(string rut, string nombre, string apellido, string email, string telefono, string clave, Dictionary<String, List<bool>> horario)
    {
      alumnos.Add(new Alumno(rut, nombre, apellido, email, telefono, clave, horario));
      return true;
    }
    public bool RegistrarProfesor(string rut, string nombre, string apellido, string email, string telefono, string clave)
    {
      profesores.Add(new Profesor(rut, nombre, apellido, email, telefono, clave));
      return true;
    }
    //Es necesario pasar el taller?
    public bool EliminarMensaje(Taller taller, Foro foro, Mensaje mensaje)
    {
      foro.DeleteMessage(mensaje);
      return true;
    }
    public bool EliminarAlumno(Alumno alumno)
    {
      List<Taller> talleresAlumno = alumno.GetTalleres();
      foreach (Taller t in talleresAlumno) t.SetCuposDisponibles();
      alumnos.RemoveAll(x => x.rut == alumno.rut);
      return true;
    }
    public bool CrearTaller(string nombre, int cupos, int precio, Dictionary<String, List<bool>> horario, Sala sala, Categoria categoria)
    {
      talleres.Add(new Taller(nombre, cupos, precio, horario, sala, categoria));
      return true;
    }
    //Que es esto?
    public bool ModificarTaller(Taller taller)
    { return true; }

    public bool DesinscribirAlumno(Taller taller, Alumno alumno)
    {
      taller.SetCuposDisponibles();
      alumno.DeleteWS(taller);
      return true;
    }
    public bool CrearEncuesta(Taller taller, string tema, List<Pregunta> preguntas)
    {
      taller.CrearEncuesta(tema, preguntas);
      return true;
    }
    public bool ResponderEncuesta(Taller taller, string tema, Alumno alumno, List<String> respuestaAlternativas)
    {
      List<Encuesta> e = taller.GetEncuestas().Where(x => x.tema == tema).ToList();
      e[0].SetRespuesta(alumno, respuestaAlternativas);
      return true;
    }
    public List<String> GenerarEstadisticaEncuesta(Taller taller, Encuesta encuesta)
    {
      List<String> estadisticas = new List<string>();
      string cantidadRespondida, cantidadPorcentual;
      cantidadRespondida = String.Concat("Respuesta: ", encuesta.GetRespuesta().Count);
      cantidadPorcentual = String.Concat("% Respondido: ", encuesta.GetRespuesta().Count / encuesta.GetPreguntas().Count);
      estadisticas.Add(cantidadRespondida);
      estadisticas.Add(cantidadPorcentual);
      return estadisticas;
    }
    public void Menu()
    {
      if (!LoadData())
      {
        InicializaUsuariosIniciales();
      }
      Interfaz interfaz = new Interfaz();
      List<String> credenciales = new List<String> { "", "" };
      List<Boolean> Option = new List<Boolean>();
      List<Boolean> Option2 = new List<Boolean>();
      List<Boolean> Option3 = new List<Boolean>();
      List<Boolean> Option4 = new List<Boolean>();
      while (!VerifyUser(credenciales))
      {
        credenciales = interfaz.LogInLogOut();
        interfaz.ErrorCredenciales(VerifyUser(credenciales));
      }



      if (GetUser(credenciales).GetType() == typeof(Alumno))
      {
        Alumno student = (Alumno)GetUser(credenciales);
        Option = interfaz.StudentsMenu(studentsMenu, studentOptionMenu);
        while (!Option[3])
        {
          if (Option[0])
          {
            interfaz.WorkShopAvailable(GetTallerresDisponibles(student));
          }
          else if (Option[1])
          {
            int select = 0;
            interfaz.WorkShopAvailable(GetTallerresDisponibles(student));
            interfaz.GreenColorConsole("Seleccione Opcion:\n");
            select=Int32.Parse(Console.ReadLine());
            if (GetTallerresDisponibles(student).ElementAt(select - 1).Key.Inscribible())
            {
                GetTallerresDisponibles(student).ElementAt(select - 1).Key.Inscribir();
                student.InscribirTaller(GetTallerresDisponibles(student).ElementAt(select - 1).Key);
                interfaz.SuccesColorConsole("EXITO: Taller inscrito");
            }
            else interfaz.ErrorColorConsole("ERROR: Taller no inscrito. Falta de cupos.");
            }
          else if (Option[2])
          {
            interfaz.ShowStudentWS(student.GetTalleres());
            Option2 = interfaz.StudentsMenu(studentsSubMenuListWs, studentOptionListWs);
            while (!Option2[2])
            {
              if (Option2[0])
              {
                Option3 = interfaz.StudentsMenu(studentsSubMenuWs, studentOptionMenuWs);
                while (!Option3[2])
                {
                  if (Option3[0])
                  {
                    Option4 = interfaz.StudentsMenu(studentsSubMenuForum, studentOptionForum);
                    while (!Option4[1]) Option4 = interfaz.StudentsMenu(studentsSubMenuForum, studentOptionForum);
                  }
                  else if (Option3[1])
                  {
                    Option4 = interfaz.StudentsMenu(studentsSubMenuEnc, studentOptionEnc);
                    while (!Option4[1]) Option4 = interfaz.StudentsMenu(studentsSubMenuEnc, studentOptionEnc);
                  }
                  Option3 = interfaz.StudentsMenu(studentsSubMenuWs, studentOptionMenuWs);
                }
              }
              else if (Option2[1]) { }
              Option2 = interfaz.StudentsMenu(studentsSubMenuListWs, studentOptionListWs);
            }


          }
          Option = interfaz.StudentsMenu(studentsMenu, studentOptionMenu);
        }
      }
      SaveData(usuarios, talleres);
    }

    public void InicializaUsuariosIniciales()
    {
      Dictionary<String, List<Boolean>> schedulea = new Dictionary<String, List<Boolean>>(){
          {"Lunes", new List<Boolean>() {false, true, false, false, false } },
          { "Martes", new List<Boolean>() { false, false, false, false, false } },
          { "Miercoles", new List<Boolean>() {false, true, false, false, false } },
          { "Jueves", new List<Boolean>() {false, false, false, false, false } },
          { "Viernes", new List<Boolean>() {false, false, false, false, false }}};
      Dictionary<String, List<Boolean>> scheduleb = new Dictionary<String, List<Boolean>>(){
          {"Lunes", new List<Boolean>() {false, true, false, false, false } },
          { "Martes", new List<Boolean>() { false, false, true, false, false } },
          { "Miercoles", new List<Boolean>() {false, true, false, false, false } },
          { "Jueves", new List<Boolean>() {false, false, true, false, false } },
          { "Viernes", new List<Boolean>() {false, false, false, false, false }}};
      Taller futbol = new Taller("futbol", 40, 15000, schedulea, new Sala("CanchaFutbol", schedulea), new Categoria());
      talleres.Add(futbol);
      Administrador administrador1 = new Administrador("18123456-7", "Carlos", "Diaz", "c@m.cl", "+56991929394", "1234");
      administradores.Add(administrador1);
      Profesor profesor1 = new Profesor("18234567-8", "Andres", "Howard", "a@m.cl", "+5699293949596", "1234");
      profesores.Add(profesor1);
      Alumno alumno1 = new Alumno("18884427-8", "Israel", "Cea", "i@m.cl", "+56999404286", "1234", scheduleb);
      alumnos.Add(alumno1);
      usuarios.Add(administrador1);
      usuarios.Add(profesor1);
      usuarios.Add(alumno1);
    }


    private Boolean VerifyUser(List<String> credenciales)
    {
      foreach (Usuario user in usuarios) if (credenciales[0].Equals(user.email) && credenciales[1].Equals(user.clave)) return true;
      return false;
    }

    private Usuario GetUser(List<String> credenciales)
    {
      List<Usuario> users = usuarios.Where(x => x.email == credenciales[0]).ToList();
      return users[0];
    }
    private static void SaveData(List<Usuario> usuarios, List<Taller> talleres)
    {
      // Creamos el Stream donde guardaremos nuestros usuarios
      String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt");
      FileStream fs = new FileStream(fileName, FileMode.Create);
      IFormatter formatter = new BinaryFormatter();
      formatter.Serialize(fs, usuarios);
      fs.Close();
      fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WorkShops.txt");
      fs = new FileStream(fileName, FileMode.Create);
      formatter.Serialize(fs, talleres);
      fs.Close();


    }

    private Boolean LoadData()
    {
      //string fileName = Path.Combine(Directory.GetCurrentDirectory(), "Users.txt");
      String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt");
      if (!File.Exists(fileName))
      {
        return false;
      }
      FileStream fs = new FileStream(fileName, FileMode.Open);
      IFormatter formatter = new BinaryFormatter();
      List<Usuario> users = formatter.Deserialize(fs) as List<Usuario>;
      foreach (Usuario u in users)
      {
        Type t = u.GetType();
        if (t == typeof(Alumno)) alumnos.Add((Alumno)u);
        else if (t == typeof(Profesor)) profesores.Add((Profesor)u);
        else administradores.Add((Administrador)u);
        usuarios.Add(u);
      }
      fs.Close();
      fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Workshops.txt");
      fs = new FileStream(fileName, FileMode.Open);
      List<Taller> workshops = formatter.Deserialize(fs) as List<Taller>;
      foreach (Taller t in workshops) talleres.Add(t);
      fs.Close();
      return true;
    }

    private List<Boolean> CreateListOption(int Length)
    {
      List<Boolean> option = new List<Boolean>(Length);
      for (int i = 0; i < Length; i++) option.Add(false);
      return option;
    }


  }
}
