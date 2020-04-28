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
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.TextNumAdd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.labelaverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(60, 55)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(241, 355)
        Me.ListBox.TabIndex = 0
        '
        'TextNumAdd
        '
        Me.TextNumAdd.Location = New System.Drawing.Point(348, 98)
        Me.TextNumAdd.Name = "TextNumAdd"
        Me.TextNumAdd.Size = New System.Drawing.Size(116, 20)
        Me.TextNumAdd.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(348, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Average"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'labelaverage
        '
        Me.labelaverage.AutoSize = True
        Me.labelaverage.Location = New System.Drawing.Point(395, 276)
        Me.labelaverage.Name = "labelaverage"
        Me.labelaverage.Size = New System.Drawing.Size(13, 13)
        Me.labelaverage.TabIndex = 4
        Me.labelaverage.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 430)
        Me.Controls.Add(Me.labelaverage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextNumAdd)
        Me.Controls.Add(Me.ListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox As ListBox
    Friend WithEvents TextNumAdd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents labelaverage As Label
End Class
