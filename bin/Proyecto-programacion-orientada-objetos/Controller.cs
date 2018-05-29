using Modelos;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Vistas
{
  //Simil a la clase sistema. Se incializan todas las listas de las clases
  class Controller
  {
    Dictionary<String, Form> vistas;
    List<Usuario> usuarios;
    List<Administrador> administradores;
    List<Profesor> profesores;
    List<Alumno> alumnos;
    List<Taller> talleres;
    List<Categoria> categorias;
    List<Sala> salas;
    List<String> bloques;
    TalleresVU logInView;

    
    public Controller(Dictionary<String, Form> vistas)
    {
      usuarios = new List<Usuario>();
      administradores = new List<Administrador>();
      profesores = new List<Profesor>();
      alumnos = new List<Alumno>();
      talleres = new List<Taller>();
      categorias = new List<Categoria>();
      salas = new List<Sala>();
      bloques = new List<String>() { "8:30-10:30", "10:30-12:30", "12:30-14:30", "14:30-16:30", "16:30-18:30" };
      this.vistas = vistas;
      logInView = (TalleresVU)vistas["Login"];
      logInView.OnLogIn += VistaLogIn_OnLogIn; //Se suscribe el metodo al evento OnLogIn
      logInView.OnAlumnoInscribirTaller += VistaInscribirTaller_OnAlumnoInscribirTaller;
      logInView.OnAlumnoEliminarTaller += VistaEliminarTaller_OnAlumnoEliminarTaller;
      logInView.OnAlumnoIngresarTaller += VistaIngresarTaller_OnAlumnoIngresarTaller;
      logInView.OnVolverMenuAlumno += VistaVolverMenuAlumno_OnVolverMenuAlumno;
      logInView.OnClosingApp += SaveDataBeforeClosing_OnClosingApp;
      logInView.OnAlumnoCrearForo += VistaAlumnoCrearForo_OnAlumnoCrearForo;
      logInView.OnAlumnoIngresarAForo += VistaAlumnoIngresarAForo_OnAlumnoIngresarAForo;
      logInView.OnAlumnoSalirDeForo += VistaAlumnoSalirDeForo_OnAlumnoSalirDeForo;
      logInView.OnAlumnoIngresarMensajeForo += VistaAlumnoIngresarMensajeForo_OnAlumnoIngresarMensajeForo;
      logInView.OnAlumnoEliminarMensaje += VistaAlumnoEliminarMensaje_OnAlumnoEliminarMensaje;
      logInView.OnAdminEliminarTaller += VistaAdminEliminarTaller_OnAdminEliminarTaller;
      logInView.OnAdminCrearTaller += VistaAdminCrearTaller_OnAdminCrearTaller;
      logInView.OnAdminEliminarAlumno += VistaAdminEliminarAlumno_OnAdminEliminarAlumno;
      logInView.OnAdminCrearAlumno += VistaAdminCrearAlumno_OnAdminCrearAlumno;
      logInView.OnAdminEliminarProfesor += VistaAdminEliminarProfesor_OnAdminEliminarProfesor;
      logInView.OnAdminCrearProfesor += VistaAdminCrearProfesor_OnAdminCrearProfesor;
      logInView.OnAdminEliminarSala += VistaAdminEliminarSala_OnAdminEliminarSala;
      logInView.OnAdminCrearSala += VistaAdminCrearSala_OnAdminCrearSala;
      //Profesor
      logInView.OnProfesorMostrarTaller += LogInView_OnProfesorMostrarTaller;
      logInView.OnProfesorLeerForo += LogInView_OnProfesorLeerForo;
      logInView.OnProfesorAgregarMensaje += LogInView_OnProfesorAgregarMensaje;
      logInView.OnProfesorEliminarMensaje += LogInView_OnProfesorEliminarMensaje;
      logInView.OnProfesorCrearForo += LogInView_OnProfesorCrearForo;
      logInView.OnProfesorEliminarForo += LogInView_OnProfesorEliminarForo;
      logInView.OnProfesorMostrarParticipantes += LogInView_OnProfesorMostrarParticipantes;
      logInView.OnProfesorCerrarSesion += LogInView_OnProfesorCerrarSesion;

      if (!LoadData())
      {
        InicializaUsuariosIniciales();
      }
      else
      {

      }
    }
        //Esta funcion cierra sesión desde cualquier panel

        private void LogInView_OnProfesorCerrarSesion(object sender, LogInEventArgs e)
        {
            
            e.panels["Login"].Visible = true;
            e.panels["ProfesorMenu"].Visible = false;
            e.panels["AdminMenu"].Visible = false;
            e.panels["StudentMenu"].Visible = false;
            e.panels["StudentWsMenu"].Visible = false;
            logInView.ClearLogIn();

        }

        

        private void LogInView_OnProfesorMostrarParticipantes(object sender, LogInEventArgs e)
        {
            logInView.ClearParticipantes();
            Taller ws = e.taller;
            List<Alumno> participantes = GetParticipantes(ws);
            logInView.ActualizarParticipantes(alumnos);
            
        }

        private void LogInView_OnProfesorEliminarForo(object sender, LogInEventArgs e)
        {
            Taller ws = e.taller;
            Foro f = e.foro;
            ws.GetForos().Remove(f);
            logInView.ClearListaForosProfe();
            logInView.CargarForosTallerProfesor(ws);
        }

        private void LogInView_OnProfesorCrearForo(object sender, LogInEventArgs e)
        {
            Taller ws = e.taller;
            String temaForo = e.temaForo;
            CrearForo(ws, temaForo);
            logInView.ActualizarListaForosProfe(ws.GetForos()[ws.GetForos().Count - 1]);
            logInView.ClearIngresoTemaForoTallerProfe();

        }

        private void LogInView_OnProfesorEliminarMensaje(object sender, LogInEventArgs e)
        {
            Foro forum = e.foro;
            Mensaje m = e.objetoMensaje;
            EliminarMensaje(forum, m);
            logInView.ActualizarListaMensajesForoProfe(m, true);
            logInView.ClearListaMensajesForoProfe();
            logInView.CargarMensajesForoProfesor(forum);
           
        }

        private void LogInView_OnProfesorAgregarMensaje(object sender, LogInEventArgs e)
        {
            Foro forum = e.foro;
            EnviarMensaje(forum, e.mensaje, GetUser(e.credenciales));
            Mensaje mensaje = forum.GetMensajes().Last();
            logInView.ActualizarListaMensajesForoProfe(mensaje, false);
        }

        private void LogInView_OnProfesorLeerForo(object sender, LogInEventArgs e)
        {
            Foro f = e.foro;
            logInView.CargarMensajesForoProfesor(f);
        }

        private void LogInView_OnProfesorMostrarTaller(object sender, LogInEventArgs e)
        {
            Taller ws = e.taller;
            logInView.CargarForosTallerProfesor(ws);
        }
//*******************************************************************************************************************

        //Metodo que esta suscrito al evento lanzado por el boton para ingresar en el Login.
        //Simplemente verifica el usuario y carga su menu. Solo esta implementado el student. --> Ir a form1.cs
        private void VistaLogIn_OnLogIn(object sender, LogInEventArgs e)
    {
      List<String> credenciales = e.credenciales;

      if (!VerifyUser(credenciales))
      {
        MessageBox.Show("ERROR: Credenciales Invalidas", "Error: Validacion de Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        MessageBox.Show("Bienvenido! " + GetUser(credenciales).nombre, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (GetUser(credenciales).GetType() == typeof(Alumno))
        {
          Alumno student = (Alumno)GetUser(credenciales);
          if (GetTalleresDisponibles(student).Count > 0)
            foreach (Taller ws in GetTalleresDisponibles(student).Keys)
              logInView.ActualizarTalleresDisponibles(ws, false);
          else
            logInView.NoHayTalleresDisponibles();
          if (student.GetTalleres().Count > 0)
            foreach (Taller ws in student.GetTalleres())
              logInView.ActualizarTalleresInscritos(ws, false);
          else
            logInView.NoHayTalleresInscritos();

          e.panels["Login"].Visible = false;
          e.panels["StudentMenu"].Visible = true;
        }
        else if (GetUser(credenciales).GetType() == typeof(Administrador))
        {
          Administrador admin = (Administrador)GetUser(credenciales);
          foreach (Taller ws in talleres)
          {
            logInView.ActualizarTalleresAdmin(ws, false);
            if (!salas.Contains(ws.sala))
              salas.Add(ws.sala);
          }
          foreach (Sala sala in salas)
          {
            logInView.ActualizarAdminTallerSalas(sala, false);
            logInView.ActualizarSalasAdmin(sala, false);
          }
          foreach (Alumno alumno in alumnos)
            logInView.ActualizarAlumnosAdmin(alumno, false);
          foreach (Profesor profesor in profesores)
            logInView.ActualizarProfesoresAdmin(profesor, false);
            

          e.panels["Login"].Visible = false;
          e.panels["AdminMenu"].Visible = true;
        }

        else
        {
          Profesor profesor = (Profesor)GetUser(credenciales);
          if (profesor.GetTalleres().Count > 0)
            foreach (Taller ws in profesor.GetTalleres())
              logInView.ActualizarTalleresProfesor(ws, false);
          else
            logInView.NoHayTalleresProfesor();

          e.panels["Login"].Visible = false;
          e.panels["ProfesorMenu"].Visible = true;
        }
      }
    }

    private void VistaInscribirTaller_OnAlumnoInscribirTaller(object sender, LogInEventArgs e)
    {
      Taller ws = e.taller;
      Alumno student = (Alumno)GetUser(e.credenciales);
      InscribirAlumno(student, ws);
      logInView.ActualizarTalleresDisponibles(ws, true);
      logInView.ActualizarTalleresInscritos(ws,false);
    }

    private void VistaEliminarTaller_OnAlumnoEliminarTaller(object sender, LogInEventArgs e)
    {
      Taller ws = e.taller;
      Alumno student = (Alumno)GetUser(e.credenciales);
      student.DeleteWS(ws);
      ws.SetCuposDisponibles();
      foreach (String day in ws.GetHorario().Keys) //Se obtiene el horario del taller elegido por el alumno
      {
        for (int i = 0; i < ws.GetHorario()[day].Count; i++)
        {
          if (ws.GetHorario()[day][i]) student.GetHorario()[day][i] = true;

        }
      }
      logInView.ActualizarTalleresInscritos(ws, true);
      logInView.ActualizarTalleresDisponibles(ws, false);
    }

    private void VistaIngresarTaller_OnAlumnoIngresarTaller(object sender, LogInEventArgs e)
    {
      Taller ws = e.taller;
      logInView.ActualizarPerfilTaller(ws);
      e.panels["StudentWsMenu"].Visible = true;
      e.panels["StudentMenu"].Visible = false;
      logInView.ClearListaMensajesForo();
    }

    private void VistaVolverMenuAlumno_OnVolverMenuAlumno(object sender, LogInEventArgs e)
    {
      e.panels["StudentMenu"].Visible = true;
      e.panels["StudentWsMenu"].Visible = false;
    }
    private void VistaAlumnoCrearForo_OnAlumnoCrearForo(object sender, LogInEventArgs e)
    {
      Taller ws = e.taller;
      String tema = e.temaForo;
      CrearForo(ws, tema);
      logInView.ActualizarListaForos(ws.GetForos()[ws.GetForos().Count-1]);
      logInView.ActualizarCantidadForosTaller(ws);
      logInView.ClearIngresoTemaForoTaller();
    }
    private void VistaAlumnoIngresarAForo_OnAlumnoIngresarAForo(object sender, LogInEventArgs e)
    {
      Foro forum = e.foro;
      logInView.ClearListaMensajesForo();
      if (forum.GetMensajes().Count > 0)
      {
        foreach (Mensaje m in forum.GetMensajes())
        {
          logInView.ActualizarListaMensajesForo(m, false);
        }
      }
      else logInView.NoExistenMensajesForo();
    }
    private void VistaAlumnoSalirDeForo_OnAlumnoSalirDeForo(object sender, LogInEventArgs e)
    {
      Foro forum = e.foro;
      logInView.ClearListaMensajesForo();
    }
    private void VistaAlumnoIngresarMensajeForo_OnAlumnoIngresarMensajeForo(object sender, LogInEventArgs e)
    {
      Foro forum = e.foro;
      EnviarMensaje(forum, e.mensaje, GetUser(e.credenciales));
      Mensaje mensaje = forum.GetMensajes().Last();
      logInView.ActualizarListaMensajesForo(mensaje, false);
    }
    private void VistaAlumnoEliminarMensaje_OnAlumnoEliminarMensaje(object sender, LogInEventArgs e)
    {
      Foro forum = e.foro;
      Mensaje m = e.objetoMensaje;
      EliminarMensaje(forum, m);
      logInView.ActualizarListaMensajesForo(m, true);
    }

    //Vistas admin

    private void VistaAdminEliminarTaller_OnAdminEliminarTaller(object sender, LogInEventArgs e)
    {
      Taller ws = e.taller;
      AdminEliminarTaller(ws);
      logInView.ActualizarTalleresAdmin(ws, true);
    }
    private void VistaAdminCrearTaller_OnAdminCrearTaller(object sender, LogInEventArgs e)
    {
      Taller ws = new Taller(e.nombreTaller, e.cuposTaller, e.precioTaller, e.horarioTaller, e.salaTaller, new Categoria());
      talleres.Add(ws);
      logInView.ActualizarTalleresAdmin(ws, false);
      logInView.AdminLimpiarCrearTaller();
    }
    private void VistaAdminEliminarAlumno_OnAdminEliminarAlumno(object sender, LogInEventArgs e)
    {
      Alumno alumno = e.student;
      AdminEliminarAlumno(alumno);
      logInView.ActualizarAlumnosAdmin(alumno, true);
    }
    private void VistaAdminCrearAlumno_OnAdminCrearAlumno(object sender, LogInEventArgs e)
    {
      Alumno alumno = new Alumno(e.rutUser, e.nombreUser, e.apellidoUser, e.mailUser, e.telefonoUser, e.passwordUser, e.horarioAlumno);
      alumnos.Add(alumno);
      usuarios.Add(alumno);
      logInView.ActualizarAlumnosAdmin(alumno, false);
      logInView.AdminLimpiarCrearAlumno();
    }
    private void VistaAdminEliminarProfesor_OnAdminEliminarProfesor(object sender, LogInEventArgs e)
    {
      Profesor profesor = e.profesor;
      AdminEliminarProfesor(profesor);
      logInView.ActualizarProfesoresAdmin(profesor, true);
    }
    private void VistaAdminCrearProfesor_OnAdminCrearProfesor(object sender, LogInEventArgs e)
    {
      Profesor profesor = new Profesor(e.rutUser, e.nombreUser, e.apellidoUser, e.mailUser, e.telefonoUser, e.passwordUser);
      profesores.Add(profesor);
      usuarios.Add(profesor);
      logInView.ActualizarProfesoresAdmin(profesor, false);
      logInView.AdminLimpiarCrearProfesor();
    }
    private void VistaAdminEliminarSala_OnAdminEliminarSala(object sender, LogInEventArgs e)
    {
      Sala sala = e.sala;
      AdminEliminarSala(sala);
      logInView.ActualizarSalasAdmin(sala, true);
      logInView.ActualizarAdminTallerSalas(sala, true);
    }
    private void VistaAdminCrearSala_OnAdminCrearSala(object sender, LogInEventArgs e)
    {
      Sala sala = new Sala(e.nombreSala, e.horarioSala);
      salas.Add(sala);
      logInView.ActualizarSalasAdmin(sala, false);
      logInView.ActualizarAdminTallerSalas(sala, false);
      logInView.AdminLimpiarCrearSala();
    }



    //Grabar los datos antes de cerrar
    private void SaveDataBeforeClosing_OnClosingApp(object sender, LogInEventArgs e)
    {
      SaveData(usuarios, talleres);
    }

    //Metodos


    //Inscribir al alumno en taller
    private bool InscribirAlumno(Alumno alumno, Taller taller)
    {
      if (taller.Inscribible())
      {
        taller.Inscribir();
        alumno.InscribirTaller(taller);
        foreach (String day in taller.GetHorario().Keys) //Se obtiene el horario del taller elegido por el alumno
          for (int i = 0; i < taller.GetHorario()[day].Count; i++)
            if (taller.GetHorario()[day][i]) alumno.GetHorario()[day][i] = false;
        return true;
      }
      return false;
    }


    //Revisar los talleres disponibles para el alumno segun su horario
    public Dictionary<Taller, List<String>> GetTalleresDisponibles(Alumno alumno)
    {
      Dictionary<Taller, List<String>> disponibles = new Dictionary<Taller, List<String>>();
      Dictionary<String, List<Boolean>> studentSchedule = alumno.GetHorario();
      Dictionary<String, List<Boolean>> wsSchedule = new Dictionary<string, List<bool>>();

      foreach (Taller ws in talleres)
      {
        wsSchedule = ws.GetHorario();
        bool fullavaliable = true;
        List<String> avaliableBlocks = new List<String>();
        foreach (String day in wsSchedule.Keys)
        {
          for (int i = 0; i < studentSchedule[day].Count; i++)
          {
            if (studentSchedule[day][i] && wsSchedule[day][i]) avaliableBlocks.Add(String.Concat(day, ": ", bloques[i]));
            if (!studentSchedule[day][i] && wsSchedule[day][i]) fullavaliable = false;
          }
        }
        if (avaliableBlocks.Count > 0 && fullavaliable) disponibles.Add(ws, avaliableBlocks);
      }

      return disponibles;
    }

    private bool CrearForo(Taller taller, string nombreForo, bool privacidad=false)
    {
      taller.CrearForo(nombreForo, privacidad);
      return true;
    }

    public bool EnviarMensaje(Foro foro, string texto, Usuario usuario)
    {
      foro.AgregarMensaje(usuario, texto);
      return true;
    }

    public bool EliminarMensaje(Foro foro, Mensaje mensaje)
    {
      foro.DeleteMessage(mensaje);
      return true;
    }

    //Metodos admin
    public void AdminEliminarTaller(Taller taller)
    {
      talleres.Remove(taller);
    }
    public void AdminEliminarAlumno(Alumno alumno)
    {
      alumnos.Remove(alumno);
      usuarios.Remove(alumno);
    }
    public void AdminEliminarProfesor(Profesor profesor)
    {
      profesores.Remove(profesor);
      usuarios.Remove(profesor);
    }
    public void AdminEliminarSala(Sala sala)
    {
      salas.Remove(sala);
    }

    public List<Alumno> GetParticipantes(Taller ws)
    {
        List<Alumno> participantes = new List<Alumno>();
        foreach (Alumno a in alumnos)
            {
                foreach(Taller t in a.GetTalleres())
                {
                    if(t.nombre==ws.nombre)
                    {
                        alumnos.Add(a);

                    }
                }
            }
            return participantes;


    }



        //Metodos de incializacion y serialize!
        public void InicializaUsuariosIniciales()
    {
      Dictionary<String, List<Boolean>> schedulea = new Dictionary<String, List<Boolean>>(){
      {"Lunes", new List<Boolean>() {false, true, false, false, false } },
      { "Martes", new List<Boolean>() { false, false, false, false, false } },
      { "Miercoles", new List<Boolean>() {false, true, false, false, false } },
      { "Jueves", new List<Boolean>() {false, false, false, false, false } },
      { "Viernes", new List<Boolean>() {false, false, false, false, false }}};
      Dictionary<String, List<Boolean>> schedulec = new Dictionary<String, List<Boolean>>(){
      {"Lunes", new List<Boolean>() {false, false, false, false, false } },
      { "Martes", new List<Boolean>() { false, false, false, true, false } },
      { "Miercoles", new List<Boolean>() {false, false, false, false, false } },
      { "Jueves", new List<Boolean>() {false, false, false, true, false } },
      { "Viernes", new List<Boolean>() {false, false, false, false, false }}};
      Dictionary<String, List<Boolean>> scheduleb = new Dictionary<String, List<Boolean>>(){
      {"Lunes", new List<Boolean>() {false, true, false, false, false } },
      { "Martes", new List<Boolean>() { false, false, true, true, false } },
      { "Miercoles", new List<Boolean>() {false, true, false, false, false } },
      { "Jueves", new List<Boolean>() {false, false, true, true, false } },
      { "Viernes", new List<Boolean>() {false, false, false, false, false }}};
      Administrador administrador1 = new Administrador("18123456-7", "Carlos", "Diaz", "c@m.cl", "+56991929394", "1234");
      administradores.Add(administrador1);
      Alumno alumno1 = new Alumno("18884427-8", "Israel", "Cea", "i@m.cl", "+56999404286", "1234", scheduleb);
      Alumno alumno2 = new Alumno("18884427-8", "Israel", "Borrar", "i@m.cl", "+56999404286", "1234", scheduleb);
      Sala sala1 = new Sala("CanchaFutbol", schedulea);
      Sala sala2 = new Sala("CanchaTenis", schedulec);
      Taller futbol = new Taller("futbol", 40, 15000, schedulea, sala1, new Categoria());
      Taller futbol2 = new Taller("futbol borrar", 40, 15000, schedulea, sala1, new Categoria());
      Taller tenis = new Taller("tenis", 40, 15000, schedulec, sala2, new Categoria());
      salas.Add(sala1);
      salas.Add(sala2);
      List<Taller> talleresD = new List<Taller>();
      tenis.CrearForo("Por qué Gohan es un papanatas?", false);
      tenis.GetForos()[0].AgregarMensaje(alumno1, "Gohan es un quesito miedoso, hasta el verde le gana");
      tenis.GetForos()[0].AgregarMensaje(alumno1, "Busco mujer de 1,70 rubia, asiatica, buena para comer gohan. Esto no es Tinder?");
      talleresD.Add(futbol);
      talleresD.Add(tenis);
      Profesor profesor1 = new Profesor("18234567-8", "Andres", "Howard", "a@m.cl", "+5699293949596", "1234", talleresD);
      Profesor profesor2 = new Profesor("18234567-8", "Andres", "Borrar", "a@m.cl", "+5699293949596", "1234", talleresD);
      profesores.Add(profesor1);
      profesores.Add(profesor2);
      talleres.Add(futbol);
      talleres.Add(tenis);
      talleres.Add(futbol2);
      alumnos.Add(alumno1);
      alumnos.Add(alumno2);
      usuarios.Add(administrador1);
      usuarios.Add(profesor1);
      usuarios.Add(profesor2);
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
      //String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt");
      String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Users.txt");
      FileStream fs = new FileStream(fileName, FileMode.Create);
      IFormatter formatter = new BinaryFormatter();
      formatter.Serialize(fs, usuarios);
      fs.Close();
      //fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WorkShops.txt");
      fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Workshops.txt");
      fs = new FileStream(fileName, FileMode.Create);
      formatter.Serialize(fs, talleres);
      fs.Close();


    }

    private Boolean LoadData()
    {
      //string fileName = Path.Combine(Directory.GetCurrentDirectory(), "Users.txt");
      //String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt");
      String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Users.txt");
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
      File.Delete(fileName);
      //fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Workshops.txt");
      fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Workshops.txt");
      fs = new FileStream(fileName, FileMode.Open);
      List<Taller> workshops = formatter.Deserialize(fs) as List<Taller>;
      foreach (Taller t in workshops) talleres.Add(t);
      fs.Close();
      File.Delete(fileName);
      return true;
    }



    }
}
