﻿using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Taller
  {
    public String nombre { get; set; }
    int cupos, precio, actualInscritos;
    List<Boolean> horario;
    List<Foro> foros;
    List<Encuesta> encuestas;
    Sala sala;
    Categoria categoria;

    public Taller(String nombre, int cupos, int precio, List<Boolean> horario, Sala sala, Categoria categoria)
    {
      this.nombre = nombre;
      this.cupos = cupos;
      this.precio = precio;
      this.horario = horario;
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

    public void SetCuposDisponibles()
    {
            actualInscritos+=1;
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
  }
}
