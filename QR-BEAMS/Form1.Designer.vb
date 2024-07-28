<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_frm))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.error_dot = New System.Windows.Forms.PictureBox()
        Me.connect_dot = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signin_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.error_dot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.connect_dot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GunaPanel1.Controls.Add(Me.error_dot)
        Me.GunaPanel1.Controls.Add(Me.connect_dot)
        Me.GunaPanel1.Controls.Add(Me.Label3)
        Me.GunaPanel1.Controls.Add(Me.Guna2ToggleSwitch1)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.signin_btn)
        Me.GunaPanel1.Controls.Add(Me.Password)
        Me.GunaPanel1.Controls.Add(Me.Username)
        Me.GunaPanel1.Location = New System.Drawing.Point(424, 43)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(287, 371)
        Me.GunaPanel1.TabIndex = 0
        '
        'error_dot
        '
        Me.error_dot.BackColor = System.Drawing.Color.Transparent
        Me.error_dot.Image = Global.QR_BEAMS.My.Resources.Resources.red
        Me.error_dot.Location = New System.Drawing.Point(0, 350)
        Me.error_dot.Name = "error_dot"
        Me.error_dot.Size = New System.Drawing.Size(19, 18)
        Me.error_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.error_dot.TabIndex = 7
        Me.error_dot.TabStop = False
        Me.error_dot.Visible = False
        '
        'connect_dot
        '
        Me.connect_dot.BackColor = System.Drawing.Color.Transparent
        Me.connect_dot.Image = Global.QR_BEAMS.My.Resources.Resources.lime
        Me.connect_dot.Location = New System.Drawing.Point(0, 350)
        Me.connect_dot.Name = "connect_dot"
        Me.connect_dot.Size = New System.Drawing.Size(19, 18)
        Me.connect_dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.connect_dot.TabIndex = 4
        Me.connect_dot.TabStop = False
        Me.connect_dot.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(82, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CREATE ACCOUNT"
        '
        'Guna2ToggleSwitch1
        '
        Me.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.CheckedState.Parent = Me.Guna2ToggleSwitch1
        Me.Guna2ToggleSwitch1.Location = New System.Drawing.Point(53, 191)
        Me.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1"
        Me.Guna2ToggleSwitch1.ShadowDecoration.Parent = Me.Guna2ToggleSwitch1
        Me.Guna2ToggleSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.Guna2ToggleSwitch1.TabIndex = 5
        Me.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.Parent = Me.Guna2ToggleSwitch1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ATTENDANCE MANANGEMENT SYSTEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(55, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "QR CODE-BASED EVENT"
        '
        'signin_btn
        '
        Me.signin_btn.CheckedState.Parent = Me.signin_btn
        Me.signin_btn.CustomImages.Parent = Me.signin_btn
        Me.signin_btn.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.signin_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.signin_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.signin_btn.HoverState.Parent = Me.signin_btn
        Me.signin_btn.Location = New System.Drawing.Point(73, 221)
        Me.signin_btn.Name = "signin_btn"
        Me.signin_btn.ShadowDecoration.Parent = Me.signin_btn
        Me.signin_btn.Size = New System.Drawing.Size(127, 37)
        Me.signin_btn.TabIndex = 2
        Me.signin_btn.Text = "SIgn in"
        '
        'Password
        '
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoverState.Parent = Me.Password
        Me.Password.IconLeft = CType(resources.GetObject("Password.IconLeft"), System.Drawing.Image)
        Me.Password.Location = New System.Drawing.Point(40, 148)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password.PlaceholderText = ""
        Me.Password.SelectedText = ""
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(197, 32)
        Me.Password.TabIndex = 1
        '
        'Username
        '
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.Parent = Me.Username
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.FocusedState.Parent = Me.Username
        Me.Username.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.HoverState.Parent = Me.Username
        Me.Username.IconLeft = Global.QR_BEAMS.My.Resources.Resources.username
        Me.Username.Location = New System.Drawing.Point(40, 100)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderText = ""
        Me.Username.SelectedText = ""
        Me.Username.ShadowDecoration.Parent = Me.Username
        Me.Username.Size = New System.Drawing.Size(197, 32)
        Me.Username.TabIndex = 0
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.Guna2Button3)
        Me.GunaPanel2.Controls.Add(Me.Guna2Button2)
        Me.GunaPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(723, 454)
        Me.GunaPanel2.TabIndex = 2
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(649, 7)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(28, 25)
        Me.Guna2Button3.TabIndex = 3
        Me.Guna2Button3.Text = "--"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(680, 7)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(28, 25)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(723, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Login_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 454)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BEAMS"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.error_dot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.connect_dot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents signin_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents connect_dot As PictureBox
    Friend WithEvents error_dot As PictureBox
End Class
