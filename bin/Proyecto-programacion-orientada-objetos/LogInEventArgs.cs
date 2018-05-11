using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
  //Clase que tiene los argumentos con sus get y set.
  public class LogInEventArgs : EventArgs
  {
    public List<String> credenciales { get; set; }
    public Dictionary<String,Panel> panels {get; set;}
    public Taller taller { get; set; }
    public String temaForo { get; set; }
    public Foro foro { get; set; }
    public String mensaje { get; set; }
    public Mensaje objetoMensaje { get; set; }

    //Argumentos para crear taller
    public String nombreTaller { get; set; }
    public int cuposTaller { get; set; }
    public int precioTaller { get; set; }
    public Sala salaTaller { get; set; }
    public Dictionary<String, List<Boolean>> horarioTaller { get; set; }

  }
}
