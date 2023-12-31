Public Class frmLogin
    Dim usuario As String = "admin"
    Dim contrasena As String = "admin"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtIngrUsuario.Text.Equals(usuario) = True And txtIngrContrasena.Text.Equals(contrasena) = True Then
            frmPrestamos.Show()
        Else
            If txtIngrUsuario.Text.Equals(usuario) = False Then
                MessageBox.Show("Error, Favor ingrese nuevamente el nombre de usuario", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If

            If txtIngrContrasena.Text.Equals(contrasena) = False Then
                MessageBox.Show("Error, Favor ingrese nuevamente la contraseña", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
