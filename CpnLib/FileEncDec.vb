Public Class FileEncDec

    Private _InputFile, _OutputFile, _Password As String

    Public _Key(), _IV() As Byte
    '
    Private Algm As System.Security.Cryptography.RijndaelManaged
    Private inFs, outFs As System.IO.FileStream
    Private wS As Security.Cryptography.CryptoStream
    Private Buffer(1024) As Byte

    Private Function generateKey() As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = _Password.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

    Private Function generateIV() As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = _Password.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function


    Public Property inputFile() As String
        Get
            Return _InputFile
        End Get
        Set(ByVal value As String)
            _InputFile = value
        End Set
    End Property
    Public Property outputFile() As String
        Get
            Return _OutputFile
        End Get
        Set(ByVal value As String)
            _OutputFile = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
            _Key = generateKey()
            _IV = generateIV()
        End Set
    End Property

    Public Sub New()
        Algm = New System.Security.Cryptography.RijndaelManaged
        Me.Password = "None"
    End Sub

    Public Function EncryptFile(Optional ByVal DeleteSourceFile As Boolean = False) As String
        Dim ErrorIfOccured As String = Nothing
        Try
            'Setup file streams to handle input and output.
            inFs = New System.IO.FileStream(_InputFile, IO.FileMode.Open, IO.FileAccess.Read)
            outFs = New System.IO.FileStream(_OutputFile, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
            outFs.SetLength(0) 'make sure fsOutput is empty
            wS = New Security.Cryptography.CryptoStream(outFs, Algm.CreateEncryptor(_Key, _IV), Security.Cryptography.CryptoStreamMode.Write)
            'Now Decrypt the File
            Dim rSize As Integer = inFs.Read(Buffer, 0, 1024)
            While rSize > 0
                wS.Write(Buffer, 0, rSize)
                wS.Flush()
                rSize = inFs.Read(Buffer, 0, 1024)
            End While
            'Closes the Streams
            If Not wS Is Nothing Then wS.Close()
            If Not inFs Is Nothing Then inFs.Close()
            If Not outFs Is Nothing Then outFs.Close()
            If DeleteSourceFile Then
                IO.File.Delete(_InputFile)
            End If
            ErrorIfOccured = Nothing
        Catch ex As Exception
            ErrorIfOccured = ex.Message
            If Not inFs Is Nothing Then inFs.Close()
            If Not outFs Is Nothing Then outFs.Close()
            IO.File.Delete(_OutputFile)
        End Try
        Return ErrorIfOccured
    End Function

    Public Function DecryptFile(Optional ByVal DeleteSourceFile As Boolean = False) As String
        Dim ErrorIfOccured As String = Nothing
        Try
            'Setup file streams to handle input and output.
            inFs = New System.IO.FileStream(_InputFile, IO.FileMode.Open, IO.FileAccess.Read)
            outFs = New System.IO.FileStream(_OutputFile, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
            outFs.SetLength(0) 'make sure fsOutput is empty
            wS = New Security.Cryptography.CryptoStream(outFs, Algm.CreateDecryptor(_Key, _IV), Security.Cryptography.CryptoStreamMode.Write)
            'Now Decrypt the File
            Dim rSize As Integer = inFs.Read(Buffer, 0, 1024)
            While rSize > 0
                wS.Write(Buffer, 0, rSize)
                wS.Flush()
                rSize = inFs.Read(Buffer, 0, 1024)
            End While
            'Closes the Streams
            If Not wS Is Nothing Then wS.Close()
            If Not inFs Is Nothing Then inFs.Close()
            If Not outFs Is Nothing Then outFs.Close()
            If DeleteSourceFile Then
                IO.File.Delete(_InputFile)
            End If
            ErrorIfOccured = Nothing
        Catch ex As Exception
            ErrorIfOccured = "Possibly Invalid Password."
            If Not inFs Is Nothing Then inFs.Close()
            If Not outFs Is Nothing Then outFs.Close()
            IO.File.Delete(_OutputFile)
        End Try
        Return ErrorIfOccured
    End Function

End Class
