Module TP_13_1_3

    Sub base2(ByVal valeur As Double)
        Dim tableauResultat() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}
        For i = 0 To 7
            If valeur Mod 2 = 0 Then
                valeur = valeur \ 2
            Else
                tableauResultat(i) = 1
                valeur = valeur \ 2
            End If
        Next
        For i = 7 To 0 Step -1
            Console.Write(tableauResultat(i))
        Next
        Console.ReadLine()
    End Sub

    Sub base8(ByVal valeur As Double)
        Dim tableauResultat() As Integer = {0, 0, 0, 0, 0, 0, 0, 0}
        For i = 0 To 7
            If valeur Mod 8 = 0 Then
                valeur = valeur \ 8
            Else
                tableauResultat(i) = 1
                valeur = valeur \ 8
            End If
        Next
        For i = 7 To 0 Step -1
            Console.Write(tableauResultat(i))
        Next
        Console.ReadLine()
    End Sub

    Sub main()
        Dim valeur, choix, continuer As Double
        Do
            Do
                Console.WriteLine("Entrez le nombre à convertir")
                valeur = Console.ReadLine
                If valeur < 0 Or valeur > 255 Then
                    Console.WriteLine("votre valeur doit etre comprise en 0 et 255")

                End If
            Loop Until valeur >= 0 And valeur <= 255
            Do
                Console.WriteLine("Entrez la base que vous souhaitez ")
                choix = Console.ReadLine
                If choix <> 2 And choix <> 8 Then
                    Console.WriteLine("votre base doit etre 2 ou 8")
                End If
            Loop Until choix = 2 Or choix = 8

            If choix = 2 Then
                base2(valeur)
            End If
            If choix = 8 Then
                base8(valeur)
            End If


            Do
                Console.WriteLine("voulez-vous continuer ?")
                continuer = Console.ReadLine
                If continuer <> 1 And continuer <> 0 Then
                    Console.WriteLine("votre choix doit etre 0 pour continuer ou 1 pour arreter")
                End If
            Loop Until continuer = 1 Or continuer = 0

        Loop Until continuer = 1

        Console.WriteLine("au revoir")
        Console.ReadLine()

    End Sub
End Module
