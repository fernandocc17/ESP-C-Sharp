<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lb_nombre = New System.Windows.Forms.ListBox()
        Me.lb_edad = New System.Windows.Forms.ListBox()
        Me.lb_telefono = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_nombre
        '
        Me.lb_nombre.FormattingEnabled = True
        Me.lb_nombre.Location = New System.Drawing.Point(12, 74)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(120, 95)
        Me.lb_nombre.TabIndex = 0
        '
        'lb_edad
        '
        Me.lb_edad.FormattingEnabled = True
        Me.lb_edad.Location = New System.Drawing.Point(160, 74)
        Me.lb_edad.Name = "lb_edad"
        Me.lb_edad.Size = New System.Drawing.Size(120, 95)
        Me.lb_edad.TabIndex = 1
        '
        'lb_telefono
        '
        Me.lb_telefono.FormattingEnabled = True
        Me.lb_telefono.Location = New System.Drawing.Point(311, 74)
        Me.lb_telefono.Name = "lb_telefono"
        Me.lb_telefono.Size = New System.Drawing.Size(120, 95)
        Me.lb_telefono.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefono"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 355)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_telefono)
        Me.Controls.Add(Me.lb_edad)
        Me.Controls.Add(Me.lb_nombre)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_nombre As System.Windows.Forms.ListBox
    Friend WithEvents lb_edad As System.Windows.Forms.ListBox
    Friend WithEvents lb_telefono As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
