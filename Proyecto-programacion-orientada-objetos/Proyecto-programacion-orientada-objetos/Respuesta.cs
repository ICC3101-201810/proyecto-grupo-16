﻿using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Respuesta
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
