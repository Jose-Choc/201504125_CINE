<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cine
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
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblFuncion = New System.Windows.Forms.Label()
        Me.LblCine = New System.Windows.Forms.Label()
        Me.CmBxFuncion = New System.Windows.Forms.ComboBox()
        Me.CmBxCine = New System.Windows.Forms.ComboBox()
        Me.GpBxCineFuncion = New System.Windows.Forms.GroupBox()
        Me.LtBxCine = New System.Windows.Forms.ListBox()
        Me.GpBxPrecios = New System.Windows.Forms.GroupBox()
        Me.LtBxFuncion = New System.Windows.Forms.ListBox()
        Me.LtBxSubTotal = New System.Windows.Forms.ListBox()
        Me.LtBxDesc1 = New System.Windows.Forms.ListBox()
        Me.LtBxDesc2 = New System.Windows.Forms.ListBox()
        Me.LtBxTotal = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GpBxCineFuncion.SuspendLayout()
        Me.GpBxPrecios.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Chartreuse
        Me.BtnCalcular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(529, 473)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(105, 35)
        Me.BtnCalcular.TabIndex = 0
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Yellow
        Me.BtnLimpiar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(366, 473)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(105, 35)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(203, 473)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(105, 35)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblFuncion
        '
        Me.LblFuncion.AutoSize = True
        Me.LblFuncion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFuncion.Location = New System.Drawing.Point(29, 49)
        Me.LblFuncion.Name = "LblFuncion"
        Me.LblFuncion.Size = New System.Drawing.Size(83, 22)
        Me.LblFuncion.TabIndex = 3
        Me.LblFuncion.Text = "Funciones"
        Me.LblFuncion.UseCompatibleTextRendering = True
        '
        'LblCine
        '
        Me.LblCine.AutoSize = True
        Me.LblCine.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCine.Location = New System.Drawing.Point(343, 49)
        Me.LblCine.Name = "LblCine"
        Me.LblCine.Size = New System.Drawing.Size(48, 22)
        Me.LblCine.TabIndex = 4
        Me.LblCine.Text = "Cines"
        Me.LblCine.UseCompatibleTextRendering = True
        '
        'CmBxFuncion
        '
        Me.CmBxFuncion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBxFuncion.FormattingEnabled = True
        Me.CmBxFuncion.Items.AddRange(New Object() {"Función 1", "Función 2", "Función 3", "Función 4"})
        Me.CmBxFuncion.Location = New System.Drawing.Point(164, 45)
        Me.CmBxFuncion.Name = "CmBxFuncion"
        Me.CmBxFuncion.Size = New System.Drawing.Size(121, 26)
        Me.CmBxFuncion.TabIndex = 5
        '
        'CmBxCine
        '
        Me.CmBxCine.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBxCine.FormattingEnabled = True
        Me.CmBxCine.Items.AddRange(New Object() {"Cine A", "Cine B", "Cine C"})
        Me.CmBxCine.Location = New System.Drawing.Point(448, 45)
        Me.CmBxCine.Name = "CmBxCine"
        Me.CmBxCine.Size = New System.Drawing.Size(121, 26)
        Me.CmBxCine.TabIndex = 6
        '
        'GpBxCineFuncion
        '
        Me.GpBxCineFuncion.Controls.Add(Me.CmBxCine)
        Me.GpBxCineFuncion.Controls.Add(Me.CmBxFuncion)
        Me.GpBxCineFuncion.Controls.Add(Me.LblCine)
        Me.GpBxCineFuncion.Controls.Add(Me.LblFuncion)
        Me.GpBxCineFuncion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpBxCineFuncion.Location = New System.Drawing.Point(96, 56)
        Me.GpBxCineFuncion.Name = "GpBxCineFuncion"
        Me.GpBxCineFuncion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GpBxCineFuncion.Size = New System.Drawing.Size(632, 111)
        Me.GpBxCineFuncion.TabIndex = 9
        Me.GpBxCineFuncion.TabStop = False
        Me.GpBxCineFuncion.Text = "Selecciones Función y cine"
        '
        'LtBxCine
        '
        Me.LtBxCine.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtBxCine.FormattingEnabled = True
        Me.LtBxCine.ItemHeight = 17
        Me.LtBxCine.Location = New System.Drawing.Point(31, 57)
        Me.LtBxCine.Name = "LtBxCine"
        Me.LtBxCine.Size = New System.Drawing.Size(89, 174)
        Me.LtBxCine.TabIndex = 7
        '
        'GpBxPrecios
        '
        Me.GpBxPrecios.Controls.Add(Me.Label6)
        Me.GpBxPrecios.Controls.Add(Me.Label5)
        Me.GpBxPrecios.Controls.Add(Me.Label4)
        Me.GpBxPrecios.Controls.Add(Me.Label3)
        Me.GpBxPrecios.Controls.Add(Me.Label2)
        Me.GpBxPrecios.Controls.Add(Me.Label1)
        Me.GpBxPrecios.Controls.Add(Me.LtBxTotal)
        Me.GpBxPrecios.Controls.Add(Me.LtBxDesc2)
        Me.GpBxPrecios.Controls.Add(Me.LtBxDesc1)
        Me.GpBxPrecios.Controls.Add(Me.LtBxSubTotal)
        Me.GpBxPrecios.Controls.Add(Me.LtBxFuncion)
        Me.GpBxPrecios.Controls.Add(Me.LtBxCine)
        Me.GpBxPrecios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpBxPrecios.Location = New System.Drawing.Point(75, 187)
        Me.GpBxPrecios.Name = "GpBxPrecios"
        Me.GpBxPrecios.Size = New System.Drawing.Size(671, 248)
        Me.GpBxPrecios.TabIndex = 10
        Me.GpBxPrecios.TabStop = False
        Me.GpBxPrecios.Text = "Precios"
        '
        'LtBxFuncion
        '
        Me.LtBxFuncion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtBxFuncion.FormattingEnabled = True
        Me.LtBxFuncion.ItemHeight = 17
        Me.LtBxFuncion.Location = New System.Drawing.Point(135, 57)
        Me.LtBxFuncion.Name = "LtBxFuncion"
        Me.LtBxFuncion.Size = New System.Drawing.Size(89, 174)
        Me.LtBxFuncion.TabIndex = 8
        '
        'LtBxSubTotal
        '
        Me.LtBxSubTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtBxSubTotal.FormattingEnabled = True
        Me.LtBxSubTotal.ItemHeight = 17
        Me.LtBxSubTotal.Location = New System.Drawing.Point(239, 57)
        Me.LtBxSubTotal.Name = "LtBxSubTotal"
        Me.LtBxSubTotal.Size = New System.Drawing.Size(89, 174)
        Me.LtBxSubTotal.TabIndex = 9
        '
        'LtBxDesc1
        '
        Me.LtBxDesc1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtBxDesc1.FormattingEnabled = True
        Me.LtBxDesc1.ItemHeight = 17
        Me.LtBxDesc1.Location = New System.Drawing.Point(343, 57)
        Me.LtBxDesc1.Name = "LtBxDesc1"
        Me.LtBxDesc1.Size = New System.Drawing.Size(89, 174)
        Me.LtBxDesc1.TabIndex = 10
        '
        'LtBxDesc2
        '
        Me.LtBxDesc2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtBxDesc2.FormattingEnabled = True
        Me.LtBxDesc2.ItemHeight = 17
        Me.LtBxDesc2.Location = New System.Drawing.Point(447, 57)
        Me.LtBxDesc2.Name = "LtBxDesc2"
        Me.LtBxDesc2.Size = New System.Drawing.Size(89, 174)
        Me.LtBxDesc2.TabIndex = 11
        '
        'LtBxTotal
        '
        Me.LtBxTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtBxTotal.FormattingEnabled = True
        Me.LtBxTotal.ItemHeight = 17
        Me.LtBxTotal.Location = New System.Drawing.Point(551, 57)
        Me.LtBxTotal.Name = "LtBxTotal"
        Me.LtBxTotal.Size = New System.Drawing.Size(89, 174)
        Me.LtBxTotal.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cine"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Función"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Subtotal"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Descuento 1"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(447, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Descuento 2"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(551, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Cine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 531)
        Me.Controls.Add(Me.GpBxCineFuncion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GpBxPrecios)
        Me.Name = "Cine"
        Me.Text = "Cine"
        Me.GpBxCineFuncion.ResumeLayout(False)
        Me.GpBxCineFuncion.PerformLayout()
        Me.GpBxPrecios.ResumeLayout(False)
        Me.GpBxPrecios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblFuncion As Label
    Friend WithEvents LblCine As Label
    Friend WithEvents CmBxFuncion As ComboBox
    Friend WithEvents CmBxCine As ComboBox
    Friend WithEvents GpBxCineFuncion As GroupBox
    Friend WithEvents LtBxCine As ListBox
    Friend WithEvents GpBxPrecios As GroupBox
    Friend WithEvents LtBxTotal As ListBox
    Friend WithEvents LtBxDesc2 As ListBox
    Friend WithEvents LtBxDesc1 As ListBox
    Friend WithEvents LtBxSubTotal As ListBox
    Friend WithEvents LtBxFuncion As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
