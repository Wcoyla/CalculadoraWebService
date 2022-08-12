<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnFact = New System.Windows.Forms.Button()
        Me.btnInverso = New System.Windows.Forms.Button()
        Me.btnPot = New System.Windows.Forms.Button()
        Me.btnSeno = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNro1
        '
        resources.ApplyResources(Me.txtNro1, "txtNro1")
        Me.txtNro1.Name = "txtNro1"
        '
        'txtNro2
        '
        resources.ApplyResources(Me.txtNro2, "txtNro2")
        Me.txtNro2.Name = "txtNro2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Name = "Label2"
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnSuma, "btnSuma")
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnRestar
        '
        Me.btnRestar.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnRestar, "btnRestar")
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.UseVisualStyleBackColor = False
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnMulti, "btnMulti")
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.UseVisualStyleBackColor = False
        '
        'btnDiv
        '
        Me.btnDiv.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnDiv, "btnDiv")
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.UseVisualStyleBackColor = False
        '
        'btnFact
        '
        Me.btnFact.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnFact, "btnFact")
        Me.btnFact.Name = "btnFact"
        Me.btnFact.UseVisualStyleBackColor = False
        '
        'btnInverso
        '
        Me.btnInverso.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnInverso, "btnInverso")
        Me.btnInverso.Name = "btnInverso"
        Me.btnInverso.UseVisualStyleBackColor = False
        '
        'btnPot
        '
        Me.btnPot.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnPot, "btnPot")
        Me.btnPot.Name = "btnPot"
        Me.btnPot.UseVisualStyleBackColor = False
        '
        'btnSeno
        '
        Me.btnSeno.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnSeno, "btnSeno")
        Me.btnSeno.Name = "btnSeno"
        Me.btnSeno.UseVisualStyleBackColor = False
        '
        'btnCos
        '
        Me.btnCos.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnCos, "btnCos")
        Me.btnCos.Name = "btnCos"
        Me.btnCos.UseVisualStyleBackColor = False
        '
        'btnTan
        '
        Me.btnTan.BackColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.btnTan, "btnTan")
        Me.btnTan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTan.Name = "btnTan"
        Me.btnTan.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Name = "Label3"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSeno)
        Me.Controls.Add(Me.btnPot)
        Me.Controls.Add(Me.btnInverso)
        Me.Controls.Add(Me.btnFact)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnFact As Button
    Friend WithEvents btnInverso As Button
    Friend WithEvents btnPot As Button
    Friend WithEvents btnSeno As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTan As Button
    Friend WithEvents Label3 As Label
End Class
