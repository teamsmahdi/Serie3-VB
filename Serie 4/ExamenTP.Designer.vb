<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenTP
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.message = New System.Windows.Forms.Label()
        Me.categories = New System.Windows.Forms.ComboBox()
        Me.btnAjouterProduit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvProduits = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Article = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.prixTTC = New System.Windows.Forms.Label()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.colis = New System.Windows.Forms.GroupBox()
        Me.btnAjouterCategorie = New System.Windows.Forms.Button()
        Me.txtCategorie = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.codeSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.designationSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Article.SuspendLayout()
        Me.colis.SuspendLayout()
        Me.SuspendLayout()
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Enabled = False
        Me.message.Location = New System.Drawing.Point(347, 44)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(0, 17)
        Me.message.TabIndex = 12
        Me.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'categories
        '
        Me.categories.FormattingEnabled = True
        Me.categories.Items.AddRange(New Object() {"A4", "A3"})
        Me.categories.Location = New System.Drawing.Point(136, 101)
        Me.categories.Name = "categories"
        Me.categories.Size = New System.Drawing.Size(227, 24)
        Me.categories.TabIndex = 11
        '
        'btnAjouterProduit
        '
        Me.btnAjouterProduit.Location = New System.Drawing.Point(516, 153)
        Me.btnAjouterProduit.Name = "btnAjouterProduit"
        Me.btnAjouterProduit.Size = New System.Drawing.Size(178, 32)
        Me.btnAjouterProduit.TabIndex = 9
        Me.btnAjouterProduit.Text = "Ajouter Produit"
        Me.btnAjouterProduit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Désignation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Code:"
        '
        'dgvProduits
        '
        Me.dgvProduits.AllowUserToAddRows = False
        Me.dgvProduits.AllowUserToDeleteRows = False
        Me.dgvProduits.AllowUserToOrderColumns = True
        Me.dgvProduits.AllowUserToResizeRows = False
        Me.dgvProduits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column5, Me.Column7})
        Me.dgvProduits.Location = New System.Drawing.Point(23, 476)
        Me.dgvProduits.Name = "dgvProduits"
        Me.dgvProduits.RowTemplate.Height = 24
        Me.dgvProduits.Size = New System.Drawing.Size(983, 214)
        Me.dgvProduits.TabIndex = 22
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Désignation"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Categorie"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Prix"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TVA"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Prix TTC"
        Me.Column7.Name = "Column7"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(136, 46)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(67, 22)
        Me.txtCode.TabIndex = 1
        '
        'Article
        '
        Me.Article.Controls.Add(Me.Label8)
        Me.Article.Controls.Add(Me.prixTTC)
        Me.Article.Controls.Add(Me.txtPrix)
        Me.Article.Controls.Add(Me.Label4)
        Me.Article.Controls.Add(Me.Label14)
        Me.Article.Controls.Add(Me.txtTva)
        Me.Article.Controls.Add(Me.Label2)
        Me.Article.Controls.Add(Me.txtDesignation)
        Me.Article.Controls.Add(Me.Label13)
        Me.Article.Controls.Add(Me.message)
        Me.Article.Controls.Add(Me.categories)
        Me.Article.Controls.Add(Me.btnAjouterProduit)
        Me.Article.Controls.Add(Me.Label5)
        Me.Article.Controls.Add(Me.txtCode)
        Me.Article.Controls.Add(Me.Label6)
        Me.Article.Location = New System.Drawing.Point(23, 177)
        Me.Article.Name = "Article"
        Me.Article.Size = New System.Drawing.Size(735, 206)
        Me.Article.TabIndex = 20
        Me.Article.TabStop = False
        Me.Article.Text = "Article"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(466, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Prix TTC:"
        '
        'prixTTC
        '
        Me.prixTTC.AutoSize = True
        Me.prixTTC.Location = New System.Drawing.Point(560, 112)
        Me.prixTTC.Name = "prixTTC"
        Me.prixTTC.Size = New System.Drawing.Size(16, 17)
        Me.prixTTC.TabIndex = 18
        Me.prixTTC.Text = "?"
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(467, 73)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(109, 22)
        Me.txtPrix.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(426, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Prix:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Choix Catégorie"
        '
        'txtTva
        '
        Me.txtTva.Location = New System.Drawing.Point(627, 73)
        Me.txtTva.Name = "txtTva"
        Me.txtTva.Size = New System.Drawing.Size(67, 22)
        Me.txtTva.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TVA:"
        '
        'txtDesignation
        '
        Me.txtDesignation.Location = New System.Drawing.Point(136, 74)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(227, 22)
        Me.txtDesignation.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(700, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "%"
        '
        'colis
        '
        Me.colis.Controls.Add(Me.btnAjouterCategorie)
        Me.colis.Controls.Add(Me.txtCategorie)
        Me.colis.Controls.Add(Me.Label12)
        Me.colis.Location = New System.Drawing.Point(23, 92)
        Me.colis.Name = "colis"
        Me.colis.Size = New System.Drawing.Size(580, 79)
        Me.colis.TabIndex = 23
        Me.colis.TabStop = False
        Me.colis.Text = "Categorie"
        '
        'btnAjouterCategorie
        '
        Me.btnAjouterCategorie.Location = New System.Drawing.Point(209, 35)
        Me.btnAjouterCategorie.Name = "btnAjouterCategorie"
        Me.btnAjouterCategorie.Size = New System.Drawing.Size(138, 31)
        Me.btnAjouterCategorie.TabIndex = 16
        Me.btnAjouterCategorie.Text = "Ajouter Categorie"
        Me.btnAjouterCategorie.UseVisualStyleBackColor = True
        '
        'txtCategorie
        '
        Me.txtCategorie.Location = New System.Drawing.Point(136, 39)
        Me.txtCategorie.Name = "txtCategorie"
        Me.txtCategorie.Size = New System.Drawing.Size(67, 22)
        Me.txtCategorie.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(72, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Libelle:"
        '
        'codeSearch
        '
        Me.codeSearch.Location = New System.Drawing.Point(189, 448)
        Me.codeSearch.Name = "codeSearch"
        Me.codeSearch.Size = New System.Drawing.Size(152, 22)
        Me.codeSearch.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(300, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Entrée Stock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 453)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Rechercher par code:"
        '
        'designationSearch
        '
        Me.designationSearch.Location = New System.Drawing.Point(541, 448)
        Me.designationSearch.Name = "designationSearch"
        Me.designationSearch.Size = New System.Drawing.Size(465, 22)
        Me.designationSearch.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(347, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Rechercher par désignation:"
        '
        'FicheProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 702)
        Me.Controls.Add(Me.designationSearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.codeSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.colis)
        Me.Controls.Add(Me.dgvProduits)
        Me.Controls.Add(Me.Article)
        Me.Name = "FicheProduit"
        Me.Text = "Entrée en stock"
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Article.ResumeLayout(False)
        Me.Article.PerformLayout()
        Me.colis.ResumeLayout(False)
        Me.colis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents message As System.Windows.Forms.Label
    Friend WithEvents categories As System.Windows.Forms.ComboBox
    Friend WithEvents btnAjouterProduit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvProduits As System.Windows.Forms.DataGridView
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Article As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTva As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents colis As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjouterCategorie As System.Windows.Forms.Button
    Friend WithEvents txtCategorie As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents codeSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents prixTTC As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents designationSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
