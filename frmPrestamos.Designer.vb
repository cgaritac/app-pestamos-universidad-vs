<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrestamos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblServicios = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbPrestamos = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdentificacionFormato = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cbUbicacion = New System.Windows.Forms.ComboBox()
        Me.cbEquipo = New System.Windows.Forms.ComboBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtLugarAulaLab = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNPrestamo = New System.Windows.Forms.TextBox()
        Me.rbEstudiante = New System.Windows.Forms.RadioButton()
        Me.rbAdministrativo = New System.Windows.Forms.RadioButton()
        Me.rbDocente = New System.Windows.Forms.RadioButton()
        Me.dtpPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblLugarAulaLab = New System.Windows.Forms.Label()
        Me.lblubicacion = New System.Windows.Forms.Label()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblNPrestamo = New System.Windows.Forms.Label()
        Me.lblFechaPrest = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvDatosPrestamos = New System.Windows.Forms.DataGridView()
        Me.NPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarAulaLab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Llaves = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbLlaves = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.tbcAsignacion = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.gbPrestamos.SuspendLayout()
        CType(Me.dgvDatosPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLlaves.SuspendLayout()
        Me.tbcAsignacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblServicios
        '
        Me.lblServicios.AutoSize = True
        Me.lblServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicios.Location = New System.Drawing.Point(493, 20)
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(290, 29)
        Me.lblServicios.TabIndex = 0
        Me.lblServicios.Text = "Servicios Audiovisuales"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.gbPrestamos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1150, 810)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Asignación AudioVisuales"
        '
        'gbPrestamos
        '
        Me.gbPrestamos.Controls.Add(Me.Label3)
        Me.gbPrestamos.Controls.Add(Me.Label2)
        Me.gbPrestamos.Controls.Add(Me.Label1)
        Me.gbPrestamos.Controls.Add(Me.lblIdentificacionFormato)
        Me.gbPrestamos.Controls.Add(Me.btnEliminar)
        Me.gbPrestamos.Controls.Add(Me.cbUbicacion)
        Me.gbPrestamos.Controls.Add(Me.cbEquipo)
        Me.gbPrestamos.Controls.Add(Me.txtObservaciones)
        Me.gbPrestamos.Controls.Add(Me.txtLugarAulaLab)
        Me.gbPrestamos.Controls.Add(Me.txtTelefono)
        Me.gbPrestamos.Controls.Add(Me.txtIdentificacion)
        Me.gbPrestamos.Controls.Add(Me.txtNombre)
        Me.gbPrestamos.Controls.Add(Me.txtNPrestamo)
        Me.gbPrestamos.Controls.Add(Me.rbEstudiante)
        Me.gbPrestamos.Controls.Add(Me.rbAdministrativo)
        Me.gbPrestamos.Controls.Add(Me.rbDocente)
        Me.gbPrestamos.Controls.Add(Me.dtpPrestamo)
        Me.gbPrestamos.Controls.Add(Me.lblObservaciones)
        Me.gbPrestamos.Controls.Add(Me.lblLugarAulaLab)
        Me.gbPrestamos.Controls.Add(Me.lblubicacion)
        Me.gbPrestamos.Controls.Add(Me.lblEquipo)
        Me.gbPrestamos.Controls.Add(Me.lblTelefono)
        Me.gbPrestamos.Controls.Add(Me.lblIdentificacion)
        Me.gbPrestamos.Controls.Add(Me.lblNombre)
        Me.gbPrestamos.Controls.Add(Me.lblUsuario)
        Me.gbPrestamos.Controls.Add(Me.lblNPrestamo)
        Me.gbPrestamos.Controls.Add(Me.lblFechaPrest)
        Me.gbPrestamos.Controls.Add(Me.btnSalir)
        Me.gbPrestamos.Controls.Add(Me.btnNuevo)
        Me.gbPrestamos.Controls.Add(Me.btnGuardar)
        Me.gbPrestamos.Controls.Add(Me.dgvDatosPrestamos)
        Me.gbPrestamos.Controls.Add(Me.gbLlaves)
        Me.gbPrestamos.Location = New System.Drawing.Point(19, 15)
        Me.gbPrestamos.Name = "gbPrestamos"
        Me.gbPrestamos.Size = New System.Drawing.Size(1109, 778)
        Me.gbPrestamos.TabIndex = 0
        Me.gbPrestamos.TabStop = False
        Me.gbPrestamos.Text = "Préstamos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(947, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "* Campos obligatorios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(395, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Eje: Piso #/Aula #/Lab #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(395, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nota: 8 dígitos sin guiones ni espacios"
        '
        'lblIdentificacionFormato
        '
        Me.lblIdentificacionFormato.AutoSize = True
        Me.lblIdentificacionFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentificacionFormato.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblIdentificacionFormato.Location = New System.Drawing.Point(892, 220)
        Me.lblIdentificacionFormato.Name = "lblIdentificacionFormato"
        Me.lblIdentificacionFormato.Size = New System.Drawing.Size(111, 18)
        Me.lblIdentificacionFormato.TabIndex = 29
        Me.lblIdentificacionFormato.Text = "Nota: 10 dígitos"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(910, 569)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(167, 31)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar alquiler"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'cbUbicacion
        '
        Me.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUbicacion.FormattingEnabled = True
        Me.cbUbicacion.Items.AddRange(New Object() {"Aula", "Laboratorio Cómputo", "Laboratorio Ciencias", "Biblioteca", "Auditorio", "Otro"})
        Me.cbUbicacion.Location = New System.Drawing.Point(220, 362)
        Me.cbUbicacion.Name = "cbUbicacion"
        Me.cbUbicacion.Size = New System.Drawing.Size(279, 28)
        Me.cbUbicacion.TabIndex = 27
        '
        'cbEquipo
        '
        Me.cbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquipo.FormattingEnabled = True
        Me.cbEquipo.Items.AddRange(New Object() {"Video been", "Pizarra normal pequeña", "Pizarra normar grande", "Pizarra acrílica pequeña", "Pizarra acrílica mediana", "Pizarra acrílica grande", "Parlantes", "Radiograbadora", "Computadora Laptop", "Computadora Desktop", "Micrófono", "Monitor LCD", "Teclado", "Mouse", "Web cam", "Otro"})
        Me.cbEquipo.Location = New System.Drawing.Point(220, 310)
        Me.cbEquipo.Name = "cbEquipo"
        Me.cbEquipo.Size = New System.Drawing.Size(279, 28)
        Me.cbEquipo.TabIndex = 26
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(220, 461)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(589, 139)
        Me.txtObservaciones.TabIndex = 25
        '
        'txtLugarAulaLab
        '
        Me.txtLugarAulaLab.Location = New System.Drawing.Point(220, 415)
        Me.txtLugarAulaLab.Name = "txtLugarAulaLab"
        Me.txtLugarAulaLab.Size = New System.Drawing.Size(169, 26)
        Me.txtLugarAulaLab.TabIndex = 24
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(220, 264)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(169, 26)
        Me.txtTelefono.TabIndex = 23
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(709, 214)
        Me.txtIdentificacion.MaxLength = 10
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(177, 26)
        Me.txtIdentificacion.TabIndex = 22
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(220, 214)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(322, 26)
        Me.txtNombre.TabIndex = 21
        '
        'txtNPrestamo
        '
        Me.txtNPrestamo.Enabled = False
        Me.txtNPrestamo.Location = New System.Drawing.Point(770, 46)
        Me.txtNPrestamo.Name = "txtNPrestamo"
        Me.txtNPrestamo.Size = New System.Drawing.Size(100, 26)
        Me.txtNPrestamo.TabIndex = 20
        '
        'rbEstudiante
        '
        Me.rbEstudiante.AutoSize = True
        Me.rbEstudiante.Location = New System.Drawing.Point(300, 160)
        Me.rbEstudiante.Name = "rbEstudiante"
        Me.rbEstudiante.Size = New System.Drawing.Size(109, 24)
        Me.rbEstudiante.TabIndex = 19
        Me.rbEstudiante.TabStop = True
        Me.rbEstudiante.Text = "Estudiante"
        Me.rbEstudiante.UseVisualStyleBackColor = True
        '
        'rbAdministrativo
        '
        Me.rbAdministrativo.AutoSize = True
        Me.rbAdministrativo.Location = New System.Drawing.Point(300, 130)
        Me.rbAdministrativo.Name = "rbAdministrativo"
        Me.rbAdministrativo.Size = New System.Drawing.Size(136, 24)
        Me.rbAdministrativo.TabIndex = 18
        Me.rbAdministrativo.TabStop = True
        Me.rbAdministrativo.Text = "Administrativo"
        Me.rbAdministrativo.UseVisualStyleBackColor = True
        '
        'rbDocente
        '
        Me.rbDocente.AutoSize = True
        Me.rbDocente.Location = New System.Drawing.Point(300, 100)
        Me.rbDocente.Name = "rbDocente"
        Me.rbDocente.Size = New System.Drawing.Size(93, 24)
        Me.rbDocente.TabIndex = 17
        Me.rbDocente.TabStop = True
        Me.rbDocente.Text = "Docente"
        Me.rbDocente.UseVisualStyleBackColor = True
        '
        'dtpPrestamo
        '
        Me.dtpPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPrestamo.Location = New System.Drawing.Point(220, 44)
        Me.dtpPrestamo.Name = "dtpPrestamo"
        Me.dtpPrestamo.Size = New System.Drawing.Size(133, 26)
        Me.dtpPrestamo.TabIndex = 16
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(38, 464)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(121, 20)
        Me.lblObservaciones.TabIndex = 15
        Me.lblObservaciones.Text = "Observaciones"
        '
        'lblLugarAulaLab
        '
        Me.lblLugarAulaLab.AutoSize = True
        Me.lblLugarAulaLab.Location = New System.Drawing.Point(38, 418)
        Me.lblLugarAulaLab.Name = "lblLugarAulaLab"
        Me.lblLugarAulaLab.Size = New System.Drawing.Size(129, 20)
        Me.lblLugarAulaLab.TabIndex = 14
        Me.lblLugarAulaLab.Text = "Lugar/Aula/Lab*"
        '
        'lblubicacion
        '
        Me.lblubicacion.AutoSize = True
        Me.lblubicacion.Location = New System.Drawing.Point(38, 365)
        Me.lblubicacion.Name = "lblubicacion"
        Me.lblubicacion.Size = New System.Drawing.Size(89, 20)
        Me.lblubicacion.TabIndex = 13
        Me.lblubicacion.Text = "Ubicación*"
        '
        'lblEquipo
        '
        Me.lblEquipo.AutoSize = True
        Me.lblEquipo.Location = New System.Drawing.Point(38, 313)
        Me.lblEquipo.Name = "lblEquipo"
        Me.lblEquipo.Size = New System.Drawing.Size(142, 20)
        Me.lblEquipo.TabIndex = 12
        Me.lblEquipo.Text = "Equipo solicitado*"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(38, 269)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(79, 20)
        Me.lblTelefono.TabIndex = 11
        Me.lblTelefono.Text = "Teléfono*"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(581, 220)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(113, 20)
        Me.lblIdentificacion.TabIndex = 10
        Me.lblIdentificacion.Text = "Identificación*"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(38, 217)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(147, 20)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre completo*"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(202, 130)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(73, 20)
        Me.lblUsuario.TabIndex = 8
        Me.lblUsuario.Text = "Usuario*"
        '
        'lblNPrestamo
        '
        Me.lblNPrestamo.AutoSize = True
        Me.lblNPrestamo.Location = New System.Drawing.Point(643, 49)
        Me.lblNPrestamo.Name = "lblNPrestamo"
        Me.lblNPrestamo.Size = New System.Drawing.Size(105, 20)
        Me.lblNPrestamo.TabIndex = 7
        Me.lblNPrestamo.Text = "N° Préstamo"
        '
        'lblFechaPrest
        '
        Me.lblFechaPrest.AutoSize = True
        Me.lblFechaPrest.Location = New System.Drawing.Point(38, 49)
        Me.lblFechaPrest.Name = "lblFechaPrest"
        Me.lblFechaPrest.Size = New System.Drawing.Size(136, 20)
        Me.lblFechaPrest.TabIndex = 6
        Me.lblFechaPrest.Text = "Fecha préstamo*"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(965, 434)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 30)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(965, 378)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 31)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(965, 328)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 29)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dgvDatosPrestamos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvDatosPrestamos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatosPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvDatosPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosPrestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPrestamo, Me.Nombre, Me.Identificacion, Me.Telefono, Me.Usuario, Me.Equipo, Me.FechaHora, Me.Ubicacion, Me.LugarAulaLab, Me.Llaves, Me.Observaciones})
        Me.dgvDatosPrestamos.Location = New System.Drawing.Point(0, 628)
        Me.dgvDatosPrestamos.Name = "dgvDatosPrestamos"
        Me.dgvDatosPrestamos.RowTemplate.Height = 24
        Me.dgvDatosPrestamos.Size = New System.Drawing.Size(1109, 150)
        Me.dgvDatosPrestamos.TabIndex = 2
        '
        'NPrestamo
        '
        Me.NPrestamo.HeaderText = "NPrestamo"
        Me.NPrestamo.Name = "NPrestamo"
        Me.NPrestamo.Width = 122
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 97
        '
        'Identificacion
        '
        Me.Identificacion.HeaderText = "Identificación"
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.Width = 136
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Width = 102
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 96
        '
        'Equipo
        '
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.Width = 89
        '
        'FechaHora
        '
        Me.FechaHora.HeaderText = "Fecha"
        Me.FechaHora.Name = "FechaHora"
        Me.FechaHora.Width = 84
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicación"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.Width = 112
        '
        'LugarAulaLab
        '
        Me.LugarAulaLab.HeaderText = "Lugar/Aula/Lab"
        Me.LugarAulaLab.Name = "LugarAulaLab"
        Me.LugarAulaLab.Width = 152
        '
        'Llaves
        '
        Me.Llaves.HeaderText = "LLaves"
        Me.Llaves.Name = "Llaves"
        Me.Llaves.Width = 93
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 150
        '
        'gbLlaves
        '
        Me.gbLlaves.Controls.Add(Me.rbNo)
        Me.gbLlaves.Controls.Add(Me.rbSi)
        Me.gbLlaves.Location = New System.Drawing.Point(647, 305)
        Me.gbLlaves.Name = "gbLlaves"
        Me.gbLlaves.Size = New System.Drawing.Size(197, 86)
        Me.gbLlaves.TabIndex = 1
        Me.gbLlaves.TabStop = False
        Me.gbLlaves.Text = "¿Ocupa llaves?*"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(26, 54)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(51, 24)
        Me.rbNo.TabIndex = 1
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(26, 28)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(45, 24)
        Me.rbSi.TabIndex = 0
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'tbcAsignacion
        '
        Me.tbcAsignacion.Controls.Add(Me.TabPage1)
        Me.tbcAsignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcAsignacion.Location = New System.Drawing.Point(12, 87)
        Me.tbcAsignacion.Name = "tbcAsignacion"
        Me.tbcAsignacion.SelectedIndex = 0
        Me.tbcAsignacion.Size = New System.Drawing.Size(1158, 843)
        Me.tbcAsignacion.TabIndex = 2
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1182, 953)
        Me.Controls.Add(Me.tbcAsignacion)
        Me.Controls.Add(Me.lblServicios)
        Me.Name = "frmPrestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Préstamos de Audiovisuales"
        Me.TabPage1.ResumeLayout(False)
        Me.gbPrestamos.ResumeLayout(False)
        Me.gbPrestamos.PerformLayout()
        CType(Me.dgvDatosPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLlaves.ResumeLayout(False)
        Me.gbLlaves.PerformLayout()
        Me.tbcAsignacion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblServicios As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gbPrestamos As GroupBox
    Friend WithEvents gbLlaves As GroupBox
    Friend WithEvents tbcAsignacion As TabControl
    Friend WithEvents dgvDatosPrestamos As DataGridView
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents lblLugarAulaLab As Label
    Friend WithEvents lblubicacion As Label
    Friend WithEvents lblEquipo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblNPrestamo As Label
    Friend WithEvents lblFechaPrest As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtLugarAulaLab As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNPrestamo As TextBox
    Friend WithEvents rbEstudiante As RadioButton
    Friend WithEvents rbAdministrativo As RadioButton
    Friend WithEvents rbDocente As RadioButton
    Friend WithEvents dtpPrestamo As DateTimePicker
    Friend WithEvents cbUbicacion As ComboBox
    Friend WithEvents cbEquipo As ComboBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblIdentificacionFormato As Label
    Friend WithEvents NPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Equipo As DataGridViewTextBoxColumn
    Friend WithEvents FechaHora As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents LugarAulaLab As DataGridViewTextBoxColumn
    Friend WithEvents Llaves As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
