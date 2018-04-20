using System;
using System.Collections.Generic;

namespace Entrega_2
{
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
