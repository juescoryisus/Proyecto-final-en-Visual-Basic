Public Class Tienda

    Dim client(10) As String
    Dim code(10) As Integer
        Dim product(10) As String
        Dim price(10) As Double
        Dim amoun(10) As String

        Dim i As Integer = 0

        Private Sub cmbproduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproduct.SelectedIndexChanged


            Dim nom As String
            Dim cod As Integer
            Dim precio As Single
            cod = cmbproduct.SelectedIndex
            nom = cmbproduct.SelectedItem.ToString()
            precio = cmbproduct.SelectedIndex

            Select Case cod
                Case 0
                    lblcode.Text = "0011"
                Case 1
                    lblcode.Text = "0022"
                Case Else
                    lblcode.Text = "0033"
            End Select

            Select Case nom
            Case "Pollo"
                lblproduct.Text = "Pollo"
            Case "Gorra"
                    lblproduct.Text = "Gorra"
                Case Else
                    lblproduct.Text = "Camisa"
            End Select

            Select Case precio
                Case 0
                    lblprice.Text = "150"
                Case 1
                    lblprice.Text = "120"
                Case Else
                    lblprice.Text = "140"
            End Select
        End Sub

        Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        ' Obtener los valores de los TextBox
        Dim numero1 As Integer = Integer.Parse(lblprice.Text)
        Dim numero2 As Integer = Integer.Parse(txtamount.Text)

        ' Realizar la multiplicación
        Dim resultado As Integer = numero1 * numero2

        ' Agregar el resultado al DataGridView


        client(i) = txtclient.Text
        code(i) = lblcode.Text
            product(i) = lblproduct.Text
            price(i) = lblprice.Text
            amoun(i) = txtamount.Text

            MsgBox("Su pedido" & (i) & "registrado")

            If i = 10 Then
                MsgBox("A llegado al limite de pedidos")
            Else
                i = i + 1
            End If


        dgvlist.Rows.Add(txtclient.Text, lblcode.Text, lblproduct.Text, "$" & lblprice.Text, txtamount.Text, resultado)


        lblcode.Text = ""
            lblproduct.Text = ""
            lblprice.Text = ""
            txtamount.Text = ""
        lblreturn.Text = ""


        obtenerTotal()

        End Sub

    Public Sub obtenerTotal()

        Dim costot As Single = 0
        Dim contador As Integer = 0
        contador = dgvlist.RowCount

        For i As Integer = 0 To contador - 1
            costot += Single.Parse(dgvlist.Rows(i).Cells(5).Value.ToString())
        Next

        lbltotaltoplay.Text = costot.ToString()

    End Sub



    Private Sub txtcash_TextChanged(sender As Object, e As EventArgs) Handles txtcash.TextChanged

        Try
            lblreturn.Text = (Single.Parse(txtcash.Text) - Single.Parse(lbltotaltoplay.Text)).ToString()
        Catch
        End Try

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        End
    End Sub




    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click


        Dim mensaje As String = "Name: " & txtclient.Text & vbCrLf & "Total: " & lbltotaltoplay.Text & vbCrLf & "Cash: " & txtcash.Text & vbCrLf & "Return: " & lblreturn.Text & "."


        MsgBox(mensaje)


    End Sub


End Class