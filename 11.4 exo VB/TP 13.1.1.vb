Module TP_13_1_1

	Sub main()

		Dim mois() As String = {"janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre"}
		Dim choix As Double
		Dim nom As String
		Do
			Console.WriteLine("quel mois cherches-tu ? (-1 pour sortir)")
			choix = Console.ReadLine

		Loop Until choix > 0 And choix <= 12
		nom = mois(choix - 1)
		Console.WriteLine("le mois que vous cherchez est le mois : " + nom.ToString)
		Console.ReadLine()



	End Sub



End Module
