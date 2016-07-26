Public Class Form1

    Private Sub btn_sumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sumar.Click
        Dim n1, n2, res As Byte
        Try
            n1 = txt_n1.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try

        Try
            n2 = txt_n2.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try



        Try
            res = n1 + n2
        Catch ex As OverflowException

        Catch ex As Exception

        End Try

        lbl_res.Text = res

    End Sub

    Private Sub btn_restar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restar.Click
        Dim n1, n2, res As Byte
        Try
            n1 = txt_n1.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try

        Try
            n2 = txt_n2.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try



        Try
            res = n1 - n2
        Catch ex As OverflowException

        Catch ex As Exception

        End Try

        lbl_res.Text = res

    End Sub

    Private Sub btn_multiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_multiplicar.Click

        Dim n1, n2, res As Byte
        Try
            n1 = txt_n1.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try

        Try
            n2 = txt_n2.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try



        Try
            res = n1 * n2
        Catch ex As OverflowException

        Catch ex As Exception

        End Try

        lbl_res.Text = res

    End Sub

    Private Sub btn_dividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dividir.Click

        Dim n1, n2, res As Byte
        Try
            n1 = txt_n1.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try

        Try
            n2 = txt_n2.Text
        Catch ChuckNorris As InvalidCastException
            MsgBox(ChuckNorris.Message)
        Catch ex As OverflowException
            MsgBox("Excepcion de overflow")
        Catch ex As Exception
        End Try



        Try
            res = n1 \ n2

        Catch ex As DivideByZeroException
            MsgBox("NO SE PUEDE DIVIDIR ENTRE CERO")
        Catch ex As OverflowException

        Catch ex As Exception

        End Try

        lbl_res.Text = res


    End Sub
End Class
