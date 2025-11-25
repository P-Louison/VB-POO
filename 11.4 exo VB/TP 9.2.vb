Module TP_9_2
    Sub main()
        Dim note, nbNote, compteur, sommesNotes, moyenne As Double

        compteur = 0
        nbNote = 0
        sommesNotes = 0

        Do
            Console.WriteLine("Note ? (entre 0 et 20, -1 pour sortir)")
            note = Console.ReadLine()

            If note >= 0 And note <= 20 Then
                nbNote += 1
                compteur += 1
                sommesNotes = sommesNotes + note

            Else

                Console.WriteLine("La note doit être entre 0 et 20")

            End If
        Loop Until note = -1

        moyenne = sommesNotes / nbNote

        Console.WriteLine("Somme : " + sommesNotes.ToString)
        Console.WriteLine("Compteur : " + compteur.ToString)
        Console.WriteLine("Moyenne : " + moyenne.ToString)
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
