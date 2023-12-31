Public Class frmPrestamos
    Dim tipoUsuario As String = ""
    Dim ocLlaves As String = ""
    Dim numprestamo As Integer = 1
    Dim fila As Integer = 0
    Dim botonOk As String = ""
    Dim numPrestamoEliminar As String = ""

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("Está seguro que desea abandonar la aplicación", "Cierre de aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNPrestamo.Text = numprestamo
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpPrestamo.Text = DateTime.Now.ToShortDateString()
        txtIdentificacion.Text = ""
        txtLugarAulaLab.Text = ""
        txtNombre.Text = ""
        txtObservaciones.Text = ""
        txtTelefono.Text = ""
        rbAdministrativo.Checked = False
        rbDocente.Checked = False
        rbEstudiante.Checked = False
        rbNo.Checked = False
        rbSi.Checked = False
        cbEquipo.SelectedIndex = -1
        cbUbicacion.SelectedIndex = -1

        MessageBox.Show("Puede proceder a realizar un nuevo registro de préstamo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIdentificacion.Text = "" Or txtLugarAulaLab.Text = "" Or cbEquipo.Text = "" Or cbUbicacion.Text = "" Or txtNombre.Text = "" Or txtTelefono.Text = "" Or (rbAdministrativo.Checked = False And rbDocente.Checked = False And rbEstudiante.Checked = False) Or (rbNo.Checked = False And rbSi.Checked = False) Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            If txtIdentificacion.TextLength < 10 Or txtTelefono.TextLength < 8 Then
                If txtIdentificacion.TextLength < 10 Then
                    MessageBox.Show("Error, favor ingrese el número de identificación con formato de 10 dígitos", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("Error, favor ingrese el número de teléfono con formato de 8 dígitos", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                End If
            Else
                If rbAdministrativo.Checked = True Then
                    tipoUsuario = "Administrativo"
                Else
                    If rbDocente.Checked = True Then
                        tipoUsuario = "Docente"
                    Else
                        tipoUsuario = "Estudiante"
                    End If
                End If

                If rbSi.Checked = True Then
                    ocLlaves = "Si"
                Else
                    ocLlaves = "No"
                End If

                dgvDatosPrestamos.Rows.Add(New String() {txtNPrestamo.Text, txtNombre.Text, txtIdentificacion.Text, txtTelefono.Text, tipoUsuario, cbEquipo.Text, dtpPrestamo.Text, cbUbicacion.Text, txtLugarAulaLab.Text, ocLlaves, txtObservaciones.Text})

                numprestamo = numprestamo + 1
                txtNPrestamo.Text = numprestamo
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        numPrestamoEliminar = InputBox("Indique el número de préstamo que desea eliminar")
        If numPrestamoEliminar = "" Then
            MessageBox.Show("Error, no introdujo un número de préstamo a eliminar", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            If numPrestamoEliminar > (numprestamo - 1) Then
                MessageBox.Show("Error, número de préstamo ingresado no es válido", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Else
                botonOk = MessageBox.Show("Por Favor confirme que desea eliminar el préstamo número: " + numPrestamoEliminar, "Confirmación para eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                Dim contador As Integer = 1
                If botonOk = vbOK Then
                    For f As Integer = 0 To dgvDatosPrestamos.Rows.Count - 2
                        If dgvDatosPrestamos.Rows(f).Cells(0).Value.ToString() = numPrestamoEliminar Then
                            fila = f
                            contador = contador + 1
                        End If
                    Next
                    If contador = 1 Then
                        MessageBox.Show("Error, número de préstamo ingresado ya fue eliminado", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                    Else
                        dgvDatosPrestamos.Rows.RemoveAt(fila)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solamente letras", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar con formato de 10 dígitos sin espacios ni guiones", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar con formato de 8 dígitos sin espacios ni guiones", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

End Class
