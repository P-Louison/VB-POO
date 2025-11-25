Public Class Eleve

    Public Class Enseignant

        Private Const MAXNOTES As Integer = 9

        Private numéro As String
        Private nom As String
        Private prenom As String
        Private adresse As String
        Private numTel As String
        Private dateNaiss As String
        Private numClasse As Integer
        Private tabNotes() As Double




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

        Public Function GetNumTel() As String
            Return numTel
        End Function
        Public Sub SetNumTel(ByVal nouvNumTel As String)
            numTel = nouvNumTel
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

        Public Function Moyennes() As Double
            Dim resultat, i As Double
            For i = 0 To MAXNOTES
                If tabNotes(i) <> -1 Then
                    resultat += tabNotes(i)
                Else
                    Exit For
                End If
            Next
            Return (resultat / i)
        End Function

        Public Sub setNote(ByVal noMatiere As Integer, ByVal note As Double)
            tabNotes(noMatiere) = note
        End Sub


        Public Overrides Function ToString() As String
            Return ("Numéro : " + numéro 
                + "Nom : " + nom 
                + "Prénom : " + prenom 
                + "Addresse : " + adresse 
                + "n° de téléphone : " + numTel 
                + "Date de naissance : " + dateNaiss 
                + "n° de la Classe" + numClasse 
                + "Notes" + tabNotes)ToString()
        End Function


    End Class


End Class
