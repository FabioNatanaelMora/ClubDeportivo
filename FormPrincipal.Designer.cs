namespace ClubDeportivo
{
    partial class FormPrincipal
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
            btnGestion = new Button();
            label1 = new Label();
            btnInscripcion = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGestion
            // 
            btnGestion.Location = new Point(182, 229);
            btnGestion.Margin = new Padding(4, 5, 4, 5);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(107, 38);
            btnGestion.TabIndex = 0;
            btnGestion.Text = "Gestionar Clientes";
            btnGestion.UseVisualStyleBackColor = true;
            btnGestion.Click += btnGestion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 46);
            label1.Name = "label1";
            label1.Size = new Size(522, 74);
            label1.TabIndex = 1;
            label1.Text = "MENU PRINCIPAL";
            // 
            // btnInscripcion
            // 
            btnInscripcion.Location = new Point(361, 229);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(138, 38);
            btnInscripcion.TabIndex = 2;
            btnInscripcion.Text = "Inscripcion";
            btnInscripcion.UseVisualStyleBackColor = true;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(930, 231);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 373);
            Controls.Add(btnSalir);
            Controls.Add(btnInscripcion);
            Controls.Add(label1);
            Controls.Add(btnGestion);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestion;
        private Label label1;
        private Button btnInscripcion;
        private Button btnSalir;
    }
}