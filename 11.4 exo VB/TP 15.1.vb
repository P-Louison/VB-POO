Module TP_15_1






    'A finir Clientpourunecommande avec des boucle While, tant que l'on ne trouve pas avec un compteur 
    'deux return a mettre
    'faire le client vide a la toute fin si On ne trouve pas de commande










    Const MAX As Integer = 2

    Structure TClient
        Dim code As String
        Dim nom As String
        Dim adresse As String
    End Structure

    Structure TCommande
        Dim numéro As Integer
        Dim dateC As String
        Dim montant As Double
        Dim codeClient As String
    End Structure

    Sub AfficherUnClient(ByVal pUnClient As TClient)
        If pUnClient.code = "X" Then
            Console.WriteLine("Client ou commande non trouvé(e)")
        End If
        Console.WriteLine("le code client est : " + pUnClient.code.ToString)
        Console.WriteLine("le nom du client est : " + pUnClient.nom.ToString)
        Console.WriteLine("l'adresse du client est : " + pUnClient.adresse.ToString)
    End Sub

    Function ClientPourUneCommande(ByVal pNuméroCommande As Integer, ByVal pTabCommandes() As TCommande, ByVal pTabClients() As TClient) As TClient
        Dim client As TClient
        Dim code As String
        code = ""


        For i = 0 To MAX
            If pNuméroCommande = pTabCommandes(i).numéro Then
                code = pTabCommandes(i).codeClient
            Else
                client.code = "X"
                client.nom = ""
                client.adresse = ""
                Return client
            End If
        Next

        For i = 0 To MAX
            If code = pTabClients(i).code Then
                client.code = pTabClients(i).code
                client.nom = pTabClients(i).nom
                client.adresse = pTabClients(i).adresse
                Return client

            End If
        Next
        Return client
    End Function

    Function MontantCommandé(ByVal pCodeClient As String, ByVal pTabCommandes() As TCommande) As Double
        Dim montant As Double

        For i = 0 To MAX

            If pCodeClient = pTabCommandes(i).codeClient Then
                montant = montant + pTabCommandes(i).montant
            End If

        Next
        Return montant

    End Function

    Sub Main()
        Dim lesClients(MAX) As TClient
        Dim lesCommandes(MAX) As TCommande
        Dim code, continuer As String
        Dim num, choix, correct As Integer


        lesClients(0).code = "C01"
        lesClients(0).nom = "NomC01"
        lesClients(0).adresse = "AdresseC01"

        lesClients(1).code = "C02"
        lesClients(1).nom = "NomC02"
        lesClients(1).adresse = "AdresseC02"

        lesClients(2).code = "C03"
        lesClients(2).nom = "NomC03"
        lesClients(2).adresse = "AdresseC03"

        lesCommandes(0).numéro = 1
        lesCommandes(0).dateC = "01-01-01"
        lesCommandes(0).montant = 100
        lesCommandes(0).codeClient = "C02"


        lesCommandes(1).numéro = 22
        lesCommandes(1).dateC = "02-01-02"
        lesCommandes(1).montant = 200
        lesCommandes(1).codeClient = "C01"

        lesCommandes(2).numéro = 42
        lesCommandes(2).dateC = "02-01-03"
        lesCommandes(2).montant = 300
        lesCommandes(2).codeClient = "C02"

        continuer = "oui"




        Do
            Console.WriteLine("0 - montant total des commandes")
            Console.WriteLine("1 - Détails d'un client pour une commande (n° de commande)")
            Console.WriteLine("2 - quitter")
            choix = Console.ReadLine()
            Select Case choix

                Case 0
                    correct = 0
                    Do

                        Console.WriteLine("quel client voulez vous ? ( code client )")
                        code = Console.ReadLine()
                        For i = 0 To MAX
                            If code <> lesClients(i).code Then
                                correct = 0
                            Else
                                correct = 1
                            End If
                        Next
                        Console.WriteLine("ce client n'exite pas !")
                    Loop Until correct = 1
                    Console.WriteLine("le montant total du client est : " + MontantCommandé(code, lesCommandes).ToString)

                Case 1

                    correct = 0
                    Console.WriteLine("quel commande souhaitez vous regarder ?")
                    code = Console.ReadLine()
                    AfficherUnClient(ClientPourUneCommande(num, lesCommandes, lesClients))

                Case 2
                    continuer = "non"
            End Select

        Loop Until continuer = "non"

        Console.ReadLine()
    End Sub
End Module