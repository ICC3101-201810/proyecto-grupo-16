using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
  public class AgregarPilotoEventArgs : EventArgs
  {
    public string nombre { get; set; }
    public Modelos.Rol rol { get; set; }
  }
}
