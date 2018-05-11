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
      this.StudentMenu = new System.Windows.Forms.Panel();
      this.InscribirTaller = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label10 = new System.Windows.Forms.Label();
      this.listTalleresInscritos = new System.Windows.Forms.ListBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label9 = new System.Windows.Forms.Label();
      this.listTalleresDisponibles = new System.Windows.Forms.ListBox();
      this.incribirT = new System.Windows.Forms.Button();
      this.loginpanel.SuspendLayout();
      this.StudentMenu.SuspendLayout();
      this.InscribirTaller.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // nametxtbox
      // 
      this.nametxtbox.Location = new System.Drawing.Point(148, 100);
      this.nametxtbox.Name = "nametxtbox";
      this.nametxtbox.Size = new System.Drawing.Size(178, 20);
      this.nametxtbox.TabIndex = 13;
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
      this.loginpanel.Location = new System.Drawing.Point(386, 140);
      this.loginpanel.Name = "loginpanel";
      this.loginpanel.Size = new System.Drawing.Size(465, 251);
      this.loginpanel.TabIndex = 16;
      // 
      // StudentMenu
      // 
      this.StudentMenu.Controls.Add(this.InscribirTaller);
      this.StudentMenu.Location = new System.Drawing.Point(2, 0);
      this.StudentMenu.Name = "StudentMenu";
      this.StudentMenu.Size = new System.Drawing.Size(886, 642);
      this.StudentMenu.TabIndex = 24;
      // 
      // InscribirTaller
      // 
      this.InscribirTaller.Controls.Add(this.tabPage1);
      this.InscribirTaller.Controls.Add(this.tabPage2);
      this.InscribirTaller.Location = new System.Drawing.Point(3, 2);
      this.InscribirTaller.Name = "InscribirTaller";
      this.InscribirTaller.SelectedIndex = 0;
      this.InscribirTaller.Size = new System.Drawing.Size(869, 637);
      this.InscribirTaller.TabIndex = 25;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.label10);
      this.tabPage1.Controls.Add(this.listTalleresInscritos);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(861, 611);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Talleres Inscritos";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(6, 12);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(175, 29);
      this.label10.TabIndex = 5;
      this.label10.Text = "Talleres Inscritos";
      // 
      // listTalleresInscritos
      // 
      this.listTalleresInscritos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listTalleresInscritos.FormattingEnabled = true;
      this.listTalleresInscritos.ItemHeight = 15;
      this.listTalleresInscritos.Location = new System.Drawing.Point(11, 44);
      this.listTalleresInscritos.Name = "listTalleresInscritos";
      this.listTalleresInscritos.Size = new System.Drawing.Size(606, 124);
      this.listTalleresInscritos.TabIndex = 4;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.incribirT);
      this.tabPage2.Controls.Add(this.label9);
      this.tabPage2.Controls.Add(this.listTalleresDisponibles);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(861, 611);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Inscribir Taller";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(6, 16);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(208, 29);
      this.label9.TabIndex = 3;
      this.label9.Text = "Talleres Disponibles";
      // 
      // listTalleresDisponibles
      // 
      this.listTalleresDisponibles.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listTalleresDisponibles.FormattingEnabled = true;
      this.listTalleresDisponibles.ItemHeight = 15;
      this.listTalleresDisponibles.Location = new System.Drawing.Point(11, 48);
      this.listTalleresDisponibles.Name = "listTalleresDisponibles";
      this.listTalleresDisponibles.Size = new System.Drawing.Size(585, 124);
      this.listTalleresDisponibles.TabIndex = 2;
      // 
      // incribirT
      // 
      this.incribirT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incribirT.Location = new System.Drawing.Point(177, 184);
      this.incribirT.Name = "incribirT";
      this.incribirT.Size = new System.Drawing.Size(206, 37);
      this.incribirT.TabIndex = 10;
      this.incribirT.Text = "Inscribir Taller";
      this.incribirT.UseVisualStyleBackColor = true;
      this.incribirT.Click += new System.EventHandler(this.incribirT_Click);
      // 
      // TalleresVU
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1432, 674);
      this.Controls.Add(this.StudentMenu);
      this.Controls.Add(this.loginpanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "TalleresVU";
      this.Text = "TalleresVU";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.loginpanel.ResumeLayout(false);
      this.loginpanel.PerformLayout();
      this.StudentMenu.ResumeLayout(false);
      this.InscribirTaller.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
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
    private System.Windows.Forms.Panel StudentMenu;
    private System.Windows.Forms.TabControl InscribirTaller;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ListBox listTalleresInscritos;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ListBox listTalleresDisponibles;
    private System.Windows.Forms.Button incribirT;
  }
}

