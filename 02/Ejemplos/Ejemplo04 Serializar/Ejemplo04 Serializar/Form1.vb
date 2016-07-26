Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1

    Private Sub btn_serializar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_serializar.Click
        Dim v As New Vivero()
        v.forma = txt_forma.Text
        v.tamanio = txt_tamanio.Text

        Dim archivo_objeto As Stream = File.Create("v.bin")
        Dim serializador As New BinaryFormatter()
        serializador.Serialize(archivo_objeto, v)
        archivo_objeto.Close()
        txt_forma.Text = ""
        txt_tamanio.Text = ""


    End Sub

    Private Sub btn_desserializar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_desserializar.Click
        Dim V As Vivero
        If File.Exists("v.bin") Then
            Dim archivo As Stream = File.OpenRead("v.bin")
            Dim desserializador As New BinaryFormatter
            V = CType(desserializador.Deserialize(archivo), Vivero)
            txt_forma.Text = V.forma
            txt_tamanio.Text = V.tamanio
            archivo.Close()
        End If
    End Sub
End Class
