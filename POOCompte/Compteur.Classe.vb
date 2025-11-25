Public Class Compteur

    Private valeur As Double

    Public Sub New(ByVal nouvValeur As Double)
        valeur = nouvValeur
    End Sub

    Public Function GetValeur()
        Return valeur
    End Function

    Public Sub PlusUn()
        valeur = valeur + 1
    End Sub

    Public Sub Raz()
        valeur = 0
    End Sub

    Public Function IncrementeDe(ByVal nombre As Double)
        If nombre > 0 Then
            valeur += nombre
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DecrementeDe(ByVal nombre As Double)
        If nombre > 0 Then
            valeur -= nombre
            Return True
        Else
            Return False
        End If
    End Function

End Class
