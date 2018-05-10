
using System;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Administrador : Usuario
  {
    public Administrador(String rut, String nombre, String apellido, String email, String telefono, String clave)
        : base(rut, nombre, apellido, email, telefono, clave)
    {

    }
  }
}