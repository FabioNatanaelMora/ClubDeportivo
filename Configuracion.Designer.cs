namespace ClubDeportivo
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelSever = new Label();
            labelDatabase = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            TxtServer = new TextBox();
            TxtDatabase = new TextBox();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            botonActConf = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 78);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(660, 31);
            label1.TabIndex = 0;
            label1.Text = "A continuación ingresar los parametros de conexion MySql";
            label1.Click += label1_Click;
            // 
            // labelSever
            // 
            labelSever.AutoSize = true;
            labelSever.Location = new Point(94, 191);
            labelSever.Name = "labelSever";
            labelSever.Size = new Size(83, 31);
            labelSever.TabIndex = 1;
            labelSever.Text = "Server";
            // 
            // labelDatabase
            // 
            labelDatabase.AutoSize = true;
            labelDatabase.Location = new Point(93, 259);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(113, 31);
            labelDatabase.TabIndex = 2;
            labelDatabase.Text = "Database";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(94, 318);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(122, 31);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(94, 385);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(117, 31);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // TxtServer
            // 
            TxtServer.Location = new Point(254, 184);
            TxtServer.Name = "TxtServer";
            TxtServer.Size = new Size(270, 38);
            TxtServer.TabIndex = 5;
            TxtServer.TextChanged += textBox1_TextChanged;
            // 
            // TxtDatabase
            // 
            TxtDatabase.Location = new Point(254, 252);
            TxtDatabase.Name = "TxtDatabase";
            TxtDatabase.Size = new Size(270, 38);
            TxtDatabase.TabIndex = 6;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(254, 311);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(270, 38);
            TxtUsername.TabIndex = 7;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(254, 378);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(270, 38);
            TxtPassword.TabIndex = 8;
            // 
            // botonActConf
            // 
            botonActConf.BackColor = Color.OldLace;
            botonActConf.Location = new Point(312, 440);
            botonActConf.Name = "botonActConf";
            botonActConf.Size = new Size(149, 55);
            botonActConf.TabIndex = 9;
            botonActConf.Text = "Actualizar";
            botonActConf.UseVisualStyleBackColor = false;
            botonActConf.Click += botonActConf_Click;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(844, 557);
            Controls.Add(botonActConf);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(TxtDatabase);
            Controls.Add(TxtServer);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelDatabase);
            Controls.Add(labelSever);
            Controls.Add(label1);
            Cursor = Cursors.AppStarting;
            Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7);
            Name = "Configuracion";
            Text = "Configuracion";
            Load += Configuracion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSever;
        private Label labelDatabase;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox TxtServer;
        private TextBox TxtDatabase;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Button botonActConf;
    }
}