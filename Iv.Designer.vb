<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iv))
        Panel1 = New Panel()
        Button1 = New Button()
        Panel5 = New Panel()
        Filtrar = New Button()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        Panel6 = New Panel()
        RadioButton7 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel4 = New Panel()
        DataGridView3 = New DataGridView()
        DataGridView2 = New DataGridView()
        DataGridView1 = New DataGridView()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        MenuStrip1 = New MenuStrip()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AgregarProductoToolStripMenuItem = New ToolStripMenuItem()
        ListarProductoToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        ListarClienteToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        AgregarUsuarioToolStripMenuItem = New ToolStripMenuItem()
        ListarUsuarioToolStripMenuItem = New ToolStripMenuItem()
        VenderToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(56, 51)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1710, 993)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ControlDark
        Button1.Location = New Point(81, 930)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 58)
        Button1.TabIndex = 20
        Button1.Text = "Limpiar Filtro"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Filtrar)
        Panel5.Controls.Add(RadioButton3)
        Panel5.Controls.Add(RadioButton4)
        Panel5.Controls.Add(RadioButton5)
        Panel5.Controls.Add(RadioButton6)
        Panel5.Location = New Point(28, 522)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(326, 406)
        Panel5.TabIndex = 19
        ' 
        ' Filtrar
        ' 
        Filtrar.Location = New Point(59, 330)
        Filtrar.Name = "Filtrar"
        Filtrar.Size = New Size(188, 58)
        Filtrar.TabIndex = 4
        Filtrar.Text = "Filtrar"
        Filtrar.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(23, 261)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(227, 45)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "Mas Costoso"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(23, 188)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(265, 45)
        RadioButton4.TabIndex = 2
        RadioButton4.TabStop = True
        RadioButton4.Text = "Mas Economico"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(23, 115)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(224, 45)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "Mas Antiguo"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(23, 42)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(231, 45)
        RadioButton6.TabIndex = 0
        RadioButton6.TabStop = True
        RadioButton6.Text = "Mas Reciente"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(RadioButton7)
        Panel6.Controls.Add(RadioButton2)
        Panel6.Controls.Add(RadioButton1)
        Panel6.Location = New Point(28, 218)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(326, 298)
        Panel6.TabIndex = 17
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(31, 199)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(153, 45)
        RadioButton7.TabIndex = 2
        RadioButton7.TabStop = True
        RadioButton7.Text = "Codigo"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(31, 116)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(136, 45)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Marca"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(31, 42)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(165, 45)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Nombre"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonFace
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(DataGridView3)
        Panel4.Controls.Add(DataGridView2)
        Panel4.Controls.Add(DataGridView1)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(386, 209)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1293, 732)
        Panel4.TabIndex = 8
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(39, 30)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersWidth = 102
        DataGridView3.Size = New Size(1215, 672)
        DataGridView3.TabIndex = 8
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(39, 30)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 102
        DataGridView2.Size = New Size(1215, 672)
        DataGridView2.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 30)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 102
        DataGridView1.Size = New Size(1215, 672)
        DataGridView1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(792, 209)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(60, 54)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(556, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(595, 66)
        Panel2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(247))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.ForeColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(44, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(510, 40)
        TextBox1.TabIndex = 1
        TextBox1.TabStop = False
        TextBox1.Text = "Buscar Producto"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(40, 40)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProductosToolStripMenuItem, ClientesToolStripMenuItem, UsuariosToolStripMenuItem, VenderToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(456, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1021, 52)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarProductoToolStripMenuItem, ListarProductoToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(177, 48)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' AgregarProductoToolStripMenuItem
        ' 
        AgregarProductoToolStripMenuItem.Name = "AgregarProductoToolStripMenuItem"
        AgregarProductoToolStripMenuItem.Size = New Size(420, 54)
        AgregarProductoToolStripMenuItem.Text = "Agregar Producto"
        ' 
        ' ListarProductoToolStripMenuItem
        ' 
        ListarProductoToolStripMenuItem.Name = "ListarProductoToolStripMenuItem"
        ListarProductoToolStripMenuItem.Size = New Size(420, 54)
        ListarProductoToolStripMenuItem.Text = "Listar Producto"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem, ListarClienteToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(147, 48)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AgregarToolStripMenuItem
        ' 
        AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        AgregarToolStripMenuItem.Size = New Size(390, 54)
        AgregarToolStripMenuItem.Text = "Agregar Cliente"
        ' 
        ' ListarClienteToolStripMenuItem
        ' 
        ListarClienteToolStripMenuItem.Name = "ListarClienteToolStripMenuItem"
        ListarClienteToolStripMenuItem.Size = New Size(390, 54)
        ListarClienteToolStripMenuItem.Text = "Listar Cliente"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarUsuarioToolStripMenuItem, ListarUsuarioToolStripMenuItem})
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(156, 48)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' AgregarUsuarioToolStripMenuItem
        ' 
        AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        AgregarUsuarioToolStripMenuItem.Size = New Size(399, 54)
        AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario"
        ' 
        ' ListarUsuarioToolStripMenuItem
        ' 
        ListarUsuarioToolStripMenuItem.Name = "ListarUsuarioToolStripMenuItem"
        ListarUsuarioToolStripMenuItem.Size = New Size(399, 54)
        ListarUsuarioToolStripMenuItem.Text = "Listar Usuario"
        ' 
        ' VenderToolStripMenuItem
        ' 
        VenderToolStripMenuItem.Name = "VenderToolStripMenuItem"
        VenderToolStripMenuItem.Size = New Size(136, 48)
        VenderToolStripMenuItem.Text = "Vender"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(97, 48)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(-61, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(1926, 41)
        Label1.TabIndex = 1
        Label1.Text = "---------------------------------------------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Iv
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1823, 1094)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Iv"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Procure Pharmacy - Inventario "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents AgregarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Filtrar As Button
    Friend WithEvents ListarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
