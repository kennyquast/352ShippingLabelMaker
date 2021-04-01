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
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(92, 47)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.Visible = False
        '
        'TxtLookup
        '
        Me.TxtLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLookup.Location = New System.Drawing.Point(171, 37)
        Me.TxtLookup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtLookup.Name = "TxtLookup"
        Me.TxtLookup.Size = New System.Drawing.Size(452, 46)
        Me.TxtLookup.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(449, 308)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 53)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPartNumber
        '
        Me.LabelPartNumber.AutoSize = True
        Me.LabelPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPartNumber.Location = New System.Drawing.Point(676, 41)
        Me.LabelPartNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPartNumber.Name = "LabelPartNumber"
        Me.LabelPartNumber.Size = New System.Drawing.Size(236, 39)
        Me.LabelPartNumber.TabIndex = 6
        Me.LabelPartNumber.Text = "Part Number : "
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(697, 101)
        Me.LabelDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(215, 39)
        Me.LabelDescription.TabIndex = 7
        Me.LabelDescription.Text = "Description : "
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelStandardPack
        '
        Me.LabelStandardPack.AutoSize = True
        Me.LabelStandardPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStandardPack.Location = New System.Drawing.Point(676, 207)
        Me.LabelStandardPack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStandardPack.Name = "LabelStandardPack"
        Me.LabelStandardPack.Size = New System.Drawing.Size(241, 39)
        Me.LabelStandardPack.TabIndex = 8
        Me.LabelStandardPack.Text = "Std Pack Qty : "
        Me.LabelStandardPack.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelSeries
        '
        Me.LabelSeries.AutoSize = True
        Me.LabelSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeries.Location = New System.Drawing.Point(691, 274)
        Me.LabelSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSeries.Name = "LabelSeries"
        Me.LabelSeries.Size = New System.Drawing.Size(223, 39)
        Me.LabelSeries.TabIndex = 9
        Me.LabelSeries.Text = "Series Level :"
        Me.LabelSeries.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartNumber
        '
        Me.lblPartNumber.AutoSize = True
        Me.lblPartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumber.Location = New System.Drawing.Point(956, 41)
        Me.lblPartNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPartNumber.Name = "lblPartNumber"
        Me.lblPartNumber.Size = New System.Drawing.Size(0, 39)
        Me.lblPartNumber.TabIndex = 10
        '
        'lblPartDescription
        '
        Me.lblPartDescription.AutoSize = True
        Me.lblPartDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartDescription.Location = New System.Drawing.Point(956, 110)
        Me.lblPartDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPartDescription.Name = "lblPartDescription"
        Me.lblPartDescription.Size = New System.Drawing.Size(0, 39)
        Me.lblPartDescription.TabIndex = 11
        '
        'lblStdPack
        '
        Me.lblStdPack.AutoSize = True
        Me.lblStdPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdPack.Location = New System.Drawing.Point(956, 207)
        Me.lblStdPack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdPack.Name = "lblStdPack"
        Me.lblStdPack.Size = New System.Drawing.Size(0, 39)
        Me.lblStdPack.TabIndex = 12
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.Location = New System.Drawing.Point(956, 274)
        Me.lblSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(0, 39)
        Me.lblSeries.TabIndex = 13
        '
        'timerClearSearch
        '
        Me.timerClearSearch.Interval = 250
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1396, 28)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'LabelArches
        '
        Me.LabelArches.AutoSize = True
        Me.LabelArches.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArches.Location = New System.Drawing.Point(16, 41)
        Me.LabelArches.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelArches.Name = "LabelArches"
        Me.LabelArches.Size = New System.Drawing.Size(96, 39)
        Me.LabelArches.TabIndex = 19
        Me.LabelArches.Text = "Rline"
        '
        'lblSkidCount
        '
        Me.lblSkidCount.AutoSize = True
        Me.lblSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkidCount.Location = New System.Drawing.Point(956, 399)
        Me.lblSkidCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSkidCount.Name = "lblSkidCount"
        Me.lblSkidCount.Size = New System.Drawing.Size(0, 39)
        Me.lblSkidCount.TabIndex = 29
        '
        'LabelSkidCount
        '
        Me.LabelSkidCount.AutoSize = True
        Me.LabelSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSkidCount.Location = New System.Drawing.Point(712, 399)
        Me.LabelSkidCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSkidCount.Name = "LabelSkidCount"
        Me.LabelSkidCount.Size = New System.Drawing.Size(202, 39)
        Me.LabelSkidCount.TabIndex = 28
        Me.LabelSkidCount.Text = "Skid Count :"
        Me.LabelSkidCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnShiftReset
        '
        Me.btnShiftReset.Location = New System.Drawing.Point(449, 389)
        Me.btnShiftReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShiftReset.Name = "btnShiftReset"
        Me.btnShiftReset.Size = New System.Drawing.Size(175, 54)
        Me.btnShiftReset.TabIndex = 30
        Me.btnShiftReset.Text = "Skid count reset"
        Me.btnShiftReset.UseVisualStyleBackColor = True
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(621, 482)
        Me.LblClock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblClock.Size = New System.Drawing.Size(0, 39)
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
        Me.TextBoxQty.Location = New System.Drawing.Point(285, 314)
        Me.TextBoxQty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(133, 46)
        Me.TextBoxQty.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 318)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 39)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Quantity :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CboColour
        '
        Me.CboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboColour.FormattingEnabled = True
        Me.CboColour.Items.AddRange(New Object() {"PURE WHITE - (C9A)", "DEEP BLACK PEARL - (C9X)", "TOURMALINE BLUE - (P5Y)", "PLATINUM GRAY - (D7X)", "PRIME - (GRU)", "PYRIT SILVER - (B7S)", "PURE GREY - (H7J)", "ORYX WHITE PEARL (OK1)", "AURORA RED (0G3)", "RACING GREEN (P6W)"})
        Me.CboColour.Location = New System.Drawing.Point(24, 252)
        Me.CboColour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboColour.Name = "CboColour"
        Me.CboColour.Size = New System.Drawing.Size(599, 47)
        Me.CboColour.TabIndex = 39
        '
        'CboSide
        '
        Me.CboSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSide.FormattingEnabled = True
        Me.CboSide.Items.AddRange(New Object() {"Left", "Right"})
        Me.CboSide.Location = New System.Drawing.Point(425, 146)
        Me.CboSide.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboSide.Name = "CboSide"
        Me.CboSide.Size = New System.Drawing.Size(197, 47)
        Me.CboSide.TabIndex = 37
        '
        'CboConfig
        '
        Me.CboConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboConfig.FormattingEnabled = True
        Me.CboConfig.Items.AddRange(New Object() {"Front", "Rear"})
        Me.CboConfig.Location = New System.Drawing.Point(425, 91)
        Me.CboConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboConfig.Name = "CboConfig"
        Me.CboConfig.Size = New System.Drawing.Size(197, 47)
        Me.CboConfig.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 39)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Choose A Configuration :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 39)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Choose a Side:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 210)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 39)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Choose A Colour"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmRline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 877)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
