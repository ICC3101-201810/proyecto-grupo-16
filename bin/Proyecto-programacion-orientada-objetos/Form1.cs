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
  public partial class Login : Form
  {
    public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;

    public Login()
    {
      InitializeComponent();
    }

    private void AgregarPilotoButton_Click(object sender, EventArgs e)
    {
      if (OnAgregarPiloto != null)
      {
        AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
        pilotoArgs.nombre = this.nametxtbox.Text;
        /*if (this.RolComboBox.Text == "Navegante")
            pilotoArgs.rol = Rol.Navegante;
        else if (this.RolComboBox.Text == "Piloto")
            pilotoArgs.rol = Rol.Piloto;*/
        pilotoArgs.rol = (Rol)Enum.Parse(typeof(Rol), this.RolComboBox.Text, true);
        OnAgregarPiloto(this, pilotoArgs);
      }
    }
    public void ActualizarListadoPilotos(Usuario pilotoNuevo)
    {
      PilotNameComboBox.Items.Add(pilotoNuevo);
    }

    private void PilotNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void NameTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void RolComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void NameTextBox_TextChanged_1(object sender, EventArgs e)
    {

    }
  }
}
