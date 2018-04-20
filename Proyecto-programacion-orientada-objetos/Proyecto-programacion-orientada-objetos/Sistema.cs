using System;
using System.Collections.Generic;

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

    public Sistema(List<Usuario> usuarios, List<Administrador> administradores, List<Profesor> profesores, List<Alumno> alumnos, List<Taller> talleres, List<Categoria> categorias, List<Sala> salas)
    {
      this.usuarios = usuarios;
      this.administradores = administradores;
      this.profesores = profesores;
      this.alumnos = alumnos;
      this.talleres = talleres;
      this.categorias = categorias;
      this.salas = salas;
    }

    public Sistema()
    {
    }

    public bool InscribirAlumno(Alumno alumno, Taller taller)
    { return true; }
    public List<Taller> MostrarTallerresDisponibles()
    { return talleres; }
    public bool CrearForo(Taller taller, string nombreForo)
    { return true; }
    public List<Mensaje> LeerForo(Taller taller, Foro foro)
    { return foro.GetMensajes(); }
    public bool EnviarMensaje(Taller taller, Foro foro, string texto, Usuario usuario, List<Media> media)
    { return true; }
    public bool RegistrarAlumno(string rut, string nombre, string apellido, string email, string telefono, string clave)
    { return true; }
    public bool RegistrarProfesor(string rut, string nombre, string apellido, string email, string telefono, string clave)
    { return true; }
    public bool EliminarMensaje(Taller taller, Foro foro, Mensaje mensaje)
    { return true; }
    public bool EliminarAlumno(Alumno alumno)
    { return true; }
    public bool CrearTaller(string nombre, int cupos, int precio, List<bool> horario, Sala sala, Categoria categoria)
    { return true; }
    public bool ModificarTaller(Taller taller)
    { return true; }
    public bool DesinscribirAlumno(Taller taller, Alumno alumno)
    { return true; }
    public bool CrearEncuesta(Taller taller, string tema, List<Pregunta> preguntas)
    { return true; }
    public bool ResponderEncuesta(Taller taller, string tema, Alumno alumno, List<String> respuestaAlternativas)
    { return true; }
    public void GenerarEstadisticaEncuesta(Taller taller, Encuesta encuesta)
    { }




  }
}
