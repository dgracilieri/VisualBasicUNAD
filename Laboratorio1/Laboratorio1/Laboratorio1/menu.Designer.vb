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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculaVelocidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculaVelocidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculaAreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversorDeMedidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculaVelocidadToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculaVelocidadToolStripMenuItem
        '
        Me.CalculaVelocidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculaVelocidadToolStripMenuItem1, Me.CalculaAreasToolStripMenuItem, Me.ConversorDeMedidasToolStripMenuItem})
        Me.CalculaVelocidadToolStripMenuItem.Name = "CalculaVelocidadToolStripMenuItem"
        Me.CalculaVelocidadToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CalculaVelocidadToolStripMenuItem.Text = "Menu"
        '
        'CalculaVelocidadToolStripMenuItem1
        '
        Me.CalculaVelocidadToolStripMenuItem1.Name = "CalculaVelocidadToolStripMenuItem1"
        Me.CalculaVelocidadToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.CalculaVelocidadToolStripMenuItem1.Text = "Calcula velocidad"
        '
        'CalculaAreasToolStripMenuItem
        '
        Me.CalculaAreasToolStripMenuItem.Name = "CalculaAreasToolStripMenuItem"
        Me.CalculaAreasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CalculaAreasToolStripMenuItem.Text = "Calcula areas"
        '
        'ConversorDeMedidasToolStripMenuItem
        '
        Me.ConversorDeMedidasToolStripMenuItem.Name = "ConversorDeMedidasToolStripMenuItem"
        Me.ConversorDeMedidasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConversorDeMedidasToolStripMenuItem.Text = "Conversor de medidas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Menu"
        Me.Text = "laboratorio1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalculaVelocidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculaVelocidadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculaAreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversorDeMedidasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
