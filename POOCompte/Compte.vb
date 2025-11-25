Public Class Compte

    Private numéro As String
    Private nom As String
    Private solde As Double

    Public Sub New(ByVal nouvNuméro As String, ByVal nouvNom As String,
           ByVal nouvSolde As Double)
        numéro = nouvNuméro
        nom = nouvNom
        solde = nouvSolde
    End Sub

    Public Sub New()
        numéro = ""
        nom = ""
        solde = 0
    End Sub

    Public Function GetNuméro() As String
        Return numéro
    End Function

    Public Function GetNomTitulaire() As String
        Return nom
    End Function

    Public Sub SetNomTitulaire(ByVal nouvNom As String)
        nom = nouvNom
    End Sub
    Public Sub SetSolde(ByVal newSolde As String)
        solde = newSolde
    End Sub

    Public Function GetSolde() As Double
        Return solde
    End Function

    Public Sub versChaine(ByVal client As String)
        Console.WriteLine("Numéro de compte : " + numéro)
        Console.WriteLine("Nom titulaire : " + nom)
        Console.WriteLine("Solde : " + solde)
    End Sub

    Public Function Crediter(ByVal montant As Double) As Boolean
        If montant > 0 Then
            solde = solde + montant
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Debiter(ByVal montant As Double) As Boolean
        If montant > 0 And (solde - montant > 0) Then
            solde = solde - montant

            Return True
        Else
            Return False
        End If
    End Function
End Class
