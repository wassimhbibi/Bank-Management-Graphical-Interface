Module les_structure
    Public nb_cli As Integer
    Public nb_comp_cli As Integer
    Public Class clientt
        Public id As Integer
        Public num_tel As Integer
        Public nom As String
        Public prenom As String
        Public profession As String
    End Class

    Public Class compte_client
        Public date_ouverture As Date
        Public num_compte As Integer
        Public solde_base As Double
    End Class
    Public v_cli(40) As clientt
    Public v_cop_cli(40) As compte_client
    Public nb_cl As Integer
    Public nb_comp As Integer
    Public im As Integer = 0
    Public Function recherch_client(ByVal x As Integer, ByVal v_cli() As clientt, ByVal s As Integer) As Boolean
        Dim j As Integer = 0
        Dim i As Boolean = False
        While j < s And i = False
            If x = v_cli(j).id Then
                i = True
            Else
                j = j + 1
            End If
        End While
        Return (i)
    End Function
   
    Public Function recherch_compte_client(ByVal z As Integer, ByVal v_cop_cli() As compte_client, ByVal a As Integer) As Boolean
        Dim l As Integer = 0
        Dim trouves As Boolean = False
        While l < a And trouves = False
            If z = v_cop_cli(l).num_compte Then
                trouves = True
            Else
                l = l + 1
            End If
        End While
        Return (trouves)
    End Function


End Module

