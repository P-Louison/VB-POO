Module Compteur_test

    Sub main()

        Dim essai As Compteur

        essai = New Compteur(25)
        Console.WriteLine(essai.GetValeur())

        essai.PlusUn()
        Console.WriteLine(essai.GetValeur())

        essai.DecrementeDe(6)
        Console.WriteLine(essai.GetValeur())

        essai.IncrementeDe(10)
        Console.WriteLine(essai.GetValeur())

        essai.IncrementeDe(-10)
        Console.WriteLine(essai.GetValeur())

        essai.Raz()
        Console.WriteLine(essai.GetValeur())

        Console.ReadLine()

        Dim cB, cC As Compteur

        cB = New Compteur(50)
        cC = New Compteur(0)

        cC.Raz()
        cC.IncrementeDe(Int(cB))
        Console.WriteLine(cB.ToString + cC.ToString)

        cB.PlusUn()
        Console.WriteLine(cB.ToString + cC.ToString)






    End Sub


End Module
