using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Foro
  {
    String tema;
    List<Mensaje> mensajes;
    Boolean privacidad;

    public Foro(String tema, List<Mensaje> mensajes, Boolean privacidad)
    {
      this.tema = tema;
      this.mensajes = mensajes;
      this.privacidad = privacidad;
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
  }
}
