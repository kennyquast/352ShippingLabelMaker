<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCladdings
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
        Me.txtLookup1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelPartNumber1 = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelStandardPack = New System.Windows.Forms.Label()
        Me.LabelSeries = New System.Windows.Forms.Label()
        Me.lblPartNumber1 = New System.Windows.Forms.Label()
        Me.lblPartDescription = New System.Windows.Forms.Label()
        Me.lblStdPack = New System.Windows.Forms.Label()
        Me.lblSeries = New System.Windows.Forms.Label()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.lblPartCount = New System.Windows.Forms.Label()
        Me.timerClearSearch = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelCladdings = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtLookup2 = New System.Windows.Forms.TextBox()
        Me.lblPartNumber2 = New System.Windows.Forms.Label()
        Me.PartNumber2 = New System.Windows.Forms.Label()
        Me.lblKitNumber = New System.Windows.Forms.Label()
        Me.LabelKitNumber = New System.Windows.Forms.Label()
        Me.lblSkidCount = New System.Windows.Forms.Label()
        Me.LabelSkidCount = New System.Windows.Forms.Label()
        Me.btnShiftReset = New System.Windows.Forms.Button()
        Me.LblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TimerScannerWait = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLookup1
        '
        Me.txtLookup1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLookup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLookup1.Location = New System.Drawing.Point(16, 101)
        Me.txtLookup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLookup1.Name = "txtLookup1"
        Me.txtLookup1.Size = New System.Drawing.Size(452, 46)
        Me.txtLookup1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 260)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 53)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPartNumber1
        '
        Me.LabelPartNumber1.AutoSize = True
        Me.LabelPartNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPartNumber1.Location = New System.Drawing.Point(497, 41)
        Me.LabelPartNumber1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPartNumber1.Name = "LabelPartNumber1"
        Me.LabelPartNumber1.Size = New System.Drawing.Size(236, 39)
        Me.LabelPartNumber1.TabIndex = 6
        Me.LabelPartNumber1.Text = "Part Number : "
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(519, 219)
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
        Me.LabelStandardPack.Location = New System.Drawing.Point(489, 426)
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
        Me.LabelSeries.Location = New System.Drawing.Point(504, 494)
        Me.LabelSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSeries.Name = "LabelSeries"
        Me.LabelSeries.Size = New System.Drawing.Size(223, 39)
        Me.LabelSeries.TabIndex = 9
        Me.LabelSeries.Text = "Series Level :"
        Me.LabelSeries.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartNumber1
        '
        Me.lblPartNumber1.AutoSize = True
        Me.lblPartNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumber1.Location = New System.Drawing.Point(777, 41)
        Me.lblPartNumber1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPartNumber1.Name = "lblPartNumber1"
        Me.lblPartNumber1.Size = New System.Drawing.Size(0, 39)
        Me.lblPartNumber1.TabIndex = 10
        '
        'lblPartDescription
        '
        Me.lblPartDescription.AutoSize = True
        Me.lblPartDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartDescription.Location = New System.Drawing.Point(777, 228)
        Me.lblPartDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPartDescription.Name = "lblPartDescription"
        Me.lblPartDescription.Size = New System.Drawing.Size(0, 39)
        Me.lblPartDescription.TabIndex = 11
        '
        'lblStdPack
        '
        Me.lblStdPack.AutoSize = True
        Me.lblStdPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdPack.Location = New System.Drawing.Point(769, 426)
        Me.lblStdPack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdPack.Name = "lblStdPack"
        Me.lblStdPack.Size = New System.Drawing.Size(0, 39)
        Me.lblStdPack.TabIndex = 12
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.Location = New System.Drawing.Point(769, 494)
        Me.lblSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(0, 39)
        Me.lblSeries.TabIndex = 13
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCount.Location = New System.Drawing.Point(605, 555)
        Me.LabelCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(126, 39)
        Me.LabelCount.TabIndex = 14
        Me.LabelCount.Text = "Count :"
        Me.LabelCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartCount
        '
        Me.lblPartCount.AutoSize = True
        Me.lblPartCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartCount.Location = New System.Drawing.Point(769, 555)
        Me.lblPartCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPartCount.Name = "lblPartCount"
        Me.lblPartCount.Size = New System.Drawing.Size(0, 39)
        Me.lblPartCount.TabIndex = 15
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
        'LabelCladdings
        '
        Me.LabelCladdings.AutoSize = True
        Me.LabelCladdings.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCladdings.Location = New System.Drawing.Point(12, 41)
        Me.LabelCladdings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCladdings.Name = "LabelCladdings"
        Me.LabelCladdings.Size = New System.Drawing.Size(170, 39)
        Me.LabelCladdings.TabIndex = 18
        Me.LabelCladdings.Text = "Claddings"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 33)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(21, 17)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.Visible = False
        '
        'txtLookup2
        '
        Me.txtLookup2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLookup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLookup2.Location = New System.Drawing.Point(20, 198)
        Me.txtLookup2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLookup2.Name = "txtLookup2"
        Me.txtLookup2.Size = New System.Drawing.Size(452, 46)
        Me.txtLookup2.TabIndex = 21
        '
        'lblPartNumber2
        '
        Me.lblPartNumber2.AutoSize = True
        Me.lblPartNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumber2.Location = New System.Drawing.Point(777, 101)
        Me.lblPartNumber2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPartNumber2.Name = "lblPartNumber2"
        Me.lblPartNumber2.Size = New System.Drawing.Size(0, 39)
        Me.lblPartNumber2.TabIndex = 23
        '
        'PartNumber2
        '
        Me.PartNumber2.AutoSize = True
        Me.PartNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNumber2.Location = New System.Drawing.Point(497, 101)
        Me.PartNumber2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PartNumber2.Name = "PartNumber2"
        Me.PartNumber2.Size = New System.Drawing.Size(236, 39)
        Me.PartNumber2.TabIndex = 22
        Me.PartNumber2.Text = "Part Number : "
        '
        'lblKitNumber
        '
        Me.lblKitNumber.AutoSize = True
        Me.lblKitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKitNumber.Location = New System.Drawing.Point(777, 161)
        Me.lblKitNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKitNumber.Name = "lblKitNumber"
        Me.lblKitNumber.Size = New System.Drawing.Size(0, 39)
        Me.lblKitNumber.TabIndex = 25
        '
        'LabelKitNumber
        '
        Me.LabelKitNumber.AutoSize = True
        Me.LabelKitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKitNumber.Location = New System.Drawing.Point(521, 161)
        Me.LabelKitNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelKitNumber.Name = "LabelKitNumber"
        Me.LabelKitNumber.Size = New System.Drawing.Size(214, 39)
        Me.LabelKitNumber.TabIndex = 24
        Me.LabelKitNumber.Text = "Kit Number : "
        '
        'lblSkidCount
        '
        Me.lblSkidCount.AutoSize = True
        Me.lblSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkidCount.Location = New System.Drawing.Point(769, 617)
        Me.lblSkidCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSkidCount.Name = "lblSkidCount"
        Me.lblSkidCount.Size = New System.Drawing.Size(0, 39)
        Me.lblSkidCount.TabIndex = 27
        '
        'LabelSkidCount
        '
        Me.LabelSkidCount.AutoSize = True
        Me.LabelSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSkidCount.Location = New System.Drawing.Point(525, 617)
        Me.LabelSkidCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSkidCount.Name = "LabelSkidCount"
        Me.LabelSkidCount.Size = New System.Drawing.Size(202, 39)
        Me.LabelSkidCount.TabIndex = 29
        Me.LabelSkidCount.Text = "Skid Count :"
        Me.LabelSkidCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnShiftReset
        '
        Me.btnShiftReset.Location = New System.Drawing.Point(295, 617)
        Me.btnShiftReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShiftReset.Name = "btnShiftReset"
        Me.btnShiftReset.Size = New System.Drawing.Size(175, 54)
        Me.btnShiftReset.TabIndex = 31
        Me.btnShiftReset.Text = "Skid count reset"
        Me.btnShiftReset.UseVisualStyleBackColor = True
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(613, 720)
        Me.LblClock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblClock.Size = New System.Drawing.Size(0, 39)
        Me.LblClock.TabIndex = 32
        '
        'TmrClock
        '
        Me.TmrClock.Enabled = True
        Me.TmrClock.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 261)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 52)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "SWITCH TO SERVICE CLADDINGS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TimerScannerWait
        '
        Me.TimerScannerWait.Interval = 91
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(295, 332)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 52)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmCladdings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 877)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LblClock)
        Me.Controls.Add(Me.btnShiftReset)
        Me.Controls.Add(Me.LabelSkidCount)
        Me.Controls.Add(Me.lblSkidCount)
        Me.Controls.Add(Me.lblKitNumber)
        Me.Controls.Add(Me.LabelKitNumber)
        Me.Controls.Add(Me.lblPartNumber2)
        Me.Controls.Add(Me.PartNumber2)
        Me.Controls.Add(Me.txtLookup2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelCladdings)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblPartCount)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.lblSeries)
        Me.Controls.Add(Me.lblStdPack)
        Me.Controls.Add(Me.lblPartDescription)
        Me.Controls.Add(Me.lblPartNumber1)
        Me.Controls.Add(Me.LabelSeries)
        Me.Controls.Add(Me.LabelStandardPack)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelPartNumber1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLookup1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCladdings"
        Me.Text = "Claddings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLookup1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelPartNumber1 As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelStandardPack As Label
    Friend WithEvents LabelSeries As Label
    Friend WithEvents lblPartNumber1 As Label
    Friend WithEvents lblPartDescription As Label
    Friend WithEvents lblStdPack As Label
    Friend WithEvents lblSeries As Label
    Friend WithEvents LabelCount As Label
    Friend WithEvents lblPartCount As Label
    Friend WithEvents timerClearSearch As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelCladdings As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtLookup2 As TextBox
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPartNumber2 As Label
    Friend WithEvents PartNumber2 As Label
    Friend WithEvents lblKitNumber As Label
    Friend WithEvents LabelKitNumber As Label
    Friend WithEvents lblSkidCount As Label
    Friend WithEvents LabelSkidCount As Label
    Friend WithEvents btnShiftReset As Button
    Friend WithEvents LblClock As Label
    Friend WithEvents TmrClock As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents TimerScannerWait As Timer
    Friend WithEvents Button3 As Button
End Class
