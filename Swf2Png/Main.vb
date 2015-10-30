Imports System.IO
Imports System.Text.RegularExpressions
Imports ImageMagick

Public Class Main
    Dim files As FileInfo()
    Dim newfiles As String()

    Private Sub ChooseButton_Click(sender As Object, e As EventArgs) Handles ChooseButton.Click
        InputFileDialog.ShowDialog()
    End Sub

    Private Sub InputFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InputFileDialog.FileOk
        If InputFileDialog.FileNames IsNot Nothing Then
            Dim i As Integer = 0
            For Each s As String In InputFileDialog.FileNames
                ReDim Preserve files(i)
                files(i) = New FileInfo(s)
                i += 1
            Next
            ''Dim value As String = String.Join(".", array)
            SelectedLabel.Text = files.Length & " files selected"
        End If
    End Sub
    Public Class FileNameComparer
        Implements IComparer

        Dim reD As New Regex("\d+")
        Dim reS As New Regex("\D+")

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Dim fi1 As IO.FileInfo = DirectCast(x, IO.FileInfo)
            Dim fi2 As IO.FileInfo = DirectCast(y, IO.FileInfo)

            If fi1.Name = fi2.Name Then
                Return 0
            ElseIf reD.IsMatch(fi1.Name) AndAlso reD.IsMatch(fi2.Name) Then
                Dim fi1m = reS.Match(fi1.Name).Value & reD.Match(fi1.Name).Value.PadLeft(20, "0") & fi1.Name
                Dim fi2m = reS.Match(fi2.Name).Value & reD.Match(fi2.Name).Value.PadLeft(20, "0") & fi2.Name
                If fi1m > fi2m Then Return 1
                If fi1m < fi2m Then Return -1
            Else
                If fi1.Name > fi2.Name Then Return 1
                If fi1.Name < fi2.Name Then Return -1
            End If
        End Function
    End Class


    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        If files IsNot Nothing And OutputTextBox.Text IsNot String.Empty Then
            Dim i As Integer = 1 ''1
            For Each f As FileInfo In files
                StatusLabel.Text = "Converting " & i & " of " & files.Length
                Me.Refresh()
                ''MsgBox(f)
                Dim objProcess As System.Diagnostics.Process
                Try
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.FileName = "swfrender.exe" ''Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & Path.DirectorySeparatorChar & "SWFTools" & Path.DirectorySeparatorChar & "swfrender.exe"
                    objProcess.StartInfo.Arguments = """" & f.FullName & """ -r " & DPINumericUpDown.Value & " -o """ & OutputTextBox.Text & Path.DirectorySeparatorChar & i & ".png"""
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.Start()
                    'Wait until the process passes back an exit code 
                    objProcess.WaitForExit()
                    'Free resources associated with this process
                    objProcess.Close()
                    ReDim Preserve newfiles(i - 1)
                    newfiles(i - 1) = OutputTextBox.Text & Path.DirectorySeparatorChar & i & ".png"
                Catch
                    MessageBox.Show("Could not start/find swfrender.exe", "Error")
                End Try
                i += 1
            Next
            StatusLabel.Text = "DONE Converting"
            Me.Refresh()
            If PDFCheckBox.Checked Then
                StatusLabel.Text = "Converting to PDF"
                Me.Refresh()
                Using collection As New MagickImageCollection()
                    For Each s As String In newfiles
                        ''compress page
                        If CompressCheckBox.Checked Then
                            Using io As New MagickImage(s)
                                io.Format = MagickFormat.Jpeg
                                io.Quality = 75
                                io.Write(s)
                            End Using
                        End If
                        ' Add page
                        collection.Add(New MagickImage(s))
                    Next
                    ' Create pdf file with two pages
                    collection.Write(OutputTextBox.Text & Path.DirectorySeparatorChar & "OUTPUT.pdf")
                End Using
                StatusLabel.Text = "Deleting Files"
                Me.Refresh()
                For Each s As String In newfiles
                    Dim fi As New FileInfo(s)
                    fi.Delete()
                Next
            End If
            StatusLabel.Text = "DONE"
            Me.Refresh()
        End If
    End Sub

    Private Sub OutputButton_Click(sender As Object, e As EventArgs) Handles OutputButton.Click
        Dim result As DialogResult = OutputFolderBrowserDialog.ShowDialog()
        If result = DialogResult.OK Then
            OutputTextBox.Text = OutputFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub InputButton_Click(sender As Object, e As EventArgs)
        ToolsFolderBrowserDialog.ShowDialog()
    End Sub
End Class
