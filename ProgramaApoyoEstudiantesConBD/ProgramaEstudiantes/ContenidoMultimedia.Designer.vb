﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenidoMultimedia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenidoMultimedia))
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(926, 583)
        Me.AxShockwaveFlash1.TabIndex = 0
        Me.AxShockwaveFlash1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AxShockwaveFlash1)
        Me.Panel1.Location = New System.Drawing.Point(18, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 583)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(898, 618)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ContenidoMultimedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(952, 655)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(968, 694)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(968, 694)
        Me.Name = "ContenidoMultimedia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContenidoMultimedia"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
