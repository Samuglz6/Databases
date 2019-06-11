<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.subtitle = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.connect_button = New System.Windows.Forms.Button()
        Me.dbPath_Text = New System.Windows.Forms.TextBox()
        Me.dbPath_label = New System.Windows.Forms.Label()
        Me.selectPath_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(271, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Disconnected"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(21, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 48)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "MANAGEMENT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(271, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(232, 48)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "RENTING SYSTEM"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'subtitle
        '
        Me.subtitle.AutoSize = True
        Me.subtitle.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle.Location = New System.Drawing.Point(334, 54)
        Me.subtitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.subtitle.Name = "subtitle"
        Me.subtitle.Size = New System.Drawing.Size(166, 18)
        Me.subtitle.TabIndex = 7
        Me.subtitle.Text = "A scooter rent system"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Snap ITC", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(43, 21)
        Me.title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(303, 51)
        Me.title.TabIndex = 6
        Me.title.Text = "Scootinator"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.subtitle)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 96)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 196)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(533, 63)
        Me.Panel2.TabIndex = 9
        '
        'connect_button
        '
        Me.connect_button.Enabled = False
        Me.connect_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_button.Location = New System.Drawing.Point(393, 66)
        Me.connect_button.Margin = New System.Windows.Forms.Padding(2)
        Me.connect_button.Name = "connect_button"
        Me.connect_button.Size = New System.Drawing.Size(85, 35)
        Me.connect_button.TabIndex = 13
        Me.connect_button.Text = "Connect"
        Me.connect_button.UseVisualStyleBackColor = True
        '
        'dbPath_Text
        '
        Me.dbPath_Text.Location = New System.Drawing.Point(194, 27)
        Me.dbPath_Text.Margin = New System.Windows.Forms.Padding(2)
        Me.dbPath_Text.Name = "dbPath_Text"
        Me.dbPath_Text.ReadOnly = True
        Me.dbPath_Text.Size = New System.Drawing.Size(284, 20)
        Me.dbPath_Text.TabIndex = 12
        '
        'dbPath_label
        '
        Me.dbPath_label.AutoSize = True
        Me.dbPath_label.BackColor = System.Drawing.Color.White
        Me.dbPath_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbPath_label.Location = New System.Drawing.Point(58, 27)
        Me.dbPath_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dbPath_label.Name = "dbPath_label"
        Me.dbPath_label.Size = New System.Drawing.Size(132, 15)
        Me.dbPath_label.TabIndex = 11
        Me.dbPath_label.Text = "Database File path:"
        '
        'selectPath_button
        '
        Me.selectPath_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectPath_button.Location = New System.Drawing.Point(61, 66)
        Me.selectPath_button.Margin = New System.Windows.Forms.Padding(2)
        Me.selectPath_button.Name = "selectPath_button"
        Me.selectPath_button.Size = New System.Drawing.Size(124, 35)
        Me.selectPath_button.TabIndex = 10
        Me.selectPath_button.Text = "Select Database"
        Me.selectPath_button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.connect_button)
        Me.Panel3.Controls.Add(Me.dbPath_Text)
        Me.Panel3.Controls.Add(Me.selectPath_button)
        Me.Panel3.Controls.Add(Me.dbPath_label)
        Me.Panel3.Location = New System.Drawing.Point(-3, 260)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(533, 128)
        Me.Panel3.TabIndex = 14
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(525, 383)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents subtitle As Label
    Friend WithEvents title As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents connect_button As Button
    Friend WithEvents dbPath_Text As TextBox
    Friend WithEvents dbPath_label As Label
    Friend WithEvents selectPath_button As Button
    Friend WithEvents Panel3 As Panel
End Class
