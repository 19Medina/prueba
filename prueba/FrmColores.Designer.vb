<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColores
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnMorado = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnNegro = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.Red
        Me.btnRojo.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRojo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRojo.Location = New System.Drawing.Point(67, 67)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(106, 42)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnVerde
        '
        Me.btnVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVerde.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerde.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVerde.Location = New System.Drawing.Point(67, 143)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(106, 41)
        Me.btnVerde.TabIndex = 1
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = False
        '
        'btnMorado
        '
        Me.btnMorado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMorado.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMorado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMorado.Location = New System.Drawing.Point(67, 222)
        Me.btnMorado.Name = "btnMorado"
        Me.btnMorado.Size = New System.Drawing.Size(106, 43)
        Me.btnMorado.TabIndex = 2
        Me.btnMorado.Text = "Morado"
        Me.btnMorado.UseVisualStyleBackColor = False
        '
        'btnAzul
        '
        Me.btnAzul.BackColor = System.Drawing.Color.Blue
        Me.btnAzul.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAzul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAzul.Location = New System.Drawing.Point(67, 294)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(106, 45)
        Me.btnAzul.TabIndex = 3
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = False
        '
        'btnNegro
        '
        Me.btnNegro.BackColor = System.Drawing.Color.Black
        Me.btnNegro.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNegro.Location = New System.Drawing.Point(67, 370)
        Me.btnNegro.Name = "btnNegro"
        Me.btnNegro.Size = New System.Drawing.Size(106, 40)
        Me.btnNegro.TabIndex = 4
        Me.btnNegro.Text = "Negro"
        Me.btnNegro.UseVisualStyleBackColor = False
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(286, 55)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(519, 355)
        Me.txtColores.TabIndex = 5
        '
        'FrmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(972, 489)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnNegro)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnMorado)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "FrmColores"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnMorado As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents btnNegro As Button
    Friend WithEvents txtColores As TextBox
End Class
