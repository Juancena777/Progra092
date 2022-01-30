Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        Const precioArroz As Double = 2.0
        Const precioFrijol As Double = 1.75
        Const precioAzucar As Double = 2.5
        Const IVA As Double = 0.12

        Dim pagoSinIVA As Double = 0
        Dim valorIVA As Double = 0
        Dim pagoConIVA As Double = 0
        Dim descuento As Double = 0
        Dim pagoFinal As Double = 0

        Label9.Text = 0
        Label10.Text = 0
        Label11.Text = 0
        Label12.Text = 0
        Label13.Text = 0
    End Sub
    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pagoSinIVA = (Val(TextBox1.Text) * precioArroz) + (Val(TextBox2.Text) * precioFrijol) + (Val(TextBox3.Text) * precioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        pagoFinal = pagoConIVA - descuento



        Label9.Text = pagoSinIVA
        Label10.Text = valorIVA
        Label11.Text = pagoConIVA
        Label12.Text = descuento
        Label13.Text = pagoFinal
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
