Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "enter" Then
            Dim ti As Form = New Tienda()
            Me.Hide()
            ti.Show()
        Else
            MessageBox.Show("INCORRECTO POR FAVOR CORRIJA DE NUEVO")
            TextBox1.Clear()
        End If

    End Sub


End Class
