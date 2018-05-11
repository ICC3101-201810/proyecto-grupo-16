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
    public event EventHandler<LogInEventArgs> OnLogIn;

    public Login()
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
