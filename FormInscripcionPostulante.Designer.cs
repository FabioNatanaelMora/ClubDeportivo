using System.Windows.Forms;

namespace ClubDeportivo
{
    partial class FormInscripcionPostulante
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
            labelNombre = new Label();
            labelApellido = new Label();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            labelDoc = new Label();
            txtDomicilio = new TextBox();
            labelDomicilio = new Label();
            lblNacimiento = new Label();
            pickerNac = new DateTimePicker();
            maskedDocumento = new MaskedTextBox();
            txtTelefono = new TextBox();
            labelTelefono = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(148, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion del Postulante";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(91, 52);
            labelNombre.Margin = new Padding(2, 0, 2, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            labelNombre.Click += label2_Click;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(91, 84);
            labelApellido.Margin = new Padding(2, 0, 2, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(64, 202);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(78, 20);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(209, 202);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 20);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(370, 202);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(78, 20);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 48);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(170, 81);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(106, 23);
            txtApellido.TabIndex = 7;
            // 
            // labelDoc
            // 
            labelDoc.AutoSize = true;
            labelDoc.Location = new Point(315, 56);
            labelDoc.Margin = new Padding(2, 0, 2, 0);
            labelDoc.Name = "labelDoc";
            labelDoc.Size = new Size(70, 15);
            labelDoc.TabIndex = 9;
            labelDoc.Text = "Documento";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(294, 164);
            txtDomicilio.Margin = new Padding(2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(191, 23);
            txtDomicilio.TabIndex = 11;
            // 
            // labelDomicilio
            // 
            labelDomicilio.AutoSize = true;
            labelDomicilio.Location = new Point(209, 167);
            labelDomicilio.Margin = new Padding(2, 0, 2, 0);
            labelDomicilio.Name = "labelDomicilio";
            labelDomicilio.Size = new Size(58, 15);
            labelDomicilio.TabIndex = 12;
            labelDomicilio.Text = "Domicilio";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Location = new Point(209, 126);
            lblNacimiento.Margin = new Padding(2, 0, 2, 0);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(65, 15);
            lblNacimiento.TabIndex = 13;
            lblNacimiento.Text = "Fecha Nac.";
            lblNacimiento.Click += lblDomicilio_Click;
            // 
            // pickerNac
            // 
            pickerNac.Location = new Point(289, 126);
            pickerNac.Name = "pickerNac";
            pickerNac.Size = new Size(238, 23);
            pickerNac.TabIndex = 14;
            // 
            // maskedDocumento
            // 
            maskedDocumento.Location = new Point(390, 52);
            maskedDocumento.Mask = "000000000";
            maskedDocumento.Name = "maskedDocumento";
            maskedDocumento.Size = new Size(137, 23);
            maskedDocumento.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(401, 84);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(106, 23);
            txtTelefono.TabIndex = 17;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(322, 87);
            labelTelefono.Margin = new Padding(2, 0, 2, 0);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(52, 15);
            labelTelefono.TabIndex = 16;
            labelTelefono.Text = "Telefono";
            // 
            // FormInscripcionPostulante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 270);
            Controls.Add(txtTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(maskedDocumento);
            Controls.Add(pickerNac);
            Controls.Add(lblNacimiento);
            Controls.Add(labelDomicilio);
            Controls.Add(txtDomicilio);
            Controls.Add(labelDoc);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormInscripcionPostulante";
            Text = "FormInscripcionPostulante";
            Load += FormInscripcionPostulante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNombre;
        private Label labelApellido;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label labelDoc;
        private TextBox txtDomicilio;
        private Label labelDomicilio;
        private Label lblNacimiento;
        private DateTimePicker pickerNac;
        private MaskedTextBox maskedDocumento;
        private TextBox txtTelefono;
        private Label labelTelefono;
    }
}