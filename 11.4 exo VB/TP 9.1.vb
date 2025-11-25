Module TP_9_1
    Sub main()
        Dim note, nbNote, moyenneDesNotes, pourcentageDesNotes, compteurNoteMoyenne, totalDesNotes As Double
        totalDesNotes = 0
        compteurNoteMoyenne = 0
        nbNote = 0
        Console.WriteLine("Entrez une note (-1 pour fin) :")
        note = Console.ReadLine()

        While note > -1
            totalDesNotes = totalDesNotes + note
            nbNote += 1
            If note > 10 Then
                compteurNoteMoyenne += 1
            End If

            Console.WriteLine("Entrez une note (-1 pour fin) :")
            note = Console.ReadLine()
        End While

        moyenneDesNotes = totalDesNotes / nbNote
        pourcentageDesNotes = (compteurNoteMoyenne / nbNote) * 100
        Console.WriteLine("Vous avez " + pourcentageDesNotes.ToString + "% de note > à 10")
        Console.WriteLine("Votre moyenne est de " + moyenneDesNotes.ToString)
        Console.ReadLine()
    End Sub
End Module
