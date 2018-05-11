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
      this.eliminarTaller = new System.Windows.Forms.Button();
      this.ingresarATaller = new System.Windows.Forms.Button();
      this.label10 = new System.Windows.Forms.Label();
      this.listTalleresInscritos = new System.Windows.Forms.ListBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.incribirT = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.listTalleresDisponibles = new System.Windows.Forms.ListBox();
      this.studentWSMenu = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.label11 = new System.Windows.Forms.Label();
      this.numeroForos = new System.Windows.Forms.Label();
      this.cuposTaller = new System.Windows.Forms.Label();
      this.horarioTaller = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.volverPanel1 = new System.Windows.Forms.Button();
      this.nombreTaller = new System.Windows.Forms.Label();
      this.listForosTaller = new System.Windows.Forms.ListBox();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.button3 = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.listForosForoMenu = new System.Windows.Forms.ListBox();
      this.label12 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.loginpanel.SuspendLayout();
      this.StudentMenu.SuspendLayout();
      this.InscribirTaller.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.studentWSMenu.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
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
      this.loginpanel.Location = new System.Drawing.Point(206, 173);
      this.loginpanel.Name = "loginpanel";
      this.loginpanel.Size = new System.Drawing.Size(465, 251);
      this.loginpanel.TabIndex = 16;
      // 
      // StudentMenu
      // 
      this.StudentMenu.Controls.Add(this.InscribirTaller);
      this.StudentMenu.Location = new System.Drawing.Point(3, 3);
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
      this.tabPage1.Controls.Add(this.eliminarTaller);
      this.tabPage1.Controls.Add(this.ingresarATaller);
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
      // eliminarTaller
      // 
      this.eliminarTaller.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.eliminarTaller.Location = new System.Drawing.Point(359, 184);
      this.eliminarTaller.Name = "eliminarTaller";
      this.eliminarTaller.Size = new System.Drawing.Size(206, 37);
      this.eliminarTaller.TabIndex = 12;
      this.eliminarTaller.Text = "Eliminar Taller";
      this.eliminarTaller.UseVisualStyleBackColor = true;
      this.eliminarTaller.Click += new System.EventHandler(this.eliminarTaller_Click);
      // 
      // ingresarATaller
      // 
      this.ingresarATaller.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ingresarATaller.Location = new System.Drawing.Point(57, 184);
      this.ingresarATaller.Name = "ingresarATaller";
      this.ingresarATaller.Size = new System.Drawing.Size(206, 37);
      this.ingresarATaller.TabIndex = 11;
      this.ingresarATaller.Text = "Ingresar a Taller";
      this.ingresarATaller.UseVisualStyleBackColor = true;
      this.ingresarATaller.Click += new System.EventHandler(this.ingresarATaller_Click);
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
      // studentWSMenu
      // 
      this.studentWSMenu.Controls.Add(this.tabControl1);
      this.studentWSMenu.Location = new System.Drawing.Point(3, 0);
      this.studentWSMenu.Name = "studentWSMenu";
      this.studentWSMenu.Size = new System.Drawing.Size(902, 642);
      this.studentWSMenu.TabIndex = 27;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Location = new System.Drawing.Point(3, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(869, 637);
      this.tabControl1.TabIndex = 25;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.button4);
      this.tabPage3.Controls.Add(this.label11);
      this.tabPage3.Controls.Add(this.numeroForos);
      this.tabPage3.Controls.Add(this.cuposTaller);
      this.tabPage3.Controls.Add(this.horarioTaller);
      this.tabPage3.Controls.Add(this.label8);
      this.tabPage3.Controls.Add(this.label7);
      this.tabPage3.Controls.Add(this.label5);
      this.tabPage3.Controls.Add(this.volverPanel1);
      this.tabPage3.Controls.Add(this.nombreTaller);
      this.tabPage3.Controls.Add(this.listForosTaller);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(861, 611);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Informacion";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(6, 12);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(73, 29);
      this.label11.TabIndex = 19;
      this.label11.Text = "Taller:";
      // 
      // numeroForos
      // 
      this.numeroForos.AutoSize = true;
      this.numeroForos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numeroForos.Location = new System.Drawing.Point(121, 142);
      this.numeroForos.Name = "numeroForos";
      this.numeroForos.Size = new System.Drawing.Size(82, 26);
      this.numeroForos.TabIndex = 18;
      this.numeroForos.Text = "Horario:";
      // 
      // cuposTaller
      // 
      this.cuposTaller.AutoSize = true;
      this.cuposTaller.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cuposTaller.Location = new System.Drawing.Point(121, 101);
      this.cuposTaller.Name = "cuposTaller";
      this.cuposTaller.Size = new System.Drawing.Size(82, 26);
      this.cuposTaller.TabIndex = 17;
      this.cuposTaller.Text = "Horario:";
      // 
      // horarioTaller
      // 
      this.horarioTaller.AutoSize = true;
      this.horarioTaller.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.horarioTaller.Location = new System.Drawing.Point(121, 61);
      this.horarioTaller.Name = "horarioTaller";
      this.horarioTaller.Size = new System.Drawing.Size(82, 26);
      this.horarioTaller.TabIndex = 16;
      this.horarioTaller.Text = "Horario:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(33, 142);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(65, 26);
      this.label8.TabIndex = 15;
      this.label8.Text = "Foros:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(33, 101);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(70, 26);
      this.label7.TabIndex = 14;
      this.label7.Text = "Cupos:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(33, 61);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 26);
      this.label5.TabIndex = 13;
      this.label5.Text = "Horario:";
      // 
      // volverPanel1
      // 
      this.volverPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.volverPanel1.Location = new System.Drawing.Point(80, 449);
      this.volverPanel1.Name = "volverPanel1";
      this.volverPanel1.Size = new System.Drawing.Size(206, 37);
      this.volverPanel1.TabIndex = 11;
      this.volverPanel1.Text = "Volver";
      this.volverPanel1.UseVisualStyleBackColor = true;
      this.volverPanel1.Click += new System.EventHandler(this.volverPanel1_Click);
      // 
      // nombreTaller
      // 
      this.nombreTaller.AutoSize = true;
      this.nombreTaller.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nombreTaller.Location = new System.Drawing.Point(75, 12);
      this.nombreTaller.Name = "nombreTaller";
      this.nombreTaller.Size = new System.Drawing.Size(175, 29);
      this.nombreTaller.TabIndex = 5;
      this.nombreTaller.Text = "Talleres Inscritos";
      // 
      // listForosTaller
      // 
      this.listForosTaller.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listForosTaller.FormattingEnabled = true;
      this.listForosTaller.ItemHeight = 15;
      this.listForosTaller.Location = new System.Drawing.Point(38, 187);
      this.listForosTaller.Name = "listForosTaller";
      this.listForosTaller.Size = new System.Drawing.Size(606, 244);
      this.listForosTaller.TabIndex = 4;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.button2);
      this.tabPage4.Controls.Add(this.listBox1);
      this.tabPage4.Controls.Add(this.button1);
      this.tabPage4.Controls.Add(this.label12);
      this.tabPage4.Controls.Add(this.button3);
      this.tabPage4.Controls.Add(this.label6);
      this.tabPage4.Controls.Add(this.listForosForoMenu);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(861, 611);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "Foros";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(623, 48);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(206, 37);
      this.button3.TabIndex = 10;
      this.button3.Text = "Ingresar a Foro";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(6, 16);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 29);
      this.label6.TabIndex = 3;
      this.label6.Text = "Foros";
      // 
      // listForosForoMenu
      // 
      this.listForosForoMenu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listForosForoMenu.FormattingEnabled = true;
      this.listForosForoMenu.ItemHeight = 15;
      this.listForosForoMenu.Location = new System.Drawing.Point(11, 48);
      this.listForosForoMenu.Name = "listForosForoMenu";
      this.listForosForoMenu.Size = new System.Drawing.Size(585, 64);
      this.listForosForoMenu.TabIndex = 2;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(6, 142);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(107, 29);
      this.label12.TabIndex = 12;
      this.label12.Text = "Mensajes";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(11, 559);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(206, 37);
      this.button1.TabIndex = 13;
      this.button1.Text = "Agregar Mensaje";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(11, 177);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(829, 364);
      this.listBox1.TabIndex = 14;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(238, 559);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(206, 37);
      this.button2.TabIndex = 15;
      this.button2.Text = "Eliminar Mensaje";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(316, 449);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(206, 37);
      this.button4.TabIndex = 20;
      this.button4.Text = "Crear Foro";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // TalleresVU
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(916, 674);
      this.Controls.Add(this.studentWSMenu);
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
      this.studentWSMenu.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
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
    private System.Windows.Forms.Button eliminarTaller;
    private System.Windows.Forms.Button ingresarATaller;
    private System.Windows.Forms.Panel studentWSMenu;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label numeroForos;
    private System.Windows.Forms.Label cuposTaller;
    private System.Windows.Forms.Label horarioTaller;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button volverPanel1;
    private System.Windows.Forms.Label nombreTaller;
    private System.Windows.Forms.ListBox listForosTaller;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox listForosForoMenu;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button button4;
  }
}

