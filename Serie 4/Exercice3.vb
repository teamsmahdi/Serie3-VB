Public Class Exercice3


    Private Sub Exercice3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        ListBox1.Visible = False
        ListBox2.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = Trim(TextBox1.Text)
        Button1.Enabled = False
        If TextBox1.Text <> "" Then
            ListBox2.Items.Clear()
            ListBox2.Visible = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 
        For Each item In ListBox1.Items
            If UCase(item).StartsWith(UCase(TextBox1.Text)) Then
                ListBox2.Items.Add(item)
            End If
        Next

    End Sub
End Class