using System;
using System.Collections.Generic;

namespace Entrega_2
{
  [Serializable]
  class Foro
  {
    String tema;
    List<Mensaje> mensajes = new List<Mensaje>();
    Boolean privacidad;

    public Foro(String tema, Boolean privacidad)
    {
      this.tema = tema;
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

    public bool DeleteMessage(Mensaje mensaje)
    {
      mensajes.RemoveAll(x => x.codigo == mensaje.codigo);
      return true;
    }
  }
}
