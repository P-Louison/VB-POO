Public Class Pile

    Private Const MAX As Double = 100
    Private tabPile(MAX) As String
    Private positionlibre As Integer

    Public Sub New()
    End Sub


    Public Function empiler(ByVal valeur As String) As Boolean

        If positionlibre > MAX Then
            Return False
        Else
            tabPile(positionlibre) = valeur
            positionlibre += 1
            Return True
        End If

    End Function

    Public Sub depiler()
        Console.WriteLine("Valeur extraite de la pile : " + tabPile(positionlibre - 1))
        positionlibre -= 1
    End Sub

    Public Function est_vide() As Boolean
        If positionlibre = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function NombreElement()
        Dim compteur As Integer
        While tabPile(compteur) <> ""
            compteur += 1
        End While
        Return compteur
    End Function

    Public Sub affichage()
        Dim i As Integer

        While i <> positionlibre
            Console.Write((tabPile(i)).ToString + " ")
            i += 1
        End While



    End Sub

End Class
