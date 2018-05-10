using System;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  class Categoria
  {
    List<String> categorias;

    public List<String> GetCategoria()
    { return categorias; }
  }
}