<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.Grb1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(184, 53)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(232, 104)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUp.Location = New System.Drawing.Point(433, 71)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(34, 32)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDown.Location = New System.Drawing.Point(433, 109)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(34, 32)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(335, 172)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(106, 21)
        Me.cboSize.TabIndex = 3
        '
        'Grb1
        '
        Me.Grb1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Grb1.Controls.Add(Me.lblFSky)
        Me.Grb1.Controls.Add(Me.lblWhite)
        Me.Grb1.Controls.Add(Me.lblFBrown)
        Me.Grb1.Controls.Add(Me.lblYellow)
        Me.Grb1.Controls.Add(Me.lblFOrange)
        Me.Grb1.Controls.Add(Me.lblFBlack)
        Me.Grb1.Controls.Add(Me.lblFViolet)
        Me.Grb1.Controls.Add(Me.lblFGreen)
        Me.Grb1.Controls.Add(Me.lblFBlue)
        Me.Grb1.Controls.Add(Me.lblFRed)
        Me.Grb1.Location = New System.Drawing.Point(38, 227)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(253, 110)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        Me.Grb1.Text = "Forecolor"
        '
        'Grb2
        '
        Me.Grb2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Grb2.Controls.Add(Me.lblBSky)
        Me.Grb2.Controls.Add(Me.lblBGreen)
        Me.Grb2.Controls.Add(Me.lblBWhite)
        Me.Grb2.Controls.Add(Me.lblBRed)
        Me.Grb2.Controls.Add(Me.lblBBrown)
        Me.Grb2.Controls.Add(Me.lblBBlue)
        Me.Grb2.Controls.Add(Me.lblBYellow)
        Me.Grb2.Controls.Add(Me.lblBViolet)
        Me.Grb2.Controls.Add(Me.lblBOrange)
        Me.Grb2.Controls.Add(Me.lblBBlack)
        Me.Grb2.Location = New System.Drawing.Point(297, 227)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(252, 110)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        Me.Grb2.Text = "Bgcolor"
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(17, 31)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(39, 25)
        Me.lblFRed.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(76, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 26)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "กำหนดตัวเลข"
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(62, 31)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(39, 25)
        Me.lblFBlue.TabIndex = 1
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.Location = New System.Drawing.Point(107, 31)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(39, 25)
        Me.lblFGreen.TabIndex = 2
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Violet
        Me.lblFViolet.Location = New System.Drawing.Point(152, 31)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(39, 25)
        Me.lblFViolet.TabIndex = 3
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(197, 31)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(39, 25)
        Me.lblFBlack.TabIndex = 4
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.Orange
        Me.lblFOrange.Location = New System.Drawing.Point(17, 69)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(39, 25)
        Me.lblFOrange.TabIndex = 5
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblYellow.Location = New System.Drawing.Point(62, 69)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(39, 25)
        Me.lblYellow.TabIndex = 6
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.Brown
        Me.lblFBrown.Location = New System.Drawing.Point(107, 69)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(39, 25)
        Me.lblFBrown.TabIndex = 7
        '
        'lblWhite
        '
        Me.lblWhite.BackColor = System.Drawing.Color.White
        Me.lblWhite.Location = New System.Drawing.Point(152, 69)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(39, 25)
        Me.lblWhite.TabIndex = 8
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblFSky.Location = New System.Drawing.Point(197, 69)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(39, 25)
        Me.lblFSky.TabIndex = 9
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblBSky.Location = New System.Drawing.Point(195, 69)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(39, 25)
        Me.lblBSky.TabIndex = 19
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Location = New System.Drawing.Point(150, 69)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(39, 25)
        Me.lblBWhite.TabIndex = 18
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.Brown
        Me.lblBBrown.Location = New System.Drawing.Point(105, 69)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(39, 25)
        Me.lblBBrown.TabIndex = 17
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(60, 69)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(39, 25)
        Me.lblBYellow.TabIndex = 16
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.Orange
        Me.lblBOrange.Location = New System.Drawing.Point(15, 69)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(39, 25)
        Me.lblBOrange.TabIndex = 15
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(195, 31)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(39, 25)
        Me.lblBBlack.TabIndex = 14
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Violet
        Me.lblBViolet.Location = New System.Drawing.Point(150, 31)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(39, 25)
        Me.lblBViolet.TabIndex = 13
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Green
        Me.lblBGreen.Location = New System.Drawing.Point(105, 31)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(39, 25)
        Me.lblBGreen.TabIndex = 12
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(60, 31)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(39, 25)
        Me.lblBBlue.TabIndex = 11
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(15, 31)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(39, 25)
        Me.lblBRed.TabIndex = 10
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(583, 382)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Grb2)
        Me.Controls.Add(Me.Grb1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmLab3"
        Me.Grb1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents Grb1 As GroupBox
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblWhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblYellow As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents Grb2 As GroupBox
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents Label21 As Label
End Class
