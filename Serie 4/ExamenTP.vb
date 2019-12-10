Public Class ExamenTP
    Private codesProduits() As String = {}, designationsProduits() As String = {}, categoriesProduits() As String = {}
    Private TvaProduits() As Double = {}
    Private PrixProduits() As Double = {}
    Private Function Exist_Category(ByVal cat As String, ByVal categories As ComboBox) As Boolean
        'Debut solution 1
        'Dim trouve As Boolean = False
        'For Each item In categories.Items
        '    If cat = item Then
        '        trouve = True
        '        Exit For
        '    End If
        'Next
        'Return trouve

        'Debut Solution 2
        If categories.Items.IndexOf(cat) = -1 Then
            Return False

        End If
        Return True
    End Function

    Private Sub btnAjouterCategorie_Click(sender As Object, e As EventArgs) Handles btnAjouterCategorie.Click
        If Not Exist_Category(txtCategorie.Text, categories) Then
            categories.Items.Add(txtCategorie.Text)
            txtCategorie.Clear()
        End If
    End Sub
    Private Sub prix_TextChanged(sender As Object, e As EventArgs) Handles txtPrix.TextChanged
        'supprimer les espaces vides avant la comparaison 
        txtPrix.Text = Trim(txtPrix.Text)
        If txtPrix.Text = "" Then
            txtPrix.BackColor = Color.White
            prixTTC.Text = "?"
        Else
            Dim prix As Double = 0
            Dim tva As Double = 0
            Try
                prix = CDbl(txtPrix.Text)
                Try
                    tva = CDbl(txtTva.Text)
                    prixTTC.Text = prix + prix * tva / 100
                Catch ex As Exception
                    prixTTC.Text = "?"
                End Try
                txtPrix.BackColor = Color.White
            Catch ex As Exception
                txtPrix.BackColor = Color.Red
                prixTTC.Text = "?"
            End Try
        End If



    End Sub

    Private Sub tva_TextChanged(sender As Object, e As EventArgs) Handles txtTva.TextChanged

        'supprimer les espaces vides avant la comparaison 
        txtTva.Text = Trim(txtTva.Text)
        If txtTva.Text = "" Then
            txtTva.BackColor = Color.White
            prixTTC.Text = "?"
        Else
            Dim prix As Double = 0
            Dim tva As Double = 0
            Try
                tva = CDbl(txtTva.Text)
                Try
                    prix = CDbl(txtPrix.Text)
                    prixTTC.Text = prix + prix * tva / 100
                Catch ex As InvalidCastException
                    prixTTC.Text = "?"
                End Try
                txtTva.BackColor = Color.White
            Catch ex As InvalidCastException
                txtTva.BackColor = Color.Red
                prixTTC.Text = "?"
            End Try

        End If

    End Sub

    Private Sub btnAjouterProduit_Click(sender As Object, e As EventArgs) Handles btnAjouterProduit.Click
        Dim code As String = Trim(txtCode.Text)
        Dim designation As String = Trim(txtDesignation.Text)
        Dim categorie As String = Trim(categories.SelectedItem)
        Dim valid As Boolean = code <> "" And designation <> "" And categorie <> "" And prixTTC.Text <> "?" And CDbl(prixTTC.Text) > 0
        If valid Then
            ReDim Preserve codesProduits(codesProduits.Count)
            ReDim Preserve designationsProduits(designationsProduits.Count)
            ReDim Preserve categoriesProduits(categoriesProduits.Count)
            ReDim Preserve PrixProduits(TvaProduits.Count)
            ReDim Preserve TvaProduits(TvaProduits.Count)
            codesProduits(codesProduits.Count - 1) = code
            designationsProduits(designationsProduits.Count - 1) = designation
            categoriesProduits(categoriesProduits.Count - 1) = categorie
            PrixProduits(PrixProduits.Count - 1) = CDbl(txtPrix.Text)
            TvaProduits(TvaProduits.Count - 1) = CDbl(txtTva.Text)
            dgvProduits.Rows.Add(code, designation, categorie, txtPrix.Text, txtTva.Text, prixTTC.Text)
            'vider vos champs
            txtCode.Clear()
            txtDesignation.Clear()
            txtPrix.Clear()
            txtTva.Clear()
            prixTTC.Text = "?"
        End If
    End Sub

    Private Sub codeSearch_TextChanged(sender As Object, e As EventArgs) Handles codeSearch.TextChanged
        dgvProduits.Rows.Clear()
        For i = 0 To codesProduits.Count - 1
            If UCase(codesProduits(i)).StartsWith(UCase(codeSearch.Text)) Or UCase(codesProduits(i)).EndsWith(UCase(codeSearch.Text)) Then
                dgvProduits.Rows.Add(codesProduits(i), designationsProduits(i), categoriesProduits(i), PrixProduits(i), TvaProduits(i),
                                    PrixProduits(i) * (1 + TvaProduits(i)) / 100)
            End If
        Next
    End Sub

    Private Sub designationSearch_TextChanged(sender As Object, e As EventArgs) Handles designationSearch.TextChanged
        dgvProduits.Rows.Clear()
        For i = 0 To designationsProduits.Count - 1
            If UCase(designationsProduits(i)).StartsWith(UCase(designationSearch.Text)) Or UCase(designationsProduits(i)).EndsWith(UCase(designationSearch.Text)) Then
                dgvProduits.Rows.Add(codesProduits(i), designationsProduits(i), categoriesProduits(i), PrixProduits(i), TvaProduits(i),
                                    PrixProduits(i) * (1 + TvaProduits(i)) / 100)

            End If
        Next
    End Sub
End Class