using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Mensaje
  {
    Usuario autor;
    String texto;
    DateTime fecha;
    List<Media> media;
    Boolean tieneMedia;
    //String codigo_mensaje_string

    public Mensaje(Usuario autor, String texto, DateTime fecha, List<Media> media)
    {
      this.autor = autor;
      this.texto = texto;
      this.fecha = fecha;
      this.media = media;
      TieneMedia();
    }

    public Boolean TieneMedia()
    {
      if (media.Count > 0)
        tieneMedia = true;
      return false;
    }
  }
}
