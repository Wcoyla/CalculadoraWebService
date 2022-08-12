Public Class Form1
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Sumar(txtNro1.Text, txtNro2.Text)
        MessageBox.Show("El resultado de la suma es: " + resultado.ToString())

    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Resta(txtNro1.Text, txtNro2.Text)
        MessageBox.Show("El resultado de la resta es: " + resultado.ToString())
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Multiplicar(txtNro1.Text, txtNro2.Text)
        MessageBox.Show("El resultado de la multiplicacion es: " + resultado.ToString())
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Dividir(txtNro1.Text, txtNro2.Text)
        MessageBox.Show("El resultado de la division es: " + resultado.ToString())
    End Sub

    Private Sub btnFact_Click(sender As Object, e As EventArgs) Handles btnFact.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Fact(txtNro1.Text)
        MessageBox.Show("El Factorial del numero es: " + resultado.ToString())
    End Sub

    Private Sub btnInverso_Click(sender As Object, e As EventArgs) Handles btnInverso.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Inverso(txtNro1.Text)
        MessageBox.Show("El inverso del numero es: " + resultado.ToString())
    End Sub

    Private Sub btnPot_Click(sender As Object, e As EventArgs) Handles btnPot.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Potencia(txtNro1.Text, txtNro2.Text)
        MessageBox.Show("El resultado de la potencia es: " + resultado.ToString())
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Seno(txtNro1.Text)
        MessageBox.Show("El seno del numero es: " + resultado.ToString())
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Coseno(txtNro1.Text)
        MessageBox.Show("El coseno del numero es: " + resultado.ToString())
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        Dim servicio As New ServiceReference2.WebService1SoapClient
        Dim resultado As Double = servicio.Tangente(txtNro1.Text)
        MessageBox.Show("La tangente del numero es: " + resultado.ToString())
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtNro1_TextChanged(sender As Object, e As EventArgs) Handles txtNro1.TextChanged

    End Sub
End Class
