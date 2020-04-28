Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextNumAdd.Text) Then
            ListBox.Items.Add(TextNumAdd.Text)
            TextNumAdd.Text = " "
        Else
            MsgBox("Solo puedes ingresar valores númericos")


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim suma As Double = 0
        Dim contador As Double = 0
        Dim average As Double = 0
        For i As Integer = 0 To ListBox.Items.Count - 1
            suma += Val(ListBox.Items(i))
            contador += 1
        Next
        average = suma / contador
        labelaverage.Text = average.ToString

    End Sub

    Private Sub labelaverage_Click(sender As Object, e As EventArgs) Handles labelaverage.Click

    End Sub

    Private Sub TextNumAdd_TextChanged(sender As Object, e As EventArgs) Handles TextNumAdd.TextChanged

    End Sub
End Class
