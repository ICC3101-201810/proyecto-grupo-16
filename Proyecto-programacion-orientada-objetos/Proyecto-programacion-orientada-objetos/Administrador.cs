using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Administrador : Usuario
  {
    public Administrador(String rut, String nombre, String apellido, String email, String telefono, String clave)
        : base(rut, nombre, apellido, email, telefono, clave)
    {

    }
  }
}

