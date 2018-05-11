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
    public event EventHandler<LogInEventArgs> OnAlumnoEliminarTaller;
    public event EventHandler<LogInEventArgs> OnAlumnoIngresarTaller;
    public event EventHandler<LogInEventArgs> OnVolverMenuAlumno;
    public event EventHandler<LogInEventArgs> OnClosingApp;

    LogInEventArgs logInArgs = new LogInEventArgs();

    Dictionary<String,Panel> panels = new Dictionary<String, Panel>(); //Diccionario que permite manejar los distintos paneles del form1. 
    List<String> bloques = new List<String>() { "8:30-10:30", "10:30-12:30", "12:30-14:30", "14:30-16:30", "16:30-18:30" };

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
        logInArgs.credenciales = new List<string>();
        logInArgs.credenciales.Add(this.nametxtbox.Text); 
        logInArgs.credenciales.Add(this.pwdtxtbox.Text);
        logInArgs.panels = this.panels;
        OnLogIn(this, logInArgs);
      }
    }

    private void incribirT_Click(object sender, EventArgs e)
    {
      if (OnAlumnoInscribirTaller != null)
      {
        if (listTalleresDisponibles.SelectedIndex>-1 && !listTalleresDisponibles.SelectedItem.Equals("No existen talleres disponibles en el horario del alumno"))
        {
          logInArgs.taller = listTalleresDisponibles.SelectedItem as Taller;
          OnAlumnoInscribirTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: No existe taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private void eliminarTaller_Click(object sender, EventArgs e)
    {
      if (OnAlumnoEliminarTaller != null)
      {
        if (listTalleresInscritos.SelectedIndex > -1 && !listTalleresInscritos.SelectedItem.Equals("No existen talleres inscritos por el alumno"))
        {
          logInArgs.taller = listTalleresInscritos.SelectedItem as Taller;
          OnAlumnoEliminarTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: No existe taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ingresarATaller_Click(object sender, EventArgs e)
    {
      if (OnAlumnoIngresarTaller != null)
      {
        if (listTalleresInscritos.SelectedIndex > -1 && !listTalleresInscritos.SelectedItem.Equals("No existen talleres inscritos por el alumno"))
        {
          logInArgs.taller = listTalleresInscritos.SelectedItem as Taller;
          OnAlumnoIngresarTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: No existe taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void volverPanel1_Click(object sender, EventArgs e)
    {
      if (OnVolverMenuAlumno != null)
      {
        OnVolverMenuAlumno(this, logInArgs);
      }
    }

    //Este metodo dice que cuando se carge la forma 1, agregue los paneles a la lista panel. 
    //Si crean un panel nuevo tienen que agregarlo aca para despues manejarlo en el controlador!
    //El for each deja visible solo el login 
    private void Form1_Load(object sender, EventArgs e)
    {
      panels.Add("Login",loginpanel);
      panels.Add("StudentMenu",StudentMenu);
      panels.Add("StudentWsMenu", studentWSMenu);
      foreach (String s in panels.Keys)
        if (!s.Equals("Login"))
          panels[s].Visible = false;

    }
    
    public void ActualizarTalleresDisponibles(Taller taller, bool borrar)
    {
      if (borrar)
        if (listTalleresDisponibles.Items.Count == 1)
          listTalleresDisponibles.Items[0] = "No existen talleres disponibles en el horario del alumno";
        else
          listTalleresDisponibles.Items.Remove(taller);
      else
        if (listTalleresDisponibles.Items.Count>0 && listTalleresDisponibles.Items[0].Equals("No existen talleres disponibles en el horario del alumno"))
        {
          listTalleresDisponibles.Items.Add(taller);
          listTalleresDisponibles.Items.RemoveAt(0);
        }
        else
            listTalleresDisponibles.Items.Add(taller);
    }

    public void NoHayTalleresDisponibles()
    {
      listTalleresDisponibles.Items.Add("No existen talleres disponibles en el horario del alumno");
    }


    public void ActualizarTalleresInscritos(Taller taller, bool borrar)
    {
      if (borrar)
        if (listTalleresInscritos.Items.Count == 1)
          listTalleresInscritos.Items[0] = "No existen talleres inscritos por el alumno";
        else
          listTalleresInscritos.Items.Remove(taller);
      else
      if (listTalleresInscritos.Items.Count > 0 && listTalleresInscritos.Items[0].Equals("No existen talleres inscritos por el alumno"))
      {
        listTalleresInscritos.Items.Add(taller);
        listTalleresInscritos.Items.RemoveAt(0);
      }
      else
        listTalleresInscritos.Items.Add(taller);
    }

    public void NoHayTalleresInscritos()
    {
      listTalleresInscritos.Items.Add("No existen talleres inscritos por el alumno");
    }

    public void ActualizarPerfilTaller(Taller ws)
    {
      string schedule = "";
      nombreTaller.Text = ws.nombre;
      foreach (String day in ws.GetHorario().Keys)
        for (int i = 0; i < ws.GetHorario()[day].Count; i++)
          if (ws.GetHorario()[day][i]) schedule = String.Concat(schedule, "| ", day + ": " + bloques[i]);
      horarioTaller.Text = schedule;
      cuposTaller.Text = ws.GetCuposDisponibles().ToString();
      numeroForos.Text = ws.GetForos().Count.ToString();
      listForosTaller.Items.Clear();
      listForosForoMenu.Items.Clear();
      foreach (Foro foro in ws.GetForos())
      {
        listForosTaller.Items.Add(foro.tema);
        listForosForoMenu.Items.Add(foro.tema);
      }
    }





    //Metodos para confirmar cierre
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      close_Click();
      CloseCancel(e);
    }
    private void close_Click()
    {
      OnClosingApp(this, logInArgs);
    }

    private void CloseCancel(FormClosingEventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
        e.Cancel = true;
    }







    //--> ir a LoginEventArgs
  }
}
