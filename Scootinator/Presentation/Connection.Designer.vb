<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connection
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
        Me.selectPath_button = New System.Windows.Forms.Button()
        Me.dbPath_label = New System.Windows.Forms.Label()
        Me.dbPath_Text = New System.Windows.Forms.TextBox()
        Me.connect_button = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.subtitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'selectPath_button
        '
        Me.selectPath_button.Location = New System.Drawing.Point(34, 188)
        Me.selectPath_button.Name = "selectPath_button"
        Me.selectPath_button.Size = New System.Drawing.Size(162, 38)
        Me.selectPath_button.TabIndex = 0
        Me.selectPath_button.Text = "Select Database"
        Me.selectPath_button.UseVisualStyleBackColor = True
        '
        'dbPath_label
        '
        Me.dbPath_label.AutoSize = True
        Me.dbPath_label.Location = New System.Drawing.Point(30, 130)
        Me.dbPath_label.Name = "dbPath_label"
        Me.dbPath_label.Size = New System.Drawing.Size(148, 20)
        Me.dbPath_label.TabIndex = 1
        Me.dbPath_label.Text = "Database File path:"
        '
        'dbPath_Text
        '
        Me.dbPath_Text.Location = New System.Drawing.Point(184, 124)
        Me.dbPath_Text.Name = "dbPath_Text"
        Me.dbPath_Text.ReadOnly = True
        Me.dbPath_Text.Size = New System.Drawing.Size(383, 26)
        Me.dbPath_Text.TabIndex = 2
        '
        'connect_button
        '
        Me.connect_button.Enabled = False
        Me.connect_button.Location = New System.Drawing.Point(471, 188)
        Me.connect_button.Name = "connect_button"
        Me.connect_button.Size = New System.Drawing.Size(96, 38)
        Me.connect_button.TabIndex = 3
        Me.connect_button.Text = "Connect"
        Me.connect_button.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(59, 31)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(236, 46)
        Me.title.TabIndex = 4
        Me.title.Text = "Scootinator"
        '
        'subtitle
        '
        Me.subtitle.AutoSize = True
        Me.subtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle.Location = New System.Drawing.Point(315, 48)
        Me.subtitle.Name = "subtitle"
        Me.subtitle.Size = New System.Drawing.Size(221, 25)
        Me.subtitle.TabIndex = 5
        Me.subtitle.Text = "A scooter rent system"
        '
        'Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 259)
        Me.Controls.Add(Me.subtitle)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.connect_button)
        Me.Controls.Add(Me.dbPath_Text)
        Me.Controls.Add(Me.dbPath_label)
        Me.Controls.Add(Me.selectPath_button)
        Me.Name = "Connection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents selectPath_button As Button
    Friend WithEvents dbPath_label As Label
    Friend WithEvents dbPath_Text As TextBox
    Friend WithEvents connect_button As Button
    Friend WithEvents title As Label
    Friend WithEvents subtitle As Label
End Class
