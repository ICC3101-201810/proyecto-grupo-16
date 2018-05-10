using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{

  class Controller
  {
    List <Usuario> usuarios = new List<Usuario>();
    List <Administrador> administradores = new List<Administrador>();
    List <Profesor> profesores = new List<Profesor>();
    List <Alumno> alumnos = new List<Alumno>();

    public Controller(Login vistaPilotos)
    {
      Pilotos = new List<Usuario>();
      this.vistaPilotos = vistaPilotos;
      this.vistaPilotos.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto;
    }

    private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
    {
      Usuario piloto = new Usuario(e.nombre, e.rol);
      Pilotos.Add(piloto);
      vistaPilotos.ActualizarListadoPilotos(piloto);
    }


  }
}
