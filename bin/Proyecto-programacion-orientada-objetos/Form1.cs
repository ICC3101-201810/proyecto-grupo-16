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
    public event EventHandler<LogInEventArgs> OnAdminEliminarAlumno;
    public event EventHandler<LogInEventArgs> OnAdminCrearAlumno;
    public event EventHandler<LogInEventArgs> OnAdminEliminarProfesor;
    public event EventHandler<LogInEventArgs> OnAdminCrearProfesor;
    public event EventHandler<LogInEventArgs> OnAdminEliminarSala;
    public event EventHandler<LogInEventArgs> OnAdminCrearSala;
    public event EventHandler<LogInEventArgs> OnAdminAsignarProfesorTaller;
    public event EventHandler<LogInEventArgs> OnAdminIngresarTaller;
    public event EventHandler<LogInEventArgs> OnVolverMenuAdmin;
    public event EventHandler<LogInEventArgs> OnAdminCrearForo;
    public event EventHandler<LogInEventArgs> OnAdminIngresarAForo;
    public event EventHandler<LogInEventArgs> OnAdminSalirDeForo;
    public event EventHandler<LogInEventArgs> OnAdminEliminarForo;
    public event EventHandler<LogInEventArgs> OnAdminIngresarMensajeForo;
    public event EventHandler<LogInEventArgs> OnAdminEliminarMensaje;
    public event EventHandler<LogInEventArgs> OnAdminEliminarProfesorTaller;
    public event EventHandler<LogInEventArgs> OnAdminAgregarProfesorTaller;
    public event EventHandler<LogInEventArgs> OnAdminEliminarAlumnoTaller;
    public event EventHandler<LogInEventArgs> OnAdminAgregarAlumnoTaller;
    public event EventHandler<LogInEventArgs> OnAdminSeleccionarHorarioTaller;


    // Event Handler Profesor
    public event EventHandler<LogInEventArgs> OnProfesorMostrarTaller;
    public event EventHandler<LogInEventArgs> OnProfesorLeerForo;
    public event EventHandler<LogInEventArgs> OnProfesorCrearForo;
    public event EventHandler<LogInEventArgs> OnProfesorEliminarForo;
    public event EventHandler<LogInEventArgs> OnProfesorAgregarMensaje;
    public event EventHandler<LogInEventArgs> OnProfesorEliminarMensaje;
    public event EventHandler<LogInEventArgs> OnProfesorMostrarParticipantes;

    public event EventHandler<LogInEventArgs> OnCerrarSesion;




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
        if (listForosForoMenu.SelectedIndex > -1 && !listForosForoMenu.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listForosForoMenu.SelectedItem as Foro;
          OnAlumnoSalirDeForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: No existe foro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void alumnoIngresarMensaje_Click(object sender, EventArgs e)
    {
      if (OnAlumnoIngresarMensajeForo != null)
      {
        if (!alumnoIngresarMensajeTexto.Text.Equals("") && listForosForoMenu.SelectedIndex>-1 && !listForosForoMenu.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listForosForoMenu.SelectedItem as Foro ;
          logInArgs.mensaje = alumnoIngresarMensajeTexto.Text;
          OnAlumnoIngresarMensajeForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar foro e ingresar un mensaje", "Error: Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        if (!adminNombreTaller.Text.Equals("") && Convert.ToInt32(Math.Round(adminCuposTaller.Value, 0)) > 0 && Convert.ToInt32(Math.Round(adminPrecioTaller.Value, 0)) > 00 && adminListSalas.SelectedIndex > -1 &&
          !adminListSalas.SelectedItem.Equals("No existen salas creadas") && !adminListSalas.SelectedItem.Equals("") && (horarioLunes.CheckedItems.Count != 0 || horarioMartes.CheckedItems.Count != 0 ||
          horarioMiercoles.CheckedItems.Count != 0 || horarioJueves.CheckedItems.Count != 0 || horarioViernes.CheckedItems.Count != 0))
        {
          logInArgs.nombreTaller = adminNombreTaller.Text;
          logInArgs.cuposTaller = Convert.ToInt32(Math.Round(adminCuposTaller.Value, 0));
          logInArgs.precioTaller = Convert.ToInt32(Math.Round(adminPrecioTaller.Value, 0));
          logInArgs.salaTaller = adminListSalas.SelectedItem as Sala;
          if (adminListProfesorCrearTaller.SelectedIndex>-1)
          {
            logInArgs.profesor = adminListProfesorCrearTaller.SelectedItem as Profesor;
          }
          else logInArgs.profesor = null;

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
          OnAdminCrearTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe completar los campos", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminEliminarAlumno_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarAlumno != null)
      {
        if (adminListAlumnos.SelectedIndex > -1 && !adminListAlumnos.SelectedItem.Equals("No existen alumnos creados"))
        {
          logInArgs.student = adminListAlumnos.SelectedItem as Alumno;
          OnAdminEliminarAlumno(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un alumno", "Error: No existe alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void adminCrearAlumno_Click(object sender, EventArgs e)
    {
      if (OnAdminCrearAlumno != null)
      {
        if (!adminNombreAlumno.Text.Equals("") && !adminApellidoAlumno.Text.Equals("") && !adminRutAlumno.Text.Equals("") && !adminMailAlumno.Text.Equals("") &&
          !adminPasswordAlumno.Text.Equals("") && !adminTelefonoAlumno.Text.Equals(""))
        {
          logInArgs.nombreUser = adminNombreAlumno.Text;
          logInArgs.apellidoUser = adminApellidoAlumno.Text;
          logInArgs.rutUser = adminRutAlumno.Text;
          logInArgs.mailUser = adminMailAlumno.Text;
          logInArgs.passwordUser = adminPasswordAlumno.Text;
          logInArgs.telefonoUser = adminTelefonoAlumno.Text;
          logInArgs.horarioAlumno = HorarioLimpio();
          logInArgs.horarioAlumno = GenerarHorario(0.2);
          OnAdminCrearAlumno(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe completar los campos", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void adminEliminarProfesor_Click_1(object sender, EventArgs e)
    {
      if (OnAdminEliminarProfesor != null)
      {
        if (adminListProfesores.SelectedIndex > -1 && !adminListProfesores.SelectedItem.Equals("No existen profesores creados"))
        {
          logInArgs.profesor = adminListProfesores.SelectedItem as Profesor;
          OnAdminEliminarProfesor(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un profesor", "Error: No existe profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminCrearProfesor_Click_1(object sender, EventArgs e)
    {
      if (OnAdminCrearProfesor != null)
      {
        if (!adminNombreProfesor.Text.Equals("") && !adminApellidoProfesor.Text.Equals("") && !adminRutProfesor.Text.Equals("") && !adminMailProfesor.Text.Equals("") &&
          !adminPasswordProfesor.Text.Equals("") && !adminTelefonoProfesor.Text.Equals(""))
        {
          logInArgs.nombreUser = adminNombreProfesor.Text;
          logInArgs.apellidoUser = adminApellidoProfesor.Text;
          logInArgs.rutUser = adminRutProfesor.Text;
          logInArgs.mailUser = adminMailProfesor.Text;
          logInArgs.passwordUser = adminPasswordProfesor.Text;
          logInArgs.telefonoUser = adminTelefonoProfesor.Text;
          OnAdminCrearProfesor(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe completar los campos", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void adminEliminarSala_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarSala != null)
      {
        if (adminListSalasTab.SelectedIndex > -1 && !adminListSalasTab.SelectedItem.Equals("No existen salas creadas"))
        {
          logInArgs.sala = adminListSalasTab.SelectedItem as Sala;
          OnAdminEliminarSala(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un sala", "Error: No existe sala", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminCrearSala_Click(object sender, EventArgs e)
    {
      if (OnAdminCrearSala != null)
      {
        if (!adminNombreSala.Text.Equals(""))
        {
          logInArgs.nombreSala = adminNombreSala.Text;
          logInArgs.horarioSala = GenerarHorario(0);
          OnAdminCrearSala(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe completar los campos", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void asignarProfesorTallerAdminTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminAsignarProfesorTaller != null)
      {
        if (adminListProfesorCrearTaller.SelectedIndex > -1 && adminListTalleres.SelectedIndex > -1)
        {
          logInArgs.taller = adminListTalleres.SelectedItem as Taller;
          logInArgs.profesor = adminListProfesorCrearTaller.SelectedItem as Profesor;
          OnAdminAsignarProfesorTaller(this, logInArgs);
        }
        else
        {
          if (adminListProfesorCrearTaller.SelectedIndex > -1)
            MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          else if (adminListTalleres.SelectedIndex > -1)
            MessageBox.Show("ERROR: Debe seleccionar un profesor", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          else
            MessageBox.Show("ERROR: Debe seleccionar un taller y profesor", "Error: Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    //Admin revisar taller
    private void adminIngresarATaller_Click(object sender, EventArgs e)
    {
      if (OnAdminIngresarTaller != null)
      {
        if (adminListTalleres.SelectedIndex > -1 && !adminListTalleres.SelectedItem.Equals("No existen talleres creados"))
        {
          logInArgs.taller = adminListTalleres.SelectedItem as Taller;
          OnAdminIngresarTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: No existe taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminVolverMenu_Click(object sender, EventArgs e)
    {
      if (OnVolverMenuAdmin != null)
      {
        OnVolverMenuAdmin(this, logInArgs);
      }
    }

    private void adminCrearForoTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminCrearForo != null)
      {
        if (!temaForoAdmin.Text.Equals(""))
        {
          logInArgs.temaForo = temaForoAdmin.Text;
          OnAdminCrearForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe ingresar un tema", "Error: No se entrega Tema", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminIngresarForoTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminIngresarAForo != null)
      {
        if (listForosForoMenuAdmin.SelectedIndex > -1 && !listForosForoMenuAdmin.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listForosForoMenuAdmin.SelectedItem as Foro;
          OnAdminIngresarAForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: No existe foro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminSalirDeForoTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminSalirDeForo != null && listForosForoMenuAdmin.SelectedIndex > -1 && !listForosForoMenuAdmin.SelectedItem.Equals("No se han creado foros"))
      {
        logInArgs.foro = listForosForoMenuAdmin.SelectedItem as Foro;
        OnAdminSalirDeForo(this, logInArgs);
      }
      else MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: No existe foro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void adminEliminarForoTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarForo != null)
      {
        if (listForosForoMenuAdmin.SelectedIndex > -1 && !listForosForoMenuAdmin.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listForosForoMenuAdmin.SelectedItem as Foro;
          OnAdminEliminarForo(this, logInArgs);
        }
        else
          MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: Foro no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminAgregarMensajeForoTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminIngresarMensajeForo != null)
      {
        if (!adminIngresarMensajeTexto.Text.Equals("") && listForosForoMenuAdmin.SelectedIndex>-1 && !listForosForoMenuAdmin.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listForosForoMenuAdmin.SelectedItem as Foro;
          logInArgs.mensaje = adminIngresarMensajeTexto.Text;
          OnAdminIngresarMensajeForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar foro e ingresar un mensaje", "Error: Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminEliminarMensajeForoTaller_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarMensaje != null)
      {
        if (listMensajesForoAdmin.SelectedIndex > -1 && !listMensajesForoAdmin.SelectedItem.Equals("El foro no contiene mensajes"))
        {
          logInArgs.objetoMensaje = listMensajesForoAdmin.SelectedItem as Mensaje;
          OnAdminEliminarMensaje(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un mensaje", "Error: No se selecciona mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void AdminTallerEliminarProf_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarProfesorTaller != null)
      {
        if (adminListProfesoresInscritosTaller.SelectedIndex > -1 && !adminListProfesoresInscritosTaller.SelectedItem.Equals("No existe profesor asignado"))
        {
          logInArgs.profesor = adminListProfesoresInscritosTaller.SelectedItem as Profesor;
          OnAdminEliminarProfesorTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un profesor", "Error: No se selecciona profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void adminTallerAgregarProfesor_Click(object sender, EventArgs e)
    {
      if (OnAdminAgregarProfesorTaller != null)
      {
        if (adminListProfesoresDisponibles.SelectedIndex > -1 && !adminListProfesoresDisponibles.SelectedItem.Equals("No existe profesor en sistema"))
        {
          logInArgs.profesor = adminListProfesoresDisponibles.SelectedItem as Profesor;
          OnAdminAgregarProfesorTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un profesor", "Error: No se selecciona profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminTallerEliminarAlumno_Click(object sender, EventArgs e)
    {
      if (OnAdminEliminarAlumnoTaller != null)
      {
        if (adminListAlumnosInscritosTaller.SelectedIndex > -1 && !adminListAlumnosInscritosTaller.SelectedItem.Equals("No existen participantes en el ramo"))
        {
          logInArgs.student = adminListAlumnosInscritosTaller.SelectedItem as Alumno;
          OnAdminEliminarAlumnoTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un alumno", "Error: No se selecciona alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void adminTallerAgregarAlumno_Click(object sender, EventArgs e)
    {
      if (OnAdminAgregarAlumnoTaller != null)
      {
        if (adminListAlumnosSistema.SelectedIndex > -1 && !adminListAlumnosSistema.SelectedItem.Equals("No existen alumnos en sistema"))
        {
          logInArgs.student = adminListAlumnosSistema.SelectedItem as Alumno;
          OnAdminAgregarAlumnoTaller(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un alumno", "Error: No se selecciona alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    //Este metodo dice que cuando se carge la forma 1, agregue los paneles a la lista panel. 
    //Si crean un panel nuevo tienen que agregarlo aca para despues manejarlo en el controlador!
    //El for each deja visible solo el login 
    private void Form1_Load(object sender, EventArgs e)
    {
      panels.Add("Login", Panellogin);
      panels.Add("StudentMenu", PanelStudentMenu);
      panels.Add("StudentWsMenu", PanelstudentWSMenu);
      panels.Add("AdminMenu", PanelMenuAdmin);
      panels.Add("panelTallerAdmin", PanelTallerAdmin);
      panels.Add("ProfesorMenu", PanelMenuProfesor);
      foreach (String s in panels.Keys)
        if (!s.Equals("Login"))
          panels[s].Visible = false;
      logInArgs.panels = this.panels;
    }


    // Metodos del estudiante

    public void ActualizarTalleresDisponibles(Taller taller, bool borrar)
    {
      //listTalleresDisponibles.Items.Clear();
      if (borrar)
        if (listTalleresDisponibles.Items.Count == 1)
          listTalleresDisponibles.Items[0] = "No existen talleres disponibles en el horario del alumno";
        else
          listTalleresDisponibles.Items.Remove(taller);
      else
        if (listTalleresDisponibles.Items.Count > 0 && listTalleresDisponibles.Items[0].Equals("No existen talleres disponibles en el horario del alumno"))
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

    public void ClearListTalleresDisponiblesAlumno()
    {
      listTalleresDisponibles.Items.Clear();
    }

    public void ActualizarTalleresInscritos(Taller taller, bool borrar)
    {
      //listTalleresInscritos.Items.Clear();
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

    public void ActualizarPerfilTaller(Taller ws, String teachers)
    {
      string schedule = "";
      nombreTaller.Text = ws.nombre;
      foreach (String day in ws.GetHorario().Keys)
        for (int i = 0; i < ws.GetHorario()[day].Count; i++)
          if (ws.GetHorario()[day][i]) schedule = String.Concat(schedule, "| ", day + ": " + bloques[i]);
      horarioTaller.Text = schedule;
      cuposTaller.Text = ws.GetCuposDisponibles().ToString();
      if (teachers.Equals(""))
        tallerTeachers.Text = "No asignado";
      else
        tallerTeachers.Text = teachers;
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

    public void ErrorEliminarMensaje()
    {
      MessageBox.Show("ERROR: El usuario no es el autor del mensaje", "Error: Usuario no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    public int CountListAdminTallerSalas()
    {
      return adminListSalas.Items.Count;
    }

    public void ActualizarAdminTallerSalas(Sala sala, bool borrar)
    {
      if (borrar)
        if (adminListSalas.Items.Count == 1 && adminListSalas.Items.Contains(sala))
        {
          adminListSalas.Items[0] = "No existen salas disponibles";
          //adminListSalas.Items.Remove(sala);
          //adminListSalas.Items.Add(new Sala("No existen salas disponibles", GenerarHorario(0)));
        }
        else
          adminListSalas.Items.Remove(sala);
      else
      {
        if (adminListSalas.Items.Contains(sala))
          return;
        if (adminListSalas.Items.Count > 0 && adminListSalas.Items[0].Equals("No existen salas disponibles"))
        {
          adminListSalas.Items.Add(sala);
          adminListSalas.Items.RemoveAt(0);
        }
        else
          adminListSalas.Items.Add(sala);
      }
    }

    public void AdminLimpiarCrearTaller()
    {
      adminNombreTaller.Clear();
      adminCuposTaller.ResetText();
      adminPrecioTaller.ResetText();
      adminListSalas.ResetText();
      adminListProfesorCrearTaller.Items.Clear();
      for (int i = 0; i <= (horarioLunes.Items.Count - 1); i++)
      {
        horarioLunes.SetItemChecked(i, false);
        horarioMartes.SetItemChecked(i, false);
        horarioMiercoles.SetItemChecked(i, false);
        horarioJueves.SetItemChecked(i, false);
        horarioViernes.SetItemChecked(i, false);
      }
    }

    public void ProfesorAsignadoCorrectamenteATaller()
    {
      adminListProfesorCrearTaller.SelectedItems.Clear();
      adminListTalleres.SelectedItems.Clear();
      MessageBox.Show("Profesor asignado correctamente", "Success: Profesor Asignado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    //Metodos para manejo de taller admin
    public void ActualizarPerfilTallerAdmin(Taller ws, String teachers)
    {
      string schedule = "";
      nombreTallerAdmin.Text = ws.nombre;
      foreach (String day in ws.GetHorario().Keys)
        for (int i = 0; i < ws.GetHorario()[day].Count; i++)
          if (ws.GetHorario()[day][i]) schedule = String.Concat(schedule, "| ", day + ": " + bloques[i]);
      horarioTallerAdmin.Text = schedule;
      cuposTallerAdmin.Text = ws.GetCuposDisponibles().ToString();
      if (teachers.Equals(""))
        tallerTeachersAdmin.Text = "No asignado";
      else
        tallerTeachersAdmin.Text = teachers;
      listForosTallerAdmin.Items.Clear();
      listForosForoMenuAdmin.Items.Clear();
      if (ws.GetForos().Count > 0)
        foreach (Foro foro in ws.GetForos())
        {
          ActualizarListaForosAdmin(foro);
        }
      else
        NoHayForosTallerAdmin();
      numeroForosAdmin.Text = ws.GetForos().Count.ToString();
    }

    public void ActualizarListaForosAdmin(Foro forum)
    {
      if (listForosTallerAdmin.Items.Count > 0 && listForosTallerAdmin.Items[0].Equals("No se han creado foros"))
      {
        listForosTallerAdmin.Items.Add(forum);
        listForosForoMenuAdmin.Items.Add(forum);
        listForosTallerAdmin.Items.RemoveAt(0);
        listForosForoMenuAdmin.Items.RemoveAt(0);
      }
      else
      {
        listForosTallerAdmin.Items.Add(forum);
        listForosForoMenuAdmin.Items.Add(forum);
      }
    }
    public void NoHayForosTallerAdmin()
    {
      listForosTallerAdmin.Items.Add("No se han creado foros");
      listForosForoMenuAdmin.Items.Add("No se han creado foros");
    }

    public void ActualizarCantidadForosTallerAdmin(Taller ws)
    {
      numeroForosAdmin.Text = ws.GetForos().Count.ToString();
    }

    public void ClearIngresoTemaForoTallerAdmin()
    {
      temaForoAdmin.Clear();
    }

    public void ActualizarListaMensajesForoAdmin(Mensaje m, bool borrar)
    {
      if (borrar)
        if (listMensajesForoAdmin.Items.Count == 1)
          listMensajesForoAdmin.Items[0] = "El foro no contiene mensajes";
        else
          listMensajesForoAdmin.Items.Remove(m);
      else
        if (listMensajesForoAdmin.Items.Count > 0 && listMensajesForoAdmin.Items[0].Equals("El foro no contiene mensajes"))
      {
        listMensajesForoAdmin.Items.Add(m);
        listMensajesForoAdmin.Items.RemoveAt(0);
      }
      else
        listMensajesForoAdmin.Items.Add(m);
      adminIngresarMensajeTexto.Clear();
    }

    public void NoExistenMensajesForoAdmin()
    {
      listMensajesForoAdmin.Items.Add("El foro no contiene mensajes");
    }

    public void ClearListaMensajesForoAdmin()
    {
      listMensajesForoAdmin.Items.Clear();
    }

    public void ClearListaForosAdmin()
    {
      listForosForoMenuAdmin.Items.Clear();
      listForosTallerAdmin.Items.Clear();
    }

    public void CargarForosTallerAdmin(List<Foro> foros)
    {
      if (foros.Count > 0)
      {
        foreach (Foro f in foros)
        {
          ActualizarListaForosAdmin(f);
        }
      }
      else
        NoHayForosTallerAdmin();
      ClearListaMensajesForoAdmin();
    }

    public void CargarMensajesForoAdmin(List<Mensaje> mensajes)
    {
      if (mensajes.Count >= 1)
      {
        foreach (Mensaje m in mensajes)
        {
          ActualizarListaMensajesForoAdmin(m, false);
        }
      }
      else
      { NoExistenMensajesForoAdmin(); }
    }

    public void ActualizarParticipantesAdmin(List<Alumno> participantes, List<Profesor> tutores, List<Alumno> alumnos, List<Profesor> profesores)
    {
      bool existe = false;
      if (participantes.Count > 0)
      {
        foreach (Alumno alumno in participantes)
        {
          if (adminListAlumnosInscritosTaller.Items.Count > 0 && adminListAlumnosInscritosTaller.Items[0].Equals("No existen participantes en el ramo"))
          {
            adminListAlumnosInscritosTaller.Items.Add(alumno);
            adminListAlumnosInscritosTaller.Items.RemoveAt(0);
          }
          else
            adminListAlumnosInscritosTaller.Items.Add(alumno);
        }
      }
      else NoHayParticipantesAdmin();

      if (tutores.Count > 0)
      {
        foreach (Profesor profesor in tutores)
        {
          if (adminListProfesoresInscritosTaller.Items.Count > 0 && adminListProfesoresInscritosTaller.Items[0].Equals("No existe profesor asignado"))
          {
            adminListProfesoresInscritosTaller.Items.Add(profesor);
            adminListProfesoresInscritosTaller.Items.RemoveAt(0);
          }
          else
            adminListProfesoresInscritosTaller.Items.Add(profesor);
        }
      }
      else NoHayTutoresAdmin();

      if (alumnos.Count > 0 && alumnos.Count>participantes.Count)
      {
        foreach (Alumno alumno in alumnos)
        {
          existe = false;
          foreach (Alumno inscrito in participantes)
          {
            if (alumno.rut.Equals(inscrito.rut))
            {
              existe = true;
              break;
            }
          }
          if (!existe)
          {
            if (adminListAlumnosSistema.Items.Count > 0 && adminListAlumnosSistema.Items[0].Equals("No existen alumnos en sistema"))
            {
              adminListAlumnosSistema.Items.Add(alumno);
              adminListAlumnosSistema.Items.RemoveAt(0);
            }
            else
              adminListAlumnosSistema.Items.Add(alumno);
          }
        }
      }
      else NoHayAlumnosTallerAdmin();

      if (profesores.Count > 0 && profesores.Count>tutores.Count)
      {
        foreach (Profesor profesor in profesores)
        {
          existe = false;
          foreach (Profesor inscrito in tutores)
          {
            if (profesor.rut.Equals(inscrito.rut))
            {
              existe = true;
              break;
            }
          }
          if (!existe)
          {
            if (adminListProfesoresDisponibles.Items.Count > 0 && adminListProfesoresDisponibles.Items[0].Equals("No existe profesor en sistema"))
            {
              adminListProfesoresDisponibles.Items.Add(profesor);
              adminListProfesoresDisponibles.Items.RemoveAt(0);
            }
            else
              adminListProfesoresDisponibles.Items.Add(profesor);
          }
        }
      }
      else NoHayProfesoresTallerAdmin();

    }

    public void NoHayParticipantesAdmin()
    {
      adminListAlumnosInscritosTaller.Items.Add("No existen participantes en el ramo");
    }
    public void NoHayTutoresAdmin()
    {
      adminListProfesoresInscritosTaller.Items.Add("No existe profesor asignado");
    }
    public void NoHayAlumnosTallerAdmin()
    {
      adminListAlumnosSistema.Items.Add("No existen alumnos en sistema");
    }
    public void NoHayProfesoresTallerAdmin()
    {
      adminListProfesoresDisponibles.Items.Add("No existe profesor en sistema");
    }

    public void ClearParticipantesAdmin()
    {
      adminListAlumnosInscritosTaller.Items.Clear();
      adminListProfesoresInscritosTaller.Items.Clear();
      adminListAlumnosSistema.Items.Clear();
      adminListProfesoresDisponibles.Items.Clear();
    }

    public void TopeDeHorario()
    {
      MessageBox.Show("ERROR: Alumno con tope de horario", "ERROR: Tope de horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }


    //Tab Alumno Admin
    public void ActualizarAlumnosAdmin(Alumno alumno, bool borrar)
    {
      if (borrar)
        if (adminListAlumnos.Items.Count == 1)
          adminListAlumnos.Items[0] = "No existen alumnos creados";
        else
          adminListAlumnos.Items.Remove(alumno);
      else
      {
        if (adminListAlumnos.Items.Count > 0 && adminListAlumnos.Items[0].Equals("No existen alumnos creados"))
        {
          adminListAlumnos.Items.Add(alumno);
          adminListAlumnos.Items.RemoveAt(0);
        }
        else
          adminListAlumnos.Items.Add(alumno);
      }
    }
    public void AdminLimpiarCrearAlumno()
    {
      adminNombreAlumno.Clear();
      adminRutAlumno.Clear();
      adminApellidoAlumno.Clear();
      adminMailAlumno.Clear();
      adminPasswordAlumno.Clear();
      adminTelefonoAlumno.Clear();
    }
    //Tab Profesor Admin
    public void ActualizarProfesoresAdmin(Profesor profesor, bool borrar)
    {
      if (borrar)
        if (adminListProfesores.Items.Count == 1)
        {
          adminListProfesores.Items[0] = "No existen profesores creados";
          adminListProfesorCrearTaller.Items[0] = "No existen profesores creados";
        }
        else
        {
          adminListProfesores.Items.Remove(profesor);
          adminListProfesorCrearTaller.Items.Remove(profesor);
        }
      else
      {
        if (adminListProfesores.Items.Count > 0 && adminListProfesores.Items[0].Equals("No existen profesores creados"))
        {
          adminListProfesores.Items.Add(profesor);
          adminListProfesores.Items.RemoveAt(0);
          adminListProfesorCrearTaller.Items.Add(profesor);
          adminListProfesorCrearTaller.Items.RemoveAt(0);
        }
        else
        {
          adminListProfesores.Items.Add(profesor);
          adminListProfesorCrearTaller.Items.Add(profesor);
        }
      }
    }
    public void AdminLimpiarCrearProfesor()
    {
      adminNombreProfesor.Clear();
      adminRutProfesor.Clear();
      adminApellidoProfesor.Clear();
      adminMailProfesor.Clear();
      adminPasswordProfesor.Clear();
      adminTelefonoProfesor.Clear();
    }
    //Tab Sala Admin
    public void ActualizarSalasAdmin(Sala sala, bool borrar)
    {
      if (borrar)
        if (adminListSalasTab.Items.Count == 1)
          adminListSalasTab.Items[0] = "No existen salas creadas";
        else
          adminListSalasTab.Items.Remove(sala);
      else
      {
        if (adminListSalasTab.Items.Count > 0 && adminListSalas.Items[0].Equals("No existen salas creadas"))
        {
          adminListSalasTab.Items.Add(sala);
          adminListSalasTab.Items.RemoveAt(0);
        }
        else
          adminListSalasTab.Items.Add(sala);
      }
    }
    public void AdminLimpiarCrearSala()
    {
      adminNombreSala.Clear();
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

    //Vista Profesor
    public void ActualizarTalleresProfesor(Taller taller, bool borrar)
    {
      if (borrar)
      {
        if (profesorTalleresDict.Items.Count == 1)
        {
          profesorTalleresDict.Items[0] = "No existen talleres inscritos por el profesor";
          TalleresParticipantes.Items[0] = "No existen talleres inscritos por el profesor";
        }
        else
        {
          profesorTalleresDict.Items.Remove(taller);
          TalleresParticipantes.Items.Remove(taller);
        }
      }
      else
        if (profesorTalleresDict.Items.Count > 0 && profesorTalleresDict.Items[0].Equals("No existen talleres inscritos por el profesor"))
        {
          profesorTalleresDict.Items.Add(taller);
          TalleresParticipantes.Items.Add(taller);
          profesorTalleresDict.Items.RemoveAt(0);
          TalleresParticipantes.Items.RemoveAt(0);
        }
      else
      {
        profesorTalleresDict.Items.Add(taller);
        TalleresParticipantes.Items.Add(taller);
      }
    }

    public void NoHayTalleresProfesor()
    {
      profesorTalleresDict.Items.Add("No existen talleres inscritos por el profesor");
    }


    //Metodos Profesor

    //Metodos que actualizan los foros en el panel profesor
    public void ActualizarListaForosProfe(Foro forum)
    {
      if (listBoxForosTallerProfe.Items.Count > 0 && listBoxForosTallerProfe.Items[0].Equals("No se han creado foros"))
      {
        listBoxForosTallerProfe.Items.Add(forum);
        //aqui se elimina el primer elemento que indica que no existen foros
        listBoxForosTallerProfe.Items.RemoveAt(0);
      }

      else
      {
        listBoxForosTallerProfe.Items.Add(forum);
      }
    }



    public void NoHayForosTallerProfe()//indica dentro de los listbox que no hay foros creados
    {
      listBoxForosTallerProfe.Items.Add("No se han creado foros");

    }

    public void ClearIngresoTemaForoTallerProfe()//Limpia el textbox que agrega nuevo foro
    {
      TemaForoP.Clear();
    }

    public void ActualizarListaMensajesForoProfe(Mensaje m, bool borrar)
    {
      if (borrar)
        if (listBoxProfeMensajesForo.Items.Count == 1)
          listBoxProfeMensajesForo.Items[0] = "El foro no contiene mensajes";
        else
          listBoxProfeMensajesForo.Items.Remove(m);
      else
      if (listBoxProfeMensajesForo.Items.Count > 0 && listBoxProfeMensajesForo.Items[0].Equals("El foro no contiene mensajes"))
      {
        listBoxProfeMensajesForo.Items.Add(m);
        listBoxProfeMensajesForo.Items.RemoveAt(0);
      }
      else
      {
        listBoxProfeMensajesForo.Items.Add(m);
        textMensajeP.Clear();
      }
      textMensajeP.Clear();

    }


    public void NoExistenMensajesForoProfe()
    {
      listBoxProfeMensajesForo.Items.Add("El foro no contiene mensajes");
    }

    public void ClearListaMensajesForoProfe()
    {
      listBoxProfeMensajesForo.Items.Clear();
    }

    public void ClearListaForosProfe()
    {
      listBoxForosTallerProfe.Items.Clear();
    }

    public void CargarMensajesForoProfesor(List<Mensaje> mensajes)
    {
      if (mensajes.Count >= 1)
      {
        foreach (Mensaje m in mensajes)
        {
          ActualizarListaMensajesForoProfe(m, false);
        }
      }
      else
      { NoExistenMensajesForoProfe(); }
    }
    public void CargarForosTallerProfesor(List<Foro> foros)
    {

      if (foros.Count > 0)
      {
        foreach (Foro f in foros)
        {
          ActualizarListaForosProfe(f);
        }
      }
      else
      { NoHayForosTallerProfe(); }
      ClearListaMensajesForoProfe();

    }

    public void ActualizarParticipantes(List<Alumno> participantes)
    {
      if (participantes.Count > 0)
      {
        foreach (Alumno alumno in participantes)
        {
          if (listParticipantes.Items.Count > 0 && listParticipantes.Items[0].Equals("No existen participantes en el ramo"))
          {
            listParticipantes.Items.Add(alumno);
            listParticipantes.Items.RemoveAt(0);
          }
          else
            listParticipantes.Items.Add(alumno);
        }
      }
      else NoHayParticipantes();
    }
    

    public void NoHayParticipantes()
    {
      listParticipantes.Items.Add("No existen participantes en el ramo");
    }


    public void ClearParticipantes()
    {
      listParticipantes.Items.Clear();
    }

    public void ClearTalleresProfesor()
    {
      profesorTalleresDict.Items.Clear();
      listBoxForosTallerProfe.Items.Clear();
      listBoxProfeMensajesForo.Items.Clear();
      textMensajeP.Clear();
      TemaForoP.Clear();
      TalleresParticipantes.Items.Clear();
      listParticipantes.Items.Clear();
    }

  //CLICKS Profesor




  private void profesorIngresarTaller_Click_1(object sender, EventArgs e)
    {
      listBoxForosTallerProfe.Items.Clear();
      if (OnProfesorMostrarTaller != null)
      {
        if (profesorTalleresDict.SelectedIndex > -1 && !profesorTalleresDict.SelectedItem.Equals("No existen talleres inscritos por el profesor"))
        {
          logInArgs.taller = profesorTalleresDict.SelectedItem as Taller;
          OnProfesorMostrarTaller(this, logInArgs);

        }
        else MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: No existe taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void profesorLeerForo_Click_1(object sender, EventArgs e)
    {
      listBoxProfeMensajesForo.Items.Clear();
      if (OnProfesorLeerForo != null)
      {
        if (listBoxForosTallerProfe.SelectedIndex > -1 && !listBoxForosTallerProfe.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listBoxForosTallerProfe.SelectedItem as Foro;
          OnProfesorLeerForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: No existe foro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CrearForoP_Click_1(object sender, EventArgs e)
    {
      if (OnProfesorCrearForo != null)
      {
        if (!TemaForoP.Text.Equals("") && profesorTalleresDict.SelectedIndex > -1 && !profesorTalleresDict.SelectedItem.Equals("No existen talleres inscritos por el profesor"))
        {
          logInArgs.taller = profesorTalleresDict.SelectedItem as Taller;
          logInArgs.temaForo = TemaForoP.Text;
          OnProfesorCrearForo(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un foro e ingresar tema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ProfesorEliminarForo_Click_1(object sender, EventArgs e)
    {
      if (OnProfesorEliminarForo != null)
      {
        if (listBoxForosTallerProfe.SelectedIndex > -1 && !listBoxForosTallerProfe.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.foro = listBoxForosTallerProfe.SelectedItem as Foro;
          OnProfesorEliminarForo(this, logInArgs);
        }
        else
          MessageBox.Show("ERROR: Debe seleccionar un foro", "Error: Foro no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void AgregarMensajeP_Click_1(object sender, EventArgs e)
    {
      if (OnProfesorAgregarMensaje != null)
      {
        if (!textMensajeP.Text.Equals("") && listBoxForosTallerProfe.SelectedIndex>-1 && !listBoxForosTallerProfe.SelectedItem.Equals("No se han creado foros"))
        {
          logInArgs.mensaje = textMensajeP.Text;
          logInArgs.foro = listBoxForosTallerProfe.SelectedItem as Foro;
          OnProfesorAgregarMensaje(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un foro e ingresar mensaje", "Error: Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void EliminarMensajeP_Click_1(object sender, EventArgs e)
    {
      if (OnProfesorEliminarMensaje != null)
      {
        if (listBoxProfeMensajesForo.SelectedIndex > -1 && !listBoxProfeMensajesForo.SelectedItem.Equals("El foro no contiene mensajes"))
        {
          logInArgs.objetoMensaje = listBoxProfeMensajesForo.SelectedItem as Mensaje;
          OnProfesorEliminarMensaje(this, logInArgs);
        }
        else MessageBox.Show("ERROR: Debe seleccionar un mensaje", "Error: No se selecciona mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void MostrarPart_Click_1(object sender, EventArgs e)
    {
      if (OnProfesorMostrarParticipantes != null)
      {
        if (TalleresParticipantes.SelectedIndex > -1 && !TalleresParticipantes.SelectedItem.Equals("No existen talleres inscritos por el profesor"))
        {
          logInArgs.taller = TalleresParticipantes.SelectedItem as Taller;
          OnProfesorMostrarParticipantes(this, logInArgs);
        }
        else
          MessageBox.Show("ERROR: Debe seleccionar un taller", "Error: Taller no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void horario_ItemCheck(object sender, EventArgs e)
    {
      BeginInvoke((MethodInvoker)delegate { 
        if (OnAdminSeleccionarHorarioTaller != null)
        {
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
          OnAdminSeleccionarHorarioTaller(this, logInArgs);
        }
      });
    }

    /*private void horario_ItemCheck(object sender, EventArgs e)
    { 
      if (OnAdminSeleccionarHorarioTaller != null)
      {
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
        OnAdminSeleccionarHorarioTaller(this, logInArgs);
      }
    }*/

    //*********************Botones Cerrar Sesión**************************************
    //Cerrar sesion desde profesor
    private void button10_Click(object sender, EventArgs e)
    {
      if (OnCerrarSesion != null) { 
      //Admin
      adminListTalleres.Items.Clear();
      AdminLimpiarCrearTaller();
      adminListAlumnos.Items.Clear();
      AdminLimpiarCrearAlumno();
      adminListProfesores.Items.Clear();
      AdminLimpiarCrearProfesor();
      adminListSalasTab.Items.Clear();
      AdminLimpiarCrearSala();

      //Profesor
      ClearTalleresProfesor();

      //Alumno
      listTalleresInscritos.Items.Clear();
      listTalleresDisponibles.Items.Clear();

      //AlumnoWs
      listForosTaller.Items.Clear();
      temaForo.Clear();
      listForosForoMenu.Items.Clear();
      listMensajesForo.Items.Clear();
      alumnoIngresarMensajeTexto.Clear();

      //Taller Admin
      listForosTallerAdmin.Items.Clear();
      temaForoAdmin.Clear();
      listForosForoMenuAdmin.Items.Clear();
      listMensajesForoAdmin.Items.Clear();
      adminIngresarMensajeTexto.Clear();
      adminListProfesoresInscritosTaller.Items.Clear();
      adminListProfesoresDisponibles.Items.Clear();
      adminListAlumnosInscritosTaller.Items.Clear();
      adminListAlumnosSistema.Items.Clear();
      OnCerrarSesion(this, logInArgs);
    }
  }


    
    public void ClearLogIn()
    {
      nametxtbox.Clear();
      pwdtxtbox.Clear();
    }

   /* private void horarioLunes_SelectedIndexChanged(object sender, EventArgs e)
    {
      horario_ItemCheck(sender, e);
    }

    private void horarioMartes_SelectedIndexChanged(object sender, EventArgs e)
    {
      horario_ItemCheck(sender,e);
    }

    private void horarioMiercoles_SelectedIndexChanged(object sender, EventArgs e)
    {
      horario_ItemCheck(sender, e);
    }

    private void horarioJueves_SelectedIndexChanged(object sender, EventArgs e)
    {
      horario_ItemCheck(sender, e);
    }

    private void horarioViernes_SelectedIndexChanged(object sender, EventArgs e)
    {
      horario_ItemCheck(sender, e);
    }*/



    //--> ir a LoginEventArgs
  }
}
