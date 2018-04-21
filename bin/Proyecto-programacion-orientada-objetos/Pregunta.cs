using System;
using System.Collections.Generic;

namespace Entrega_2
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
