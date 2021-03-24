<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RlineRelabel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblSeries = New System.Windows.Forms.Label()
        Me.LblColour = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtReason = New System.Windows.Forms.TextBox()
        Me.TxtLookup = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TimerClearSearch = New System.Windows.Forms.Timer(Me.components)
        Me.BtnKennySecret = New System.Windows.Forms.Button()
        Me.BtnService = New System.Windows.Forms.Button()
        Me.TxtLabelQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLookup = New System.Windows.Forms.Button()
        Me.LblReason = New System.Windows.Forms.Label()
        Me.LblMain = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(30, 25)
        Me.DataGridView1.TabIndex = 22
        Me.DataGridView1.Visible = False
        '
        'LblSeries
        '
        Me.LblSeries.AutoSize = True
        Me.LblSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeries.Location = New System.Drawing.Point(50, 184)
        Me.LblSeries.Name = "LblSeries"
        Me.LblSeries.Size = New System.Drawing.Size(106, 31)
        Me.LblSeries.TabIndex = 21
        Me.LblSeries.Text = "Series :"
        '
        'LblColour
        '
        Me.LblColour.AutoSize = True
        Me.LblColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColour.Location = New System.Drawing.Point(50, 132)
        Me.LblColour.Name = "LblColour"
        Me.LblColour.Size = New System.Drawing.Size(116, 31)
        Me.LblColour.TabIndex = 20
        Me.LblColour.Text = "Colour : "
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescription.Location = New System.Drawing.Point(50, 84)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(223, 31)
        Me.LblDescription.TabIndex = 19
        Me.LblDescription.Text = "Part Description :"
        '
        'TxtReason
        '
        Me.TxtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReason.Location = New System.Drawing.Point(56, 303)
        Me.TxtReason.Name = "TxtReason"
        Me.TxtReason.Size = New System.Drawing.Size(444, 38)
        Me.TxtReason.TabIndex = 18
        '
        'TxtLookup
        '
        Me.TxtLookup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLookup.Location = New System.Drawing.Point(56, 40)
        Me.TxtLookup.Name = "TxtLookup"
        Me.TxtLookup.Size = New System.Drawing.Size(444, 38)
        Me.TxtLookup.TabIndex = 17
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(338, 347)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(162, 64)
        Me.BtnSubmit.TabIndex = 16
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(56, 347)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(159, 64)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnKennySecret
        '
        Me.BtnKennySecret.Location = New System.Drawing.Point(221, 347)
        Me.BtnKennySecret.Name = "BtnKennySecret"
        Me.BtnKennySecret.Size = New System.Drawing.Size(111, 64)
        Me.BtnKennySecret.TabIndex = 28
        Me.BtnKennySecret.Text = "Super Secret Kenny Button"
        Me.BtnKennySecret.UseVisualStyleBackColor = True
        Me.BtnKennySecret.Visible = False
        '
        'BtnService
        '
        Me.BtnService.Enabled = False
        Me.BtnService.Location = New System.Drawing.Point(507, 225)
        Me.BtnService.Name = "BtnService"
        Me.BtnService.Size = New System.Drawing.Size(75, 36)
        Me.BtnService.TabIndex = 27
        Me.BtnService.Text = "Service"
        Me.BtnService.UseVisualStyleBackColor = True
        '
        'TxtLabelQty
        '
        Me.TxtLabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabelQty.Location = New System.Drawing.Point(400, 225)
        Me.TxtLabelQty.Name = "TxtLabelQty"
        Me.TxtLabelQty.Size = New System.Drawing.Size(100, 38)
        Me.TxtLabelQty.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 31)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Number of Labels : "
        '
        'BtnLookup
        '
        Me.BtnLookup.Location = New System.Drawing.Point(506, 40)
        Me.BtnLookup.Name = "BtnLookup"
        Me.BtnLookup.Size = New System.Drawing.Size(75, 36)
        Me.BtnLookup.TabIndex = 24
        Me.BtnLookup.Text = "Lookup Part"
        Me.BtnLookup.UseVisualStyleBackColor = True
        '
        'LblReason
        '
        Me.LblReason.AutoSize = True
        Me.LblReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReason.Location = New System.Drawing.Point(24, 269)
        Me.LblReason.Name = "LblReason"
        Me.LblReason.Size = New System.Drawing.Size(536, 31)
        Me.LblReason.TabIndex = 23
        Me.LblReason.Text = "Please provide a reason for label reprinting."
        '
        'LblMain
        '
        Me.LblMain.AutoSize = True
        Me.LblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMain.Location = New System.Drawing.Point(50, 1)
        Me.LblMain.Name = "LblMain"
        Me.LblMain.Size = New System.Drawing.Size(316, 31)
        Me.LblMain.TabIndex = 29
        Me.LblMain.Text = "Scan or enter part below."
        '
        'RlineRelabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 433)
        Me.Controls.Add(Me.LblMain)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblSeries)
        Me.Controls.Add(Me.LblColour)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.TxtReason)
        Me.Controls.Add(Me.TxtLookup)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnKennySecret)
        Me.Controls.Add(Me.BtnService)
        Me.Controls.Add(Me.TxtLabelQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLookup)
        Me.Controls.Add(Me.LblReason)
        Me.Name = "RlineRelabel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RlineRelabel"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblSeries As Label
    Friend WithEvents LblColour As Label
    Friend WithEvents LblDescription As Label
    Friend WithEvents TxtReason As TextBox
    Friend WithEvents TxtLookup As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TimerClearSearch As Timer
    Friend WithEvents BtnKennySecret As Button
    Friend WithEvents BtnService As Button
    Friend WithEvents TxtLabelQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLookup As Button
    Friend WithEvents LblReason As Label
    Friend WithEvents LblMain As Label
End Class
