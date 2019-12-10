Public Class Exercice2
    Public Function AjoutVille(ByVal v As String) As Boolean
        Dim added As Boolean = False
        If Not cbVille.Items.Contains(v) Then
            cbVille.Items.Add(v)
            added = True
            cbVille.Text = ""
        End If
        Return added
    End Function
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim added As Boolean = AjoutVille(cbVille.Text) 
        If added Then
            MessageBox.Show("la ville est ajoutée avec succès")
        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Sure", "Vous êtes sur de vouloir supprimer une ville", MessageBoxButtons.YesNo)
        If dialogResult = dialogResult.Yes Then
            cbVille.Items.Remove(cbVille.SelectedItem)
        End If
    End Sub

    Private Sub btnToutSupprimer_Click(sender As Object, e As EventArgs) Handles btnToutSupprimer.Click
        cbVille.Items.Clear()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub
End Class