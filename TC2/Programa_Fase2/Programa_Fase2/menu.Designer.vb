<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.MenuOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Op9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOpcionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuOpcionesToolStripMenuItem
        '
        Me.MenuOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArrayToolStripMenuItem, Me.Op1ToolStripMenuItem, Me.Op2ToolStripMenuItem, Me.Op3ToolStripMenuItem, Me.Op4ToolStripMenuItem, Me.Op5ToolStripMenuItem, Me.Op6ToolStripMenuItem, Me.Op8ToolStripMenuItem, Me.Op9ToolStripMenuItem})
        Me.MenuOpcionesToolStripMenuItem.Name = "MenuOpcionesToolStripMenuItem"
        Me.MenuOpcionesToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MenuOpcionesToolStripMenuItem.Text = "Menu opciones"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ArrayToolStripMenuItem.Text = "Agenda"
        '
        'Op1ToolStripMenuItem
        '
        Me.Op1ToolStripMenuItem.Name = "Op1ToolStripMenuItem"
        Me.Op1ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op1ToolStripMenuItem.Text = "Calculo de distancia"
        '
        'Op2ToolStripMenuItem
        '
        Me.Op2ToolStripMenuItem.Name = "Op2ToolStripMenuItem"
        Me.Op2ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op2ToolStripMenuItem.Text = "Capitales Sudamerica"
        '
        'Op3ToolStripMenuItem
        '
        Me.Op3ToolStripMenuItem.Name = "Op3ToolStripMenuItem"
        Me.Op3ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op3ToolStripMenuItem.Text = "Presupuesto"
        '
        'Op4ToolStripMenuItem
        '
        Me.Op4ToolStripMenuItem.Name = "Op4ToolStripMenuItem"
        Me.Op4ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op4ToolStripMenuItem.Text = "op4"
        '
        'Op5ToolStripMenuItem
        '
        Me.Op5ToolStripMenuItem.Name = "Op5ToolStripMenuItem"
        Me.Op5ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op5ToolStripMenuItem.Text = "op5"
        '
        'Op6ToolStripMenuItem
        '
        Me.Op6ToolStripMenuItem.Name = "Op6ToolStripMenuItem"
        Me.Op6ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op6ToolStripMenuItem.Text = "op6"
        '
        'Op8ToolStripMenuItem
        '
        Me.Op8ToolStripMenuItem.Name = "Op8ToolStripMenuItem"
        Me.Op8ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op8ToolStripMenuItem.Text = "op8"
        '
        'Op9ToolStripMenuItem
        '
        Me.Op9ToolStripMenuItem.Name = "Op9ToolStripMenuItem"
        Me.Op9ToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.Op9ToolStripMenuItem.Text = "op9"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa Fase 2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuOpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Op9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
