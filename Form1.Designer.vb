<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(42, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(675, 888)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ControlDarkDark
        Button3.Location = New Point(177, 748)
        Button3.Name = "Button3"
        Button3.Size = New Size(317, 63)
        Button3.TabIndex = 8
        Button3.Text = "Constraseña Olvidada"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlDarkDark
        Button2.Location = New Point(212, 817)
        Button2.Name = "Button2"
        Button2.Size = New Size(247, 63)
        Button2.TabIndex = 7
        Button2.Text = "Crear Usuario" & vbCrLf
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(212, 670)
        Button1.Name = "Button1"
        Button1.Size = New Size(247, 63)
        Button1.TabIndex = 0
        Button1.Text = "Entrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(35, 515)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(595, 104)
        Panel3.TabIndex = 5
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
        TextBox2.TabIndex = 2
        TextBox2.Text = "CONTRASEÑA "
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(35, 359)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(595, 104)
        Panel2.TabIndex = 4
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
        TextBox1.TabIndex = 1
        TextBox1.Text = "USUARIO"
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
        Label2.Location = New Point(189, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 59)
        Label2.TabIndex = 2
        Label2.Text = "Iniciar Sesion"
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
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(563, 668)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(62, 67)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(563, 668)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 67)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(757, 973)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Procure's Pharmacy"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
