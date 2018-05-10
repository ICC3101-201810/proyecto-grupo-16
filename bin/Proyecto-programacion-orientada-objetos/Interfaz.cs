using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_2
{
  class Interfaz
  {

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

    public int StudentsMenu(List<String> studentsMenu)
    {
      int i = 1;
      RedColorConsole("\tMenu Estudiante\n");
      GreenColorConsole("Seleccione Opcion:\n");
      foreach (String index in studentsMenu) WhiteColorConsole("(" + (i++) + ") " + index);
      return Int32.Parse(Console.ReadLine()) - 1;
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
                    schedule = "";
                    foreach (String blocks in wsAvaliable[ws]) schedule = String.Concat(schedule, "| ", blocks);
                    WhiteColorConsole("(" + (i++) + ") " + ws.nombre + ", Horario: " + schedule + "\n");
                }
            }
            else ErrorColorConsole("\nERROR: No existen talleres en horario disponible.\n");
    }
    public void MostrarTalleres(List<Taller> talleres)
    {
      int i=1;
      foreach(Taller ws in talleres)
      {
        WhiteColorConsole("(" + (i++) + ") " + ws.nombre);// + ", Horario: " + schedule + "\n");
      } 
    }

    public void MostrarAlumnos(List<Alumno> alumnos){
      for (int i = 0; i < alumnos.Count; i++)
        WhiteColorConsole("(" + (i+1) + ") " + alumnos[i].GetApellido() + ", " + alumnos[i].GetNombre());
    }

    public void MostrarProfesores(List<Profesor> profesores){
      int i = 0;
      foreach(Profesor p in profesores){
        WhiteColorConsole("(" + (i + 1) + ") " + p.GetApellido() + ", " + p.GetNombre());
        i++;
      }
    }

    public void AdminMostrarTalleres(List<Taller> talleres){
      GreenColorConsole("\nTalleres:\n");
      MostrarTalleres(talleres);
    }

    public int AdminEliminarTaller(List<Taller> talleres){
      GreenColorConsole("\nSeleccione el taller a eliminar\n");
      MostrarTalleres(talleres);
      return Int32.Parse(Console.ReadLine());
    }

    public void AdminMostrarProfesores(List<Profesor> profesores){
      GreenColorConsole("\nProfesores vigentes:\n");
      MostrarProfesores(profesores);
    }

    public void AdminMostrarAlumnos(List<Alumno> alumnos){
      GreenColorConsole("\nAlumnos vigentes:\n");
      MostrarAlumnos(alumnos);
    }

    public int AdminEliminarAlumno(List<Alumno> alumnos){
      GreenColorConsole("\nSeleccione el alumno a eliminar\n");
      MostrarAlumnos(alumnos);
      return Int32.Parse(Console.ReadLine());
    }

    public Taller AgregarTaller(){
      // string nombre, int cupos, int precio, Dictionary<String, List<bool>> horario, Sala sala, Categoria categoria,Profesor profesor
      GreenColorConsole("\nAgregar Taller:\n");
      WhiteColorConsole("Ingrese el nombre del taller: ");
      String nombre = Console.ReadLine();
      WhiteColorConsole("Ingrese la cantidad de cupos: ");
      int cupos = Int32.Parse(Console.ReadLine());
      WhiteColorConsole("Ingrese el precio (sin decimales): ");
      int precio = Int32.Parse(Console.ReadLine());
      Dictionary<String, List<Boolean>> horario = GenerarHorario(0.95);
      // Ingresar el horario
      // Ingresar la sala

      //Ingresar la categoria
      //Ingresar el profesor
      return null;
    }

    public int AdminEliminarProfesor(List<Profesor> profesores){
      GreenColorConsole("\nSelecione el profesor a eliminar\n");
      MostrarProfesores(profesores);
      return Int32.Parse(Console.ReadLine());
    }

    public Sala AdminAgregarSala(){
      GreenColorConsole("\nAgregar Sala\n");
      WhiteColorConsole("Ingrese el nombre de la sala: ");
      String nombre = Console.ReadLine();
      return new Sala(nombre, GenerarHorario(0.75));
    }

    public Alumno AdminAgregarAlumno(){
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
      Dictionary<String, List <Boolean>> horario = GenerarHorario(0.5);
      return new Alumno(rut, nombre, apellido, mail, telefono, clave, horario);
    }

    public Profesor AdminAgregarProfesor(){
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

    public void MostrarSalas(List<Sala> salas){
      GreenColorConsole("\nSalas:\n");
      int i = 1;
      foreach(Sala s in salas){
        WhiteColorConsole("(" + (i++) + ") " + s.GetNombre());
      }
    }

    public Dictionary<String, List<Boolean>> GenerarHorario(double probability){
      Dictionary<String, List<Boolean>> ret = new Dictionary<String, List<Boolean>>(){
      {"Lunes", GenerarRandomBooleanList(probability) },
      { "Martes", GenerarRandomBooleanList(probability) },
      { "Miercoles", GenerarRandomBooleanList(probability) },
      { "Jueves", GenerarRandomBooleanList(probability) },
      { "Viernes", GenerarRandomBooleanList(probability)}};
      return ret;
    }

    public List<Boolean> GenerarRandomBooleanList(double probability){
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
