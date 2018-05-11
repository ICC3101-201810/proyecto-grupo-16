using System;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Respuesta
  {
    Alumno autor;
    List<String> respuestaAlternativas;

    public Respuesta(Alumno autor, List<String> respuestaAlternativas)
    {
      this.autor = autor;
      this.respuestaAlternativas = respuestaAlternativas;
    }
  }
}