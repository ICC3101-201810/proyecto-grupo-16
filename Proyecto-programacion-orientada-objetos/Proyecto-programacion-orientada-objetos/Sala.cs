using System;
using System.Collections.Generic;

namespace Entrega_2
{
  [Serializable]
  class Sala
  {
    
    String nombre;
    List<Boolean> horario;

    public Sala(String nombre, List<Boolean> horario)
    {
      this.nombre = nombre;
      this.horario = horario;
    }

    public List<Boolean> GetHorario()
    {
      return horario;
    }

    // Ingresa el horario de la sala. Retorna true si fue ingresado con exito.
    public Boolean SetHorario()
    {

      return true;
    }
  }
}
