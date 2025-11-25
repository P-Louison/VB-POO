Module TP_11_4
    Sub Main()
        Dim lignes As Double
        Dim etoiles As String
        Console.WriteLine("Combien de lignes pour votre triangle ? (>=0)")
        lignes = Console.ReadLine()
        etoiles = "*"
        If lignes <= 0 Then
            Console.WriteLine("Erreur. > 0.")
        End If
        For i = 0 To lignes - 1
            For j = 0 To lignes - 1
                Console.Write(" ")
            Next
            Console.WriteLine(etoiles)
            lignes -= 1
            etoiles += "**"
        Next
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub
End Module
