<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RP))
        Panel1 = New Panel()
        Panel3 = New Panel()
        TextBox2 = New TextBox()
        Panel4 = New Panel()
        TextBox3 = New TextBox()
        Button4 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Button7 = New Button()
        Panel6 = New Panel()
        TextBox4 = New TextBox()
        Panel7 = New Panel()
        TextBox5 = New TextBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(43, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(675, 888)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(38, 459)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(595, 104)
        Panel3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.ForeColor = SystemColors.ScrollBar
        TextBox2.Location = New Point(41, 31)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(510, 40)
        TextBox2.TabIndex = 0
        TextBox2.Text = "Numero de Telefono (4-)"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(TextBox3)
        Panel4.Location = New Point(38, 459)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(595, 104)
        Panel4.TabIndex = 6
        Panel4.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.ForeColor = SystemColors.ScrollBar
        TextBox3.Location = New Point(41, 31)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(510, 40)
        TextBox3.TabIndex = 0
        TextBox3.Text = "CODIGO DE RECUPERACION"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(212, 612)
        Button4.Name = "Button4"
        Button4.Size = New Size(247, 63)
        Button4.TabIndex = 10
        Button4.Text = "Verificar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlDarkDark
        Button2.Location = New Point(128, 818)
        Button2.Name = "Button2"
        Button2.Size = New Size(414, 63)
        Button2.TabIndex = 9
        Button2.Text = "Usar un Correo Electronico"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ControlDarkDark
        Button3.Location = New Point(128, 818)
        Button3.Name = "Button3"
        Button3.Size = New Size(414, 63)
        Button3.TabIndex = 8
        Button3.Text = "Usar un Numero de Telefono"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(212, 612)
        Button1.Name = "Button1"
        Button1.Size = New Size(247, 63)
        Button1.TabIndex = 6
        Button1.Text = "Recuperar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(38, 459)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(595, 104)
        Panel2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(41, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(510, 40)
        TextBox1.TabIndex = 0
        TextBox1.Text = "CORREO ELECTRONICO"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(32, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(-32, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(725, 59)
        Label3.TabIndex = 3
        Label3.Text = "--------------------------------------------------"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(92, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(486, 59)
        Label2.TabIndex = 2
        Label2.Text = "RECUPERAR CONTRASEÑA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(149, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(468, 66)
        Label1.TabIndex = 0
        Label1.Text = "PROCURE PHARMACY"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Button7)
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(PictureBox2)
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(43, 44)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(675, 888)
        Panel5.TabIndex = 2
        ' 
        ' Button7
        ' 
        Button7.Cursor = Cursors.Hand
        Button7.Location = New Point(212, 681)
        Button7.Name = "Button7"
        Button7.Size = New Size(247, 63)
        Button7.TabIndex = 6
        Button7.Text = "Guardar"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(TextBox4)
        Panel6.Location = New Point(35, 515)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(595, 104)
        Panel6.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.ForeColor = SystemColors.ScrollBar
        TextBox4.Location = New Point(41, 31)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(510, 40)
        TextBox4.TabIndex = 0
        TextBox4.Text = "CONFIRMAR CONTRASEÑA "
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(TextBox5)
        Panel7.Location = New Point(35, 359)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(595, 104)
        Panel7.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Cursor = Cursors.IBeam
        TextBox5.ForeColor = SystemColors.ScrollBar
        TextBox5.Location = New Point(41, 31)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(510, 40)
        TextBox5.TabIndex = 0
        TextBox5.Text = "CONTRASEÑA"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(32, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(131, 113)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(-32, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(725, 59)
        Label4.TabIndex = 3
        Label4.Text = "--------------------------------------------------"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(205, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(260, 59)
        Label5.TabIndex = 2
        Label5.Text = "Nueva Clave"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Impact", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(149, 56)
        Label6.Name = "Label6"
        Label6.Size = New Size(468, 66)
        Label6.TabIndex = 0
        Label6.Text = "PROCURE PHARMACY"
        ' 
        ' RP
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(761, 977)
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "RP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Recuperar Clave"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
End Class
