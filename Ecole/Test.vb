Module Test

    Sub main()



        'Dim prof As Enseignant

        'prof = New Enseignant("E0112", "Dupont", "Pierre", "1, rue de la Paix - 75000 PARIS", "0145045540", "1/10/1980", 8, 20)
        'Console.WriteLine(prof.ToString())

        'Console.WriteLine(prof.GetSalaireMensuel())
        'prof.SetAugmenterIndice(2)
        'Console.WriteLine(prof.GetIndice())
        'prof.SetAugmenterIndice(10)
        'Console.WriteLine(prof.GetIndice())
        'Console.WriteLine(prof.GetSalaireMensuel())



        Dim eleve As Eleve

        eleve = New Eleve("112", "Martin", "Pierre", "7, rue de la Paix 77000 MELUN", "0164024532", "23/07/02", "BTSSIO1")
        Console.WriteLine(eleve.ToString())



        eleve.setNote(1, 15)
        eleve.setNote(2, 15)
        eleve.setNote(3, 15)
        eleve.setNote(4, 15)
        eleve.setNote(5, 15)
        eleve.setNote(6, 15)
        eleve.setNote(7, 15)
        eleve.setNote(8, 15)
        eleve.setNote(9, 15)
        eleve.setNote(0, 15)



        If eleve.Moyennes() = False Then
            Console.WriteLine("Aucune note: impossible de calculer la moyenne générale.")
        Else
            Console.WriteLine(eleve.Moyennes())
        End If

        Console.WriteLine(eleve.ToString())

        Console.ReadLine()
    End Sub

End Module
