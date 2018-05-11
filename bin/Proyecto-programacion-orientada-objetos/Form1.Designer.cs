namespace Vistas
{
  partial class TalleresVU
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.nametxtbox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.LogInButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pwdtxtbox = new System.Windows.Forms.TextBox();
      this.loginpanel = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.loginpanel.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // nametxtbox
      // 
      this.nametxtbox.Location = new System.Drawing.Point(148, 100);
      this.nametxtbox.Name = "nametxtbox";
      this.nametxtbox.Size = new System.Drawing.Size(178, 20);
      this.nametxtbox.TabIndex = 13;
      this.nametxtbox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged_1);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(81, 132);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Contraseña";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(81, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Usuario";
      // 
      // LogInButton
      // 
      this.LogInButton.Location = new System.Drawing.Point(168, 167);
      this.LogInButton.Name = "LogInButton";
      this.LogInButton.Size = new System.Drawing.Size(124, 23);
      this.LogInButton.TabIndex = 9;
      this.LogInButton.Text = "Ingresar";
      this.LogInButton.UseVisualStyleBackColor = true;
      this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(164, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 29);
      this.label1.TabIndex = 8;
      this.label1.Text = "Talleres VU";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.label1.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label4.Location = new System.Drawing.Point(179, 68);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(104, 20);
      this.label4.TabIndex = 10;
      this.label4.Text = "Iniciar Sesion";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pwdtxtbox
      // 
      this.pwdtxtbox.Location = new System.Drawing.Point(148, 129);
      this.pwdtxtbox.Name = "pwdtxtbox";
      this.pwdtxtbox.Size = new System.Drawing.Size(178, 20);
      this.pwdtxtbox.TabIndex = 15;
      this.pwdtxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // loginpanel
      // 
      this.loginpanel.Controls.Add(this.pwdtxtbox);
      this.loginpanel.Controls.Add(this.label4);
      this.loginpanel.Controls.Add(this.nametxtbox);
      this.loginpanel.Controls.Add(this.label3);
      this.loginpanel.Controls.Add(this.label2);
      this.loginpanel.Controls.Add(this.LogInButton);
      this.loginpanel.Controls.Add(this.label1);
      this.loginpanel.Location = new System.Drawing.Point(1, 1);
      this.loginpanel.Name = "loginpanel";
      this.loginpanel.Size = new System.Drawing.Size(465, 251);
      this.loginpanel.TabIndex = 16;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Location = new System.Drawing.Point(1, 1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(465, 251);
      this.panel1.TabIndex = 17;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(148, 129);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(178, 20);
      this.textBox1.TabIndex = 15;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label5.Location = new System.Drawing.Point(179, 68);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(104, 20);
      this.label5.TabIndex = 10;
      this.label5.Text = "Iniciar Sesion";
      this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(148, 100);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(178, 20);
      this.textBox2.TabIndex = 13;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(81, 132);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(61, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Contraseña";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(81, 103);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(43, 13);
      this.label7.TabIndex = 11;
      this.label7.Text = "Usuario";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(168, 167);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(124, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "Ingresar";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(79, 28);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(319, 29);
      this.label8.TabIndex = 8;
      this.label8.Text = "Probando el inicio de sesion";
      this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // TalleresVU
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1207, 674);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.loginpanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "TalleresVU";
      this.Text = "TalleresVU";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.loginpanel.ResumeLayout(false);
      this.loginpanel.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox nametxtbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button LogInButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox pwdtxtbox;
    private System.Windows.Forms.Panel loginpanel;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label8;
  }
}

