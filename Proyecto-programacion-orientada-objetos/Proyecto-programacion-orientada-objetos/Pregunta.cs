using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
