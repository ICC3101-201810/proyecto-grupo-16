using System;
using System.Threading;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Mensaje
  {
    public Usuario autor { get; }
    public String texto { get; set; }
    public DateTime fecha { get; }
    public List<Media> media { get; }
    public String codigo { get; }
    public static int count = 0;

    //Boolean tieneMedia;
    //String codigo_mensaje_string

    public Mensaje(Usuario autor, String texto, DateTime fecha, List<Media> media)
    {
      this.autor = autor;
      this.texto = texto;
      this.fecha = DateTime.Now;
      this.media = media;
      codigo = String.Concat(DateTime.Now.ToString(), autor.GetNombre(), Interlocked.Increment(ref count).ToString());
    }

    //Constructor sin media
    public Mensaje(Usuario autor, String texto)
    {
      this.autor = autor;
      this.texto = texto;
      this.fecha = DateTime.Now;
      codigo = String.Concat(DateTime.Now.ToString(), autor.GetNombre(), Interlocked.Increment(ref count).ToString());
    }

    /*public Boolean TieneMedia()
    {
      if (media.Count > 0) tieneMedia = true;
      else tieneMedia = false;
      return tieneMedia;
    }*/

    public override string ToString()
    {
      return "---" + "Por " + autor.GetNombre() + " " + autor.apellido + " - " + fecha + ": "+ texto+ "---";
    }
  }
}