<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercice2
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
        Me.cbVille = New System.Windows.Forms.ComboBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnToutSupprimer = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selectionnez ou entrez ville:"
        '
        'cbVille
        '
        Me.cbVille.FormattingEnabled = True
        Me.cbVille.Location = New System.Drawing.Point(34, 123)
        Me.cbVille.Name = "cbVille"
        Me.cbVille.Size = New System.Drawing.Size(261, 24)
        Me.cbVille.TabIndex = 1
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(356, 126)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(142, 33)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(356, 164)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(142, 33)
        Me.btnSupprimer.TabIndex = 3
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnToutSupprimer
        '
        Me.btnToutSupprimer.Location = New System.Drawing.Point(356, 203)
        Me.btnToutSupprimer.Name = "btnToutSupprimer"
        Me.btnToutSupprimer.Size = New System.Drawing.Size(142, 33)
        Me.btnToutSupprimer.TabIndex = 4
        Me.btnToutSupprimer.Text = "Tout Supprimer"
        Me.btnToutSupprimer.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(356, 242)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(142, 33)
        Me.btnQuitter.TabIndex = 5
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Exercice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 429)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnToutSupprimer)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.cbVille)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Exercice2"
        Me.Text = "Exercice2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbVille As System.Windows.Forms.ComboBox
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnToutSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
End Class
