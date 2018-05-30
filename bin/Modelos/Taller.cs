using System;
using System.Threading;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Taller
  {
    public String nombre { get; set; }
    int cupos, precio, actualInscritos;
    Dictionary<String, List<Boolean>> horario;
    List<Foro> foros = new List<Foro>();
    List<Encuesta> encuestas = new List<Encuesta>();
    public Sala sala { get; set; }
    public static int count=0;
    int id;
    Categoria categoria;


    public Taller(String nombre, int cupos, int precio, Dictionary<String, List<Boolean>> horario, Sala sala, Categoria categoria)
    {
      this.nombre = nombre;
      this.cupos = cupos;
      this.precio = precio;
      this.horario = horario;
      this.sala = sala;
      this.categoria = categoria;
      this.id= Interlocked.Increment(ref count); 
    }

    public Dictionary<String, List<Boolean>> GetHorario()
    {
      return horario;
    }

    public int GetCuposDisponibles()
    {
      return cupos - actualInscritos;
    }

    public void SetCuposDisponibles()
    {
      actualInscritos += 1;
    }
    public void AddCuposDisponibles()
    {
      actualInscritos -= 1;
    }
    public int GetCuposIniciales()
    {
      return cupos;
    }

    public Boolean Inscribible()
    {
      if (GetCuposDisponibles() > 0) return true;
      return false;
    }

    public Boolean Inscribir()
    {
      actualInscritos += 1;
      return true;
    }

    public Boolean CrearForo(String nombre, Boolean privacidad)
    {
      foros.Add(new Foro(nombre, privacidad));
      return true;
    }

    public List<Foro> GetForos()
    {
      return foros;
    }


    public Boolean CrearEncuesta(String tema, List<Pregunta> preguntas)
    {
      encuestas.Add(new Encuesta(tema, preguntas));
      return true;
    }

    public List<Encuesta> GetEncuestas()
    {
      return encuestas;
    }

    public override string ToString()
    {
      string schedule = "";
      List<String> bloques = new List<String>() { "8:30-10:30", "10:30-12:30", "12:30-14:30", "14:30-16:30", "16:30-18:30" };
      foreach (String day in horario.Keys)
        for (int i = 0; i < horario[day].Count; i++)
          if (horario[day][i]) schedule = String.Concat(schedule, "| ", day + ": " + bloques[i]);

      return nombre + " - " + schedule;
    }

    public int GetId()
    {
      return id;
    }

  }
}