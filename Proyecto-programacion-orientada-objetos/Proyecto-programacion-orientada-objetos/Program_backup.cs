using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2
{
  class Program_backup
  {

    /*static void Main(string[] args)
    {
      //SE CREAN LOS OBJETOS NECESARIOS PARA EL SISTEMA
      //---------------------------------------------------------------
      List<Usuario> usuarios = new List<Usuario>();
      List<Administrador> administradores = new List<Administrador>();
      List<Profesor> profesores = new List<Profesor>();
      List<Alumno> alumnos = new List<Alumno>();
      List<Taller> talleres = new List<Taller>();
      List<Categoria> categorias = new List<Categoria>();
      List<Sala> salas = new List<Sala>();
      //----------------------------------------------------------------

      Taller futbol = new Taller("futbol", 40, 15000, new List<bool>(){ false, true, false, false, false }, new List<Foro>() ,new List<Encuesta>(), new Sala("CanchaFutbol", new List<bool>() { false, true, false, false, false }), new Categoria() );
      talleres.Add(futbol); 
      Administrador administrador1 = new Administrador("18123456-7", "Carlos", "Diaz", "c@m.cl", "+56991929394", "1234");
      administradores.Add(administrador1);
      Profesor profesor1 = new Profesor("18234567-8", "Andres", "Howard", "a@m.cl","+5699293949596", "1234", new List<Taller> { futbol});
      profesores.Add(profesor1);
      Alumno alumno1 = new Alumno("18884427-8", "Israel", "Cea", "i@m.cl","+56999404286", "1234", new List<Taller> {futbol}, new List<bool>() { false, true, false, false, false });
      alumnos.Add(alumno1);
      usuarios.Add(administrador1);
      usuarios.Add(profesor1);
      usuarios.Add(alumno1);
      Sistema sistema = new Sistema(usuarios, administradores, profesores, alumnos, talleres, categorias, salas);
      //----------------------------------------------------------------
      //INICIO DEL PROGRAMA
      Console.WriteLine("Bienvenido Talleres VU");
      Usuario usuarioLogin = new Usuario("", "", "", "", "", "");
      //----------------------------------------------------------------
      bool entrar1 = false;
      while (entrar1 == false)
      {
          Console.WriteLine("Ingrese su mail:");
          string mailLogin = Console.ReadLine();
          Console.WriteLine("Ingrese su clave:");
          string claveLogin = Console.ReadLine();
          bool haEntrado = false;
          foreach (Usuario u in usuarios)//Recorre la lista de usuarios para ver si está registrado el mail
          {
              string claveU = u.GetClave();
              string mailU = u.GetMail();
              if (mailU == mailLogin && claveU == claveLogin)
              {
                  haEntrado = true;
                  usuarioLogin = u;
                  string nombreU = u.GetNombre();
                  Console.WriteLine("Hola " + nombreU + "!");
                  break;
              }
              else
              {
                  haEntrado = false;
              }
          }
          if (haEntrado == true)
          {
              entrar1 = true;
          }
          if(haEntrado==false)
          {
              Console.WriteLine("Clave o Usuario incorrectas! Vuelva a escribir sus datos.");
              entrar1 = false;
          }

      }

      //----------------------------------------------------------------
      //SE IDENTIFICA EL TIPO DE USUARIO QUE ACCEDE A LA APLICACIÓN
      Type tipoUsuario = usuarioLogin.GetType();
      if (tipoUsuario.Equals(typeof(Administrador)))
          { Console.WriteLine("Usted es Administrador"); }
      if (tipoUsuario.Equals(typeof(Profesor)))
          { Console.WriteLine("Usted es Profesor"); }
      if (tipoUsuario.Equals(typeof(Alumno)))
          { Console.WriteLine("Usted es Alumno"); }
      Console.ReadKey();

    }*/
  }
}
