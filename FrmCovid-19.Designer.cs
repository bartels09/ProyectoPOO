namespace Covid_19_2
{
    partial class FrmCovid19
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblFechaActual = new Label();
            txtFechaActual = new TextBox();
            btnCerrarA = new Button();
            gridDatosPaciente = new TabControl();
            tabDatosPaciente = new TabPage();
            gbSintomas = new GroupBox();
            btnResumir = new Button();
            btDiagnostico = new Button();
            cbMovilidad = new CheckBox();
            cbPecho = new CheckBox();
            cbDifResp = new CheckBox();
            lblSintomasGraves = new Label();
            cbCansancio = new CheckBox();
            cbTos = new CheckBox();
            lblSintomasBasicos = new Label();
            cbFiebre = new CheckBox();
            gbInformacionPacientes = new GroupBox();
            txtOtro = new TextBox();
            rbOtro = new RadioButton();
            txtNacionalidad = new TextBox();
            lblNacionalidad = new Label();
            txtEstadoCivil = new TextBox();
            lblEstadoCivil = new Label();
            dptFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            lblSexo = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            lblProvincia = new Label();
            cbProvincias = new ComboBox();
            lvlNivelAcademico = new Label();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tabSintomas = new TabPage();
            gridDatosPaciente.SuspendLayout();
            tabDatosPaciente.SuspendLayout();
            gbSintomas.SuspendLayout();
            gbInformacionPacientes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DIAGNOSTICO";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaActual.Location = new Point(358, 12);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(111, 28);
            lblFechaActual.TabIndex = 1;
            lblFechaActual.Text = "Dia Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFechaActual.Location = new Point(487, 7);
            txtFechaActual.Margin = new Padding(3, 4, 3, 4);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(114, 34);
            txtFechaActual.TabIndex = 2;
            // 
            // btnCerrarA
            // 
            btnCerrarA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarA.Location = new Point(773, 9);
            btnCerrarA.Margin = new Padding(3, 4, 3, 4);
            btnCerrarA.Name = "btnCerrarA";
            btnCerrarA.Size = new Size(128, 36);
            btnCerrarA.TabIndex = 3;
            btnCerrarA.Text = "Cerrar App";
            btnCerrarA.UseVisualStyleBackColor = true;
            btnCerrarA.Click += btnCerrarA_Click;
            // 
            // gridDatosPaciente
            // 
            gridDatosPaciente.Controls.Add(tabDatosPaciente);
            gridDatosPaciente.Controls.Add(tabSintomas);
            gridDatosPaciente.Location = new Point(14, 95);
            gridDatosPaciente.Margin = new Padding(3, 4, 3, 4);
            gridDatosPaciente.Name = "gridDatosPaciente";
            gridDatosPaciente.SelectedIndex = 0;
            gridDatosPaciente.Size = new Size(1062, 591);
            gridDatosPaciente.TabIndex = 4;
            // 
            // tabDatosPaciente
            // 
            tabDatosPaciente.Controls.Add(gbSintomas);
            tabDatosPaciente.Controls.Add(gbInformacionPacientes);
            tabDatosPaciente.Location = new Point(4, 29);
            tabDatosPaciente.Margin = new Padding(3, 4, 3, 4);
            tabDatosPaciente.Name = "tabDatosPaciente";
            tabDatosPaciente.Padding = new Padding(3, 4, 3, 4);
            tabDatosPaciente.Size = new Size(1054, 558);
            tabDatosPaciente.TabIndex = 0;
            tabDatosPaciente.Text = "Datos del Paciente";
            tabDatosPaciente.UseVisualStyleBackColor = true;
            // 
            // gbSintomas
            // 
            gbSintomas.BackColor = SystemColors.Control;
            gbSintomas.Controls.Add(btnResumir);
            gbSintomas.Controls.Add(btDiagnostico);
            gbSintomas.Controls.Add(cbMovilidad);
            gbSintomas.Controls.Add(cbPecho);
            gbSintomas.Controls.Add(cbDifResp);
            gbSintomas.Controls.Add(lblSintomasGraves);
            gbSintomas.Controls.Add(cbCansancio);
            gbSintomas.Controls.Add(cbTos);
            gbSintomas.Controls.Add(lblSintomasBasicos);
            gbSintomas.Controls.Add(cbFiebre);
            gbSintomas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbSintomas.ForeColor = SystemColors.ControlText;
            gbSintomas.Location = new Point(404, 8);
            gbSintomas.Name = "gbSintomas";
            gbSintomas.Size = new Size(644, 543);
            gbSintomas.TabIndex = 1;
            gbSintomas.TabStop = false;
            gbSintomas.Text = "Sintomas del Paciente";
            // 
            // btnResumir
            // 
            btnResumir.Location = new Point(213, 405);
            btnResumir.Name = "btnResumir";
            btnResumir.Size = new Size(222, 29);
            btnResumir.TabIndex = 9;
            btnResumir.Text = "Resumir";
            btnResumir.UseVisualStyleBackColor = true;
            btnResumir.Click += btnResumir_Click;
            // 
            // btDiagnostico
            // 
            btDiagnostico.Location = new Point(422, 508);
            btDiagnostico.Name = "btDiagnostico";
            btDiagnostico.Size = new Size(222, 29);
            btDiagnostico.TabIndex = 8;
            btDiagnostico.Text = "Nuevo DIagnóstico";
            btDiagnostico.UseVisualStyleBackColor = true;
            // 
            // cbMovilidad
            // 
            cbMovilidad.AutoSize = true;
            cbMovilidad.Location = new Point(180, 343);
            cbMovilidad.Name = "cbMovilidad";
            cbMovilidad.Size = new Size(332, 29);
            cbMovilidad.TabIndex = 7;
            cbMovilidad.Text = "Incapacidad para hablar o moverse";
            cbMovilidad.UseVisualStyleBackColor = true;
            cbMovilidad.CheckedChanged += cbMovilidad_CheckedChanged;
            // 
            // cbPecho
            // 
            cbPecho.AutoSize = true;
            cbPecho.Location = new Point(180, 301);
            cbPecho.Name = "cbPecho";
            cbPecho.Size = new Size(268, 29);
            cbPecho.TabIndex = 6;
            cbPecho.Text = "Dolor o Presión en el pecho";
            cbPecho.UseVisualStyleBackColor = true;
            cbPecho.CheckedChanged += cbPecho_CheckedChanged;
            // 
            // cbDifResp
            // 
            cbDifResp.AutoSize = true;
            cbDifResp.Location = new Point(180, 255);
            cbDifResp.Name = "cbDifResp";
            cbDifResp.Size = new Size(467, 29);
            cbDifResp.TabIndex = 5;
            cbDifResp.Text = "Dificultad para respirar o sensación de falta de aire";
            cbDifResp.UseVisualStyleBackColor = true;
            cbDifResp.CheckedChanged += cbDifResp_CheckedChanged;
            // 
            // lblSintomasGraves
            // 
            lblSintomasGraves.AutoSize = true;
            lblSintomasGraves.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSintomasGraves.ForeColor = Color.FromArgb(128, 64, 64);
            lblSintomasGraves.Location = new Point(26, 215);
            lblSintomasGraves.Name = "lblSintomasGraves";
            lblSintomasGraves.Size = new Size(153, 25);
            lblSintomasGraves.TabIndex = 4;
            lblSintomasGraves.Text = "Síntomas Graves";
            // 
            // cbCansancio
            // 
            cbCansancio.AutoSize = true;
            cbCansancio.Location = new Point(173, 165);
            cbCansancio.Name = "cbCansancio";
            cbCansancio.Size = new Size(120, 29);
            cbCansancio.TabIndex = 3;
            cbCansancio.Text = "Cansancio";
            cbCansancio.UseVisualStyleBackColor = true;
            cbCansancio.CheckedChanged += cbCansancio_CheckedChanged;
            // 
            // cbTos
            // 
            cbTos.AutoSize = true;
            cbTos.Location = new Point(173, 130);
            cbTos.Name = "cbTos";
            cbTos.Size = new Size(106, 29);
            cbTos.TabIndex = 2;
            cbTos.Text = "Tos Seca";
            cbTos.UseVisualStyleBackColor = true;
            cbTos.CheckedChanged += cbTos_CheckedChanged;
            // 
            // lblSintomasBasicos
            // 
            lblSintomasBasicos.AutoSize = true;
            lblSintomasBasicos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSintomasBasicos.ForeColor = Color.FromArgb(128, 64, 64);
            lblSintomasBasicos.Location = new Point(26, 59);
            lblSintomasBasicos.Name = "lblSintomasBasicos";
            lblSintomasBasicos.Size = new Size(158, 25);
            lblSintomasBasicos.TabIndex = 1;
            lblSintomasBasicos.Text = "Síntomas Básicos";
            // 
            // cbFiebre
            // 
            cbFiebre.AutoSize = true;
            cbFiebre.Location = new Point(173, 96);
            cbFiebre.Name = "cbFiebre";
            cbFiebre.Size = new Size(86, 29);
            cbFiebre.TabIndex = 0;
            cbFiebre.Text = "Fiebre";
            cbFiebre.UseVisualStyleBackColor = true;
            cbFiebre.CheckedChanged += cbFiebre_CheckedChanged;
            // 
            // gbInformacionPacientes
            // 
            gbInformacionPacientes.Controls.Add(txtOtro);
            gbInformacionPacientes.Controls.Add(rbOtro);
            gbInformacionPacientes.Controls.Add(txtNacionalidad);
            gbInformacionPacientes.Controls.Add(lblNacionalidad);
            gbInformacionPacientes.Controls.Add(txtEstadoCivil);
            gbInformacionPacientes.Controls.Add(lblEstadoCivil);
            gbInformacionPacientes.Controls.Add(dptFechaNacimiento);
            gbInformacionPacientes.Controls.Add(lblFechaNacimiento);
            gbInformacionPacientes.Controls.Add(txtCorreo);
            gbInformacionPacientes.Controls.Add(lblCorreo);
            gbInformacionPacientes.Controls.Add(rbFemenino);
            gbInformacionPacientes.Controls.Add(rbMasculino);
            gbInformacionPacientes.Controls.Add(lblSexo);
            gbInformacionPacientes.Controls.Add(txtDireccion);
            gbInformacionPacientes.Controls.Add(lblDireccion);
            gbInformacionPacientes.Controls.Add(lblProvincia);
            gbInformacionPacientes.Controls.Add(cbProvincias);
            gbInformacionPacientes.Controls.Add(lvlNivelAcademico);
            gbInformacionPacientes.Controls.Add(txtSegundoApellido);
            gbInformacionPacientes.Controls.Add(lblSegundoApellido);
            gbInformacionPacientes.Controls.Add(txtPrimerApellido);
            gbInformacionPacientes.Controls.Add(lblPrimerApellido);
            gbInformacionPacientes.Controls.Add(txtNombre);
            gbInformacionPacientes.Controls.Add(lblNombre);
            gbInformacionPacientes.FlatStyle = FlatStyle.System;
            gbInformacionPacientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbInformacionPacientes.Location = new Point(6, 7);
            gbInformacionPacientes.Name = "gbInformacionPacientes";
            gbInformacionPacientes.Size = new Size(382, 544);
            gbInformacionPacientes.TabIndex = 0;
            gbInformacionPacientes.TabStop = false;
            gbInformacionPacientes.Text = "Información de Pacientes";
            gbInformacionPacientes.Enter += gbInformacionPacientes_Enter;
            // 
            // txtOtro
            // 
            txtOtro.BackColor = Color.FromArgb(255, 255, 192);
            txtOtro.BorderStyle = BorderStyle.FixedSingle;
            txtOtro.Enabled = false;
            txtOtro.Location = new Point(189, 301);
            txtOtro.Name = "txtOtro";
            txtOtro.Size = new Size(125, 30);
            txtOtro.TabIndex = 24;
            // 
            // rbOtro
            // 
            rbOtro.AutoSize = true;
            rbOtro.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbOtro.Location = new Point(194, 272);
            rbOtro.Name = "rbOtro";
            rbOtro.Size = new Size(66, 27);
            rbOtro.TabIndex = 23;
            rbOtro.TabStop = true;
            rbOtro.Text = "Otro";
            rbOtro.UseVisualStyleBackColor = true;
            rbOtro.CheckedChanged += rbOtro_CheckedChanged;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.BackColor = Color.FromArgb(255, 255, 192);
            txtNacionalidad.BorderStyle = BorderStyle.FixedSingle;
            txtNacionalidad.Location = new Point(189, 469);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(125, 30);
            txtNacionalidad.TabIndex = 22;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNacionalidad.ForeColor = Color.FromArgb(128, 64, 64);
            lblNacionalidad.Location = new Point(10, 471);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(110, 23);
            lblNacionalidad.TabIndex = 21;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.BackColor = Color.FromArgb(255, 255, 192);
            txtEstadoCivil.BorderStyle = BorderStyle.FixedSingle;
            txtEstadoCivil.Location = new Point(189, 429);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(125, 30);
            txtEstadoCivil.TabIndex = 20;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstadoCivil.ForeColor = Color.FromArgb(128, 64, 64);
            lblEstadoCivil.Location = new Point(10, 436);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(97, 23);
            lblEstadoCivil.TabIndex = 19;
            lblEstadoCivil.Text = "Estado Civil";
            // 
            // dptFechaNacimiento
            // 
            dptFechaNacimiento.Format = DateTimePickerFormat.Short;
            dptFechaNacimiento.Location = new Point(189, 386);
            dptFechaNacimiento.Name = "dptFechaNacimiento";
            dptFechaNacimiento.Size = new Size(151, 30);
            dptFechaNacimiento.TabIndex = 18;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.FromArgb(128, 64, 64);
            lblFechaNacimiento.Location = new Point(10, 386);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(147, 23);
            lblFechaNacimiento.TabIndex = 17;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(255, 255, 192);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(192, 342);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 30);
            txtCorreo.TabIndex = 16;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.FromArgb(128, 64, 64);
            lblCorreo.Location = new Point(6, 344);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(151, 23);
            lblCorreo.TabIndex = 15;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbFemenino.Location = new Point(80, 304);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(106, 27);
            rbFemenino.TabIndex = 13;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            rbFemenino.CheckedChanged += rbFemenino_CheckedChanged;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbMasculino.Location = new Point(80, 272);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(108, 27);
            rbMasculino.TabIndex = 12;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            rbMasculino.CheckedChanged += rbMasculino_CheckedChanged;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexo.ForeColor = Color.FromArgb(128, 64, 64);
            lblSexo.Location = new Point(6, 272);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(46, 23);
            lblSexo.TabIndex = 11;
            lblSexo.Text = "Sexo";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(255, 255, 192);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(192, 229);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 30);
            txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.FromArgb(128, 64, 64);
            lblDireccion.Location = new Point(6, 229);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(81, 23);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblProvincia.ForeColor = Color.FromArgb(128, 64, 64);
            lblProvincia.Location = new Point(6, 189);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(79, 23);
            lblProvincia.TabIndex = 8;
            lblProvincia.Text = "Provincia";
            // 
            // cbProvincias
            // 
            cbProvincias.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbProvincias.ForeColor = Color.FromArgb(128, 64, 64);
            cbProvincias.FormattingEnabled = true;
            cbProvincias.Items.AddRange(new object[] { "San José", "Cartago", "Heredia", "Alajuela", "Puntarenas", "Guanacaste", "Limón" });
            cbProvincias.Location = new Point(192, 186);
            cbProvincias.Name = "cbProvincias";
            cbProvincias.Size = new Size(125, 31);
            cbProvincias.TabIndex = 7;
            cbProvincias.SelectedIndexChanged += cbProvincias_SelectedIndexChanged;
            // 
            // lvlNivelAcademico
            // 
            lvlNivelAcademico.AutoSize = true;
            lvlNivelAcademico.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lvlNivelAcademico.ForeColor = Color.FromArgb(128, 64, 64);
            lvlNivelAcademico.Location = new Point(6, 145);
            lvlNivelAcademico.Name = "lvlNivelAcademico";
            lvlNivelAcademico.Size = new Size(137, 23);
            lvlNivelAcademico.TabIndex = 6;
            lvlNivelAcademico.Text = "Nivel Académico";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.BackColor = Color.FromArgb(255, 255, 192);
            txtSegundoApellido.BorderStyle = BorderStyle.FixedSingle;
            txtSegundoApellido.Location = new Point(192, 96);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(125, 30);
            txtSegundoApellido.TabIndex = 5;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoApellido.ForeColor = Color.FromArgb(128, 64, 64);
            lblSegundoApellido.Location = new Point(6, 103);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(145, 23);
            lblSegundoApellido.TabIndex = 4;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(255, 255, 192);
            txtPrimerApellido.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerApellido.Location = new Point(192, 60);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(125, 30);
            txtPrimerApellido.TabIndex = 3;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerApellido.ForeColor = Color.FromArgb(128, 64, 64);
            lblPrimerApellido.Location = new Point(6, 67);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(127, 23);
            lblPrimerApellido.TabIndex = 2;
            lblPrimerApellido.Text = "Primer Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 255, 192);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(192, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 30);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(128, 64, 64);
            lblNombre.Location = new Point(6, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tabSintomas
            // 
            tabSintomas.Location = new Point(4, 29);
            tabSintomas.Margin = new Padding(3, 4, 3, 4);
            tabSintomas.Name = "tabSintomas";
            tabSintomas.Padding = new Padding(3, 4, 3, 4);
            tabSintomas.Size = new Size(1054, 558);
            tabSintomas.TabIndex = 1;
            tabSintomas.Text = "Síntomas";
            tabSintomas.UseVisualStyleBackColor = true;
            // 
            // FrmCovid19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1088, 732);
            ControlBox = false;
            Controls.Add(gridDatosPaciente);
            Controls.Add(btnCerrarA);
            Controls.Add(txtFechaActual);
            Controls.Add(lblFechaActual);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCovid19";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Pacientes con COVID19";
            Load += FrmCovid19_Load;
            gridDatosPaciente.ResumeLayout(false);
            tabDatosPaciente.ResumeLayout(false);
            gbSintomas.ResumeLayout(false);
            gbSintomas.PerformLayout();
            gbInformacionPacientes.ResumeLayout(false);
            gbInformacionPacientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblFechaActual;
        private TextBox txtFechaActual;
        private Button btnCerrarA;
        private TabControl gridDatosPaciente;
        private TabPage tabDatosPaciente;
        private TabPage tabSintomas;
        private GroupBox gbInformacionPacientes;
        private Label lblNombre;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtNombre;
        private Label lblDireccion;
        private Label lblProvincia;
        private ComboBox cbProvincias;
        private Label lvlNivelAcademico;
        private TextBox txtSegundoApellido;
        private Label lblSexo;
        private TextBox txtDireccion;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private TextBox txtEstadoCivil;
        private Label lblEstadoCivil;
        private DateTimePicker dptFechaNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtNacionalidad;
        private Label lblNacionalidad;
        private GroupBox gbSintomas;
        private Label lblSintomasBasicos;
        private CheckBox cbFiebre;
        private CheckBox cbCansancio;
        private CheckBox cbTos;
        private Button btnResumir;
        private Button btDiagnostico;
        private CheckBox cbMovilidad;
        private CheckBox cbPecho;
        private CheckBox cbDifResp;
        private Label lblSintomasGraves;
        private RadioButton rbOtro;
        private TextBox txtOtro;
    }
}