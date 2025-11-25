Module TP_13_2

    Sub AfficherMatrice(ByRef pMatrice(,) As Double)

        For i = 0 To 3
            For j = 0 To 3
                Console.Write(pMatrice(i, j).ToString + vbTab)
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
    End Sub

    Sub echanger(ByRef pA As Double, ByRef pB As Double)
        Dim pC As Double
        pC = pA
        pA = pB
        pB = pC

    End Sub

    Sub InverserLignesMatrices(ByRef pMatrice(,) As Double)
        Dim c As Double
        For i = 0 To 3
            For j = c To 3
                echanger(pMatrice(i, j), pMatrice(j, i))

            Next
            c += 1
        Next
    End Sub

    Sub main()

        Dim pMatrice(,) As Double = {
        {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}
        }
        AfficherMatrice(pMatrice)
        Console.WriteLine()
        InverserLignesMatrices(pMatrice)
        Console.WriteLine()
        AfficherMatrice(pMatrice)
        Console.WriteLine()

        Console.ReadLine()

    End Sub


End Module
