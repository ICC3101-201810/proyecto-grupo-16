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
    public event EventHandler<LogInEventArgs> OnAlumnoCrearForo;
    public event EventHandler<LogInEventArgs> OnAlumnoIngresarAForo;
    public event EventHandler<LogInEventArgs> OnAlumnoSalirDeForo;
    public event EventHandler<LogInEventArgs> OnAlumnoIngresarMensajeForo;
    public event EventHandler<LogInEventArgs> OnAlumnoEliminarMensaje;

    //Event Handler admin
    public event EventHandler<LogInEventArgs> OnAdminEliminarTaller;
    public event EventHandler<LogInEventArgs> OnAdminCrearTaller;





    LogInEventArgs logInArgs = new LogInEventArgs();

    Dictionary<String, Panel> panels = new Dictionary<String, Panel>(); //Diccionario que permite manejar los distintos paneles del form1. 
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
        if (listTalleresDisponibles.SelectedIndex > -1 && !listTalleresDisponibles.SelectedItem.Equals("No existen talleres disponibles en el horario del alumno"))
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

    private void alumnoCrearForo_Click(object sender, EventArgs e)
    {
      if (OnAlumnoCrearForo != null)
      {
        if (!temaForo.Text.Equals(""))
        {
          logInArgs.temaForo = temaForo.Text;
          OnAlumnoCrearForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe ingresar un tema", "Error: No se entrega Tema", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ingresarAForo_Click(object sender, EventArgs e)
    {
      if (OnAlumnoIngresarAForo != null)
      {
        if (listForosForoMenu.SelectedIndex > -1 && !listForosForoMenu.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listForosForoMenu.SelectedItem as Foro;
          OnAlumnoIngresarAForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: No existe foro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void alumnoSalirDeForo_Click(object sender, EventArgs e)
    {
      if (OnAlumnoSalirDeForo != null)
      {
        logInArgs.foro = listForosForoMenu.SelectedItem as Foro;
        OnAlumnoSalirDeForo(this, logInArgs);
      }
    }

    private void alumnoIngresarMensaje_Click(object sender, EventArgs e)
    {
      if (OnAlumnoIngresarMensajeForo != null)
      {
        if (!alumnoIngresarMensajeTexto.Text.Equals(""))
        {
          logInArgs.mensaje = alumnoIngresarMensajeTexto.Text;
          OnAlumnoIngresarMensajeForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe ingresar un mensaje", "Error: No se ingresa mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void alumnoEliminarMensaje_Click(object sender, EventArgs e)
    {
      if (OnAlumnoEliminarMensaje != null)
      {
        if (listMensajesForo.SelectedIndex > -1 && !listMensajesForo.SelectedItem.Equals("El foro no contiene mensajes"))
        {
          logInArgs.objetoMensaje = listMensajesForo.SelectedItem as Mensaje;
          OnAlumnoEliminarMensaje(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un mensaje", "Error: No se selecciona mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    //Eventos del admin
    private void adminEliminarTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarTaller != null)
      {
        if (adminListTalleres.SelectedIndex > -1 && !adminListTalleres.SelectedItem.Equals("No existen talleres creados"))
        { 
          logInArgs.taller = adminListTalleres.SelectedItem as Taller;
          OnAdminEliminarTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: No existe taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void adminCrearTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminCrearTaller != null)
      {
        if (!adminNombreTaller.Text.Equals("") && Convert.ToInt32(Math.Round(adminCuposTaller.Value, 0)) >0 && Convert.ToInt32(Math.Round(adminPrecioTaller.Value, 0))>00 && adminListSalas.SelectedIndex > -1 &&
          !adminListSalas.SelectedItem.Equals("No existen salas creadas") && !adminListSalas.SelectedItem.Equals("") && (horarioLunes.CheckedItems.Count!=0 || horarioMartes.CheckedItems.Count != 0 ||
          horarioMiercoles.CheckedItems.Count != 0 || horarioJueves.CheckedItems.Count != 0 || horarioViernes.CheckedItems.Count != 0))
        {
          logInArgs.nombreTaller = adminNombreTaller.Text;
          logInArgs.cuposTaller = Convert.ToInt32(Math.Round(adminCuposTaller.Value, 0));
          logInArgs.precioTaller = Convert.ToInt32(Math.Round(adminPrecioTaller.Value,0));
          logInArgs.salaTaller = adminListSalas.SelectedItem as Sala;
          logInArgs.horarioTaller = HorarioLimpio();
          for (int i = 0; i <= (horarioLunes.Items.Count - 1); i++)
          {
            if (horarioLunes.GetItemChecked(i))
              logInArgs.horarioTaller["Lunes"][i] = true;
            if (horarioMartes.GetItemChecked(i))
              logInArgs.horarioTaller["Martes"][i] = true;
            if (horarioMiercoles.GetItemChecked(i))
              logInArgs.horarioTaller["Miercoles"][i] = true;
            if (horarioJueves.GetItemChecked(i))
              logInArgs.horarioTaller["Jueves"][i] = true;
            if (horarioViernes.GetItemChecked(i))
              logInArgs.horarioTaller["Viernes"][i] = true;
          }
          OnAdminCrearTaller(this,logInArgs);
        }
        else MessageBox.Show("ERROR: Debe completar los campos", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
      panels.Add("AdminMenu", MenuAdmin);
      foreach (String s in panels.Keys)
        if (!s.Equals("Login"))
          panels[s].Visible = false;

    }
    

    // Metodos del estudiante

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
      listForosTaller.Items.Clear();
      listForosForoMenu.Items.Clear();
      if (ws.GetForos().Count > 0)
        foreach (Foro foro in ws.GetForos())
        {
          ActualizarListaForos(foro);
        }
      else
        NoHayForosTaller();
      numeroForos.Text = ws.GetForos().Count.ToString();
    }

    public void ActualizarListaForos(Foro forum)
    {
      if (listForosTaller.Items.Count > 0 && listForosTaller.Items[0].Equals("No se han creado foros"))
      {
        listForosTaller.Items.Add(forum);
        listForosForoMenu.Items.Add(forum);
        listForosTaller.Items.RemoveAt(0);
        listForosForoMenu.Items.RemoveAt(0);
      }
      else
      {
        listForosTaller.Items.Add(forum);
        listForosForoMenu.Items.Add(forum);
      }
    }
    public void NoHayForosTaller()
    {
      listForosTaller.Items.Add("No se han creado foros");
      listForosForoMenu.Items.Add("No se han creado foros");
    }

    public void ActualizarCantidadForosTaller(Taller ws)
    {
      numeroForos.Text = ws.GetForos().Count.ToString();
    }

    public void ClearIngresoTemaForoTaller()
    {
      temaForo.Clear();
    }

    public void ActualizarListaMensajesForo(Mensaje m, bool borrar)
    {
      if (borrar)
        if (listMensajesForo.Items.Count == 1)
          listMensajesForo.Items[0] = "El foro no contiene mensajes";
        else
          listMensajesForo.Items.Remove(m);
      else
        if (listMensajesForo.Items.Count > 0 && listMensajesForo.Items[0].Equals("El foro no contiene mensajes"))
        {
          listMensajesForo.Items.Add(m);
          listMensajesForo.Items.RemoveAt(0);
        }
      else
        listMensajesForo.Items.Add(m);
      alumnoIngresarMensajeTexto.Clear();
    }

    public void NoExistenMensajesForo()
    {
      listMensajesForo.Items.Add("El foro no contiene mensajes");
    }

    public void ClearListaMensajesForo()
    {
      listMensajesForo.Items.Clear();
    }

    //Metodos del admin

    public void ActualizarTalleresAdmin(Taller taller, bool borrar)
    {
      if (borrar)
        if (adminListTalleres.Items.Count == 1)
          adminListTalleres.Items[0] = "No existen talleres creados";
        else
          adminListTalleres.Items.Remove(taller);
      else
      {
        if (adminListTalleres.Items.Count > 0 && adminListTalleres.Items[0].Equals("No existen talleres creados"))
        {
          adminListTalleres.Items.Add(taller);
          adminListTalleres.Items.RemoveAt(0);
        }
        else
          adminListTalleres.Items.Add(taller);
      }
    }

    public void ActualizarAdminTallerSalas(Sala sala, bool borrar)
    {
      if (borrar)
        if (adminListSalas.Items.Count == 1)
          adminListSalas.Items[0] = "No existen salas creadas";
        else
          adminListSalas.Items.Remove(sala);
      else
      {
        if (adminListSalas.Items.Count > 0 && adminListSalas.Items[0].Equals("No existen salas creadas"))
        {
          adminListSalas.Items.Add(sala);
          adminListSalas.Items.RemoveAt(0);
        }
        else
          adminListSalas.Items.Add(sala);
      }
    }

    public void AdminLimpiarCrearTaller ()
    {
      adminNombreTaller.Clear();
      adminCuposTaller.ResetText();
      adminPrecioTaller.ResetText();
      adminListSalas.ResetText();
      for (int i = 0; i <= (horarioLunes.Items.Count - 1); i++)
      {
        horarioLunes.SetItemChecked(i,false);
        horarioMartes.SetItemChecked(i, false);
        horarioMiercoles.SetItemChecked(i, false);
        horarioJueves.SetItemChecked(i, false);
        horarioViernes.SetItemChecked(i, false);
      }
    }


    //Metodo para simular horarios banner
    public Dictionary<String, List<Boolean>> GenerarHorario(double probability)
    {
      Dictionary<String, List<Boolean>> ret = new Dictionary<String, List<Boolean>>(){
      {"Lunes", GenerarRandomBooleanList(probability) },
      { "Martes", GenerarRandomBooleanList(probability) },
      { "Miercoles", GenerarRandomBooleanList(probability) },
      { "Jueves", GenerarRandomBooleanList(probability) },
      { "Viernes", GenerarRandomBooleanList(probability)}};
      return ret;
    }

    public List<Boolean> GenerarRandomBooleanList(double probability)
    {
      List<Boolean> ret = new List<Boolean>();
      Random random = new Random();
      int temp = 0;
      for (int i = 0; i < 5; i++)
      {
        temp = random.Next(0, 100);
        if (temp >= probability * 100)
          ret.Add(true);
        else
          ret.Add(false);
      }
      return ret;
    }

    //Metodo para simular generacion de horario taller
    public Dictionary<String, List<Boolean>> HorarioLimpio()
    {
      Dictionary<String, List<Boolean>> ret = new Dictionary<String, List<Boolean>>(){
      {"Lunes", GenerarRandomBooleanList(2) },
      { "Martes", GenerarRandomBooleanList(2) },
      { "Miercoles", GenerarRandomBooleanList(2) },
      { "Jueves", GenerarRandomBooleanList(2) },
      { "Viernes", GenerarRandomBooleanList(2)}};
      return ret;
    }



    //Metodos para confirmar cierre
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      //close_Click();
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
