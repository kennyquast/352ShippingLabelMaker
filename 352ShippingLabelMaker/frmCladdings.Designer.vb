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
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLookup1
        '
        Me.txtLookup1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLookup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLookup1.Location = New System.Drawing.Point(12, 82)
        Me.txtLookup1.Name = "txtLookup1"
        Me.txtLookup1.Size = New System.Drawing.Size(340, 38)
        Me.txtLookup1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPartNumber1
        '
        Me.LabelPartNumber1.AutoSize = True
        Me.LabelPartNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPartNumber1.Location = New System.Drawing.Point(373, 33)
        Me.LabelPartNumber1.Name = "LabelPartNumber1"
        Me.LabelPartNumber1.Size = New System.Drawing.Size(189, 31)
        Me.LabelPartNumber1.TabIndex = 6
        Me.LabelPartNumber1.Text = "Part Number : "
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(389, 178)
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
        Me.LabelStandardPack.Location = New System.Drawing.Point(367, 346)
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
        Me.LabelSeries.Location = New System.Drawing.Point(378, 401)
        Me.LabelSeries.Name = "LabelSeries"
        Me.LabelSeries.Size = New System.Drawing.Size(178, 31)
        Me.LabelSeries.TabIndex = 9
        Me.LabelSeries.Text = "Series Level :"
        Me.LabelSeries.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartNumber1
        '
        Me.lblPartNumber1.AutoSize = True
        Me.lblPartNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumber1.Location = New System.Drawing.Point(583, 33)
        Me.lblPartNumber1.Name = "lblPartNumber1"
        Me.lblPartNumber1.Size = New System.Drawing.Size(0, 31)
        Me.lblPartNumber1.TabIndex = 10
        '
        'lblPartDescription
        '
        Me.lblPartDescription.AutoSize = True
        Me.lblPartDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartDescription.Location = New System.Drawing.Point(583, 185)
        Me.lblPartDescription.Name = "lblPartDescription"
        Me.lblPartDescription.Size = New System.Drawing.Size(0, 31)
        Me.lblPartDescription.TabIndex = 11
        '
        'lblStdPack
        '
        Me.lblStdPack.AutoSize = True
        Me.lblStdPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdPack.Location = New System.Drawing.Point(577, 346)
        Me.lblStdPack.Name = "lblStdPack"
        Me.lblStdPack.Size = New System.Drawing.Size(0, 31)
        Me.lblStdPack.TabIndex = 12
        '
        'lblSeries
        '
        Me.lblSeries.AutoSize = True
        Me.lblSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeries.Location = New System.Drawing.Point(577, 401)
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Size = New System.Drawing.Size(0, 31)
        Me.lblSeries.TabIndex = 13
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCount.Location = New System.Drawing.Point(454, 451)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(102, 31)
        Me.LabelCount.TabIndex = 14
        Me.LabelCount.Text = "Count :"
        Me.LabelCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartCount
        '
        Me.lblPartCount.AutoSize = True
        Me.lblPartCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartCount.Location = New System.Drawing.Point(577, 451)
        Me.lblPartCount.Name = "lblPartCount"
        Me.lblPartCount.Size = New System.Drawing.Size(0, 31)
        Me.lblPartCount.TabIndex = 15
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
        'LabelCladdings
        '
        Me.LabelCladdings.AutoSize = True
        Me.LabelCladdings.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCladdings.Location = New System.Drawing.Point(9, 33)
        Me.LabelCladdings.Name = "LabelCladdings"
        Me.LabelCladdings.Size = New System.Drawing.Size(135, 31)
        Me.LabelCladdings.TabIndex = 18
        Me.LabelCladdings.Text = "Claddings"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(16, 14)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.Visible = False
        '
        'txtLookup2
        '
        Me.txtLookup2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLookup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLookup2.Location = New System.Drawing.Point(15, 161)
        Me.txtLookup2.Name = "txtLookup2"
        Me.txtLookup2.Size = New System.Drawing.Size(340, 38)
        Me.txtLookup2.TabIndex = 21
        '
        'lblPartNumber2
        '
        Me.lblPartNumber2.AutoSize = True
        Me.lblPartNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartNumber2.Location = New System.Drawing.Point(583, 82)
        Me.lblPartNumber2.Name = "lblPartNumber2"
        Me.lblPartNumber2.Size = New System.Drawing.Size(0, 31)
        Me.lblPartNumber2.TabIndex = 23
        '
        'PartNumber2
        '
        Me.PartNumber2.AutoSize = True
        Me.PartNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNumber2.Location = New System.Drawing.Point(373, 82)
        Me.PartNumber2.Name = "PartNumber2"
        Me.PartNumber2.Size = New System.Drawing.Size(189, 31)
        Me.PartNumber2.TabIndex = 22
        Me.PartNumber2.Text = "Part Number : "
        '
        'lblKitNumber
        '
        Me.lblKitNumber.AutoSize = True
        Me.lblKitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKitNumber.Location = New System.Drawing.Point(583, 131)
        Me.lblKitNumber.Name = "lblKitNumber"
        Me.lblKitNumber.Size = New System.Drawing.Size(0, 31)
        Me.lblKitNumber.TabIndex = 25
        '
        'LabelKitNumber
        '
        Me.LabelKitNumber.AutoSize = True
        Me.LabelKitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKitNumber.Location = New System.Drawing.Point(391, 131)
        Me.LabelKitNumber.Name = "LabelKitNumber"
        Me.LabelKitNumber.Size = New System.Drawing.Size(171, 31)
        Me.LabelKitNumber.TabIndex = 24
        Me.LabelKitNumber.Text = "Kit Number : "
        '
        'lblSkidCount
        '
        Me.lblSkidCount.AutoSize = True
        Me.lblSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkidCount.Location = New System.Drawing.Point(577, 501)
        Me.lblSkidCount.Name = "lblSkidCount"
        Me.lblSkidCount.Size = New System.Drawing.Size(0, 31)
        Me.lblSkidCount.TabIndex = 27
        '
        'LabelSkidCount
        '
        Me.LabelSkidCount.AutoSize = True
        Me.LabelSkidCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSkidCount.Location = New System.Drawing.Point(394, 501)
        Me.LabelSkidCount.Name = "LabelSkidCount"
        Me.LabelSkidCount.Size = New System.Drawing.Size(162, 31)
        Me.LabelSkidCount.TabIndex = 29
        Me.LabelSkidCount.Text = "Skid Count :"
        Me.LabelSkidCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnShiftReset
        '
        Me.btnShiftReset.Location = New System.Drawing.Point(221, 501)
        Me.btnShiftReset.Name = "btnShiftReset"
        Me.btnShiftReset.Size = New System.Drawing.Size(131, 44)
        Me.btnShiftReset.TabIndex = 31
        Me.btnShiftReset.Text = "Skid count reset"
        Me.btnShiftReset.UseVisualStyleBackColor = True
        '
        'LblClock
        '
        Me.LblClock.AutoSize = True
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(460, 585)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblClock.Size = New System.Drawing.Size(0, 31)
        Me.LblClock.TabIndex = 32
        '
        'TmrClock
        '
        Me.TmrClock.Enabled = True
        Me.TmrClock.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 42)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "SWITCH TO SERVICE CLADDINGS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCladdings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 750)
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
End Class
