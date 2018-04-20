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
    List<String> bloques = new List<String>() { "8:30-10:30", "10:30-12:30", "12:30-14:30", "14:30-16:30", "16:30-18:30" };

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
    public Dictionary<Taller, List<String>> GetTallerresDisponibles(Alumno alumno)
    {
            Dictionary<Taller, List<String>> disponibles = new Dictionary<Taller, List<String>>();
            Dictionary<String,List<Boolean>> studentSchedule = alumno.GetHorario();
            Dictionary<String, List<Boolean>> wsSchedule = new Dictionary<string, List<bool>>();

            foreach (Taller ws in talleres)
            {
                wsSchedule = ws.GetHorario();
                List<String> avaliableBlocks = new List<String>();
                foreach (String day in wsSchedule.Keys)
                {
                    int i = 0;
                    foreach (Boolean avaliable in studentSchedule[day]) if (studentSchedule[day][i++] && wsSchedule[day][i])
                        {
                            avaliableBlocks.Add(String.Concat(day, ": ", bloques[i]));
                            Console.WriteLine(String.Concat(day, ": ", bloques[i]));
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
    public bool RegistrarAlumno(string rut, string nombre, string apellido, string email, string telefono, string clave, Dictionary<String, List<bool>>horario)
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
    public bool CrearTaller(string nombre, int cupos, int precio, Dictionary<String,List<bool>> horario, Sala sala, Categoria categoria)
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
    public void Menu()
    {
            LoadData();
            Interfaz interfaz = new Interfaz();
            List<String> credenciales = new List<String>{"",""};
            while (!VerifyUser(credenciales))
            {
                credenciales=interfaz.LogInLogOut();
                interfaz.ErrorCredenciales(VerifyUser(credenciales));
            }



            if (GetUser(credenciales).GetType() == typeof(Alumno))
            {
                List<Boolean> studentOption = new List<Boolean>();
                studentOption = interfaz.StudentsMenu();
                while (!studentOption[3])
                {
                    if (studentOption[0])
                    {
                        interfaz.WorkShopAvailable(GetTallerresDisponibles((Alumno)GetUser(credenciales)));
                    }
                    else if (studentOption[1])
                    {
                        interfaz.WorkShopAvailable(GetTallerresDisponibles((Alumno)GetUser(credenciales)));
                    }
                    else if (studentOption[2])
                    {
                        interfaz.WorkShopAvailable(GetTallerresDisponibles((Alumno)GetUser(credenciales)));
                    }
                    studentOption = interfaz.StudentsMenu();
                }
            }








            //Dictionary<String, List<Boolean>> schedulea = new Dictionary<String, List<Boolean>>(){
            //    {"Lunes", new List<Boolean>() {false, true, false, false, false } },
            //    { "Martes", new List<Boolean>() { false, false, false, false, false } },
            //    { "Miercoles", new List<Boolean>() {false, true, false, false, false } },
            //    { "Jueves", new List<Boolean>() {false, false, false, false, false } },
            //    { "Viernes", new List<Boolean>() {false, false, false, false, false }}};
            //Dictionary<String, List<Boolean>> scheduleb = new Dictionary<String, List<Boolean>>(){
            //    {"Lunes", new List<Boolean>() {false, true, false, false, false } },
            //    { "Martes", new List<Boolean>() { false, false, true, false, false } },
            //    { "Miercoles", new List<Boolean>() {false, true, false, false, false } },
            //    { "Jueves", new List<Boolean>() {false, false, true, false, false } },
            //    { "Viernes", new List<Boolean>() {false, false, false, false, false }}};

            //Taller futbol = new Taller("futbol", 40, 15000, schedulea,new Sala("CanchaFutbol", schedulea), new Categoria());
            //talleres.Add(futbol);
            //Administrador administrador1 = new Administrador("18123456-7", "Carlos", "Diaz", "c@m.cl", "+56991929394", "1234");
            //administradores.Add(administrador1);
            //Profesor profesor1 = new Profesor("18234567-8", "Andres", "Howard", "a@m.cl", "+5699293949596", "1234");
            //profesores.Add(profesor1);
            //Alumno alumno1 = new Alumno("18884427-8", "Israel", "Cea", "i@m.cl", "+56999404286", "1234", scheduleb);
            //alumnos.Add(alumno1);
            //usuarios.Add(administrador1);
            //usuarios.Add(profesor1);
            //usuarios.Add(alumno1);





            SaveData(usuarios, talleres);
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
        string fileName = "Users.txt";
        FileStream fs = new FileStream(fileName, FileMode.Create);
        IFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, usuarios);
        fs.Close();
        fileName = "WorkShops.txt";
        fs = new FileStream(fileName, FileMode.Create);
        formatter.Serialize(fs, talleres);
        fs.Close();
        

        }

    private void LoadData()
    {
        string fileName = "Users.txt";
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
        fileName = "Workshops.txt";
        fs = new FileStream(fileName, FileMode.Open);
        List<Taller> workshops =formatter.Deserialize(fs) as List<Taller>;
        foreach (Taller t in workshops) talleres.Add(t);
        fs.Close();
        
        }




    }
}
