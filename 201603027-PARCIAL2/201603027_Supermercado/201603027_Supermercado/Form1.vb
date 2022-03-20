Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo.Items.Add("JUGOS")
        Combo.Items.Add("FRITURAS")
        Combo.Items.Add("GALLETAS")
        Combo.Items.Add("BATERIAS")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim tipo As String
        Dim nombre As String
        Dim inv, cant As Integer
        tipo = Combo.Text
        nombre = TextBox1.Text
        inv = Val(TextBox2.Text)
        cant = Val(TextBox3.Text)
        If tipo IsNot "" And nombre IsNot "" Then
            If inv > 0 And cant > 0 Then
                Module1.Aceptar(tipo, nombre, inv, cant)
            Else
                MsgBox("DATO NO VALIDO")
            End If
        Else
            MsgBox("LLENAR LA INFORMACION")
        End If
    End Sub

    Private Sub LimpiarDataGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDataGridViewToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        MsgBox("SE LIMPIAN DATOS")
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        ReDim nombres(5), tipos(5), invs(5), cants(5), sobrantes(5), totales(5)
        contador = 0
        MsgBox("LIMPIEZA TOTAL")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Pregunta = MsgBox("TODO SE VA A CERRAR JIJI", vbYesNo + vbQuestion)
        If Pregunta = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo.SelectedIndexChanged

    End Sub
End Class
