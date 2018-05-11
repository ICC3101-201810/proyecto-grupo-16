using System;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Pregunta
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