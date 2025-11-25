Module TP_9_3
    Sub main()
        Dim n, i As Integer
        Do
            Console.WriteLine("Saisir le nombre :")
            n = Console.ReadLine()
        Loop Until n > 0
        For i = 1 To n
            If (n Mod 2) = 0 Then

                Console.WriteLine(n)

            End If
            n -= 1
        Next

        Console.ReadLine()

        Dim commission, vente, totalvente As Double
        Dim nom As String
        Dim reponse As String

        Do

            Console.WriteLine("Nom du représentant ?")
            nom = Console.ReadLine()
            totalvente = 0

            For i = 1 To 4

                Console.WriteLine("Semaine " + i.ToString + ": Ventes H.T hebdomadaires (0 pour stopper la saisie")

                vente = Console.ReadLine()
                If vente < 0 Then
                    Console.WriteLine("Ventes ne peuvent être inférieur 0")
                    i -= 1
                ElseIf vente = 0 Then
                    i = 4
                Else
                    totalvente = totalvente + vente
                End If
            Next

            commission = totalvente / 10

            Console.WriteLine("Bilan pour " + nom)
            Console.WriteLine("Total des ventes H.T. = " + totalvente.ToString)
            Console.WriteLine("Commision = " + commission.ToString)
            Console.WriteLine("autre représantant ?")
            reponse = Console.ReadLine()

            If reponse <> "oui" Then
                reponse = "non"
            End If


        Loop Until reponse = "non"
        Console.ReadLine()
    End Sub
End Module
