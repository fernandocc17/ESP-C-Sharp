Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("cargando")
        lb_edad.Items.Clear()
        lb_nombre.Items.Clear()
        lb_telefono.Items.Clear()

        Dim lector As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\personas.csv")


        lector.TextFieldType = FileIO.FieldType.Delimited
        lector.SetDelimiters(",")

        Dim registro As String()
        MsgBox(lector.ToString)
        While Not lector.EndOfData
            MsgBox("Leyendo")
            registro = lector.ReadFields
            lb_nombre.Items.Add(registro(0))
            lb_edad.Items.Add(registro(1))
            lb_telefono.Items.Add(registro(2))
        End While

        lector.Close()
    End Sub

End Class