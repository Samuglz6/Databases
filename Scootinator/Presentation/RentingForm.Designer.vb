<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentingForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.total_price = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.client_id = New System.Windows.Forms.Label()
        Me.client_phone = New System.Windows.Forms.Label()
        Me.client_name = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.scooter_renting_listbox = New System.Windows.Forms.ListBox()
        Me.scooter_available_listbox = New System.Windows.Forms.ListBox()
        Me.client_listbox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.historial_tab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.title = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.scooter_brand = New System.Windows.Forms.Label()
        Me.scooter_weight = New System.Windows.Forms.Label()
        Me.scooter_speed = New System.Windows.Forms.Label()
        Me.scooter_price = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.historial_tab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.scooter_price)
        Me.GroupBox1.Controls.Add(Me.scooter_speed)
        Me.GroupBox1.Controls.Add(Me.scooter_weight)
        Me.GroupBox1.Controls.Add(Me.scooter_brand)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.total_price)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Splitter1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.client_id)
        Me.GroupBox1.Controls.Add(Me.client_phone)
        Me.GroupBox1.Controls.Add(Me.client_name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.scooter_renting_listbox)
        Me.GroupBox1.Controls.Add(Me.scooter_available_listbox)
        Me.GroupBox1.Controls.Add(Me.client_listbox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 692)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Renting"
        '
        'total_price
        '
        Me.total_price.AutoSize = True
        Me.total_price.Location = New System.Drawing.Point(279, 607)
        Me.total_price.Name = "total_price"
        Me.total_price.Size = New System.Drawing.Size(0, 15)
        Me.total_price.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(179, 607)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Total price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Finishing hour:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Begining hour:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Date:"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(142, 302)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(85, 21)
        Me.DateTimePicker3.TabIndex = 0
        Me.DateTimePicker3.Value = New Date(2019, 4, 27, 18, 34, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(142, 329)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(85, 21)
        Me.DateTimePicker2.TabIndex = 19
        Me.DateTimePicker2.Value = New Date(2019, 4, 27, 18, 34, 0, 0)
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(3, 17)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 672)
        Me.Splitter1.TabIndex = 18
        Me.Splitter1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Select the date and time wanted to rent them:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 275)
        Me.DateTimePicker1.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 21)
        Me.DateTimePicker1.TabIndex = 16
        '
        'client_id
        '
        Me.client_id.AutoSize = True
        Me.client_id.Location = New System.Drawing.Point(258, 116)
        Me.client_id.Name = "client_id"
        Me.client_id.Size = New System.Drawing.Size(0, 15)
        Me.client_id.TabIndex = 15
        '
        'client_phone
        '
        Me.client_phone.AutoSize = True
        Me.client_phone.Location = New System.Drawing.Point(258, 185)
        Me.client_phone.Name = "client_phone"
        Me.client_phone.Size = New System.Drawing.Size(0, 15)
        Me.client_phone.TabIndex = 14
        '
        'client_name
        '
        Me.client_name.AutoSize = True
        Me.client_name.Location = New System.Drawing.Point(258, 148)
        Me.client_name.Name = "client_name"
        Me.client_name.Size = New System.Drawing.Size(0, 15)
        Me.client_name.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Clients"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select the client who is renting the scooter/s:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 639)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 37)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Make the Rent"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Scooters to be rented"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Scooters Available"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(431, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'scooter_renting_listbox
        '
        Me.scooter_renting_listbox.FormattingEnabled = True
        Me.scooter_renting_listbox.ItemHeight = 15
        Me.scooter_renting_listbox.Location = New System.Drawing.Point(413, 395)
        Me.scooter_renting_listbox.Name = "scooter_renting_listbox"
        Me.scooter_renting_listbox.Size = New System.Drawing.Size(120, 139)
        Me.scooter_renting_listbox.TabIndex = 2
        '
        'scooter_available_listbox
        '
        Me.scooter_available_listbox.FormattingEnabled = True
        Me.scooter_available_listbox.ItemHeight = 15
        Me.scooter_available_listbox.Location = New System.Drawing.Point(35, 395)
        Me.scooter_available_listbox.Name = "scooter_available_listbox"
        Me.scooter_available_listbox.Size = New System.Drawing.Size(120, 139)
        Me.scooter_available_listbox.TabIndex = 1
        '
        'client_listbox
        '
        Me.client_listbox.FormattingEnabled = True
        Me.client_listbox.ItemHeight = 15
        Me.client_listbox.Location = New System.Drawing.Point(34, 88)
        Me.client_listbox.Name = "client_listbox"
        Me.client_listbox.Size = New System.Drawing.Size(120, 139)
        Me.client_listbox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.historial_tab)
        Me.GroupBox2.Location = New System.Drawing.Point(586, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 519)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "History"
        '
        'historial_tab
        '
        Me.historial_tab.Controls.Add(Me.TabPage1)
        Me.historial_tab.Controls.Add(Me.TabPage2)
        Me.historial_tab.Location = New System.Drawing.Point(6, 19)
        Me.historial_tab.Name = "historial_tab"
        Me.historial_tab.SelectedIndex = 0
        Me.historial_tab.Size = New System.Drawing.Size(390, 494)
        Me.historial_tab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 468)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clients"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(427, 468)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Scooters"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Location = New System.Drawing.Point(586, 575)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 144)
        Me.Panel1.TabIndex = 2
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Snap ITC", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(214, 74)
        Me.title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(478, 82)
        Me.title.TabIndex = 8
        Me.title.Text = "Scootinator"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(1007, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 519)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ranking"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(175, 412)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Brand:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(175, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Max. Weight:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(175, 471)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Max. Speed:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(175, 499)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 15)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Price per Hour:"
        '
        'scooter_brand
        '
        Me.scooter_brand.AutoSize = True
        Me.scooter_brand.Location = New System.Drawing.Point(303, 412)
        Me.scooter_brand.Name = "scooter_brand"
        Me.scooter_brand.Size = New System.Drawing.Size(0, 15)
        Me.scooter_brand.TabIndex = 31
        '
        'scooter_weight
        '
        Me.scooter_weight.AutoSize = True
        Me.scooter_weight.Location = New System.Drawing.Point(303, 440)
        Me.scooter_weight.Name = "scooter_weight"
        Me.scooter_weight.Size = New System.Drawing.Size(0, 15)
        Me.scooter_weight.TabIndex = 32
        '
        'scooter_speed
        '
        Me.scooter_speed.AutoSize = True
        Me.scooter_speed.Location = New System.Drawing.Point(303, 471)
        Me.scooter_speed.Name = "scooter_speed"
        Me.scooter_speed.Size = New System.Drawing.Size(0, 15)
        Me.scooter_speed.TabIndex = 33
        '
        'scooter_price
        '
        Me.scooter_price.AutoSize = True
        Me.scooter_price.Location = New System.Drawing.Point(303, 499)
        Me.scooter_price.Name = "scooter_price"
        Me.scooter_price.Size = New System.Drawing.Size(0, 15)
        Me.scooter_price.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(-5, 718)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1424, 74)
        Me.Panel2.TabIndex = 3
        '
        'RentingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1409, 785)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RentingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.historial_tab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents historial_tab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents client_id As Label
    Friend WithEvents client_phone As Label
    Friend WithEvents client_name As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents scooter_renting_listbox As ListBox
    Friend WithEvents scooter_available_listbox As ListBox
    Friend WithEvents client_listbox As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents total_price As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents title As Label
    Friend WithEvents scooter_price As Label
    Friend WithEvents scooter_speed As Label
    Friend WithEvents scooter_weight As Label
    Friend WithEvents scooter_brand As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
End Class
