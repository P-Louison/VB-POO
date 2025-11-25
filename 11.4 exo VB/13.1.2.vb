Module TP_13_1_2

    Sub maxmin()
        Dim tabval(10) As Double
        Dim nbmax, nbmin As Double

        For i = 0 To 9

            Console.WriteLine("nombre n° " + i.ToString)
            tabval(i) = Console.ReadLine
        Next
        nbmax = tabval(0)
        nbmin = tabval(0)

        For i = 1 To 9


            If tabval(i) > nbmax Then
                nbmax = tabval(i)
            ElseIf tabval(i) < nbmin Then
                nbmin = tabval(i)
            End If

        Next

        Console.WriteLine("min = " + nbmin.ToString)
            Console.WriteLine("max = " + nbmax.ToString)

        Console.WriteLine("au revoir")
        Console.ReadLine()

    End Sub


    Sub main()

        maxmin()

    End Sub


End Module
