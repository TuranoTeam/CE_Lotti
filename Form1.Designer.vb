<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UltraNumericEditor1 = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraCombo1 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.UltraNumericEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraNumericEditor1
        '
        Me.UltraNumericEditor1.Location = New System.Drawing.Point(154, 46)
        Me.UltraNumericEditor1.Name = "UltraNumericEditor1"
        Me.UltraNumericEditor1.Size = New System.Drawing.Size(100, 21)
        Me.UltraNumericEditor1.TabIndex = 0
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Location = New System.Drawing.Point(238, 135)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(550, 80)
        Me.UltraGrid1.TabIndex = 1
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(58, 126)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(75, 23)
        Me.UltraButton1.TabIndex = 2
        Me.UltraButton1.Text = "UltraButton1"
        '
        'UltraCombo1
        '
        Me.UltraCombo1.Location = New System.Drawing.Point(154, 302)
        Me.UltraCombo1.Name = "UltraCombo1"
        Me.UltraCombo1.Size = New System.Drawing.Size(100, 22)
        Me.UltraCombo1.TabIndex = 3
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Location = New System.Drawing.Point(432, 292)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(200, 110)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "UltraGroupBox1"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(154, 354)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "UltraLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1666, 734)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraCombo1)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.UltraNumericEditor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UltraNumericEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UltraNumericEditor1 As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraCombo1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
