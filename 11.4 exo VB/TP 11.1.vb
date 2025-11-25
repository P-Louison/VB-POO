Module TP_11_1
    Function PerimetreCercle(ByVal pRayon As Double) As Double
        Return 2 * System.Math.PI * pRayon
    End Function

    Function SurfaceCercle(ByVal pRayon As Double) As Double
        Return System.Math.PI * pRayon ^ 2
    End Function

    Function PerimetreRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return 2 * pLongueur + 2 * pLargeur
    End Function

    Function SurfaceRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return pLargeur * pLongueur
    End Function

    Sub main()

        Dim choix, valeurLargeur, valeurLongeur, valeurCercle As Double

        Do
            Console.WriteLine("1. Calcul du périmètre d'un cercle.")
            Console.WriteLine("2. Calcul de la surface d'un cercle.")
            Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
            Console.WriteLine("4. Calcul de la surface d'un rectangle.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("votre choix ?")
            choix = Console.ReadLine

            Select Case choix
                Case 1
                    Do

                        Console.WriteLine("Rayon du cercle ? (Rayon > 0)")
                        valeurCercle = Console.ReadLine()
                        If valeurCercle < 0 Then
                            Console.WriteLine("la valeur doit être supérieur à 0")
                        End If

                    Loop Until valeurCercle > 0
                    Console.WriteLine("Périmètre: " + PerimetreCercle(valeurCercle).ToString)
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 2
                    Do

                        Console.WriteLine("surface du cercle ? (Rayon > 0)")
                        valeurCercle = Console.ReadLine()
                        If valeurCercle < 0 Then
                            Console.WriteLine("la valeur doit être supérieur à 0")
                        End If

                    Loop Until valeurCercle > 0
                    Console.WriteLine("Surface: " + SurfaceCercle(valeurCercle).ToString)
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 3
                    Do

                        Console.WriteLine("Longeur du rectangle ? (supérieur à 0)")
                        valeurLongeur = Console.ReadLine
                        Console.WriteLine("largeur du rectangle ? (supérieur à 0)")
                        valeurLargeur = Console.ReadLine
                        If valeurLargeur <= 0 Or valeurLongeur <= 0 Then
                            Console.WriteLine("les deux valeurs doivent être supérieur à 0")
                        End If

                    Loop Until valeurLongeur > 0 And valeurLargeur > 0
                    Console.WriteLine("Périmètre:" + PerimetreRectangle(valeurLongeur, valeurLargeur).ToString)
                    Console.WriteLine(". . . Rappel menu . . .")


                Case 4
                    Do

                        Console.WriteLine("Longeur du rectangle ? (supérieur à 0)")
                        valeurLongeur = Console.ReadLine
                        Console.WriteLine("largeur du rectangle ? (supérieur à 0)")
                        valeurLargeur = Console.ReadLine
                        If valeurLargeur <= 0 Or valeurLongeur <= 0 Then
                            Console.WriteLine("les deux valeurs doivent être supérieur à 0")
                        End If

                    Loop Until valeurLongeur > 0 And valeurLargeur > 0

                    Console.WriteLine("Périmètre:" + SurfaceRectangle(valeurLongeur, valeurLargeur).ToString)
                    Console.WriteLine(". . . Rappel menu . . .")

            End Select

            If choix > 5 Then
                Console.WriteLine("Choix erroné.")
            End If
            Console.WriteLine(". . . Rappel menu . . .")

        Loop Until choix = 5
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
