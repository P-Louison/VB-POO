Public Class Eleve



    Private Const MAXNOTES As Integer = 9

    Private numéro As String
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private numTeleleve As String
    Private dateNaiss As String
    Private numClasse As String
    Private tabNotes() As Double = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1}


    Public Sub New(ByVal nouvNuméro As String,
                ByVal nouvnom As String,
                ByVal nouvprenom As String,
                ByVal nouvadresse As String,
                ByVal nouvnumTeleleve As String,
                ByVal nouvdateNaiss As String,
                ByVal nouvClasse As String
                )

        numéro = nouvNuméro
        nom = nouvnom
        prenom = nouvprenom
        adresse = nouvadresse
        numTeleleve = nouvnumTeleleve
        dateNaiss = nouvdateNaiss
        numClasse = nouvClasse
    End Sub




    Public Function GetNuméro() As String
        Return numéro
    End Function

    Public Function GetNom() As String
        Return nom
    End Function
    Public Sub SetNom(ByVal nouvNom As String)
        nom = nouvNom
    End Sub

    Public Function GetPrenom() As String
        Return prenom
    End Function
    Public Sub SetPrenom(ByVal nouvPrenom As String)
        prenom = nouvPrenom
    End Sub

    Public Function GetNumTeleleve() As String
        Return numTeleleve
    End Function

    Public Sub SetNumTeleleve(ByVal nouvNumTeleleve As String)
        numTeleleve = nouvNumTeleleve
    End Sub

    Public Function GetAddresse() As String
        Return adresse
    End Function
    Public Sub Setaddresse(ByVal nouvAdresse As String)
        adresse = nouvAdresse
    End Sub

    Public Function GetDateNaiss() As String
        Return dateNaiss
    End Function

    Public Function GetNumClasse() As String
        Return numClasse
    End Function
    Public Sub SetNumClasse(ByVal nouvNumClasse As String)
        numClasse = nouvNumClasse
    End Sub

    Public Function Moyenne() As Double
        Dim resultat, i, compteur As Double

        For i = 0 To MAXNOTES
            If tabNotes(i) <> -1 Then
                resultat += tabNotes(i)
                compteur += 1
            End If

        Next
        If compteur = 0 Then
            Return -1
        End If

        Return resultat / compteur
    End Function

    Public Sub setNote(ByVal noMatiere As Integer, ByVal note As Double)
        tabNotes(noMatiere) = note
    End Sub

    Public Overrides Function ToString() As String
        Dim chaine As String
        chaine = ("Numéro : " + numéro + vbNewLine +
            "Nom : " + nom + vbNewLine +
            "Prenom : " + prenom + vbNewLine +
            "adresse : " + adresse + vbNewLine +
            "numTel :" + numTeleleve + vbNewLine +
            "date de naissance : " + dateNaiss + vbNewLine +
            "numéro de classe : " + numClasse + vbNewLine
            )
        For i = 0 To MAXNOTES
            chaine = chaine + tabNotes(i).ToString + " | "
        Next

        Return chaine
    End Function




End Class
