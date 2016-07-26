<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_forma = New System.Windows.Forms.TextBox()
        Me.txt_tamanio = New System.Windows.Forms.TextBox()
        Me.btn_serializar = New System.Windows.Forms.Button()
        Me.btn_desserializar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_forma
        '
        Me.txt_forma.Location = New System.Drawing.Point(44, 43)
        Me.txt_forma.Name = "txt_forma"
        Me.txt_forma.Size = New System.Drawing.Size(100, 20)
        Me.txt_forma.TabIndex = 0
        '
        'txt_tamanio
        '
        Me.txt_tamanio.Location = New System.Drawing.Point(44, 109)
        Me.txt_tamanio.Name = "txt_tamanio"
        Me.txt_tamanio.Size = New System.Drawing.Size(100, 20)
        Me.txt_tamanio.TabIndex = 1
        '
        'btn_serializar
        '
        Me.btn_serializar.Location = New System.Drawing.Point(213, 43)
        Me.btn_serializar.Name = "btn_serializar"
        Me.btn_serializar.Size = New System.Drawing.Size(84, 23)
        Me.btn_serializar.TabIndex = 2
        Me.btn_serializar.Text = "Serializar"
        Me.btn_serializar.UseVisualStyleBackColor = True
        '
        'btn_desserializar
        '
        Me.btn_desserializar.Location = New System.Drawing.Point(213, 109)
        Me.btn_desserializar.Name = "btn_desserializar"
        Me.btn_desserializar.Size = New System.Drawing.Size(84, 23)
        Me.btn_desserializar.TabIndex = 3
        Me.btn_desserializar.Text = "DesSerializar"
        Me.btn_desserializar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 267)
        Me.Controls.Add(Me.btn_desserializar)
        Me.Controls.Add(Me.btn_serializar)
        Me.Controls.Add(Me.txt_tamanio)
        Me.Controls.Add(Me.txt_forma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_forma As System.Windows.Forms.TextBox
    Friend WithEvents txt_tamanio As System.Windows.Forms.TextBox
    Friend WithEvents btn_serializar As System.Windows.Forms.Button
    Friend WithEvents btn_desserializar As System.Windows.Forms.Button

End Class
