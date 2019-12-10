Public Class format
    Private totalTTC As Double
    Private Sub btnAjouterLettre_Click(sender As Object, e As EventArgs) Handles btnAjouterLettre.Click
        Dim numero, type, poids, mode, adresse, tarif As String
        numero = dgvCourrier.Rows.Count + 1
        type = "Lettre"
        poids = poidsLettre.Text
        adresse = adresseLettre.Text
        Try 
        
            If formatLettre.SelectedItem = "A4" Then
                tarif = 2.5 + poids
            Else
                tarif = 3.5 + poids
            End If  
            If expressLettre.Checked Then
                mode = expressLettre.Text
                tarif *= 2
            Else
                mode = normalLettre.Text
            End If
            dgvCourrier.Rows.Add(numero, type, poids, mode, adresse, tarif)
            totalTTC += tarif
            poidsLettre.BackColor = Color.White
        Catch ex As InvalidCastException
            poidsLettre.BackColor = Color.Red
            poidsLettre.Clear() 
        End Try 

    End Sub


    Private Sub format_Load(sender As Object, e As EventArgs) Handles Me.Load
        lettre.Enabled = False
        colis.Enabled = False
    End Sub

    Private Sub CheckLettre_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLettre.CheckedChanged
        lettre.Enabled = Not lettre.Enabled
    End Sub

    Private Sub CheckColis_CheckedChanged(sender As Object, e As EventArgs) Handles CheckColis.CheckedChanged
        colis.Enabled = Not colis.Enabled
    End Sub


    Private Sub btnAjouterColis_Click(sender As Object, e As EventArgs) Handles btnAjouterColis.Click

        poidsColis.BackColor = Color.White
        txtVolume.BackColor = Color.White
        Dim numero, type, poids, mode, adresse, tarif, volume As String
        numero = dgvCourrier.Rows.Count + 1
        type = "Colis"
        poids = poidsColis.Text
        volume = txtVolume.Text
        adresse = adresseColis.Text
        Try
            tarif = 0.25 * volume + poids * 1.0
            If expressColis.Checked Then
                mode = expressLettre.Text
                tarif *= 2
            Else
                mode = normalColis.Text
            End If 
            dgvCourrier.Rows.Add(numero, type, poids, mode, adresse, tarif)
            totalTTC += tarif

        Catch ex As InvalidCastException
            If Not IsNumeric(poidsColis.Text) Then
                poidsColis.BackColor = Color.Red
                poidsColis.Clear()
            End If
            If Not IsNumeric(txtVolume.Text) Then
                txtVolume.BackColor = Color.Red
                txtVolume.Clear()
            End If
      
        End Try
    End Sub

    Private Sub btnCalculerTarif_Click(sender As Object, e As EventArgs) Handles btnCalculerTarif.Click
        txtTarifTTC.Text = Me.totalTTC
    End Sub
End Class
