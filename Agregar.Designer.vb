<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar))
        Panel1 = New Panel()
        Button1 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel5 = New Panel()
        TextBox4 = New TextBox()
        Panel4 = New Panel()
        TextBox3 = New TextBox()
        Panel3 = New Panel()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Panel6 = New Panel()
        Button2 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel8 = New Panel()
        TextBox6 = New TextBox()
        Panel9 = New Panel()
        TextBox7 = New TextBox()
        Panel10 = New Panel()
        TextBox8 = New TextBox()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
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
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(36, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1370, 677)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1148, 579)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 58)
        Button1.TabIndex = 22
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Impact", 9F)
        Label6.Location = New Point(209, 577)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 37)
        Label6.TabIndex = 21
        Label6.Text = "Cantidad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Impact", 9F)
        Label5.Location = New Point(227, 461)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 37)
        Label5.TabIndex = 20
        Label5.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Impact", 9F)
        Label4.Location = New Point(228, 345)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 37)
        Label4.TabIndex = 19
        Label4.Text = "Marca"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(213, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 37)
        Label2.TabIndex = 18
        Label2.Text = "Nombre"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(TextBox4)
        Panel5.Location = New Point(408, 558)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(551, 79)
        Panel5.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.ForeColor = SystemColors.ScrollBar
        TextBox4.Location = New Point(16, 19)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(510, 40)
        TextBox4.TabIndex = 0
        TextBox4.Text = "Cantidad del Producto"
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(TextBox3)
        Panel4.Location = New Point(408, 442)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(551, 79)
        Panel4.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.ForeColor = SystemColors.ScrollBar
        TextBox3.Location = New Point(16, 19)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(510, 40)
        TextBox3.TabIndex = 0
        TextBox3.Text = "Precio del Producto"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(408, 326)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(551, 79)
        Panel3.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.ForeColor = SystemColors.ScrollBar
        TextBox2.Location = New Point(16, 19)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(510, 40)
        TextBox2.TabIndex = 0
        TextBox2.Text = "Marca del Producto"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(408, 210)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(551, 79)
        Panel2.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.ForeColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(16, 19)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(510, 40)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Nombre del Producto"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(-180, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(2055, 59)
        Label3.TabIndex = 15
        Label3.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(143, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(937, 66)
        Label1.TabIndex = 13
        Label1.Text = "PROCURE PHARMACY - AGREGAR PRODUCTO"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(Button2)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Panel8)
        Panel6.Controls.Add(Panel9)
        Panel6.Controls.Add(Panel10)
        Panel6.Controls.Add(PictureBox2)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label12)
        Panel6.Location = New Point(36, 32)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1370, 677)
        Panel6.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1148, 579)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 58)
        Button2.TabIndex = 22
        Button2.Text = "Agregar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Impact", 9F)
        Label8.Location = New Point(143, 571)
        Label8.Name = "Label8"
        Label8.Size = New Size(245, 37)
        Label8.TabIndex = 20
        Label8.Text = "Correo Electronico"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Impact", 9F)
        Label9.Location = New Point(228, 398)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 37)
        Label9.TabIndex = 19
        Label9.Text = "Cedula"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(213, 229)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 37)
        Label10.TabIndex = 18
        Label10.Text = "Nombre"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(TextBox6)
        Panel8.Location = New Point(408, 550)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(551, 79)
        Panel8.TabIndex = 17
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Cursor = Cursors.IBeam
        TextBox6.ForeColor = SystemColors.ScrollBar
        TextBox6.Location = New Point(16, 19)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(510, 40)
        TextBox6.TabIndex = 0
        TextBox6.Text = "Correo del Cliente"
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel9.BorderStyle = BorderStyle.Fixed3D
        Panel9.Controls.Add(TextBox7)
        Panel9.Location = New Point(408, 380)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(551, 79)
        Panel9.TabIndex = 17
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.ForeColor = SystemColors.ScrollBar
        TextBox7.Location = New Point(16, 19)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(510, 40)
        TextBox7.TabIndex = 0
        TextBox7.Text = "Cedula del Cliente"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(TextBox8)
        Panel10.Location = New Point(408, 210)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(551, 79)
        Panel10.TabIndex = 16
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Cursor = Cursors.IBeam
        TextBox8.ForeColor = SystemColors.ScrollBar
        TextBox8.Location = New Point(16, 19)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(510, 40)
        TextBox8.TabIndex = 0
        TextBox8.Text = "Nombre del Cliente"
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 28)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(131, 113)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Impact", 14.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ButtonFace
        Label11.Location = New Point(-180, 135)
        Label11.Name = "Label11"
        Label11.Size = New Size(2055, 59)
        Label11.TabIndex = 15
        Label11.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Impact", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(143, 54)
        Label12.Name = "Label12"
        Label12.Size = New Size(871, 66)
        Label12.TabIndex = 13
        Label12.Text = "PROCURE PHARMACY - AGREGAR CLIENTE"
        ' 
        ' Agregar
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1442, 741)
        Controls.Add(Panel6)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Agregar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Procure Pharmacy - Agregar al Sistema"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
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
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
