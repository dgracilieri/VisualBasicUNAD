<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculaTiempoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiaFormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculaSueldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibeTextoONumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(170, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 372)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1208, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimerToolStripMenuItem, Me.CalculaTiempoToolStripMenuItem, Me.CambiaFormatoToolStripMenuItem, Me.CalculaSueldoToolStripMenuItem, Me.RecibeTextoONumerosToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.CalculadoraToolStripMenuItem, Me.ImagenesToolStripMenuItem, Me.MouseToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 20)
        Me.ToolStripMenuItem1.Text = "Menu de Programas"
        '
        'TimerToolStripMenuItem
        '
        Me.TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        Me.TimerToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.TimerToolStripMenuItem.Text = "Timer"
        '
        'CalculaTiempoToolStripMenuItem
        '
        Me.CalculaTiempoToolStripMenuItem.Name = "CalculaTiempoToolStripMenuItem"
        Me.CalculaTiempoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CalculaTiempoToolStripMenuItem.Text = "Calcula tiempo"
        '
        'CambiaFormatoToolStripMenuItem
        '
        Me.CambiaFormatoToolStripMenuItem.Name = "CambiaFormatoToolStripMenuItem"
        Me.CambiaFormatoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CambiaFormatoToolStripMenuItem.Text = "Cambia formato"
        '
        'CalculaSueldoToolStripMenuItem
        '
        Me.CalculaSueldoToolStripMenuItem.Name = "CalculaSueldoToolStripMenuItem"
        Me.CalculaSueldoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CalculaSueldoToolStripMenuItem.Text = "Calcula sueldo"
        '
        'RecibeTextoONumerosToolStripMenuItem
        '
        Me.RecibeTextoONumerosToolStripMenuItem.Name = "RecibeTextoONumerosToolStripMenuItem"
        Me.RecibeTextoONumerosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.RecibeTextoONumerosToolStripMenuItem.Text = "Recibe texto o numeros"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'ImagenesToolStripMenuItem
        '
        Me.ImagenesToolStripMenuItem.Name = "ImagenesToolStripMenuItem"
        Me.ImagenesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ImagenesToolStripMenuItem.Text = "Imagenes"
        '
        'MouseToolStripMenuItem
        '
        Me.MouseToolStripMenuItem.Name = "MouseToolStripMenuItem"
        Me.MouseToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.MouseToolStripMenuItem.Text = "Mouse"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripMenuItem3.Text = "Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalirToolStripMenuItem.Text = "Sobre desarrollo"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1208, 603)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form12"
        Me.Text = "Trabajo Colaborativo 1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculaTiempoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiaFormatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculaSueldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecibeTextoONumerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImagenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MouseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
