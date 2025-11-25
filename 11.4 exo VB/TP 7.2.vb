Module TP_7_2
    Sub main()
        Dim nbJourDeLocation, nbKm, tarifJourEssence, tarifJourDiesel As Double

        Console.WriteLine("Nombre de jours de location ?")
        nbJourDeLocation = Console.ReadLine()
        Console.WriteLine("Distance à parcourir ?")
        nbKm = Console.ReadLine()

        tarifJourEssence = 30 * nbJourDeLocation + 0.85 * nbKm
        tarifJourDiesel = 35 * nbJourDeLocation + 0.65 * nbKm

        If tarifJourEssence < tarifJourDiesel Then
            Console.WriteLine("Meilleur choix : Essence")

        ElseIf tarifJourEssence = tarifJourDiesel Then
            Console.WriteLine("il n'y a pas de meilleur choix !")


        Else
            Console.WriteLine("Meilleur choix : Diesel")


        End If

        Console.WriteLine("Au revoir")
    End Sub
End Module
