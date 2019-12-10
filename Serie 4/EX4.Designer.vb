<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class format
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckLettre = New System.Windows.Forms.CheckBox()
        Me.CheckColis = New System.Windows.Forms.CheckBox()
        Me.btnCalculerTarif = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTarifTTC = New System.Windows.Forms.Label()
        Me.colis = New System.Windows.Forms.GroupBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAjouterColis = New System.Windows.Forms.Button()
        Me.adresseColis = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.normalColis = New System.Windows.Forms.RadioButton()
        Me.expressColis = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.poidsColis = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lettre = New System.Windows.Forms.GroupBox()
        Me.message = New System.Windows.Forms.Label()
        Me.formatLettre = New System.Windows.Forms.ComboBox()
        Me.btnAjouterLettre = New System.Windows.Forms.Button()
        Me.adresseLettre = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.normalLettre = New System.Windows.Forms.RadioButton()
        Me.expressLettre = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.poidsLettre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvCourrier = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colis.SuspendLayout()
        Me.lettre.SuspendLayout()
        CType(Me.dgvCourrier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisir le type de votre courrier"
        '
        'CheckLettre
        '
        Me.CheckLettre.AutoSize = True
        Me.CheckLettre.Location = New System.Drawing.Point(250, 63)
        Me.CheckLettre.Name = "CheckLettre"
        Me.CheckLettre.Size = New System.Drawing.Size(67, 21)
        Me.CheckLettre.TabIndex = 1
        Me.CheckLettre.Text = "Lettre"
        Me.CheckLettre.UseVisualStyleBackColor = True
        '
        'CheckColis
        '
        Me.CheckColis.AutoSize = True
        Me.CheckColis.Location = New System.Drawing.Point(356, 62)
        Me.CheckColis.Name = "CheckColis"
        Me.CheckColis.Size = New System.Drawing.Size(60, 21)
        Me.CheckColis.TabIndex = 2
        Me.CheckColis.Text = "Colis"
        Me.CheckColis.UseVisualStyleBackColor = True
        '
        'btnCalculerTarif
        '
        Me.btnCalculerTarif.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCalculerTarif.Location = New System.Drawing.Point(432, 673)
        Me.btnCalculerTarif.Name = "btnCalculerTarif"
        Me.btnCalculerTarif.Size = New System.Drawing.Size(188, 31)
        Me.btnCalculerTarif.TabIndex = 11
        Me.btnCalculerTarif.Text = "Calculer Tarif"
        Me.btnCalculerTarif.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(637, 680)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tarif ="
        '
        'txtTarifTTC
        '
        Me.txtTarifTTC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTarifTTC.AutoSize = True
        Me.txtTarifTTC.Location = New System.Drawing.Point(692, 680)
        Me.txtTarifTTC.Name = "txtTarifTTC"
        Me.txtTarifTTC.Size = New System.Drawing.Size(16, 17)
        Me.txtTarifTTC.TabIndex = 12
        Me.txtTarifTTC.Text = "?"
        '
        'colis
        '
        Me.colis.Controls.Add(Me.txtVolume)
        Me.colis.Controls.Add(Me.Label8)
        Me.colis.Controls.Add(Me.btnAjouterColis)
        Me.colis.Controls.Add(Me.adresseColis)
        Me.colis.Controls.Add(Me.Label9)
        Me.colis.Controls.Add(Me.normalColis)
        Me.colis.Controls.Add(Me.expressColis)
        Me.colis.Controls.Add(Me.Label10)
        Me.colis.Controls.Add(Me.Label11)
        Me.colis.Controls.Add(Me.poidsColis)
        Me.colis.Controls.Add(Me.Label12)
        Me.colis.Location = New System.Drawing.Point(530, 103)
        Me.colis.Name = "colis"
        Me.colis.Size = New System.Drawing.Size(493, 382)
        Me.colis.TabIndex = 11
        Me.colis.TabStop = False
        Me.colis.Text = "Colis"
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(140, 75)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(174, 22)
        Me.txtVolume.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Kg"
        '
        'btnAjouterColis
        '
        Me.btnAjouterColis.Location = New System.Drawing.Point(89, 336)
        Me.btnAjouterColis.Name = "btnAjouterColis"
        Me.btnAjouterColis.Size = New System.Drawing.Size(75, 31)
        Me.btnAjouterColis.TabIndex = 9
        Me.btnAjouterColis.Text = "Ajouter"
        Me.btnAjouterColis.UseVisualStyleBackColor = True
        '
        'adresseColis
        '
        Me.adresseColis.Location = New System.Drawing.Point(166, 155)
        Me.adresseColis.Name = "adresseColis"
        Me.adresseColis.Size = New System.Drawing.Size(181, 153)
        Me.adresseColis.TabIndex = 8
        Me.adresseColis.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Adresse de destination"
        '
        'normalColis
        '
        Me.normalColis.AutoSize = True
        Me.normalColis.Location = New System.Drawing.Point(225, 113)
        Me.normalColis.Name = "normalColis"
        Me.normalColis.Size = New System.Drawing.Size(74, 21)
        Me.normalColis.TabIndex = 6
        Me.normalColis.TabStop = True
        Me.normalColis.Text = "Normal"
        Me.normalColis.UseVisualStyleBackColor = True
        '
        'expressColis
        '
        Me.expressColis.AutoSize = True
        Me.expressColis.Location = New System.Drawing.Point(140, 113)
        Me.expressColis.Name = "expressColis"
        Me.expressColis.Size = New System.Drawing.Size(79, 21)
        Me.expressColis.TabIndex = 5
        Me.expressColis.TabStop = True
        Me.expressColis.Text = "Express"
        Me.expressColis.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Mode Expedition:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Volume:"
        '
        'poidsColis
        '
        Me.poidsColis.Location = New System.Drawing.Point(136, 41)
        Me.poidsColis.Name = "poidsColis"
        Me.poidsColis.Size = New System.Drawing.Size(174, 22)
        Me.poidsColis.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(86, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Poids"
        '
        'lettre
        '
        Me.lettre.Controls.Add(Me.message)
        Me.lettre.Controls.Add(Me.formatLettre)
        Me.lettre.Controls.Add(Me.btnAjouterLettre)
        Me.lettre.Controls.Add(Me.adresseLettre)
        Me.lettre.Controls.Add(Me.Label3)
        Me.lettre.Controls.Add(Me.normalLettre)
        Me.lettre.Controls.Add(Me.expressLettre)
        Me.lettre.Controls.Add(Me.Label4)
        Me.lettre.Controls.Add(Me.Label5)
        Me.lettre.Controls.Add(Me.poidsLettre)
        Me.lettre.Controls.Add(Me.Label6)
        Me.lettre.Enabled = False
        Me.lettre.Location = New System.Drawing.Point(40, 103)
        Me.lettre.Name = "lettre"
        Me.lettre.Size = New System.Drawing.Size(475, 382)
        Me.lettre.TabIndex = 12
        Me.lettre.TabStop = False
        Me.lettre.Text = "Lettre"
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
        'formatLettre
        '
        Me.formatLettre.FormattingEnabled = True
        Me.formatLettre.Items.AddRange(New Object() {"A4", "A3"})
        Me.formatLettre.Location = New System.Drawing.Point(136, 71)
        Me.formatLettre.Name = "formatLettre"
        Me.formatLettre.Size = New System.Drawing.Size(174, 24)
        Me.formatLettre.TabIndex = 11
        '
        'btnAjouterLettre
        '
        Me.btnAjouterLettre.Location = New System.Drawing.Point(89, 336)
        Me.btnAjouterLettre.Name = "btnAjouterLettre"
        Me.btnAjouterLettre.Size = New System.Drawing.Size(75, 31)
        Me.btnAjouterLettre.TabIndex = 9
        Me.btnAjouterLettre.Text = "Ajouter"
        Me.btnAjouterLettre.UseVisualStyleBackColor = True
        '
        'adresseLettre
        '
        Me.adresseLettre.Location = New System.Drawing.Point(166, 155)
        Me.adresseLettre.Name = "adresseLettre"
        Me.adresseLettre.Size = New System.Drawing.Size(181, 153)
        Me.adresseLettre.TabIndex = 8
        Me.adresseLettre.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Adresse de destination"
        '
        'normalLettre
        '
        Me.normalLettre.AutoSize = True
        Me.normalLettre.Location = New System.Drawing.Point(225, 113)
        Me.normalLettre.Name = "normalLettre"
        Me.normalLettre.Size = New System.Drawing.Size(74, 21)
        Me.normalLettre.TabIndex = 6
        Me.normalLettre.TabStop = True
        Me.normalLettre.Text = "Normal"
        Me.normalLettre.UseVisualStyleBackColor = True
        '
        'expressLettre
        '
        Me.expressLettre.AutoSize = True
        Me.expressLettre.Location = New System.Drawing.Point(140, 113)
        Me.expressLettre.Name = "expressLettre"
        Me.expressLettre.Size = New System.Drawing.Size(79, 21)
        Me.expressLettre.TabIndex = 5
        Me.expressLettre.TabStop = True
        Me.expressLettre.Text = "Express"
        Me.expressLettre.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mode Expedition:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Format:"
        '
        'poidsLettre
        '
        Me.poidsLettre.Location = New System.Drawing.Point(136, 41)
        Me.poidsLettre.Name = "poidsLettre"
        Me.poidsLettre.Size = New System.Drawing.Size(174, 22)
        Me.poidsLettre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Poids"
        '
        'dgvCourrier
        '
        Me.dgvCourrier.AllowUserToAddRows = False
        Me.dgvCourrier.AllowUserToDeleteRows = False
        Me.dgvCourrier.AllowUserToOrderColumns = True
        Me.dgvCourrier.AllowUserToResizeRows = False
        Me.dgvCourrier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCourrier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCourrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourrier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvCourrier.Location = New System.Drawing.Point(40, 508)
        Me.dgvCourrier.Name = "dgvCourrier"
        Me.dgvCourrier.RowTemplate.Height = 24
        Me.dgvCourrier.Size = New System.Drawing.Size(983, 150)
        Me.dgvCourrier.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° Courrier"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Type"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Poids"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Mode d'expedition"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Adresse"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tarif"
        Me.Column6.Name = "Column6"
        '
        'format
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 727)
        Me.Controls.Add(Me.dgvCourrier)
        Me.Controls.Add(Me.lettre)
        Me.Controls.Add(Me.colis)
        Me.Controls.Add(Me.txtTarifTTC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalculerTarif)
        Me.Controls.Add(Me.CheckColis)
        Me.Controls.Add(Me.CheckLettre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "format"
        Me.Text = "Form1"
        Me.colis.ResumeLayout(False)
        Me.colis.PerformLayout()
        Me.lettre.ResumeLayout(False)
        Me.lettre.PerformLayout()
        CType(Me.dgvCourrier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckLettre As System.Windows.Forms.CheckBox
    Friend WithEvents CheckColis As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculerTarif As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTarifTTC As System.Windows.Forms.Label
    Friend WithEvents colis As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAjouterColis As System.Windows.Forms.Button
    Friend WithEvents adresseColis As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents normalColis As System.Windows.Forms.RadioButton
    Friend WithEvents expressColis As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents poidsColis As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents lettre As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjouterLettre As System.Windows.Forms.Button
    Friend WithEvents adresseLettre As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents normalLettre As System.Windows.Forms.RadioButton
    Friend WithEvents expressLettre As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents poidsLettre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents formatLettre As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCourrier As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents message As System.Windows.Forms.Label

End Class
