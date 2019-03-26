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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScootersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsHistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScootersHistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 20, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsToolStripMenuItem, Me.ScootersToolStripMenuItem, Me.HistorialToolStripMenuItem, Me.RankingToolStripMenuItem, Me.BookingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(186, 450)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.Checked = True
        Me.ClientsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProbandoToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(146, 42)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'ProbandoToolStripMenuItem
        '
        Me.ProbandoToolStripMenuItem.Name = "ProbandoToolStripMenuItem"
        Me.ProbandoToolStripMenuItem.Size = New System.Drawing.Size(242, 42)
        Me.ProbandoToolStripMenuItem.Text = "probando"
        '
        'ScootersToolStripMenuItem
        '
        Me.ScootersToolStripMenuItem.Name = "ScootersToolStripMenuItem"
        Me.ScootersToolStripMenuItem.Size = New System.Drawing.Size(146, 42)
        Me.ScootersToolStripMenuItem.Text = "Scooters"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsHistorialToolStripMenuItem, Me.ScootersHistorialToolStripMenuItem})
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(146, 42)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'ClientsHistorialToolStripMenuItem
        '
        Me.ClientsHistorialToolStripMenuItem.Name = "ClientsHistorialToolStripMenuItem"
        Me.ClientsHistorialToolStripMenuItem.Size = New System.Drawing.Size(252, 42)
        Me.ClientsHistorialToolStripMenuItem.Text = "Clients"
        '
        'ScootersHistorialToolStripMenuItem
        '
        Me.ScootersHistorialToolStripMenuItem.Name = "ScootersHistorialToolStripMenuItem"
        Me.ScootersHistorialToolStripMenuItem.Size = New System.Drawing.Size(252, 42)
        Me.ScootersHistorialToolStripMenuItem.Text = "Scooters"
        '
        'RankingToolStripMenuItem
        '
        Me.RankingToolStripMenuItem.Name = "RankingToolStripMenuItem"
        Me.RankingToolStripMenuItem.Size = New System.Drawing.Size(146, 42)
        Me.RankingToolStripMenuItem.Text = "Ranking"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(146, 42)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScootersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProbandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsHistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScootersHistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RankingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
End Class
