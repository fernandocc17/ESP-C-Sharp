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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(125, 41)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(125, 84)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(100, 20)
        Me.txt_edad.TabIndex = 1
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(125, 128)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 111)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Grabar a archivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(25, 47)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 111)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Ver registros"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 335)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_edad As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
