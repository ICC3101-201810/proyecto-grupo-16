using System;
using System.Collections.Generic;

namespace Entrega_2
{
  class Encuesta
  {
    String tema;
    List<Pregunta> preguntas;
    List<Respuesta> respuestas;

    public Encuesta(String tema, List<Pregunta> preguntas, List<Respuesta> respuestas)
    {
      this.tema = tema;
      this.preguntas = preguntas;
      this.respuestas = respuestas;
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
