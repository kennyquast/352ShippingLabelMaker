<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdminControlPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminControlPanel))
        Me.AdminProductionGrid = New System.Windows.Forms.DataGridView()
        Me.LblInformation = New System.Windows.Forms.Label()
        Me.BtnReprintArch = New System.Windows.Forms.Button()
        Me.BtnReprintCladding = New System.Windows.Forms.Button()
        Me.LblNote = New System.Windows.Forms.Label()
        Me.BtnReprintRline = New System.Windows.Forms.Button()
        Me.BtnKennySecret = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnPartLabel = New System.Windows.Forms.Button()
        Me.BtnUpdateSoftware = New System.Windows.Forms.Button()
        Me.BtnAddUser = New System.Windows.Forms.Button()
        Me.TxtClockNumber = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.LblClockNumber = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.BtnAddUserSubmit = New System.Windows.Forms.Button()
        Me.BtnRelabelRline = New System.Windows.Forms.Button()
        CType(Me.AdminProductionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminProductionGrid
        '
        Me.AdminProductionGrid.AllowUserToAddRows = False
        Me.AdminProductionGrid.AllowUserToDeleteRows = False
        Me.AdminProductionGrid.AllowUserToResizeRows = False
        Me.AdminProductionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.AdminProductionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminProductionGrid.Location = New System.Drawing.Point(12, 201)
        Me.AdminProductionGrid.Name = "AdminProductionGrid"
        Me.AdminProductionGrid.Size = New System.Drawing.Size(1041, 324)
        Me.AdminProductionGrid.TabIndex = 5
        '
        'LblInformation
        '
        Me.LblInformation.AutoSize = True
        Me.LblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformation.Location = New System.Drawing.Point(12, 20)
        Me.LblInformation.Name = "LblInformation"
        Me.LblInformation.Size = New System.Drawing.Size(431, 120)
        Me.LblInformation.TabIndex = 3
        Me.LblInformation.Text = resources.GetString("LblInformation.Text")
        '
        'BtnReprintArch
        '
        Me.BtnReprintArch.Enabled = False
        Me.BtnReprintArch.Location = New System.Drawing.Point(650, 70)
        Me.BtnReprintArch.Name = "BtnReprintArch"
        Me.BtnReprintArch.Size = New System.Drawing.Size(166, 52)
        Me.BtnReprintArch.TabIndex = 0
        Me.BtnReprintArch.Text = "Reprint Arch Label"
        Me.BtnReprintArch.UseVisualStyleBackColor = True
        '
        'BtnReprintCladding
        '
        Me.BtnReprintCladding.Enabled = False
        Me.BtnReprintCladding.Location = New System.Drawing.Point(650, 143)
        Me.BtnReprintCladding.Name = "BtnReprintCladding"
        Me.BtnReprintCladding.Size = New System.Drawing.Size(166, 52)
        Me.BtnReprintCladding.TabIndex = 1
        Me.BtnReprintCladding.Text = "Reprint Claddings Label"
        Me.BtnReprintCladding.UseVisualStyleBackColor = True
        '
        'LblNote
        '
        Me.LblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNote.Location = New System.Drawing.Point(479, 9)
        Me.LblNote.Name = "LblNote"
        Me.LblNote.Size = New System.Drawing.Size(574, 58)
        Me.LblNote.TabIndex = 4
        Me.LblNote.Text = "Note: Reprinting a label WILL NOT production report those parts, please use the m" &
    "ain screen to properly scan and generate labels"
        '
        'BtnReprintRline
        '
        Me.BtnReprintRline.Enabled = False
        Me.BtnReprintRline.Location = New System.Drawing.Point(477, 70)
        Me.BtnReprintRline.Name = "BtnReprintRline"
        Me.BtnReprintRline.Size = New System.Drawing.Size(166, 52)
        Me.BtnReprintRline.TabIndex = 6
        Me.BtnReprintRline.Text = "Reprint R-Line Label"
        Me.BtnReprintRline.UseVisualStyleBackColor = True
        '
        'BtnKennySecret
        '
        Me.BtnKennySecret.Location = New System.Drawing.Point(12, 550)
        Me.BtnKennySecret.Name = "BtnKennySecret"
        Me.BtnKennySecret.Size = New System.Drawing.Size(193, 52)
        Me.BtnKennySecret.TabIndex = 7
        Me.BtnKennySecret.Text = "DO NOT CLICK THIS IF YOU CAN SEE IT"
        Me.BtnKennySecret.UseVisualStyleBackColor = True
        Me.BtnKennySecret.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClose.Location = New System.Drawing.Point(16, 143)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(193, 52)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close Admin Panel"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnPartLabel
        '
        Me.BtnPartLabel.Location = New System.Drawing.Point(477, 143)
        Me.BtnPartLabel.Name = "BtnPartLabel"
        Me.BtnPartLabel.Size = New System.Drawing.Size(166, 52)
        Me.BtnPartLabel.TabIndex = 9
        Me.BtnPartLabel.Text = "1x4 Part Label Print"
        Me.BtnPartLabel.UseVisualStyleBackColor = True
        '
        'BtnUpdateSoftware
        '
        Me.BtnUpdateSoftware.Location = New System.Drawing.Point(891, 550)
        Me.BtnUpdateSoftware.Name = "BtnUpdateSoftware"
        Me.BtnUpdateSoftware.Size = New System.Drawing.Size(153, 52)
        Me.BtnUpdateSoftware.TabIndex = 10
        Me.BtnUpdateSoftware.Text = "Update Software"
        Me.BtnUpdateSoftware.UseVisualStyleBackColor = True
        Me.BtnUpdateSoftware.Visible = False
        '
        'BtnAddUser
        '
        Me.BtnAddUser.Location = New System.Drawing.Point(231, 553)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.Size = New System.Drawing.Size(197, 49)
        Me.BtnAddUser.TabIndex = 11
        Me.BtnAddUser.Text = "Add User"
        Me.BtnAddUser.UseVisualStyleBackColor = True
        Me.BtnAddUser.Visible = False
        '
        'TxtClockNumber
        '
        Me.TxtClockNumber.Location = New System.Drawing.Point(16, 626)
        Me.TxtClockNumber.Name = "TxtClockNumber"
        Me.TxtClockNumber.Size = New System.Drawing.Size(189, 20)
        Me.TxtClockNumber.TabIndex = 12
        Me.TxtClockNumber.Visible = False
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(231, 626)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(189, 20)
        Me.TxtUsername.TabIndex = 13
        Me.TxtUsername.Visible = False
        '
        'TxtFullName
        '
        Me.TxtFullName.Location = New System.Drawing.Point(439, 626)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(189, 20)
        Me.TxtFullName.TabIndex = 14
        Me.TxtFullName.Visible = False
        '
        'LblClockNumber
        '
        Me.LblClockNumber.AutoSize = True
        Me.LblClockNumber.Location = New System.Drawing.Point(13, 605)
        Me.LblClockNumber.Name = "LblClockNumber"
        Me.LblClockNumber.Size = New System.Drawing.Size(74, 13)
        Me.LblClockNumber.TabIndex = 15
        Me.LblClockNumber.Text = "Clock Number"
        Me.LblClockNumber.Visible = False
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(228, 605)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(113, 13)
        Me.LblUsername.TabIndex = 16
        Me.LblUsername.Text = "Username (fLastname)"
        Me.LblUsername.Visible = False
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.Location = New System.Drawing.Point(436, 605)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(54, 13)
        Me.LblFullName.TabIndex = 17
        Me.LblFullName.Text = "Full Name"
        Me.LblFullName.Visible = False
        '
        'BtnAddUserSubmit
        '
        Me.BtnAddUserSubmit.Location = New System.Drawing.Point(650, 626)
        Me.BtnAddUserSubmit.Name = "BtnAddUserSubmit"
        Me.BtnAddUserSubmit.Size = New System.Drawing.Size(131, 26)
        Me.BtnAddUserSubmit.TabIndex = 18
        Me.BtnAddUserSubmit.Text = "Submit User"
        Me.BtnAddUserSubmit.UseVisualStyleBackColor = True
        Me.BtnAddUserSubmit.Visible = False
        '
        'BtnRelabelRline
        '
        Me.BtnRelabelRline.Enabled = False
        Me.BtnRelabelRline.Location = New System.Drawing.Point(822, 70)
        Me.BtnRelabelRline.Name = "BtnRelabelRline"
        Me.BtnRelabelRline.Size = New System.Drawing.Size(166, 52)
        Me.BtnRelabelRline.TabIndex = 19
        Me.BtnRelabelRline.Text = "Relabel R-Line"
        Me.BtnRelabelRline.UseVisualStyleBackColor = True
        '
        'FormAdminControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1065, 658)
        Me.Controls.Add(Me.BtnRelabelRline)
        Me.Controls.Add(Me.BtnAddUserSubmit)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblClockNumber)
        Me.Controls.Add(Me.TxtFullName)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtClockNumber)
        Me.Controls.Add(Me.BtnAddUser)
        Me.Controls.Add(Me.BtnUpdateSoftware)
        Me.Controls.Add(Me.BtnPartLabel)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnKennySecret)
        Me.Controls.Add(Me.BtnReprintRline)
        Me.Controls.Add(Me.LblNote)
        Me.Controls.Add(Me.BtnReprintCladding)
        Me.Controls.Add(Me.BtnReprintArch)
        Me.Controls.Add(Me.LblInformation)
        Me.Controls.Add(Me.AdminProductionGrid)
        Me.Name = "FormAdminControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Control Panel"
        Me.TopMost = True
        CType(Me.AdminProductionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdminProductionGrid As DataGridView
    Friend WithEvents LblInformation As Label
    Friend WithEvents BtnReprintArch As Button
    Friend WithEvents BtnReprintCladding As Button
    Friend WithEvents LblNote As Label
    Friend WithEvents BtnReprintRline As Button
    Friend WithEvents BtnKennySecret As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnPartLabel As Button
    Friend WithEvents BtnUpdateSoftware As Button
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents TxtClockNumber As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtFullName As TextBox
    Friend WithEvents LblClockNumber As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents BtnAddUserSubmit As Button
    Friend WithEvents BtnRelabelRline As Button
End Class
