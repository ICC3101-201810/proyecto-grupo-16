﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
  [Serializable]
  public class Media
  {
    String tipo, path;

    public Media(String tipo, String path)
    {
      this.tipo = tipo;
      this.path = path;
    }
  }
}