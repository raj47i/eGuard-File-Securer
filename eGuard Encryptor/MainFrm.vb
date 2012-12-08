Public Class MainFrm

#Region "Comman Buttons[Exit | `Help | About ]"
    Private Sub Exit_Application(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click, Button6.Click
        Me.Close()
    End Sub

    Private Sub About_Application(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click, Button9.Click
        My.Forms.AboutFrm.ShowDialog()
    End Sub

    Private Sub Help_Show(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click, Button4.Click
        Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\Manual.CHM", HelpNavigator.TableOfContents)
    End Sub

#End Region

#Region "Encryption Process"
    Private Sub Select_FileToEnc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OFD.Title = "Select File to Encrypt.."
        OFD.Filter = "All Files [*.*]|*.*"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEncSrc.Text = OFD.FileName
            '
            txtEncDestn.Text = txtEncSrc.Text & "e"
            btnenc.Enabled = True
        End If
    End Sub
    Private Sub Sel_Enc_File(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtEncDestn.Text = FBD.SelectedPath & "\" & IO.Path.GetFileName(txtEncSrc.Text) & "e"
        End If
    End Sub

    Private Sub Encrypt_File(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenc.Click
        If txtenp1.Text = txtenp2.Text Then
            Dim edc As New CpnLib.FileEncDec
            edc.inputFile = txtEncSrc.Text
            edc.outputFile = txtEncDestn.Text
            edc.Password = txtenp1.Text
            Dim m As String = edc.EncryptFile(CheckBox1.Checked)
            If m = Nothing Then
                MsgBox("File was encrypted successfully.", MsgBoxStyle.Information)
                btnenc.Enabled = False
                txtEncDestn.Text = "Not Selected."
                txtEncSrc.Text = "Not Selected."
                txtenp1.Text = "None"
                txtenp2.Text = "None"
            Else
                MsgBox(m)
            End If
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtenp1.Text = ""
            txtenp2.Text = ""
        End If
    End Sub

#End Region

#Region "Decryption Process"

    Private Sub Select_FileToDec(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        OFD.Title = "Select File to Decrypt.."
        OFD.Filter = "Encrypted Files [*.*e]|*.*e"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDecSrc.Text = OFD.FileName
            '
            Dim srcName As String = IO.Path.GetFileName(txtDecSrc.Text)
            txtDecDestn.Text = (txtDecSrc.Text).Remove(txtDecSrc.Text.Length - 1)
            btndec.Enabled = True
        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim m As String = IO.Path.GetFileName(txtDecSrc.Text)
            txtDecDestn.Text = FBD.SelectedPath & "\" & m.Remove(m.Length - 1)
        End If
    End Sub
    Private Sub Decrypt_File(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndec.Click
        If txtDecp1.Text = txtDecp2.Text Then
            Dim dec As New CpnLib.FileEncDec
            dec.inputFile = txtDecSrc.Text
            dec.outputFile = txtDecDestn.Text
            dec.Password = txtDecp1.Text
            Dim m As String = dec.DecryptFile(CheckBox2.Checked)
            If m = Nothing Then
                MsgBox("File was decrypted successfully.", MsgBoxStyle.Information)
                btndec.Enabled = False
                txtDecDestn.Text = "Not Selected."
                txtDecSrc.Text = "Not Selected."
                txtDecp1.Text = "None"
                txtDecp2.Text = "None"
            Else
                MsgBox(m)
            End If
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtDecp1.Text = ""
            txtDecp2.Text = ""
        End If
    End Sub

#End Region

End Class
