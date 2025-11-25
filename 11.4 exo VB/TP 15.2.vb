Module TP_15_2
    Const MAX As Double = 5

    Structure TMatériel
        Dim noSerie As String
        Dim modèle As String
        Dim type As String
        Dim annéeDAchat As Integer
    End Structure

    Function SaisirMatériel() As TMatériel
        Dim materiel As TMatériel

        Console.WriteLine("quel est le numéro de série ?")
        materiel.noSerie = Console.ReadLine()
        Console.WriteLine("quel est le modèle ?")
        materiel.modèle = Console.ReadLine()
        Console.WriteLine("quel est le type ?")
        materiel.type = Console.ReadLine()
        Console.WriteLine("quel est l'année d'achat ?")
        materiel.annéeDAchat = Console.ReadLine()

        Return materiel

    End Function

    Sub AfficherUnMatériel(ByVal pUnMatériel As TMatériel)
        Console.WriteLine("le numero de série est  : " + pUnMatériel.noSerie)
        Console.WriteLine("le modèle est : " + pUnMatériel.modèle)
        Console.WriteLine("le type de matériel est  : " + pUnMatériel.type)
        Console.WriteLine("l'année d'achat est : " + pUnMatériel.annéeDAchat.ToString)
    End Sub




    Sub AfficherLesMatériels(ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer)
        Dim i As Double = 0

        For i = 0 To pPosLibre - 1
            AfficherUnMatériel(pLesMatériels(i))
        Next

    End Sub




    Function AjouterUnMatériel(ByVal pMatériel As TMatériel, ByRef pLesMatériels() As TMatériel, ByRef pPosLibre As Integer) As Boolean

        If pPosLibre > MAX Then
            Return False
        Else
            pLesMatériels(pPosLibre) = pMatériel
            pPosLibre += 1
            Return True
        End If


    End Function

    Function SupprimerParIndex(ByVal pIndex As Integer, ByRef pLesMatériels() As TMatériel, ByRef pPosLibre As Integer) As Boolean
        Dim i As Double = 0
        Dim x As Double = 0

        If pPosLibre <= 0 Then
            Return False
        End If

        For x = pIndex To pPosLibre - 2
            pLesMatériels(x) = pLesMatériels(x + 1)
        Next

        pPosLibre -= 1

        Return True

    End Function



    Function SupprimerParNoSérie(ByVal pNoSérie As String, ByRef pLesMatériels() As TMatériel, ByRef pPosLibre As Integer) As Boolean
        Dim i As Double = 0

        For i = 0 To pPosLibre
            If pNoSérie = pLesMatériels(i).noSerie Then
                SupprimerParIndex(i, pLesMatériels, pPosLibre)
                Return True
            ElseIf i > pPosLibre Then
                Return False
            End If
        Next

        Return False
    End Function







    Sub main()
        Dim pLesMatériels(MAX) As TMatériel
        Dim choix As Double
        Dim pPosLibre As Double = 0
        Dim index As Double = 0
        Dim noserie As String


        Do
            Console.WriteLine("-----------------------")
            Console.WriteLine("1. Ajouter un matériel dans le tableau.")
            Console.WriteLine("2. Supprimer un matériel (saisie index)")
            Console.WriteLine("3. Supprimer un matériel (saisie n° série).")
            Console.WriteLine("4. Lister à l'écran tous les matériels.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("quel est votre choix ?")
            Console.WriteLine(pPosLibre.ToString)

            choix = Console.ReadLine()

            Select Case choix

                Case 1
                    If AjouterUnMatériel(SaisirMatériel(), pLesMatériels, pPosLibre) = True Then
                        Console.WriteLine("ajout validé")
                    Else
                        Console.WriteLine("ajout échoué")
                    End If
                    Console.WriteLine(pPosLibre.ToString)

                Case 2
                    Do
                        Console.WriteLine("quel est l'index que vous souhaitez supprimer ?")
                        index = Console.ReadLine()
                        If index < 0 Or index > pPosLibre Then
                            Console.WriteLine("votre index n'exite pas !!")
                        End If
                    Loop Until index >= 0 And index < pPosLibre



                    If SupprimerParIndex(index, pLesMatériels, pPosLibre) = True Then
                        Console.WriteLine("le matériel a bien été supprimé !")
                    Else
                        Console.WriteLine("échec de la supprision")
                    End If
                    Console.WriteLine(pPosLibre.ToString)

                Case 3

                    Console.WriteLine("quel est le numéro de série")
                    noserie = Console.ReadLine()

                    If SupprimerParNoSérie(noserie, pLesMatériels, pPosLibre) = True Then
                        Console.WriteLine("le matériel a bien été supprimé !")
                    Else
                        Console.WriteLine("échec de la supprision")
                    End If
                    Console.WriteLine(pPosLibre.ToString)


                Case 4

                    If pLesMatériels(0).noSerie = "" Then
                        Console.WriteLine("vous avez aucun matériels de stocké")
                    Else
                        AfficherLesMatériels(pLesMatériels, pPosLibre)
                    End If
                    Console.WriteLine(pPosLibre.ToString)

            End Select


            Console.ReadLine()
        Loop Until choix = 5
    End Sub

End Module
