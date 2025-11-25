Module TP_7_3
    Sub main()
        Dim tauxhoraire, nbHeureTravaille, salaireHebdomadaire As Double

        Console.WriteLine("Nombre d'heures travaillees hebdomadaire ?")
        nbHeureTravaille = Console.ReadLine()

        If nbHeureTravaille < 39 Then
            Console.WriteLine("Vous ne travaillez pas assez !")
            Console.WriteLine("Salaire hebdomadaire : 0")

        ElseIf nbHeureTravaille >= 39 And nbHeureTravaille <= 47 Then
            Console.WriteLine("Taux horaire ?")
            tauxhoraire = Console.ReadLine()
            salaireHebdomadaire = (39 * tauxhoraire) + (nbHeureTravaille - 39) * (tauxhoraire * 1.25)
            Console.WriteLine("Salaire hebdomadaire : " + salaireHebdomadaire.ToString)

        ElseIf nbHeureTravaille > 47 Then
            Console.WriteLine("Taux horaire ?")
            tauxhoraire = Console.ReadLine()
            salaireHebdomadaire = (39 * tauxhoraire) + (8 * (tauxhoraire * 1.25)) + ((nbHeureTravaille - 47) * (tauxhoraire * 1.5))
            Console.WriteLine("Salaire hebdomadaire : " + salaireHebdomadaire.ToString)

        End If

        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
