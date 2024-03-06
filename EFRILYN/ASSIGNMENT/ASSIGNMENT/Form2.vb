Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim NUM1, NUM2, OP As Double

        NUM1 = Val(TextBox1.Text)
        NUM2 = Val(TextBox2.Text)

        If TextBox4.Text = "+" Then
            OP = NUM1 + NUM2
            TextBox3.Text = OP
        ElseIf TextBox4.Text = "-" Then
            OP = NUM1 - NUM2
            TextBox3.Text = OP
        ElseIf TextBox4.Text = "*" Then
            OP = NUM1 * NUM2
            TextBox3.Text = OP
        ElseIf TextBox4.Text = "/" Then
            OP = NUM1 / NUM2
            TextBox3.Text = OP
        Else
            MsgBox("Enter Operator")
        End If


    End Sub
End Class