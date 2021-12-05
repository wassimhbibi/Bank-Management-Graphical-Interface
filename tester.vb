Public Class tester
    Dim file As String

    Private Sub tester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.ShowDialog()
        Dim m1 As New clientt
        im = 0
        file = OpenFileDialog1.FileName.ToString
        Dim sr As New IO.StreamReader(file)
        Dim x() As String
        Do While sr.Peek > 0
            x = sr.ReadLine().Split("#")
            m1.id = CInt(x(0))
            cb.Items.Add(m1.id.ToString)


        Loop
    End Sub



    Private Sub cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb.SelectedIndexChanged
       Dim k As Integer
        Dim m1 As New clientt
        im = 0
        Dim x() As String
        Dim sr As New IO.StreamReader(file)
        Do While sr.Peek > 0
            x = sr.ReadLine().Split("#")
            m1.id = CInt(x(0))
            If m1.id = cb.Text Then
                mm.Rows.Insert(k, x(0), x(1), x(2), x(3), x(4))
                k = k + 1
                Exit Do
            End If

        Loop
    End Sub
End Class