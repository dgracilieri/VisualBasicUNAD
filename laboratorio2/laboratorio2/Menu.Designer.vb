<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ValidaPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromedioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidaPalabrasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ValidaPalabrasToolStripMenuItem
        '
        Me.ValidaPalabrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidaToolStripMenuItem, Me.GastosToolStripMenuItem, Me.ProductoMatrizToolStripMenuItem, Me.PromedioToolStripMenuItem, Me.EstudiantesToolStripMenuItem})
        Me.ValidaPalabrasToolStripMenuItem.Name = "ValidaPalabrasToolStripMenuItem"
        Me.ValidaPalabrasToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ValidaPalabrasToolStripMenuItem.Text = "Programas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ValidaToolStripMenuItem
        '
        Me.ValidaToolStripMenuItem.Name = "ValidaToolStripMenuItem"
        Me.ValidaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ValidaToolStripMenuItem.Text = "Valida"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'ProductoMatrizToolStripMenuItem
        '
        Me.ProductoMatrizToolStripMenuItem.Name = "ProductoMatrizToolStripMenuItem"
        Me.ProductoMatrizToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ProductoMatrizToolStripMenuItem.Text = "Producto matriz"
        '
        'PromedioToolStripMenuItem
        '
        Me.PromedioToolStripMenuItem.Name = "PromedioToolStripMenuItem"
        Me.PromedioToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PromedioToolStripMenuItem.Text = "Promedio"
        '
        'EstudiantesToolStripMenuItem
        '
        Me.EstudiantesToolStripMenuItem.Name = "EstudiantesToolStripMenuItem"
        Me.EstudiantesToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EstudiantesToolStripMenuItem.Text = "Estudiantes"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ValidaPalabrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoMatrizToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PromedioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstudiantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
