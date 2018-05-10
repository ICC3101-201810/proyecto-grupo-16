using System;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  class Pregunta
  {
    string texto;
    List<string> alternativas;

    public Pregunta(string texto, List<string> alternativas)
    {
      this.texto = texto;
      this.alternativas = alternativas;
    }
  }
}