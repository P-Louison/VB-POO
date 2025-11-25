Module TP_11_2

    Function Factoriel(ByVal nombre As Double) As Double
        For i = 1 To nombre - 1
            nombre = nombre * i
        Next

        Return nombre
    End Function

    Sub main()
        Dim valeur As Double
        Console.WriteLine("Saisir un nombre >= 0")

        Do
            valeur = Console.ReadLine()
            If valeur < 0 Then
                Console.WriteLine("Saisir un nombre >= 0")
            ElseIf valeur = 0 Or valeur = 1 Then
                Console.WriteLine("La factorielle de ce nombre est 1")
                Console.WriteLine("au revoir")
            End If

        Loop Until valeur > 0

        Console.WriteLine("La factorielle de ce nombre est " + Factoriel(valeur).ToString)
        Console.WriteLine("au revoir")
        Console.ReadLine()
    End Sub
End Module
