Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class Iv
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
        Form1.Show()
    End Sub
    Private Sub Iv_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Dim modegrid As Int128 = 2


    Private Sub Iv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Show()

        Dim data = llgrd()
        DataGridView1.DataSource = data
        RadioButton1.Checked = True

        Placeholder(TextBox1, "BUSCAR")

        modegrid = 1
        DataGridView2.Hide()
        DataGridView3.Hide()

    End Sub



    Public Function BuscarProductos(nombre As String, opcion As Integer) As DataTable
        Dim data As New DataTable()

        Try
            Dim sql As String = ""

            Select Case opcion
                Case 1
                    sql = "SELECT * FROM productos WHERE Nombre LIKE @nombre"
                Case 2
                    sql = "SELECT * FROM productos WHERE Marca LIKE @nombre"
                Case 3
                    sql = "SELECT * FROM productos WHERE Codigo LIKE  @nombre"
                Case Else
                    Throw New ArgumentException("Opción de búsqueda no válida.")
            End Select

            Conex.Open()
            Dim comand As New MySqlCommand(sql, Conex)
            comand.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
            Dim Adp As New MySqlDataAdapter(comand)
            Adp.Fill(data)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return data
    End Function

    Public Function BuscarUsuarios(nombre As String, opcion As Integer) As DataTable
        Dim data As New DataTable()

        Try
            Dim sql As String = ""

            Select Case opcion
                Case 1
                    sql = "SELECT * FROM usuarios WHERE fullname LIKE @nombre"
                Case 2
                    sql = "SELECT * FROM usuarios WHERE username LIKE @nombre"
                Case 3
                    sql = "SELECT * FROM usuarios WHERE user_id LIKE  @nombre"
                Case Else
                    Throw New ArgumentException("Opción de búsqueda no válida.")
            End Select

            Conex.Open()
            Dim comand As New MySqlCommand(sql, Conex)
            comand.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
            Dim Adp As New MySqlDataAdapter(comand)
            Adp.Fill(data)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return data
    End Function

    Public Function BuscarClientes(nombre As String, opcion As Integer) As DataTable
        Dim data As New DataTable()

        Try
            Dim sql As String = ""

            Select Case opcion
                Case 1
                    sql = "SELECT * FROM clientes WHERE Nombre LIKE @nombre"
                Case 2
                    sql = "SELECT * FROM clientes WHERE Correo LIKE @nombre"
                Case 3
                    sql = "SELECT * FROM clientes WHERE Cedula LIKE  @nombre"
                Case Else
                    Throw New ArgumentException("Opción de búsqueda no válida.")
            End Select

            Conex.Open()
            Dim comand As New MySqlCommand(sql, Conex)
            comand.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
            Dim Adp As New MySqlDataAdapter(comand)
            Adp.Fill(data)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return data
    End Function

    Public Function pr_tie()
        If RadioButton4.Checked Then
            Return True
        End If
        If RadioButton6.Checked Then
            Return True
        End If
        Return False
    End Function


    Private Sub ListarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarClienteToolStripMenuItem.Click
        modegrid = 2
        DataGridView1.Hide()
        DataGridView2.Show()
        DataGridView3.Hide()

        RadioButton1.Text = "Nombre"
        RadioButton2.Text = "Correo"
        RadioButton7.Text = "Cedula"

        RadioButton3.Hide()
        RadioButton4.Hide()
    End Sub

    Private Sub ListarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarUsuarioToolStripMenuItem.Click
        modegrid = 3
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Show()

        RadioButton1.Text = "Fullname"
        RadioButton2.Text = "Username"
        RadioButton7.Text = "User ID"

        RadioButton3.Hide()
        RadioButton4.Hide()
    End Sub

    Private Sub ListarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarProductoToolStripMenuItem.Click
        modegrid = 1
        DataGridView1.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()

        RadioButton1.Text = "Nombre"
        RadioButton2.Text = "Marca"
        RadioButton7.Text = "Codigo"

        RadioButton3.Show()
        RadioButton4.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim grid As DataGridView = Nothing
        Dim load As DataTable = Nothing
        Dim data As DataTable

        Try

            If modegrid = 1 Then 'Producto
                grid = DataGridView1
                load = llgrd()
            ElseIf modegrid = 2 Then 'Cliente
                grid = DataGridView2
                load = llgrd_c()
            ElseIf modegrid = 3 Then 'Usuario
                grid = DataGridView3
                load = llgrd_u()
            End If

            Conex.Close()

            Dim nombre As String = TextBox1.Text
            Dim opcion As Integer = 0


            If RadioButton1.Checked Then
                opcion = 1
            ElseIf RadioButton2.Checked Then
                opcion = 2
            ElseIf RadioButton7.Checked Then
                opcion = 3
            Else
                Try
                    grid.DataSource = load
                    SortAndBindDataGridView(load, grid)
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
                Exit Sub
            End If

            If modegrid = 1 Then 'Producto
                data = BuscarProductos(nombre, opcion)
            ElseIf modegrid = 2 Then 'Cliente
                data = BuscarClientes(nombre, opcion)
            ElseIf modegrid = 3 Then 'Usuario
                data = BuscarUsuarios(nombre, opcion)
            End If

            ' Realiza la búsqueda de productos según la opción seleccionada

            grid.DataSource = data

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Public f As Boolean = False
    Private Sub SortAndBindDataGridView(data As DataTable, gridView As DataGridView)
        Dim sortedData As DataTable = Nothing

        If RadioButton4.Checked Then
            data.DefaultView.Sort = "Precio ASC"
            sortedData = data.DefaultView.ToTable()
            f = True
        ElseIf RadioButton3.Checked Then
            data.DefaultView.Sort = "Precio DESC"
            sortedData = data.DefaultView.ToTable()
            f = True
        ElseIf RadioButton6.Checked Then
            data.DefaultView.Sort = "Codigo ASC"
            sortedData = data.DefaultView.ToTable()
            f = True
        ElseIf RadioButton5.Checked Then
            data.DefaultView.Sort = "Codigo DESC"
            sortedData = data.DefaultView.ToTable()
        End If

        gridView.DataSource = sortedData
        gridView.AutoResizeColumns()
    End Sub





    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False

        f = False
    End Sub

    Private Sub Filtrar_Click(sender As Object, e As EventArgs) Handles Filtrar.Click

        Dim grid = Nothing
        Dim load = Nothing

        If modegrid = 1 Then 'Producto
            grid = DataGridView1
            load = llgrd()
        ElseIf modegrid = 2 Then
            grid = DataGridView2
            load = llgrd_c()
        ElseIf modegrid = 2 Then
            grid = DataGridView3
            load = llgrd_u()
        End If

        Try
            Conex.Close()

            Dim nombre As String = TextBox1.Text
            Dim opcion As Integer = 0

            If RadioButton1.Checked Then
                opcion = 1
            ElseIf RadioButton2.Checked Then
                opcion = 2
            ElseIf RadioButton7.Checked Then
                opcion = 3
            Else
                Dim data As DataTable = llgrd()
                DataGridView1.DataSource = data
                Exit Sub
            End If

            Dim productosEncontrados As DataTable = BuscarProductos(nombre, opcion)
            SortAndBindDataGridView(productosEncontrados, grid)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        Agregar.Show()
        Agregar.Panel1.Show()
        Agregar.Panel6.Hide()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Agregar.Show()
        Agregar.Panel1.Hide()
        Agregar.Panel6.Show()
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        C.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub



    Public Function llgrd() As DataTable
        Conex.Close()
        Dim data = New DataTable

        Try

            Dim comand = New MySqlCommand("SELECT * FROM productos", Conex)
            Dim Adp = New MySqlDataAdapter(comand)
            Adp.Fill(data)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return data

    End Function

    Public Function llgrd_u() As DataTable
        Conex.Close()
        Dim data = New DataTable

        Try

            Dim comand = New MySqlCommand("SELECT * FROM usuarios", Conex)
            Dim Adp = New MySqlDataAdapter(comand)
            Adp.Fill(data)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return data

    End Function

    Public Function llgrd_c() As DataTable
        Conex.Close()
        Dim data = New DataTable

        Try

            Dim comand = New MySqlCommand("SELECT * FROM clientes", Conex)
            Dim Adp = New MySqlDataAdapter(comand)
            Adp.Fill(data)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return data

    End Function

    Private Sub VenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenderToolStripMenuItem.Click
        MessageBox.Show("Gracias por su Compra")
    End Sub
End Class