<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.btnenc = New System.Windows.Forms.Button
        Me.txtenp2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtenp1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtEncDestn = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtEncSrc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btndec = New System.Windows.Forms.Button
        Me.txtDecp2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDecp1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.txtDecDestn = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button12 = New System.Windows.Forms.Button
        Me.txtDecSrc = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(388, 172)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.eGuard_Encryptor.My.Resources.Resources.bk
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.btnenc)
        Me.TabPage1.Controls.Add(Me.txtenp2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtenp1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.txtEncDestn)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtEncSrc)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(380, 146)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encryption"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(10, 118)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(237, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Delete source file after successful encryption"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(311, 84)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(249, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Help"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(311, 59)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "About"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnenc
        '
        Me.btnenc.Enabled = False
        Me.btnenc.Location = New System.Drawing.Point(249, 59)
        Me.btnenc.Name = "btnenc"
        Me.btnenc.Size = New System.Drawing.Size(60, 23)
        Me.btnenc.TabIndex = 11
        Me.btnenc.Text = "Encrypt"
        Me.btnenc.UseVisualStyleBackColor = True
        '
        'txtenp2
        '
        Me.txtenp2.BackColor = System.Drawing.SystemColors.Info
        Me.txtenp2.Location = New System.Drawing.Point(76, 85)
        Me.txtenp2.Name = "txtenp2"
        Me.txtenp2.Size = New System.Drawing.Size(170, 20)
        Me.txtenp2.TabIndex = 10
        Me.txtenp2.Text = "None"
        Me.txtenp2.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Confirm :"
        '
        'txtenp1
        '
        Me.txtenp1.BackColor = System.Drawing.SystemColors.Info
        Me.txtenp1.Location = New System.Drawing.Point(76, 60)
        Me.txtenp1.Name = "txtenp1"
        Me.txtenp1.Size = New System.Drawing.Size(170, 20)
        Me.txtenp1.TabIndex = 8
        Me.txtenp1.Text = "None"
        Me.txtenp1.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtEncDestn
        '
        Me.txtEncDestn.Location = New System.Drawing.Point(92, 34)
        Me.txtEncDestn.Name = "txtEncDestn"
        Me.txtEncDestn.ReadOnly = True
        Me.txtEncDestn.Size = New System.Drawing.Size(251, 20)
        Me.txtEncDestn.TabIndex = 4
        Me.txtEncDestn.Text = "Not Selected."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destination"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEncSrc
        '
        Me.txtEncSrc.Location = New System.Drawing.Point(92, 9)
        Me.txtEncSrc.Name = "txtEncSrc"
        Me.txtEncSrc.ReadOnly = True
        Me.txtEncSrc.Size = New System.Drawing.Size(251, 20)
        Me.txtEncSrc.TabIndex = 1
        Me.txtEncSrc.Text = "Not Selected."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File to Encrypt :"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.eGuard_Encryptor.My.Resources.Resources.bk
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.btndec)
        Me.TabPage2.Controls.Add(Me.txtDecp2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtDecp1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.txtDecDestn)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.txtDecSrc)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(380, 146)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decryption"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(10, 118)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(237, 17)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "Delete source file after successful decryption"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(311, 84)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 23)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Exit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(249, 84)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 23)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "Help"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(311, 59)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 23)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "About"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btndec
        '
        Me.btndec.Enabled = False
        Me.btndec.Location = New System.Drawing.Point(249, 59)
        Me.btndec.Name = "btndec"
        Me.btndec.Size = New System.Drawing.Size(60, 23)
        Me.btndec.TabIndex = 26
        Me.btndec.Text = "Decrypt"
        Me.btndec.UseVisualStyleBackColor = True
        '
        'txtDecp2
        '
        Me.txtDecp2.BackColor = System.Drawing.SystemColors.Info
        Me.txtDecp2.Location = New System.Drawing.Point(76, 85)
        Me.txtDecp2.Name = "txtDecp2"
        Me.txtDecp2.Size = New System.Drawing.Size(170, 20)
        Me.txtDecp2.TabIndex = 25
        Me.txtDecp2.Text = "None"
        Me.txtDecp2.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Confirm :"
        '
        'txtDecp1
        '
        Me.txtDecp1.BackColor = System.Drawing.SystemColors.Info
        Me.txtDecp1.Location = New System.Drawing.Point(76, 60)
        Me.txtDecp1.Name = "txtDecp1"
        Me.txtDecp1.Size = New System.Drawing.Size(170, 20)
        Me.txtDecp1.TabIndex = 23
        Me.txtDecp1.Text = "None"
        Me.txtDecp1.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Password :"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(346, 33)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(25, 23)
        Me.Button11.TabIndex = 21
        Me.Button11.Text = "..."
        Me.Button11.UseVisualStyleBackColor = True
        '
        'txtDecDestn
        '
        Me.txtDecDestn.Location = New System.Drawing.Point(92, 34)
        Me.txtDecDestn.Name = "txtDecDestn"
        Me.txtDecDestn.ReadOnly = True
        Me.txtDecDestn.Size = New System.Drawing.Size(251, 20)
        Me.txtDecDestn.TabIndex = 20
        Me.txtDecDestn.Text = "Not Selected."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Destination"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(346, 8)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(25, 23)
        Me.Button12.TabIndex = 17
        Me.Button12.Text = "..."
        Me.Button12.UseVisualStyleBackColor = True
        '
        'txtDecSrc
        '
        Me.txtDecSrc.Location = New System.Drawing.Point(92, 9)
        Me.txtDecSrc.Name = "txtDecSrc"
        Me.txtDecSrc.ReadOnly = True
        Me.txtDecSrc.Size = New System.Drawing.Size(251, 20)
        Me.txtDecSrc.TabIndex = 16
        Me.txtDecSrc.Text = "Not Selected."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "File to Decrypt :"
        '
        'OFD
        '
        Me.OFD.Filter = "All Files (*.*)|*.*"
        Me.OFD.InitialDirectory = "c:"
        '
        'FBD
        '
        Me.FBD.Description = "Select Destination Folder.."
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eGuard_Encryptor.My.Resources.Resources.bk
        Me.ClientSize = New System.Drawing.Size(412, 193)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " eGuard File Securer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtEncSrc As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtEncDestn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtenp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtenp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnenc As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btndec As System.Windows.Forms.Button
    Friend WithEvents txtDecp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDecp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents txtDecDestn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents txtDecSrc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog

End Class
