<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C))
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Button2 = New Button()
        Panel4 = New Panel()
        TextBox3 = New TextBox()
        Panel5 = New Panel()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel8 = New Panel()
        Button4 = New Button()
        Button5 = New Button()
        Panel9 = New Panel()
        TextBox7 = New TextBox()
        Button6 = New Button()
        Panel10 = New Panel()
        TextBox8 = New TextBox()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(42, 41)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1457, 888)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1326, 714)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 67)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1326, 714)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(62, 67)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Location = New Point(603, 716)
        Button2.Name = "Button2"
        Button2.Size = New Size(247, 63)
        Button2.TabIndex = 15
        Button2.Text = "Entrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(TextBox3)
        Panel4.Location = New Point(793, 498)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(595, 104)
        Panel4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.ForeColor = SystemColors.ScrollBar
        TextBox3.Location = New Point(41, 31)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(510, 40)
        TextBox3.TabIndex = 0
        TextBox3.Text = "Confirmar Contraseña "
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(TextBox4)
        Panel5.Location = New Point(793, 342)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(595, 104)
        Panel5.TabIndex = 10
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
        TextBox4.Text = "Constraseña"
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(929, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(350, 59)
        Label4.TabIndex = 9
        Label4.Text = "Clave De Usuario"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(64, 498)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(595, 104)
        Panel3.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.ForeColor = SystemColors.ScrollBar
        TextBox2.Location = New Point(41, 31)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(510, 40)
        TextBox2.TabIndex = 0
        TextBox2.Text = "Usuario"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(174, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(64, 342)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(595, 104)
        Panel2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.ForeColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(41, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(510, 40)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Nombre Completo"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(-32, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(2055, 59)
        Label3.TabIndex = 3
        Label3.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(123, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(480, 59)
        Label2.TabIndex = 6
        Label2.Text = "Informacion De Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(291, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(988, 66)
        Label1.TabIndex = 0
        Label1.Text = "PROCURE PHARMACY - CREAR USUARIO NUEVO"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(Button4)
        Panel8.Controls.Add(Button5)
        Panel8.Controls.Add(Panel9)
        Panel8.Controls.Add(Button6)
        Panel8.Controls.Add(Panel10)
        Panel8.Controls.Add(PictureBox2)
        Panel8.Controls.Add(Label6)
        Panel8.Controls.Add(Label7)
        Panel8.Controls.Add(Label8)
        Panel8.Location = New Point(42, 41)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1457, 888)
        Panel8.TabIndex = 3
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.Location = New Point(603, 689)
        Button4.Name = "Button4"
        Button4.Size = New Size(247, 63)
        Button4.TabIndex = 15
        Button4.Text = "Entrar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = SystemColors.ControlDarkDark
        Button5.Location = New Point(969, 481)
        Button5.Name = "Button5"
        Button5.Size = New Size(143, 63)
        Button5.TabIndex = 14
        Button5.Text = "CORREO"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel9.BorderStyle = BorderStyle.Fixed3D
        Panel9.Controls.Add(TextBox7)
        Panel9.Location = New Point(341, 460)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(595, 104)
        Panel9.TabIndex = 13
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.ForeColor = SystemColors.ScrollBar
        TextBox7.Location = New Point(41, 31)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(510, 40)
        TextBox7.TabIndex = 0
        TextBox7.Text = "NUMERO DE RECUPERACION (+58-)"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = SystemColors.ControlDarkDark
        Button6.Location = New Point(969, 481)
        Button6.Name = "Button6"
        Button6.Size = New Size(125, 63)
        Button6.TabIndex = 12
        Button6.Text = "TLF"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(TextBox8)
        Panel10.Location = New Point(341, 460)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(595, 104)
        Panel10.TabIndex = 9
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Cursor = Cursors.IBeam
        TextBox8.ForeColor = SystemColors.ScrollBar
        TextBox8.Location = New Point(41, 31)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(510, 40)
        TextBox8.TabIndex = 0
        TextBox8.Text = "CORREO DE RECUPERACION"
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(174, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(131, 113)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(-32, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(2055, 59)
        Label6.TabIndex = 3
        Label6.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(426, 281)
        Label7.Name = "Label7"
        Label7.Size = New Size(600, 59)
        Label7.TabIndex = 6
        Label7.Text = "Informacion De Recuperacion"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Impact", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(291, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(988, 66)
        Label8.TabIndex = 0
        Label8.Text = "PROCURE PHARMACY - CREAR USUARIO NUEVO"
        ' 
        ' C
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1541, 971)
        Controls.Add(Panel1)
        Controls.Add(Panel8)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "C"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Usuario Nuevo"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
