Module TP_7_1

    Sub main()
        Dim montant As Double
        Dim remise As Double
        remise = 0
        Console.WriteLine("Veuillez taper votre montant")
        montant = Console.ReadLine()
        If montant < 2000 Then
            remise = montant
            Console.WriteLine("pas de remise")
            Console.WriteLine("Le montant net est : " + remise.ToString())

        End If
        If montant >= 2000 And montant < 5000 Then
            remise = montant * 0.99
            Console.WriteLine("Remise de 1%")
            Console.WriteLine("Le montant net est : " + remise.ToString())
        End If
        If montant >= 5000 Then
            remise = montant * 0.98
            Console.WriteLine("Remise de 2%")
            Console.WriteLine("Le montant net est : " + remise.ToString())

        End If
        Console.WriteLine("Au revoir")
    End Sub
End Module
