using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
  public partial class TalleresVU : Form
  {
    //Se define el handler del evento
    public event EventHandler<LogInEventArgs> OnLogIn;

    public event EventHandler<LogInEventArgs> OnAlumnoInscribirTaller;


    Dictionary<String,Panel> panels = new Dictionary<String, Panel>(); //Diccionario que permite manejar los distintos paneles del form1. 

    //Paneles: Con los paneles podemos generar distintas vistas. Piensen que es como un contenedor o una pagina que podemos hacer visible o no dependiendo de donde estemos.

    public TalleresVU()
    {
      InitializeComponent();
    }

    //Evento de click en ingresar
    private void LogInButton_Click(object sender, EventArgs e)
    {
      //Revisa si hay metodos suscritos. Si los hay crea una instancia de argumentos, donde se pasa el usuario, la password y la lista de los paneles.
      //Estos se usan en el metodo que está en el controller para inciar sesion. El paso de argumentos permite que entre clases puedan conocer los valores.
      //Entonces se pasan los valores de la forma y el controlador verifica si cumple los requisitos. Igual cuando interfaz pasaba lo que ingresaba el usuario a Sistema!
      if (OnLogIn != null)
      {
        LogInEventArgs logInArgs = new LogInEventArgs();
        logInArgs.credenciales = new List<string>();
        logInArgs.credenciales.Add(this.nametxtbox.Text); 
        logInArgs.credenciales.Add(this.pwdtxtbox.Text);
        logInArgs.panels = this.panels;
        OnLogIn(this, logInArgs);
      }
    }
  
    //Este metodo dice que cuando se carge la forma 1, agregue los paneles a la lista panel. 
    //Si crean un panel nuevo tienen que agregarlo aca para despues manejarlo en el controlador!
    //El for each deja visible solo el login 
    private void Form1_Load(object sender, EventArgs e)
    {
      panels.Add("Login",loginpanel);
      panels.Add("StudentMenu",StudentMenu);
      foreach (String s in panels.Keys)
        if (!s.Equals("Login"))
          panels[s].Visible = false;

    }

    public void ActualizarTalleresDisponibles(Taller taller)
    {
      listTalleresDisponibles.Items.Add(taller);
    }

    private void incribirT_Click(object sender, EventArgs e)
    {
      if (OnAlumnoInscribirTaller != null)
      {
        LogInEventArgs inscribirTallerEventArgs = new LogInEventArgs();
        inscribirTallerEventArgs.taller = listTalleresDisponibles.SelectedItem as Taller;
        OnAlumnoInscribirTaller(this, inscribirTallerEventArgs);
      }
    }

    //--> ir a LoginEventArgs
  }
}
