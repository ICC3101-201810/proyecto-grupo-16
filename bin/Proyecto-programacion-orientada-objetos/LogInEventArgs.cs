using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
  public class LogInEventArgs : EventArgs
  {
    public string user { get; set; }
    public string password { get; set; }
    public Dictionary<String,Panel> panels {get; set;}
  }
}
