Public Class Enseignant

    Private Const VALEURINDICE As Double = 13.754

    Private numéro As String
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private numTel As String
    Private dateNaiss As String
    Private indice As Integer
    Private nombreDHeures As Double

    Public Sub New(ByVal nouvNuméro As String,
                   ByVal nouvnom As String,
                   ByVal nouvprenom As String,
                   ByVal nouvadresse As String,
                   ByVal nouvnumTel As String,
                   ByVal nouvdateNaiss As String,
                   ByVal nouvindice As Double,
                   ByVal nouvnombreDHeures As Double)

        numéro = nouvNuméro
        nom = nouvnom
        prenom = nouvprenom
        adresse = nouvadresse
        numTel = nouvnumTel
        dateNaiss = nouvdateNaiss
        indice = nouvindice
        nombreDHeures = nouvnombreDHeures
    End Sub



    Public Function GetNuméro()
        Return numéro
    End Function

    Public Function GetNom()
        Return nom
    End Function
    Public Sub SetNom(ByVal nouvNom As String)
        nom = nouvNom
    End Sub

    Public Function GetPrenom()
        Return prenom
    End Function
    Public Sub SetPrenom(ByVal nouvPrenom As String)
        prenom = nouvPrenom
    End Sub

    Public Function GetNumTel()
        Return numTel
    End Function
    Public Sub SetNumTelenseignant(ByVal nouvNumTel As String)
        numTel = nouvNumTel
    End Sub

    Public Function GetAddresse()
        Return adresse
    End Function
    Public Sub SetNumTel(ByVal nouvAdresse As String)
        adresse = nouvAdresse
    End Sub

    Public Function GetDateNaiss()
        Return dateNaiss
    End Function

    Public Function GetIndice()
        Return indice
    End Function
    Public Function SetAugmenterIndice(ByVal nouvIndice As Integer) As Boolean
        If nouvIndice > indice Then
            indice = nouvIndice
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetNombreDHeure()
        Return nombreDHeures
    End Function
    Public Sub SetNombreDHeures(ByVal nouvNombreDHeures As Integer)
        nombreDHeures = nouvNombreDHeures
    End Sub

    Public Function GetSalaireMensuel()
        Return nombreDHeures * indice * VALEURINDICE
    End Function

    Public Overrides Function ToString() As String
        Return ("Numéro : " + numéro + vbNewLine +
            "Nom : " + nom + vbNewLine +
            "Prenom : " + prenom + vbNewLine +
            "adresse : " + adresse + vbNewLine +
            "numTel :" + numTel + vbNewLine +
            "date de naissance : " + dateNaiss + vbNewLine +
            "indice " + indice.ToString + vbNewLine +
            "nombre d'heure : " + nombreDHeures.ToString
            ).ToString
    End Function




End Class
