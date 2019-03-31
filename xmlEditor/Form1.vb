Public Class frm_main
    Dim ds As New DataSet
    Dim fileName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ofd As New OpenFileDialog
        ofd.Filter = "XML Files|*.xml"

        If ofd.ShowDialog = DialogResult.OK Then
            fileName = ofd.FileName
            ds.ReadXml(fileName)
            dgv_data.DataSource = ds.Tables(0)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ds.WriteXml(fileName)
    End Sub

    Private Sub frm_main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        dgv_data.Width = Me.Width - 40
        dgv_data.Height = Me.Height - 84
        btn_save.Left = Me.Width - btn_save.Width - 27
        btn_save.Top = Me.Height - btn_save.Height - 43
    End Sub
End Class
