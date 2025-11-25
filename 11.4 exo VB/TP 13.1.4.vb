Imports System.ComponentModel

Module TP_13_1_4

    Sub change(ByVal montant As Double, ByVal position As Double)
        Dim calcul As Double
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM", "LUF", "NLG", "GRD", "SIT", "PTE", "CYP", "MTL", "SKK"}
        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94, 40.33, 2.2, 340.75, 239.64, 200.48, 0.58, 0.42, 30.12}

        calcul = montant * taux(position)
        Console.WriteLine("Montant dans l'ancienne monnaie nationale : " + calcul.ToString)

    End Sub

    Sub main()
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM", "LUF", "NLG", "GRD", "SIT", "PTE", "CYP", "MTL", "SKK"}
        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94, 40.33, 2.2, 340.75, 239.64, 200.48, 0.58, 0.42, 30.12}



        Dim montant, position, continuer As Double
        Dim devise, check As String


        Do
            check = "no"
            Do
                Console.WriteLine("quel est votre montant")
                montant = Console.ReadLine
                If montant < 0 Then
                    Console.WriteLine("votre montant ne peux pas être inférieur à 0")
                End If
            Loop Until montant >= 0

            Do
                Console.WriteLine("quel est la devise que vous souhaitez ?(en majuscule)")
                devise = Console.ReadLine
                For i = 0 To 15
                    If devises(i) = devise Then
                        check = "ok"
                        position = i
                    End If

                Next
                If check = "no" Then
                    Console.WriteLine("votre devise n'est pas disponible")
                End If
            Loop Until check = "ok"

            change(montant, position)

            Console.ReadLine()
            Do
                Console.WriteLine("voulez-vous continuer ? 0 pour continuer ou 1 pour arreter")
                continuer = Console.ReadLine
                If continuer <> 1 And continuer <> 0 Then
                    Console.WriteLine("votre choix doit etre 0 pour continuer ou 1 pour arreter")
                End If
            Loop Until continuer = 1 Or continuer = 0

        Loop Until continuer = 1
    End Sub

End Module
