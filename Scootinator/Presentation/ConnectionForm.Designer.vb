<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectionForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.selectPath_button = New System.Windows.Forms.Button()
        Me.dbPath_label = New System.Windows.Forms.Label()
        Me.dbPath_Text = New System.Windows.Forms.TextBox()
        Me.connect_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'selectPath_button
        '
        Me.selectPath_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectPath_button.Location = New System.Drawing.Point(23, 122)
        Me.selectPath_button.Margin = New System.Windows.Forms.Padding(2)
        Me.selectPath_button.Name = "selectPath_button"
        Me.selectPath_button.Size = New System.Drawing.Size(124, 35)
        Me.selectPath_button.TabIndex = 0
        Me.selectPath_button.Text = "Select Database"
        Me.selectPath_button.UseVisualStyleBackColor = True
        '
        'dbPath_label
        '
        Me.dbPath_label.AutoSize = True
        Me.dbPath_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbPath_label.Location = New System.Drawing.Point(20, 83)
        Me.dbPath_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dbPath_label.Name = "dbPath_label"
        Me.dbPath_label.Size = New System.Drawing.Size(132, 15)
        Me.dbPath_label.TabIndex = 1
        Me.dbPath_label.Text = "Database File path:"
        '
        'dbPath_Text
        '
        Me.dbPath_Text.Location = New System.Drawing.Point(156, 83)
        Me.dbPath_Text.Margin = New System.Windows.Forms.Padding(2)
        Me.dbPath_Text.Name = "dbPath_Text"
        Me.dbPath_Text.ReadOnly = True
        Me.dbPath_Text.Size = New System.Drawing.Size(284, 20)
        Me.dbPath_Text.TabIndex = 2
        '
        'connect_button
        '
        Me.connect_button.Enabled = False
        Me.connect_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_button.Location = New System.Drawing.Point(355, 122)
        Me.connect_button.Margin = New System.Windows.Forms.Padding(2)
        Me.connect_button.Name = "connect_button"
        Me.connect_button.Size = New System.Drawing.Size(85, 35)
        Me.connect_button.TabIndex = 3
        Me.connect_button.Text = "Connect"
        Me.connect_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DATABASE CONNECTION"
        '
        'ConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 172)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.connect_button)
        Me.Controls.Add(Me.dbPath_Text)
        Me.Controls.Add(Me.dbPath_label)
        Me.Controls.Add(Me.selectPath_button)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ConnectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents selectPath_button As Button
    Friend WithEvents dbPath_label As Label
    Friend WithEvents dbPath_Text As TextBox
    Friend WithEvents connect_button As Button
    Friend WithEvents Label1 As Label
End Class
