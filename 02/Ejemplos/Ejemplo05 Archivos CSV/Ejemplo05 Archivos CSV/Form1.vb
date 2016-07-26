Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre, edad, telefono As String

        nombre = txt_nombre.Text
        edad = txt_edad.Text
        telefono = txt_telefono.Text

        'Descriptor de archivo que nos servira para hacer un enlace logico 
        'al archivo fisico
        Dim fd As System.IO.StreamWriter


        fd = My.Computer.FileSystem.OpenTextFileWriter("C:\personas.csv", True)

        Dim registro As String
        registro = nombre & "," & edad & "," & telefono

        fd.WriteLine(registro)

        fd.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ventana As New Form2
        ventana.Show()

    End Sub
End Class
