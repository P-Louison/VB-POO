
Module TP_13_3

    Const MAXSALLES As Integer = 10  ' mis à 10 (au lieu de 50) pour test
    Const MAXJOURS As Integer = 6
    Const MAXTRANCHES As Integer = 10


    Sub Initialiser(ByRef pTab(,,) As Integer)
        For i = 0 To MAXSALLES
            For j = 0 To MAXJOURS
                For z = 0 To MAXTRANCHES
                    pTab(i, j, z) = 0
                Next
            Next
        Next

    End Sub

    Sub Main()
        Dim capaciteLue, heureLue, jourLu, occupation(MAXSALLES, MAXJOURS, MAXTRANCHES) As Integer
        Dim capacité() As Integer = {20, 40, 30, 20, 10, 50, 10, 20, 20, 25}

        Initialiser(occupation)
        occupation(3, 2, 4) = 1
        occupation(1, 1, 1) = 1
        occupation(1, 2, 1) = 1
        occupation(4, 5, 1) = 1
        occupation(2, 2, 4) = 1
        occupation(8, 3, 2) = 1
        occupation(5, 3, 3) = 1


        Do
            Console.WriteLine("quelle capacité souhaitez vous ?")
            capaciteLue = Console.ReadLine
            If capaciteLue < 0 Or capaciteLue > 50 Then
                Console.WriteLine("la capacité compris entre 0 et 50")
            End If
        Loop Until capaciteLue >= 1 And capaciteLue <= 50

        Do
            Console.WriteLine("quel jour souhaitez regarder ?")
            jourLu = Console.ReadLine
            If jourLu < 1 And jourLu > 7 Then
                Console.WriteLine("les jours sont numérotés de 1 à 7")
            End If
        Loop Until jourLu >= 1 And jourLu <= MAXJOURS

        Do
            Console.WriteLine("quel horaire souhaitez vous")
            heureLue = Console.ReadLine
            If heureLue < 1 And heureLue > 10 Then
                Console.WriteLine("la plage horaire est de 1 à 10")
            End If
        Loop Until heureLue >= 1 And heureLue <= MAXTRANCHES




        For i = 0 To MAXSALLES - 1
            If occupation(i, jourLu, heureLue) = 0 Then
                If capacité(i) >= capaciteLue Then
                    Console.WriteLine("la salle " + i.ToString + " est disponible")
                End If
            Else
                Console.WriteLine("cette salle n'est disponible")
            End If
        Next


        Console.ReadLine()
    End Sub

End Module
