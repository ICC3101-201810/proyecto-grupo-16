using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Encuesta
  {
    String tema;
    List<Pregunta> preguntas;
    List<Respuesta> respuestas= new List<Respuesta>();

    public Encuesta(String tema, List<Pregunta> preguntas)
    {
      this.tema = tema;
      this.preguntas = preguntas;
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
