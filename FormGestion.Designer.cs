namespace ClubDeportivo
{
    partial class FormGestion
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
            btnNvoSocio = new Button();
            botonConf = new Button();
            SuspendLayout();
            // 
            // btnNvoSocio
            // 
            btnNvoSocio.Location = new Point(66, 115);
            btnNvoSocio.Name = "btnNvoSocio";
            btnNvoSocio.Size = new Size(130, 23);
            btnNvoSocio.TabIndex = 0;
            btnNvoSocio.Text = "Nuevo Socio";
            btnNvoSocio.UseVisualStyleBackColor = true;
            btnNvoSocio.Click += btnNvoSocio_Click;
            // 
            // botonConf
            // 
            botonConf.Location = new Point(649, 369);
            botonConf.Name = "botonConf";
            botonConf.Size = new Size(96, 23);
            botonConf.TabIndex = 1;
            botonConf.Text = "Configuración";
            botonConf.UseVisualStyleBackColor = true;
            botonConf.Click += botonConf_Click;
            // 
            // FormGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonConf);
            Controls.Add(btnNvoSocio);
            Name = "FormGestion";
            Text = "FormGestion";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNvoSocio;
        private Button botonConf;
    }
}