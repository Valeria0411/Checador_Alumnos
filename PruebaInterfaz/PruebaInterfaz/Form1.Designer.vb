<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazPrueba
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfazPrueba))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lista = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1056, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIENVENIDO AL SISTEMA DE CHEQUEO PREPARATORIA N°17"
        Me.Label1.Visible = False
        '
        'lista
        '
        Me.lista.ImageStream = CType(resources.GetObject("lista.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lista.Tag = "no se que hacer con mi vida"
        Me.lista.TransparentColor = System.Drawing.Color.Transparent
        Me.lista.Images.SetKeyName(0, "16cf0674eae27dad45f4c72487de04c5--laptop-stickers-emoticon.jpg")
        Me.lista.Images.SetKeyName(1, "1484942352ios-emoji-party-popper.png")
        Me.lista.Images.SetKeyName(2, "ap,550x550,12x12,1,transparent,t.u2.png")
        Me.lista.Images.SetKeyName(3, "original.jpg")
        '
        'InterfazPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 500)
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1314, 743)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Name = "InterfazPrueba"
        Me.Text = "IntChecador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lista As ImageList
End Class
