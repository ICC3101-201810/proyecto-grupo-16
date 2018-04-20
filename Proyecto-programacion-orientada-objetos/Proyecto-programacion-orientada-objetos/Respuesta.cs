using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
