Public Class frmConversao

    Function ConverterGrausParaMinutosSegundos(ByVal grausDecimais As Decimal) As String
        Try
            Dim decimalGrauAbs As Decimal = Math.Abs(grausDecimais)

            Dim valorRetornado As String = "'"
            Dim grauSimbolo As String = "°"
            Dim minutoSimbolo As String = "´"
            Dim segundoSimbolo As String = """"

            Dim Graus As String = Math.Truncate(decimalGrauAbs) & grauSimbolo
            Dim minutosDecimal As Decimal = (decimalGrauAbs - Math.Truncate(decimalGrauAbs)) * 60
            Dim segundosDecimal As Decimal = (minutosDecimal - Math.Truncate(minutosDecimal))
            Dim Minutos As String = Math.Truncate(minutosDecimal) & minutoSimbolo
            Dim Segundos As String = String.Format("{0:##.0000}", (segundosDecimal * 60)) & segundoSimbolo

            valorRetornado = Graus & " " & Minutos & " " & Segundos
            Return valorRetornado

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub txtGraus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGraus.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ",")
    End Sub

    Private Sub txtGraus_TextChanged(sender As Object, e As EventArgs) Handles txtGraus.TextChanged
        If (txtGraus.Text Is Nothing Or txtGraus.Text.Trim().Length < 1) Then
            btnConverter.Enabled = False
        Else
            btnConverter.Enabled = True
        End If
    End Sub

    Private Sub btnConverter_Click(sender As Object, e As EventArgs) Handles btnConverter.Click
        Dim valor As Decimal

        If (String.IsNullOrWhiteSpace(txtGraus.Text)) Then
            MessageBox.Show("Informe um valor em graus...")
        Else
            valor = Convert.ToDecimal(txtGraus.Text)
        End If

        Try
            txtMinutosSegundos.Text = ConverterGrausParaMinutosSegundos(valor)
        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class
