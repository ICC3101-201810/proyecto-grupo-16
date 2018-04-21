using System;
using System.Collections.Generic;

namespace Entrega_2
{
  [Serializable]
  class Mensaje
  {
    public Usuario autor { get; }
    public String texto { get; set; }
    public DateTime fecha { get; }
    public List<Media> media { get; }
    public String codigo { get; }
    Boolean tieneMedia;
    //String codigo_mensaje_string

    public Mensaje(Usuario autor, String texto, DateTime fecha, List<Media> media)
    {
      this.autor = autor;
      this.texto = texto;
      this.fecha = fecha;
      this.media = media;
      codigo = String.Concat(DateTime.Now.ToString(), autor.GetNombre());
    }

    public Boolean TieneMedia()
    {
      if (media.Count > 0) tieneMedia = true;
      else tieneMedia = false;
      return tieneMedia;

    }
  }
}
