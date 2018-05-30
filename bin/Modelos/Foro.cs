using System;
using System.Threading;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Foro
  {
    public String tema { get; }
    List<Mensaje> mensajes = new List<Mensaje>();
    public Boolean privacidad { get; }
    public static int count = 0;
    int id;

    public Foro(String tema, Boolean privacidad)
    {
      this.tema = tema;
      this.privacidad = privacidad;
      this.id = Interlocked.Increment(ref count);
    }
    //public Boolean AgregarMensaje(Usuario usuario, String texto, List<Media> media)
    public Boolean AgregarMensaje(Usuario usuario, String texto)
    {
      mensajes.Add(new Mensaje(usuario, texto));
      return true;
    }

    public Boolean AgregarMensaje(Usuario usuario, String texto, List<Media> media)
    {
      mensajes.Add(new Mensaje(usuario, texto, DateTime.Now, media));
      return true;
    }

    public List<Mensaje> GetMensajes()
    {
      return mensajes;
    }

    public bool DeleteMessage(Mensaje mensaje)
    {
      mensajes.RemoveAll(x => x.codigo == mensaje.codigo);
      return true;
    }
    public bool BorrarMensaje()
    {
      if (mensajes.Count > 0)
      {
        Console.WriteLine("Escriba el número del mensaje que desea eliminar:");
        int i = Int32.Parse(Console.ReadLine());
        mensajes.Remove(mensajes[i - 1]);
        return true;
      }
      else { return false; }
    }
    public string GetTema()
    { return tema; }

    public override string ToString()
    {
      return tema;
    }
    public int GetId()
    {
      return id;
    }
  }
}