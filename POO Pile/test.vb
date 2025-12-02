Module test

    Sub Main()

        Dim choix, chaine As String
        Dim p As Pile

        p = New Pile



        Do

            Console.WriteLine("1. Empiler")
            Console.WriteLine("2. Dépiler")
            Console.WriteLine("3. Tester si la Pile est vide")
            Console.WriteLine("4. Nombre d'éléments dans la Pile")
            Console.WriteLine("5. Contenu de la Pile")
            Console.WriteLine("6. Quitter")
            choix = Console.ReadLine()

            Select Case choix

                Case 1
                    Console.WriteLine("entrez votre chaine de caractere")
                    chaine = Console.ReadLine()

                    If p.empiler(chaine) Then
                        Console.WriteLine("élément empiler")
                    Else
                        Console.WriteLine("l'élément n'a pasété ajouté")
                    End If

                Case 2

                    p.depiler()

                Case 3

                    If p.est_vide() Then
                        Console.WriteLine("la pile est bien vide")
                    Else
                        Console.WriteLine("la pile n'est pas vide")
                    End If

                Case 4

                    Console.WriteLine("la pile comporte " + p.NombreElement.ToString + " élément(s)")

                Case 5

                    p.affichage()

                Case 6

                    Console.WriteLine("aurevoir !")


            End Select
            Console.ReadLine()

        Loop Until choix = 6




    End Sub

End Module
