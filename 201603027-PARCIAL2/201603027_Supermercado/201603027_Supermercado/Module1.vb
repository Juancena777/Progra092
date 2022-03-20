Module Module1



    Public nombres(5) As String
        Public tipos(5) As String
        Public invs(5) As String
        Public cants(5) As String
        Public unidades(5) As String
        Public sobrantes(5) As String
        Public totales(5) As String
        Public contador = 0
        Friend Sub Aceptar(tipo As String, nombre As String, inv As Integer, cant As Integer)
            If contador < 6 Then
                Dim packs, sobrante As Integer
                Dim precio As Double
                Select Case tipo
                    Case "JUGOS"
                        precio = 8.5
                    Case "FRITURAS"
                        precio = 11.2
                    Case "GALLETAS"
                        precio = 4.25
                    Case "BATERIAS"
                        precio = 15
                End Select
                packs = inv \ cant
                sobrante = inv Mod cant
                If packs >= 10 Then
                    precio = precio - (precio * 0.1)
                ElseIf packs >= 5 Then
                    precio = precio - (precio * 0.05)
                ElseIf packs >= 3 Then
                    precio = precio - (precio * 0.03)
                End If

                nombres(contador) = nombre
                tipos(contador) = tipo
                invs(contador) = inv
                cants(contador) = packs
                unidades(contador) = cant
                sobrantes(contador) = sobrante
                totales(contador) = precio * cant
                contador = contador + 1
                MsgBox("Se guardaron los datos exitosamente")
            Else
                MsgBox("No se pueden agregar mas datos")
            End If
            MostrarVectores()
        End Sub

        Sub MostrarVectores()
            Form1.DataGridView1.Rows.Clear()
            For i As Integer = 0 To contador - 1
                Form1.DataGridView1.Rows.Add(nombres(i), tipos(i), invs(i), cants(i), unidades(i), sobrantes(i), totales(i))
            Next
        End Sub

    End Module
