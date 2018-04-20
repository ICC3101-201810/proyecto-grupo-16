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
    List<Usuario> usuarios = new List<Usuario>();
    List<Administrador> administradores= new List<Administrador>();
    List<Profesor> profesores= new List<Profesor>();
    List<Alumno> alumnos=new List<Alumno>();
    List<Taller> talleres=new List<Taller>();
    List<Categoria> categorias= new List<Categoria>();
    List<Sala> salas =new List<Sala>();

    public Sistema()
    {
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
    public List<Taller> MostrarTallerresDisponibles()
    {
            return talleres;
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
    public bool RegistrarAlumno(string rut, string nombre, string apellido, string email, string telefono, string clave, List<bool>horario)
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
    public bool CrearTaller(string nombre, int cupos, int precio, List<bool> horario, Sala sala, Categoria categoria)
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
        List <Encuesta> e = taller.GetEncuestas().Where(x => x.tema == tema).ToList();
        e[0].SetRespuesta(alumno, respuestaAlternativas);
        return true;
    }
    public List<String> GenerarEstadisticaEncuesta(Taller taller, Encuesta encuesta)
    {
            List<String> estadisticas = new List<string>();
            string cantidadRespondida, cantidadPorcentual;
            cantidadRespondida = String.Concat("Respuesta: ",encuesta.GetRespuesta().Count);
            cantidadPorcentual = String.Concat("% Respondido: ", encuesta.GetRespuesta().Count/ encuesta.GetPreguntas().Count);
            estadisticas.Add(cantidadRespondida);
            estadisticas.Add(cantidadPorcentual);
            return estadisticas;
    }
    private static void SaveUsers(List<Usuario> usuarios)
    {
        // Creamos el Stream donde guardaremos nuestros usuarios
        string fileName = "Users.txt";
        FileStream fs = new FileStream(fileName, FileMode.CreateNew);
        IFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, usuarios);
        fs.Close();
    }

    private void LoadUsers()
    {
        string fileName = "Users.txt";
        // Creamos el Stream donde se encuentra nuestro juego
        FileStream fs = new FileStream(fileName, FileMode.Open);
        IFormatter formatter = new BinaryFormatter();
        List<Usuario> usuarios = formatter.Deserialize(fs) as List<Usuario>;
        fs.Close();
        foreach (Usuario u in usuarios)
        {
            Type t = u.GetType();
            if (t == typeof(Alumno)) alumnos.Add((Alumno)u);
            else if (t == typeof(Profesor)) profesores.Add((Profesor)u);
            else administradores.Add((Administrador)u);
        }

    }




    }
}
