Imports Microsoft.Win32

Module tp

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

    Function Factoriel(ByVal nombre As Double) As Double

        For i = 1 To nombre - 1

            nombre = nombre * i

        Next
        Return nombre
    End Function


    Sub Main()

        'Dim montant As Double
        'Dim remise As Double
        'remise = 0
        'Console.WriteLine("Veuillez taper votre montant")
        'montant = Console.ReadLine()
        'If montant < 2000 Then
        '    remise = montant
        '    Console.WriteLine("pas de remise")
        '    Console.WriteLine("Le montant net est : " + remise.ToString())

        'End If
        'If montant >= 2000 And montant < 5000 Then
        '    remise = montant * 0.99
        '    Console.WriteLine("Remise de 1%")
        '    Console.WriteLine("Le montant net est : " + remise.ToString())
        'End If
        'If montant >= 5000 Then
        '    remise = montant * 0.98
        '    Console.WriteLine("Remise de 2%")
        '    Console.WriteLine("Le montant net est : " + remise.ToString())

        'End If
        'Console.WriteLine("Au revoir")



        'Dim nbJourDeLocation, nbKm, tarifJourEssence, tarifJourDiesel As Double

        'Console.WriteLine("Nombre de jours de location ?")
        'nbJourDeLocation = Console.ReadLine()
        'Console.WriteLine("Distance à parcourir ?")
        'nbKm = Console.ReadLine()

        'tarifJourEssence = 30 * nbJourDeLocation + 0.85 * nbKm
        'tarifJourDiesel = 35 * nbJourDeLocation + 0.65 * nbKm

        'If tarifJourEssence < tarifJourDiesel Then
        '    Console.WriteLine("Meilleur choix : Essence")

        'ElseIf tarifJourEssence = tarifJourDiesel Then
        '    Console.WriteLine("il n'y a pas de meilleur choix !")


        'Else
        '    Console.WriteLine("Meilleur choix : Diesel")


        'End If

        'Console.WriteLine("Au revoir")




        'Dim tauxhoraire, nbHeureTravaille, salaireHebdomadaire As Double

        'Console.WriteLine("Nombre d'heures travaillees hebdomadaire ?")
        'nbHeureTravaille = Console.ReadLine()

        'If nbHeureTravaille < 39 Then
        '    Console.WriteLine("Vous ne travaillez pas assez !")
        '    Console.WriteLine("Salaire hebdomadaire : 0")

        'ElseIf nbHeureTravaille >= 39 And nbHeureTravaille <= 47 Then
        '    Console.WriteLine("Taux horaire ?")
        '    tauxhoraire = Console.ReadLine()
        '    salaireHebdomadaire = (39 * tauxhoraire) + (nbHeureTravaille - 39) * (tauxhoraire * 1.25)
        '    Console.WriteLine("Salaire hebdomadaire : " + salaireHebdomadaire.ToString)

        'ElseIf nbHeureTravaille > 47 Then
        '    Console.WriteLine("Taux horaire ?")
        '    tauxhoraire = Console.ReadLine()
        '    salaireHebdomadaire = (39 * tauxhoraire) + (8 * (tauxhoraire * 1.25)) + ((nbHeureTravaille - 47) * (tauxhoraire * 1.5))
        '    Console.WriteLine("Salaire hebdomadaire : " + salaireHebdomadaire.ToString)

        'End If

        'Console.WriteLine("Au revoir")
        'Console.ReadLine()

        'Dim note, nbNote, moyenneDesNotes, pourcentageDesNotes, compteurNoteMoyenne, totalDesNotes As Double
        'totalDesNotes = 0
        'compteurNoteMoyenne = 0
        'nbNote = 0
        'Console.WriteLine("Entrez une note (-1 pour fin) :")
        'note = Console.ReadLine()

        'While note > -1
        '    totalDesNotes = totalDesNotes + note
        '    nbNote += 1
        '    If note > 10 Then
        '        compteurNoteMoyenne += 1
        '    End If

        '    Console.WriteLine("Entrez une note (-1 pour fin) :")
        '    note = Console.ReadLine()
        'End While

        'moyenneDesNotes = totalDesNotes / nbNote
        'pourcentageDesNotes = (compteurNoteMoyenne / nbNote) * 100
        'Console.WriteLine("Vous avez " + pourcentageDesNotes.ToString + "% de note > à 10")
        'Console.WriteLine("Votre moyenne est de " + moyenneDesNotes.ToString)
        'Console.ReadLine()

        'Dim note, nbNote, compteur, sommesNotes, moyenne As Double

        'compteur = 0
        'nbNote = 0
        'sommesNotes = 0

        'Do
        '    Console.WriteLine("Note ? (entre 0 et 20, -1 pour sortir)")
        '    note = Console.ReadLine()

        '    If note >= 0 And note <= 20 Then
        '        nbNote += 1
        '        compteur += 1
        '        sommesNotes = sommesNotes + note

        '    Else

        '        Console.WriteLine("La note doit être entre 0 et 20")

        '    End If
        'Loop Until note = -1

        'moyenne = sommesNotes / nbNote

        'Console.WriteLine("Somme : " + sommesNotes.ToString)
        'Console.WriteLine("Compteur : " + compteur.ToString)
        'Console.WriteLine("Moyenne : " + moyenne.ToString)
        'Console.WriteLine("Au revoir")
        'Console.ReadLine()


        'Dim n, i As Integer
        'Do
        '    Console.WriteLine("Saisir le nombre :")
        '    n = Console.ReadLine()
        'Loop Until n > 0
        'For i = 1 To n
        '    If (n Mod 2) = 0 Then

        '        Console.WriteLine(n)

        '    End If
        '    n -= 1
        'Next

        'Console.ReadLine()

        'Dim commission, vente, i, totalvente As Double
        'Dim nom As String
        'Dim reponse As String

        'Do

        '    Console.WriteLine("Nom du représentant ?")
        '    nom = Console.ReadLine()
        '    totalvente = 0

        '    For i = 1 To 4

        '        Console.WriteLine("Semaine " + i.ToString + ": Ventes H.T hebdomadaires (0 pour stopper la saisie")

        '        vente = Console.ReadLine()
        '        If vente < 0 Then
        '            Console.WriteLine("Ventes ne peuvent être inférieur 0")
        '            i -= 1
        '        ElseIf vente = 0 Then
        '            i = 4
        '        Else
        '            totalvente = totalvente + vente
        '        End If
        '    Next

        '    commission = totalvente / 10

        '    Console.WriteLine("Bilan pour " + nom)
        '    Console.WriteLine("Total des ventes H.T. = " + totalvente.ToString)
        '    Console.WriteLine("Commision = " + commission.ToString)
        '    Console.WriteLine("autre représantant ?")
        '    reponse = Console.ReadLine()

        '    If reponse <> "oui" Then
        '        reponse = "non"
        '    End If


        'Loop Until reponse = "non"
        'Console.ReadLine()

        'Dim choix, valeurLargeur, valeurLongeur, valeurCercle As Double

        'Do
        '    Console.WriteLine("1. Calcul du périmètre d'un cercle.")
        '    Console.WriteLine("2. Calcul de la surface d'un cercle.")
        '    Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
        '    Console.WriteLine("4. Calcul de la surface d'un rectangle.")
        '    Console.WriteLine("5. Quitter.")
        '    Console.WriteLine("votre choix ?")
        '    choix = Console.ReadLine

        '    Select Case choix
        '        Case 1
        '            Do

        '                Console.WriteLine("Rayon du cercle ? (Rayon > 0)")
        '                valeurCercle = Console.ReadLine()
        '                If valeurCercle < 0 Then
        '                    Console.WriteLine("la valeur doit être supérieur à 0")
        '                End If

        '            Loop Until valeurCercle > 0
        '            Console.WriteLine("Périmètre: " + PerimetreCercle(valeurCercle).ToString)
        '            Console.WriteLine(". . . Rappel menu . . .")

        '        Case 2
        '            Do

        '                Console.WriteLine("surface du cercle ? (Rayon > 0)")
        '                valeurCercle = Console.ReadLine()
        '                If valeurCercle < 0 Then
        '                    Console.WriteLine("la valeur doit être supérieur à 0")
        '                End If

        '            Loop Until valeurCercle > 0
        '            Console.WriteLine("Surface: " + SurfaceCercle(valeurCercle).ToString)
        '            Console.WriteLine(". . . Rappel menu . . .")

        '        Case 3
        '            Do

        '                Console.WriteLine("Longeur du rectangle ? (supérieur à 0)")
        '                valeurLongeur = Console.ReadLine
        '                Console.WriteLine("largeur du rectangle ? (supérieur à 0)")
        '                valeurLargeur = Console.ReadLine
        '                If valeurLargeur <= 0 Or valeurLongeur <= 0 Then
        '                    Console.WriteLine("les deux valeurs doivent être supérieur à 0")
        '                End If

        '            Loop Until valeurLongeur > 0 And valeurLargeur > 0
        '            Console.WriteLine("Périmètre:" + PerimetreRectangle(valeurLongeur, valeurLargeur).ToString)
        '            Console.WriteLine(". . . Rappel menu . . .")


        '        Case 4
        '            Do

        '                Console.WriteLine("Longeur du rectangle ? (supérieur à 0)")
        '                valeurLongeur = Console.ReadLine
        '                Console.WriteLine("largeur du rectangle ? (supérieur à 0)")
        '                valeurLargeur = Console.ReadLine
        '                If valeurLargeur <= 0 Or valeurLongeur <= 0 Then
        '                    Console.WriteLine("les deux valeurs doivent être supérieur à 0")
        '                End If

        '            Loop Until valeurLongeur > 0 And valeurLargeur > 0

        '            Console.WriteLine("Périmètre:" + SurfaceRectangle(valeurLongeur, valeurLargeur).ToString)
        '            Console.WriteLine(". . . Rappel menu . . .")

        '    End Select

        '    If choix > 5 Then
        '        Console.WriteLine("Choix erroné.")
        '    End If
        '    Console.WriteLine(". . . Rappel menu . . .")

        'Loop Until choix = 5
        'Console.WriteLine("Au revoir")
        'Console.ReadLine()


        Dim valeur As Double
        Console.WriteLine("Saisir un nombre >= 0")

        Do
            valeur = Console.ReadLine()
            If valeur < 0 Then
                Console.WriteLine("Saisir un nombre >= 0")
            ElseIf valeur = 0 Or valeur = 1 Then
                Console.WriteLine("La factorielle de ce nombre est 1")
                Console.WriteLine("au revoir")
            End If

        Loop Until valeur > 0

        Console.WriteLine("La factorielle de ce nombre est " + Factoriel(valeur).ToString)
        Console.WriteLine("au revoir")
        Console.ReadLine()






    End Sub

End Module
