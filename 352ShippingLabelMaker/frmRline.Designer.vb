<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRline
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtLookup = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelPartNumber = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelStandardPack = New System.Windows.Forms.Label()
        Me.LabelSeries = New System.Windows.Forms.Label()
        Me.lblPartNumber = New System.Windows.Forms.Label()
        Me.lblPartDescription = New System.Windows.Forms.Label()
        Me.lblStdPack = New System.Windows.Forms.Label()
        Me.lblSeries = New System.Windows.Forms.Label()
        Me.timerClearSearch = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelArches = New System.Windows.Forms.Label()
        Me.lblSkidCount = New System.Windows.Forms.Label()
        Me.LabelSkidCount = New System.Windows.Forms.Label()
        Me.btnShiftReset = New System.Windows.Forms.Button()
        Me.LblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboColour = New System.Windows.Forms.ComboBox()
        Me.CboSide = New System.Windows.Forms.ComboBox()
        Me.CboConfig = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(69, 38)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.Visible = False
        '
        'TxtLookup
        '
        Me.TxtLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLookup.Location = New System.Drawing.Point(128, 30)
        Me.TxtLookup.Name = "TxtLookup"
        Me.TxtLookup.Size = New System.Drawing.Size(340, 38)
        Me.TxtLookup.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPartNumber
        '
        Me.LabelPartNumber.AutoSize = True
        Me.LabelPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPartNumber.Location = New System.Drawing.Point(507, 33)
        Me.LabelPartNumber.Name = "LabelPartNumber"
        Me.LabelPartNumber.Size = New System.Drawing.Size(189, 31)
        Me.LabelPartNumber.TabIndex = 6
        Me.LabelPartNumber.Text = "Part Number : "
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(523, 82)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(173, 31)
        Me.LabelDescription.TabIndex = 7
        Me.LabelDescription.Text = "Description : "
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStandardPack
        '
        Me.LabelStandardPack.AutoSize = True
        Me.LabelStandardPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStandardPack.Location = New System.Drawing.Point(507, 168)
        Me.LabelStandardPack.Name = "LabelStandardPack"
        Me.LabelStandardPack.Size = New System.Drawing.Size(195, 31)
        Me.LabelStandardPack.TabIndex = 8
        Me.LabelStandardPack.Text = "Std Pack Qty : "
        Me.LabelStandardPack.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSeries
        '
        Me.LabelSeries.AutoSize = True
        Me.LabelSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeries.Location = New System.Drawing.Point(518, 223)
        Me.LabelSeries.Name = "LabelSeries"
        Me.LabelSeries.Size = New System.Drawing.Size(178, 31)
        Me.LabelSeries.TabIndex = 9
        Me.LabelSeries.Text = "Series Level :"
        Me.LabelSeries.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartNumber
        '
        Me.lblPartNumber.AutoSize = True
        Me.lblPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumber.Location = New System.Drawing.Point(717, 33)
        Me.lblPartNumber.Name = "lblPartNumber"
        Me.lblPartNumber.Size = New System.Drawing.Size(0, 31)
        Me.lblPartNumber.TabIndex = 10
        '
        'lblPartDescription
        '
        Me.lblPartDescription.AutoSize = True
        Me.lblPartDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartDescription.Location = New System.Drawing.Point(717, 89)
        Me.lblPartDescription.Name = "lblPartDescription"
        Me.lblPartDescription.Size = New System.Drawing.Size(0, 31)
        Me.lblPartDescription.TabIndex = 11
        '
        'lblStdPack
        '
        Me.lblStdPack.AutoSize = True
        Me.lblStdPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdPack.Location = New System.Drawing.Point(717, 168)
        Me.lblStdPack.Name = "lblStdPack"
        Me.lblStdPack.Size = New System.Drawing.Size(0, 31)
        Me.lblStdPack.TabIndex = 12
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.Location = New System.Drawing.Point(717, 223)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(0, 31)
        Me.lblSeries.TabIndex = 13
        '
        'timerClearSearch
        '
        Me.timerClearSearch.Interval = 250
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1047, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'LabelArches
        '
        Me.LabelArches.AutoSize = True
        Me.LabelArches.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArches.Location = New System.Drawing.Point(12, 33)
        Me.LabelArches.Name = "LabelArches"
        Me.LabelArches.Size = New System.Drawing.Size(76, 31)
        Me.LabelArches.TabIndex = 19
        Me.LabelArches.Text = "Rline"
        '
        'lblSkidCount
        '
        Me.lblSkidCount.AutoSize = True
        Me.lblSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkidCount.Location = New System.Drawing.Point(717, 324)
        Me.lblSkidCount.Name = "lblSkidCount"
        Me.lblSkidCount.Size = New System.Drawing.Size(0, 31)
        Me.lblSkidCount.TabIndex = 29
        '
        'LabelSkidCount
        '
        Me.LabelSkidCount.AutoSize = True
        Me.LabelSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSkidCount.Location = New System.Drawing.Point(534, 324)
        Me.LabelSkidCount.Name = "LabelSkidCount"
        Me.LabelSkidCount.Size = New System.Drawing.Size(162, 31)
        Me.LabelSkidCount.TabIndex = 28
        Me.LabelSkidCount.Text = "Skid Count :"
        Me.LabelSkidCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnShiftReset
        '
        Me.btnShiftReset.Location = New System.Drawing.Point(337, 316)
        Me.btnShiftReset.Name = "btnShiftReset"
        Me.btnShiftReset.Size = New System.Drawing.Size(131, 44)
        Me.btnShiftReset.TabIndex = 30
        Me.btnShiftReset.Text = "Skid count reset"
        Me.btnShiftReset.UseVisualStyleBackColor = True
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(466, 392)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblClock.Size = New System.Drawing.Size(0, 31)
        Me.LblClock.TabIndex = 33
        '
        'TmrClock
        '
        Me.TmrClock.Enabled = True
        Me.TmrClock.Interval = 1000
        '
        'TextBoxQty
        '
        Me.TextBoxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQty.Location = New System.Drawing.Point(214, 255)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(101, 38)
        Me.TextBoxQty.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 31)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Quantity :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CboColour
        '
        Me.CboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboColour.FormattingEnabled = True
        Me.CboColour.Items.AddRange(New Object() {"TITANIUM BEIGE - (A1X)", "FORTANA RED - (B3Z)", "KURKUMA MET - (R1X)", "REFLEX SILVER - (A7W)", "PURE WHITE - (C9A)", "DEEP BLACK PEARL - (C9X)", "TOURMALINE BLUE - (P5Y)", "PLATINUM GRAY - (D7X)", "HUNTING BROWN - (A8U)", "PRIME - (GRU)", "RACING GREEN - (P6W )", "PYRIT SILVER - (B7S)", "PURE GREY - (H7J)", "ORYX WHITE PEARL (OK1)", "AURORA RED (0G3)"})
        Me.CboColour.Location = New System.Drawing.Point(18, 205)
        Me.CboColour.Name = "CboColour"
        Me.CboColour.Size = New System.Drawing.Size(450, 39)
        Me.CboColour.TabIndex = 39
        '
        'CboSide
        '
        Me.CboSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSide.FormattingEnabled = True
        Me.CboSide.Items.AddRange(New Object() {"Left", "Right"})
        Me.CboSide.Location = New System.Drawing.Point(319, 119)
        Me.CboSide.Name = "CboSide"
        Me.CboSide.Size = New System.Drawing.Size(149, 39)
        Me.CboSide.TabIndex = 37
        '
        'CboConfig
        '
        Me.CboConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboConfig.FormattingEnabled = True
        Me.CboConfig.Items.AddRange(New Object() {"Front", "Rear"})
        Me.CboConfig.Location = New System.Drawing.Point(319, 74)
        Me.CboConfig.Name = "CboConfig"
        Me.CboConfig.Size = New System.Drawing.Size(149, 39)
        Me.CboConfig.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 31)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Choose A Configuration :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 31)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Choose a Side:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 31)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Choose A Colour"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmRline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 742)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboColour)
        Me.Controls.Add(Me.CboConfig)
        Me.Controls.Add(Me.CboSide)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxQty)
        Me.Controls.Add(Me.LblClock)
        Me.Controls.Add(Me.btnShiftReset)
        Me.Controls.Add(Me.lblSkidCount)
        Me.Controls.Add(Me.LabelSkidCount)
        Me.Controls.Add(Me.LabelArches)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblSeries)
        Me.Controls.Add(Me.lblStdPack)
        Me.Controls.Add(Me.lblPartDescription)
        Me.Controls.Add(Me.lblPartNumber)
        Me.Controls.Add(Me.LabelSeries)
        Me.Controls.Add(Me.LabelStandardPack)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelPartNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtLookup)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRline"
        Me.Text = "Rline"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtLookup As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelPartNumber As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelStandardPack As Label
    Friend WithEvents LabelSeries As Label
    Friend WithEvents lblPartNumber As Label
    Friend WithEvents lblPartDescription As Label
    Friend WithEvents lblStdPack As Label
    Friend WithEvents lblSeries As Label
    Friend WithEvents timerClearSearch As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelArches As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSkidCount As Label
    Friend WithEvents LabelSkidCount As Label
    Friend WithEvents btnShiftReset As Button
    Friend WithEvents LblClock As Label
    Friend WithEvents TmrClock As Timer
    Friend WithEvents TextBoxQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CboColour As ComboBox
    Friend WithEvents CboSide As ComboBox
    Friend WithEvents CboConfig As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
