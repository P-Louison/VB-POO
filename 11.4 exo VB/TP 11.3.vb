Module TP_11_3
    Const c = 300000

    Function dilatation(ByVal deltaT As Double, ByVal vitesse As Double) As Double
        Return deltaT / Math.Sqrt(1 - (vitesse * vitesse / (c ^ 2)))
    End Function
    Function contraction(ByVal longueurFusee As Double, ByVal vitesse As Double) As Double
        Return longueurFusee * Math.Sqrt(1 - (vitesse * vitesse) / (c ^ 2))
    End Function
    Function composition(ByVal vitesse As Double, ByVal vitesseObus As Double)
        Return (vitesseObus + vitesse) / (1 + (vitesseObus * vitesse) / (c ^ 2))
    End Function

    Sub main()
        Dim choix, valun, valdeux As Double


        Do
            Console.WriteLine("1. La dilatation du temps")
            Console.WriteLine("2. La contraction des longueurs")
            Console.WriteLine("3. Loi de composition des vitesses")
            Console.WriteLine("4. Quitter")
            choix = Console.ReadLine()

            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        valun = Console.ReadLine()
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        valdeux = Console.ReadLine()
                    Loop Until valun > 0 And valdeux > 0

                    Console.WriteLine("Durée écoulée sur la terre = " + dilatation(valdeux, valun).ToString)
                    Console.ReadLine()

                Case 2
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        valun = Console.ReadLine()
                        Console.WriteLine("Taille de la fusée (en kms)?")
                        valdeux = Console.ReadLine()
                    Loop Until valun > 0 And valdeux > 0
                    Console.WriteLine("Durée écoulée sur la terre = " + contraction(valdeux, valun).ToString)
                    Console.ReadLine()

                Case 3
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        valun = Console.ReadLine()
                        Console.WriteLine("Vitesse de l'obus, dans le repère de la fusée (en km/s) ?")
                        valdeux = Console.ReadLine()
                    Loop Until valun > 0 And valdeux > 0
                    Console.WriteLine("Durée écoulée sur la terre = " + composition(valun, valdeux).ToString)
                    Console.ReadLine()
            End Select

            If choix <= 0 Or choix >= 5 Then
                Console.WriteLine("choix erroné")
            End If


        Loop Until choix = 4
        Console.WriteLine("Au revoir.")
        Console.ReadLine()






    End Sub
End Module
