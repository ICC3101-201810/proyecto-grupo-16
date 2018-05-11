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

  }
}
