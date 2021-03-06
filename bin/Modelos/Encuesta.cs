﻿using System;
using System.Collections.Generic;

namespace Modelos
{
  [Serializable]
  public class Encuesta
  {
    public String tema { get; set; }
    List<Pregunta> preguntas;
    List<string> respuestasCorrectas; //esta lista guarda las alternativas correctas para su posterior comparación con la lista de respuestas que entrega el alumno 
    List<Respuesta> respuestas;

    public Encuesta(String tema, List<Pregunta> preguntas)
    {
      this.tema = tema;
      this.preguntas = preguntas;
      respuestas = new List<Respuesta>();
    }
    public List<Pregunta> GetPreguntas()
    {
      return preguntas;
    }
    public List<Respuesta> GetRespuesta()
    {
      return respuestas;
    }
    public Boolean SetRespuesta(Alumno alumno, List<String> respuestasAlumno)
    {
      respuestas.Add(new Respuesta(alumno, respuestasAlumno));
      return true;
    }


  }
}