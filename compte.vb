Public Class compte

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim comp1 As New compte_client
            Dim f As Boolean = recherch_compte_client(CInt(n_c.Text), v_cop_cli, im)
            If f = True Then
                MessageBox.Show("le compte de client déja existe ")
                n_c.Clear()
                d_oo.Clear()
                sdb.Clear()

            Else

                comp1.num_compte = CInt(n_c.Text)
                comp1.date_ouverture = CDate(d_oo.Text)
                comp1.solde_base = CDbl(sdb.Text)
                v_cop_cli(im) = comp1
                wa1.Rows.Insert(im, v_cop_cli(im).num_compte, v_cop_cli(im).date_ouverture, v_cop_cli(im).solde_base)
                im = im + 1
                n_c.Clear()
                d_oo.Clear()
                sdb.Clear()

                MessageBox.Show("ajoute avec succé")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        SaveFileDialog1.ShowDialog()
        Dim file As String = SaveFileDialog1.FileName.ToString
        Dim sw As New IO.StreamWriter(file)
        For i = 0 To im - 1
            sw.WriteLine(wa1.Item(0, i).Value & "#" & wa1.Item(1, i).Value & "#" & wa1.Item(2, i).Value & "#" & wa1.Item(3, i).Value)
        Next
        sw.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim k As Integer
        OpenFileDialog1.ShowDialog()
        Dim x1 As New compte_client
        im = 0
        Dim file As String = OpenFileDialog1.FileName.ToString
        Dim sr As New IO.StreamReader(file)
        Dim x() As String
        Do While sr.Peek > 0
            x = sr.ReadLine().Split("#")
            x1.num_compte = CInt(x(0))
            x1.date_ouverture = (x(1))
            x1.solde_base = (x(2))
            v_cop_cli(k) = x1
            im = im + 1
            wa1.Rows.Insert(k, x(0), x(1), x(2))
            k = k + 1
        Loop
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Close()
    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        wa1.Rows.Clear()
    End Sub

    Private Sub d_o_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim cc1 As New compte_client
        Dim i As Integer
        Dim k As Integer
        i = recherch_compte_client(CInt(n_c.Text), v_cop_cli, im)
        cc1.num_compte = CInt(n_c.Text)
        cc1.date_ouverture = (d_oo.Text)
        cc1.solde_base = (sdb.Text)
        v_cop_cli(i) = cc1
        k = wa1.CurrentRow.Index
        wa1.Item(0, k).Value = n_c.Text
        wa1.Item(1, k).Value = d_oo.Text
        wa1.Item(2, k).Value = sdb.Text
        MessageBox.Show("modification succe")
        n_c.Clear()
        d_oo.Clear()
        sdb.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim j As Integer = 0
        Dim x As Integer = 0
        Try

            Dim verif As Boolean = False
            Dim res As DialogResult
            Dim a As Boolean = recherch_compte_client(CInt(n_c.Text), v_cop_cli, im)
            If a = True Then
                res = MessageBox.Show("veuley vous supprimet ce client", "supprimet", MessageBoxButtons.YesNo)
                If res = DialogResult.Yes Then
                    While (j < im - 1 And verif = False)
                        If CInt(n_c.Text) <> v_cli(j).id Then
                            j = j + 1
                        Else
                            verif = True
                        End If
                    End While

                    n_c.Text = v_cop_cli(j).num_compte
                    d_oo.Text = v_cop_cli(j).date_ouverture
                    sdb.Text = v_cop_cli(j).solde_base

                    For x = j To im - 1
                        v_cop_cli(x) = v_cop_cli(x + 1)
                    Next
                    im = im - 1
                    n_c.Clear()
                    d_oo.Clear()
                    sdb.Clear()
                   
                    wa1.Rows.Clear()
                    For i = 0 To im - 1
                        MessageBox.Show(v_cli(i).id)
                        wa1.Rows.Insert(i, v_cop_cli(i).num_compte, v_cop_cli(i).date_ouverture, v_cop_cli(i).solde_base)
                    Next


                    '   wa.Rows.RemoveAt(wa.CurrentRow.Index)
                    '   wa.Refresh()
                    MessageBox.Show("la supprition avec succe")

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class