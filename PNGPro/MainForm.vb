Public Class MainForm

    Dim IsClosing = False

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        PNGChooser.ShowDialog(Me)
    End Sub

    Private Sub PNGChooser_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PNGChooser.FileOk
        For Each file As String In PNGChooser.FileNames
            Dim itm As New ListViewItem
            itm.Text = file
            itm.SubItems.Add("READY")
            PNGList.Items.Add(itm)
        Next
    End Sub

    Private Sub PNGList_DragEnter(sender As Object, e As DragEventArgs) Handles PNGList.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PNGList_DragDrop(sender As Object, e As DragEventArgs) Handles PNGList.DragDrop
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        For Each file As String In files
            If file.EndsWith(".png") Then
                Dim itm As New ListViewItem
                itm.Text = file
                itm.SubItems.Add("READY")
                PNGList.Items.Add(itm)
            End If
        Next
    End Sub

    Private Sub OptimizeButton_Click(sender As Object, e As EventArgs) Handles OptimizeButton.Click
        If AddButton.Enabled = True Then
            AddButton.Enabled = False
            PNGList.AllowDrop = False
            OptimizeButton.Text = "Abort"
            OptimizeButton.BackColor = Color.DarkRed

            GetWork()
        Else
            If OptiWorker.IsBusy = True Then
                OptiWorker.CancelAsync()
            End If
            ReEnable()
        End If

    End Sub

    Sub ReEnable()
        AddButton.Enabled = True
        OptimizeButton.Text = "Optimize PNGs"
        OptimizeButton.BackColor = Color.ForestGreen
        PNGList.AllowDrop = True
    End Sub

    Sub GetWork()
        If AddButton.Enabled Then
            Return
        End If

        For Each item As ListViewItem In PNGList.Items
            If item.SubItems.Item(1).Text Is "DONE" Then
                Continue For
            End If
            item.SubItems.Item(1).Text = "BUSY"

            OptiWorker.RunWorkerAsync(item)
            Return
        Next

        ReEnable()
    End Sub

    Private Sub OptiWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles OptiWorker.DoWork
        Dim item As ListViewItem = e.Argument

        ' Run oxipng
        Dim Info As New ProcessStartInfo()
        Info.FileName = Environment.CurrentDirectory & "\oxipng.exe"
        Info.WindowStyle = ProcessWindowStyle.Hidden
        Info.UseShellExecute = False
        Info.CreateNoWindow = True
        Info.Arguments = "-o 4 """ & item.Text & """"
        Dim p = Process.Start(Info)

        While True
            If p.HasExited Then
                Console.WriteLine("DONE")
                GoTo is_finished
            End If
            If OptiWorker.CancellationPending = True Then
                Console.WriteLine("KILL")
                p.Kill()
                item.SubItems.Item(1).Text = "ABORT"
                e.Cancel = True
                Return
            End If
            System.Threading.Thread.Sleep(500)
        End While

is_finished:

        If p.ExitCode = 1 Then
            item.SubItems.Item(1).Text = "ERROR"
        Else
            item.SubItems.Item(1).Text = "DONE"
        End If
    End Sub

    Private Sub OptiWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles OptiWorker.RunWorkerCompleted
        If IsClosing Then
            Me.Close()
        Else
            GetWork()
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        IsClosing = True
        AddButton.Enabled = False
        PNGList.AllowDrop = False
        OptimizeButton.Text = "CLOSING"
        If OptiWorker.IsBusy = True Then
            OptiWorker.CancelAsync()
            e.Cancel = True
        End If
    End Sub
End Class
