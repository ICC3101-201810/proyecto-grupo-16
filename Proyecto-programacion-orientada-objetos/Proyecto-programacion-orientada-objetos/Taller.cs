﻿using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Entrega_2
{
  class Taller
  {
    String nombre;
    int cupos, precio, actualInscritos;
    List<Boolean> horario;
    List<Foro> foros;
    List<Encuesta> encuestas;
    Sala sala;
    Categoria categoria;

    public Taller(String nombre, int cupos, int precio, List<Boolean> horario, List<Foro> foros, List<Encuesta> encuestas, Sala sala, Categoria categoria)
    {
      this.nombre = nombre;
      this.cupos = cupos;
      this.precio = precio;
      this.horario = horario;
      this.foros = foros;
      this.encuestas = encuestas;
      this.sala = sala;
      this.categoria = categoria;
    }

    public List<Boolean> GetHorario()
    {
      return horario;
    }

    public int GetCuposDisponibles()
    {
      return cupos - actualInscritos;
    }

    public int GetCuposIniciales()
    {
      return cupos;
    }

    public Boolean Inscribible()
    {
      //if (GetCupos() > 0) return true;
      return false;
    }

    public Boolean Inscribir()
    {
      actualInscritos += 1;
      return true;
    }

    public Boolean CrearForo(String nombre, Boolean provacidad)
    {
      return true;
    }

    public List<Foro> GetForos()
    {
      return foros;
    }

    public Boolean CrearEncuesta(String tema, List<Pregunta> preguntas)
    {
      return true;
    }

    public List<Encuesta> GetEncuestas()
    {
      return encuestas;
    }
  }
}
