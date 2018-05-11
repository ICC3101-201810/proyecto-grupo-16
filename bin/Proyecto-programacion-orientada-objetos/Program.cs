using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Dictionary<String, Form> vistas = new Dictionary<String, Form>();
      vistas.Add("Login", new Login());
      Controller controlador = new Controller(vistas);


      Application.Run(vistas["Login"]);
    }
  }
}
