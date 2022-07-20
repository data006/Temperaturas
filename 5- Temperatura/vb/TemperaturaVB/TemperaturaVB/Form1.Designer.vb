<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperatura
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
        Me.grpTempIn = New System.Windows.Forms.GroupBox()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.radInR = New System.Windows.Forms.RadioButton()
        Me.radInK = New System.Windows.Forms.RadioButton()
        Me.radInF = New System.Windows.Forms.RadioButton()
        Me.radinC = New System.Windows.Forms.RadioButton()
        Me.grpTempOut = New System.Windows.Forms.GroupBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.radOutR = New System.Windows.Forms.RadioButton()
        Me.radOutK = New System.Windows.Forms.RadioButton()
        Me.radOutF = New System.Windows.Forms.RadioButton()
        Me.radOutC = New System.Windows.Forms.RadioButton()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpTempIn.SuspendLayout()
        Me.grpTempOut.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTempIn
        '
        Me.grpTempIn.Controls.Add(Me.txtIn)
        Me.grpTempIn.Controls.Add(Me.radInR)
        Me.grpTempIn.Controls.Add(Me.radInK)
        Me.grpTempIn.Controls.Add(Me.radInF)
        Me.grpTempIn.Controls.Add(Me.radinC)
        Me.grpTempIn.Location = New System.Drawing.Point(101, 66)
        Me.grpTempIn.Name = "grpTempIn"
        Me.grpTempIn.Size = New System.Drawing.Size(182, 169)
        Me.grpTempIn.TabIndex = 0
        Me.grpTempIn.TabStop = False
        Me.grpTempIn.Text = "Temperatura de Entrada"
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(14, 132)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(150, 20)
        Me.txtIn.TabIndex = 4
        '
        'radInR
        '
        Me.radInR.AutoSize = True
        Me.radInR.Location = New System.Drawing.Point(14, 97)
        Me.radInR.Name = "radInR"
        Me.radInR.Size = New System.Drawing.Size(65, 17)
        Me.radInR.TabIndex = 3
        Me.radInR.TabStop = True
        Me.radInR.Text = "Rankine"
        Me.radInR.UseVisualStyleBackColor = True
        '
        'radInK
        '
        Me.radInK.AutoSize = True
        Me.radInK.Location = New System.Drawing.Point(14, 74)
        Me.radInK.Name = "radInK"
        Me.radInK.Size = New System.Drawing.Size(54, 17)
        Me.radInK.TabIndex = 2
        Me.radInK.TabStop = True
        Me.radInK.Text = "Kelvin"
        Me.radInK.UseVisualStyleBackColor = True
        '
        'radInF
        '
        Me.radInF.AutoSize = True
        Me.radInF.Location = New System.Drawing.Point(14, 51)
        Me.radInF.Name = "radInF"
        Me.radInF.Size = New System.Drawing.Size(75, 17)
        Me.radInF.TabIndex = 1
        Me.radInF.TabStop = True
        Me.radInF.Text = "Fahrenheit"
        Me.radInF.UseVisualStyleBackColor = True
        '
        'radinC
        '
        Me.radinC.AutoSize = True
        Me.radinC.Location = New System.Drawing.Point(14, 28)
        Me.radinC.Name = "radinC"
        Me.radinC.Size = New System.Drawing.Size(58, 17)
        Me.radinC.TabIndex = 0
        Me.radinC.TabStop = True
        Me.radinC.Text = "Celsius"
        Me.radinC.UseVisualStyleBackColor = True
        '
        'grpTempOut
        '
        Me.grpTempOut.Controls.Add(Me.txtOut)
        Me.grpTempOut.Controls.Add(Me.radOutR)
        Me.grpTempOut.Controls.Add(Me.radOutK)
        Me.grpTempOut.Controls.Add(Me.radOutF)
        Me.grpTempOut.Controls.Add(Me.radOutC)
        Me.grpTempOut.Location = New System.Drawing.Point(352, 66)
        Me.grpTempOut.Name = "grpTempOut"
        Me.grpTempOut.Size = New System.Drawing.Size(192, 169)
        Me.grpTempOut.TabIndex = 1
        Me.grpTempOut.TabStop = False
        Me.grpTempOut.Text = "Temperatura de Salida"
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(20, 132)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(149, 20)
        Me.txtOut.TabIndex = 5
        '
        'radOutR
        '
        Me.radOutR.AutoSize = True
        Me.radOutR.Location = New System.Drawing.Point(20, 96)
        Me.radOutR.Name = "radOutR"
        Me.radOutR.Size = New System.Drawing.Size(65, 17)
        Me.radOutR.TabIndex = 7
        Me.radOutR.TabStop = True
        Me.radOutR.Text = "Rankine"
        Me.radOutR.UseVisualStyleBackColor = True
        '
        'radOutK
        '
        Me.radOutK.AutoSize = True
        Me.radOutK.Location = New System.Drawing.Point(20, 73)
        Me.radOutK.Name = "radOutK"
        Me.radOutK.Size = New System.Drawing.Size(54, 17)
        Me.radOutK.TabIndex = 6
        Me.radOutK.TabStop = True
        Me.radOutK.Text = "Kelvin"
        Me.radOutK.UseVisualStyleBackColor = True
        '
        'radOutF
        '
        Me.radOutF.AutoSize = True
        Me.radOutF.Location = New System.Drawing.Point(20, 50)
        Me.radOutF.Name = "radOutF"
        Me.radOutF.Size = New System.Drawing.Size(75, 17)
        Me.radOutF.TabIndex = 5
        Me.radOutF.TabStop = True
        Me.radOutF.Text = "Fahrenheit"
        Me.radOutF.UseVisualStyleBackColor = True
        '
        'radOutC
        '
        Me.radOutC.AutoSize = True
        Me.radOutC.Location = New System.Drawing.Point(20, 27)
        Me.radOutC.Name = "radOutC"
        Me.radOutC.Size = New System.Drawing.Size(58, 17)
        Me.radOutC.TabIndex = 4
        Me.radOutC.TabStop = True
        Me.radOutC.Text = "Celsius"
        Me.radOutC.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(229, 293)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(171, 42)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmTemperatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpTempOut)
        Me.Controls.Add(Me.grpTempIn)
        Me.Name = "frmTemperatura"
        Me.Text = "Conversor de Temperatura"
        Me.grpTempIn.ResumeLayout(False)
        Me.grpTempIn.PerformLayout()
        Me.grpTempOut.ResumeLayout(False)
        Me.grpTempOut.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTempIn As GroupBox
    Friend WithEvents txtIn As TextBox
    Friend WithEvents radInR As RadioButton
    Friend WithEvents radInK As RadioButton
    Friend WithEvents radInF As RadioButton
    Friend WithEvents radinC As RadioButton
    Friend WithEvents grpTempOut As GroupBox
    Friend WithEvents txtOut As TextBox
    Friend WithEvents radOutR As RadioButton
    Friend WithEvents radOutK As RadioButton
    Friend WithEvents radOutF As RadioButton
    Friend WithEvents radOutC As RadioButton
    Friend WithEvents btnOk As Button
    Friend WithEvents lblIn As Label
    Friend WithEvents lblOut As Label
End Class
