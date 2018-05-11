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
      this.vistas = vistas;
      logInView = (TalleresVU)vistas["Login"];
      logInView.OnLogIn += VistaLogIn_OnLogIn; //Se suscribe el metodo al evento OnLogIn
      if (!LoadData())
      {
        InicializaUsuariosIniciales();
      }
    }

    //Metodo que esta suscrito al evento lanzado por el boton para ingresar en el Login.
    //Simplemente verifica el usuario y carga su menu. Solo esta implementado el student. --> Ir a form1.cs
    private void VistaLogIn_OnLogIn(object sender, LogInEventArgs e)
    {
      List<String> credenciales = new List<String> { "", "" };
      credenciales[0]=e.user;
      credenciales[1] = e.password;
      if (!VerifyUser(credenciales))
      {
        MessageBox.Show("ERROR: Credenciales Invalidas", "Error: Validacion de Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        MessageBox.Show("Bienvenido! " + GetUser(credenciales).nombre, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (GetUser(credenciales).GetType() == typeof(Alumno))
        {
          e.panels["Login"].Visible = false;
          e.panels["StudentMenu"].Visible = true;
        }
        else MessageBox.Show("Under construction");
      }
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
      Taller futbol = new Taller("futbol", 40, 15000, schedulea, new Sala("CanchaFutbol", schedulea), new Categoria());
      Taller futbol2 = new Taller("futbol borrar", 40, 15000, schedulea, new Sala("CanchaFutbol", schedulea), new Categoria());
      Taller tenis = new Taller("tenis", 40, 15000, schedulec, new Sala("CanchaTenis", schedulec), new Categoria());
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
      File.Delete(fileName);
      fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Workshops.txt");
      fs = new FileStream(fileName, FileMode.Open);
      List<Taller> workshops = formatter.Deserialize(fs) as List<Taller>;
      foreach (Taller t in workshops) talleres.Add(t);
      fs.Close();
      File.Delete(fileName);
      return true;
    }





  }
}
