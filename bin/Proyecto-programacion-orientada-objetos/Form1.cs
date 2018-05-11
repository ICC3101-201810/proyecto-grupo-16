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
    public event EventHandler<LogInEventArgs> OnLogIn;
    Dictionary<String,Panel> panels = new Dictionary<String, Panel>();
    public TalleresVU()
    {
      InitializeComponent();
    }

    private void LogInButton_Click(object sender, EventArgs e)
    {
      if (OnLogIn != null)
      {
        LogInEventArgs logInArgs = new LogInEventArgs();
        logInArgs.user = this.nametxtbox.Text;
        logInArgs.password = this.pwdtxtbox.Text;
        logInArgs.panels = this.panels;
        OnLogIn(this, logInArgs);
      }
    }
  
    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      panels.Add("Login",loginpanel);
      panels.Add("Menu",panel1);
      panels["Login"].BringToFront();

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

    private void label8_Click(object sender, EventArgs e)
    {

    }
  }
}
