Public Class Form1
    Dim username As String
    Dim password As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        username = Val("TextBox1.Text")
        username = "efrilyn"

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        password = Val("TextBox2.Text")
        password = "quindoza"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If username = "efrilyn" And password = "quindoza" Then
            MsgBox("LOGIN SUCESS")
        ElseIf username = "" And password = "" Then
            MsgBox("PLEASE ENTER USERNAME AND PASSWORD")
        ElseIf username = "" Then
            MsgBox("PLEASE ENTER USERNAME")
        ElseIf password = "" Then
            MsgBox("PLEASE ENTER PASSWORD")
        Else
            MsgBox("WRONG USERNAME AND PASSWORD")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
