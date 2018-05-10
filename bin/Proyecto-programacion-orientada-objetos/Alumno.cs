using System;
using System.Collections.Generic;

namespace Entrega_2
{
  [Serializable]
  class Alumno : Usuario
  {
    public List<Taller> talleresInscritos;
    public Dictionary<String, List<Boolean>> horario;

    // Constructor con todos los parametros
    public Alumno(String rut, String nombre, String apellido, String email, String telefono, String clave, List<Taller> talleresInscritos, Dictionary<String, List<Boolean>> horario)
        : base(rut, nombre, apellido, email, telefono, clave)
    {
      this.talleresInscritos = talleresInscritos;
      this.horario = horario;
    }

    // Constructor sin talleres inscritos. Esta pensado en que luego se le incriben talleres al alumno.
    public Alumno(String rut, String nombre, String apellido, String email, String telefono, String clave, Dictionary<String, List<Boolean>> horario)
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

    public Dictionary<String, List<Boolean>> GetHorario()
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

    public bool DeleteWS(Taller taller)
    {
      talleresInscritos.RemoveAll(x => x.nombre == taller.nombre);
      return true;
    }
    //public override string GetNombre()
    //    { return nombre; }
  }
}
