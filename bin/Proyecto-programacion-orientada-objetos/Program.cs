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
      Dictionary<String, Form> vistas = new Dictionary<String, Form>(); //Se genera un diccionario de forms. Quizas no sea necesario (ya que se puede trabajar todo en una form)
      vistas.Add("Login", new TalleresVU()); //se agrega al diccionario la Form1 que se llama TalleresVU
      Controller controlador = new Controller(vistas); //se crea el controlador


      Application.Run(vistas["Login"]); //se incia la aplicacion--> ir al controlador
    }
  }
}
