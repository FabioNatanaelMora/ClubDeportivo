namespace ClubDeportivo
{
    partial class FormNvoSocio
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
            nNombreLbl = new Label();
            nNombreTxt = new TextBox();
            nApellidoTxt = new TextBox();
            nApellidoLbl = new Label();
            nFechaNacLbl = new Label();
            nFechaNacTxt = new TextBox();
            nDomicilioTxt = new TextBox();
            nTelefonoLbl = new Label();
            nTelefonoTxt = new TextBox();
            nAltaBtn = new Button();
            nDomicilioLbl = new Label();
            SuspendLayout();
            // 
            // nNombreLbl
            // 
            nNombreLbl.AutoSize = true;
            nNombreLbl.BackColor = Color.DarkOrange;
            nNombreLbl.Location = new Point(83, 21);
            nNombreLbl.Name = "nNombreLbl";
            nNombreLbl.Size = new Size(59, 19);
            nNombreLbl.TabIndex = 0;
            nNombreLbl.Text = "Nombre";
            // 
            // nNombreTxt
            // 
            nNombreTxt.Location = new Point(133, 52);
            nNombreTxt.Name = "nNombreTxt";
            nNombreTxt.Size = new Size(153, 25);
            nNombreTxt.TabIndex = 5;
            // 
            // nApellidoTxt
            // 
            nApellidoTxt.Location = new Point(469, 52);
            nApellidoTxt.Name = "nApellidoTxt";
            nApellidoTxt.Size = new Size(176, 25);
            nApellidoTxt.TabIndex = 6;
            // 
            // nApellidoLbl
            // 
            nApellidoLbl.AutoSize = true;
            nApellidoLbl.BackColor = Color.FromArgb(255, 128, 0);
            nApellidoLbl.Location = new Point(418, 21);
            nApellidoLbl.Name = "nApellidoLbl";
            nApellidoLbl.Size = new Size(58, 19);
            nApellidoLbl.TabIndex = 7;
            nApellidoLbl.Text = "Apellido";
            // 
            // nFechaNacLbl
            // 
            nFechaNacLbl.AutoSize = true;
            nFechaNacLbl.BackColor = Color.FromArgb(255, 128, 0);
            nFechaNacLbl.Location = new Point(82, 100);
            nFechaNacLbl.Name = "nFechaNacLbl";
            nFechaNacLbl.Size = new Size(71, 19);
            nFechaNacLbl.TabIndex = 8;
            nFechaNacLbl.Text = "fecha Nac.";
            // 
            // nFechaNacTxt
            // 
            nFechaNacTxt.Location = new Point(133, 133);
            nFechaNacTxt.Name = "nFechaNacTxt";
            nFechaNacTxt.Size = new Size(78, 25);
            nFechaNacTxt.TabIndex = 9;
            // 
            // nDomicilioTxt
            // 
            nDomicilioTxt.Location = new Point(469, 133);
            nDomicilioTxt.Name = "nDomicilioTxt";
            nDomicilioTxt.Size = new Size(224, 25);
            nDomicilioTxt.TabIndex = 11;
            // 
            // nTelefonoLbl
            // 
            nTelefonoLbl.AutoSize = true;
            nTelefonoLbl.BackColor = Color.FromArgb(255, 128, 0);
            nTelefonoLbl.Location = new Point(82, 175);
            nTelefonoLbl.Name = "nTelefonoLbl";
            nTelefonoLbl.Size = new Size(60, 19);
            nTelefonoLbl.TabIndex = 12;
            nTelefonoLbl.Text = "Telefono";
            // 
            // nTelefonoTxt
            // 
            nTelefonoTxt.Location = new Point(133, 212);
            nTelefonoTxt.Name = "nTelefonoTxt";
            nTelefonoTxt.Size = new Size(153, 25);
            nTelefonoTxt.TabIndex = 13;
            // 
            // nAltaBtn
            // 
            nAltaBtn.BackColor = Color.FromArgb(255, 128, 0);
            nAltaBtn.Location = new Point(505, 212);
            nAltaBtn.Name = "nAltaBtn";
            nAltaBtn.Size = new Size(127, 44);
            nAltaBtn.TabIndex = 14;
            nAltaBtn.Text = "Ingresar";
            nAltaBtn.UseVisualStyleBackColor = false;
            nAltaBtn.MouseClick += nAltaBtn_MouseClick;
            // 
            // nDomicilioLbl
            // 
            nDomicilioLbl.AutoSize = true;
            nDomicilioLbl.BackColor = Color.FromArgb(255, 128, 0);
            nDomicilioLbl.Location = new Point(400, 116);
            nDomicilioLbl.Name = "nDomicilioLbl";
            nDomicilioLbl.Size = new Size(65, 19);
            nDomicilioLbl.TabIndex = 15;
            nDomicilioLbl.Text = "Domicilio";
            nDomicilioLbl.Click += nDomicilioLbl_Click_1;
            // 
            // FormNvoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 510);
            Controls.Add(nDomicilioLbl);
            Controls.Add(nAltaBtn);
            Controls.Add(nTelefonoTxt);
            Controls.Add(nTelefonoLbl);
            Controls.Add(nDomicilioTxt);
            Controls.Add(nFechaNacTxt);
            Controls.Add(nFechaNacLbl);
            Controls.Add(nApellidoLbl);
            Controls.Add(nApellidoTxt);
            Controls.Add(nNombreTxt);
            Controls.Add(nNombreLbl);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormNvoSocio";
            Text = "FormNvoSocio";
            Load += FormNvoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nNombreLbl;
        private TextBox nNombreTxt;
        private TextBox nApellidoTxt;
        private Label nApellidoLbl;
        private Label nFechaNacLbl;
        private TextBox nFechaNacTxt;
        private TextBox nDomicilioTxt;
        private Label nTelefonoLbl;
        private TextBox nTelefonoTxt;
        private Button nAltaBtn;
        private Label nDomicilioLbl;
    }
}