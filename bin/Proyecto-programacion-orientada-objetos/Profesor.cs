using System;
using System.Collections.Generic;

namespace Entrega_2
{
  [Serializable]
  class Profesor : Usuario
  {

    public List<Taller> talleresDictados;

    // Constructor con todos los parametros
    public Profesor(String rut, String nombre, String apellido, String email, String telefono, String clave, List<Taller> talleresDictados)
        : base(rut, nombre, apellido, email, telefono, clave)
    {
      this.talleresDictados = talleresDictados;
    }

    // Constructor sin talleres. Para que se le agreguen despues
    /*public Profesor(String rut, String nombre, String apellido, String email, String telefono, String clave)
            : base(rut, nombre, apellido, email, telefono, clave)
    {
      this.talleresDictados = new List<Taller>();
    }*/

    public Boolean InscribirTaller(Taller taller)
    {
      talleresDictados.Add(taller);
      return true;
    }

    public List<Taller> GetTalleres()
    {
      return talleresDictados;
    }

    public void SetTalleres()
    {

    }
    

  }
}
