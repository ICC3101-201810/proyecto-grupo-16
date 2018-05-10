namespace Vistas
{
  partial class Login
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
      this.AgregarPilotoButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pwdtxtbox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // nametxtbox
      // 
      this.nametxtbox.Location = new System.Drawing.Point(149, 101);
      this.nametxtbox.Name = "nametxtbox";
      this.nametxtbox.Size = new System.Drawing.Size(178, 20);
      this.nametxtbox.TabIndex = 13;
      this.nametxtbox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged_1);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(82, 133);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Contraseña";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(82, 104);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Usuario";
      // 
      // AgregarPilotoButton
      // 
      this.AgregarPilotoButton.Location = new System.Drawing.Point(169, 168);
      this.AgregarPilotoButton.Name = "AgregarPilotoButton";
      this.AgregarPilotoButton.Size = new System.Drawing.Size(124, 23);
      this.AgregarPilotoButton.TabIndex = 9;
      this.AgregarPilotoButton.Text = "Ingresar";
      this.AgregarPilotoButton.UseVisualStyleBackColor = true;
      this.AgregarPilotoButton.Click += new System.EventHandler(this.AgregarPilotoButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(165, 40);
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
      this.label4.Location = new System.Drawing.Point(180, 69);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(104, 20);
      this.label4.TabIndex = 10;
      this.label4.Text = "Iniciar Sesion";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pwdtxtbox
      // 
      this.pwdtxtbox.Location = new System.Drawing.Point(149, 130);
      this.pwdtxtbox.Name = "pwdtxtbox";
      this.pwdtxtbox.Size = new System.Drawing.Size(178, 20);
      this.pwdtxtbox.TabIndex = 15;
      this.pwdtxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(456, 261);
      this.Controls.Add(this.pwdtxtbox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.nametxtbox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.AgregarPilotoButton);
      this.Controls.Add(this.label1);
      this.Name = "Login";
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox nametxtbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button AgregarPilotoButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox pwdtxtbox;
  }
}

