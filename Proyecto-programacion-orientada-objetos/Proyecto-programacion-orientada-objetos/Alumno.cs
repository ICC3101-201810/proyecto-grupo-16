using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Alumno : Usuario
  {
    List<Taller> talleresInscritos;
    List<Boolean> horario;

    // Constructor con todos los parametros
    public Alumno(String rut, String nombre, String apellido, String email, String telefono, String clave, List<Taller> talleresInscritos, List<Boolean> horario)
        : base(rut, nombre, apellido, email, telefono, clave)
    {
      this.talleresInscritos = talleresInscritos;
      this.horario = horario;
    }

    // Constructor sin talleres inscritos. Esta pensado en que luego se le incriben talleres al alumno.
    public Alumno(String rut, String nombre, String apellido, String email, String telefono, String clave, List<Boolean> horario)
            : base(rut, nombre, apellido, email, telefono, clave)
    {
      this.talleresInscritos = new List<Taller>();
      this.horario = horario;
    }

    public Boolean InscribirTaller(Taller taller)
    {
      this.talleresInscritos.Add(taller);
      return true;
    }

    public List<Boolean> GetHorario()
    {
      return horario;
    }

    public void SetHorario()
    {

    }

    public List<Taller> GetTalleres()
    {
      return talleresInscritos;
    }

    public void SetTalleres()
    {

    }
  }
}
