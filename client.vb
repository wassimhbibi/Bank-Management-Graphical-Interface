Public Class client

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cli1 As New clientt
            Dim f As Boolean = recherch_client(CInt(tx_id.Text), v_cli, im)
            If f = True Then
                MessageBox.Show("le client déja existe ")
                tx_id.Clear()
                tx_nu.Clear()
                tx_n.Clear()
                tx_p.Clear()
                tx_pu.Clear()
               
            Else

                cli1.id = CInt(tx_id.Text)
                cli1.num_tel = CInt(tx_nu.Text)
                cli1.nom = (tx_n.Text)
                cli1.prenom = (tx_p.Text)

                cli1.profession = (tx_pu.Text)

                v_cli(im) = cli1
                wa.Rows.Insert(im, v_cli(im).id, v_cli(im).num_tel, v_cli(im).nom, v_cli(im).prenom, v_cli(im).profession)
                im = im + 1
                tx_id.Clear()
                tx_nu.Clear()
                tx_n.Clear()
                tx_p.Clear()
                tx_pu.Clear()
               

                MessageBox.Show("ajoute avec succé")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tx_nu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_n.TextChanged

    End Sub

   

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim k As Integer
        OpenFileDialog1.ShowDialog()
        Dim x1 As New clientt
        im = 0
        Dim file As String = OpenFileDialog1.FileName.ToString
        Dim sr As New IO.StreamReader(file)
        Dim x() As String
        Do While sr.Peek > 0
            x = sr.ReadLine().Split("#")
            x1.id = CInt(x(0))
            x1.num_tel = (x(1))
            x1.nom = (x(2))
            x1.prenom = (x(3))
            x1.profession = (x(4))

            v_cli(k) = x1
            im = im + 1
            wa.Rows.Insert(k, x(0), x(1), x(2), x(3), x(4))
            k = k + 1
        Loop
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        SaveFileDialog1.ShowDialog()
        Dim file As String = SaveFileDialog1.FileName.ToString
        Dim sw As New IO.StreamWriter(file)
        For i = 0 To im - 1
            sw.WriteLine(v_cli(i).id & "#" & v_cli(i).num_tel & "#" & v_cli(i).nom & "#" & v_cli(i).prenom & "#" & v_cli(i).profession)
        Next
        sw.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        wa.Rows.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim j As Integer = 0
        Dim x As Integer = 0

        Dim verif As Boolean = False
        Dim res As DialogResult
        Dim a As Boolean = recherch_client(CInt(tx_id.Text), v_cli, im)
        If a = True Then
            res = MessageBox.Show("veuley vous supprimet ce client", "supprimet", MessageBoxButtons.YesNo)
            If res = DialogResult.Yes Then
                While (j < im - 1 And verif = False)
                    If CInt(tx_id.Text) <> v_cli(j).id Then
                        j = j + 1
                    Else
                        verif = True
                    End If
                End While

                tx_nu.Text = v_cli(j).num_tel
                tx_n.Text = v_cli(j).nom
                tx_p.Text = v_cli(j).prenom
                tx_pu.Text = v_cli(j).profession
                For x = j To im - 1
                    v_cli(x) = v_cli(x + 1)
                Next
                im = im - 1
                tx_id.Clear()
                tx_nu.Clear()
                tx_n.Clear()
                tx_p.Clear()
                tx_pu.Clear()
                wa.Rows.Clear()
                For i = 0 To im - 1
                    MessageBox.Show(v_cli(i).id)
                    wa.Rows.Insert(i, v_cli(i).id, v_cli(i).num_tel, v_cli(i).nom, v_cli(i).prenom, v_cli(i).profession)
                Next


                '   wa.Rows.RemoveAt(wa.CurrentRow.Index)
                '   wa.Refresh()
                MessageBox.Show("la supprition avec succe")

            End If

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim c1 As New clientt
        Dim i As Integer
        Dim k As Integer
        i = recherch_client(CInt(tx_id.Text), v_cli, im)
        c1.id = CInt(tx_id.Text)
        c1.num_tel = CInt(tx_nu.Text)
        c1.nom = (tx_n.Text)
        c1.prenom = (tx_p.Text)
        c1.profession = (tx_pu.Text)
        v_cli(i) = c1
        k = wa.CurrentRow.Index
        wa.Item(0, k).Value = tx_id.Text
        wa.Item(1, k).Value = tx_nu.Text
        wa.Item(2, k).Value = tx_n.Text
        wa.Item(3, k).Value = tx_p.Text
        wa.Item(4, k).Value = tx_pu.Text
        MessageBox.Show("modification succe")
        tx_id.Clear()
        tx_nu.Clear()
        tx_n.Clear()
        tx_p.Clear()
        tx_pu.Clear()
    End Sub

    Private Sub wa_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles wa.CellContentClick

    End Sub
End Class
