Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Agregar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If vc(TextBox4.Text) Then 'Cantidad Realista
            If vp(TextBox3.Text) Then 'Precio Realista
                If verificar_usuario() Then 'El No usuario existe

                    Try
                        Conex.Open()
                        Dim comand As New MySqlCommand("INSERT INTO productos(Nombre, Marca, Precio, Cantidad) VALUES('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "');", Conex)
                        Dim resultado = comand.ExecuteNonQuery
                        MsgBox("Registro exitoso")
                    Catch ex As Exception
                        MsgBox("ERROR: " + ex.Message)
                    Finally
                        Conex.Close()
                    End Try

                Else 'El usuario existe

                    If verificar_marca() Then 'De marca diferente

                        Try
                            Conex.Open()
                            Dim comand As New MySqlCommand("INSERT INTO productos(Nombre, Marca, Precio, Cantidad) VALUES('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "');", Conex)
                            Dim resultado = comand.ExecuteNonQuery
                            MsgBox("Registro exitoso")
                        Catch ex As Exception
                            MsgBox("ERROR: " + ex.Message)
                        Finally
                            Conex.Close()
                        End Try

                    Else 'De la misma marca
                        Dim vv As Short
                        Dim vn = Short.Parse(TextBox4.Text)

                        Try
                            Conex.Open()
                            Dim tt = "SELECT Cantidad FROM productos WHERE Nombre = @Nombre;"
                            Dim command As New MySqlCommand(tt, Conex)
                            command.Parameters.AddWithValue("@Nombre", TextBox1.Text)
                            Dim result = command.ExecuteScalar
                            vv = Short.Parse(result.ToString)
                        Catch ex As Exception
                            MessageBox.Show("ERROR: " + ex.Message)
                        Finally
                            Conex.Close()
                        End Try

                        Dim suma = vv + vn

                        Try
                            Conex.Open()
                            Dim comand As New MySqlCommand("UPDATE productos SET Cantidad = @Cantidad WHERE Nombre = @Nombre;", Conex)
                            comand.Parameters.AddWithValue("@Cantidad", suma)
                            comand.Parameters.AddWithValue("@Nombre", TextBox1.Text)
                            Dim resultado = comand.ExecuteNonQuery
                            MessageBox.Show("Registro exitoso")
                            Close()
                        Catch ex As Exception
                            MessageBox.Show("ERROR: " + ex.Message)
                        Finally
                            Conex.Close()
                        End Try

                    End If

                End If
            Else 'Precio Irreal
                MessageBox.Show("Ingrese un Precio Realista")
                TextBox3.Text = ""
            End If
        Else 'Cantidad Irreal
            MessageBox.Show("Ingrese una Cantidad Realista")
            TextBox4.Text = ""
        End If

    End Sub



    Public Function vm(inputString As String) As Boolean 'Mail
        If Not inputString.Contains("@") Then
            Return False
        End If
        If Not inputString.EndsWith(".com") Then
            Return False
        End If
        Return True
    End Function

    Public Function vci(ci As String) As Boolean 'Cedula
        If ci.Length > 8 Or ci.Length < 7 Then
            Return False
        End If
        If Not ci.All(AddressOf Char.IsDigit) Then
            Return False
        End If
        Return True
    End Function

    Public Function vc(ci As String) As Boolean 'Cantidad
        If ci.Length < 0 Then
            Return False
        End If
        If Not ci.All(AddressOf Char.IsDigit) Then
            Return False
        End If
        Return True
    End Function

    Public Function vp(ci As String) As Boolean 'Precio
        If ci.Length < 0 Then
            Return False
        End If
        If Not ci.All(AddressOf Char.IsDigit) Then
            Return False
        End If
        Return True
    End Function

    Private Function verificar_usuario() As Boolean
        Dim resultado As MySqlDataReader = Nothing
        Try
            Conex.Open()
            Dim comando = New MySqlCommand("SELECT * FROM productos WHERE Nombre = '" + TextBox1.Text + "';", Conex)
            resultado = comando.ExecuteReader()
            If resultado.HasRows Then
                Return False 'existe
            Else
                Return True 'no existe
            End If
        Catch ex As Exception
            MsgBox("ERROR: " + ex.Message)
            Return False
        Finally
            If resultado IsNot Nothing Then
                resultado.Close()
            End If
            Conex.Close()
        End Try
    End Function

    Private Function verificar_marca() As Boolean
        Dim resultado As MySqlDataReader = Nothing
        Try
            Conex.Open()
            Dim comando = New MySqlCommand("SELECT * FROM productos WHERE Marca = '" + TextBox2.Text + "';", Conex)
            resultado = comando.ExecuteReader()
            If resultado.HasRows Then
                Return False 'existe
            Else
                Return True 'no existe
            End If
        Catch ex As Exception
            MsgBox("ERROR: " + ex.Message)
            Return False
        Finally
            If resultado IsNot Nothing Then
                resultado.Close()
            End If
            Conex.Close()
        End Try
    End Function

    Private Function verificar_cedula() As Boolean
        Dim resultado As MySqlDataReader = Nothing
        Try
            Conex.Open()
            Dim comando = New MySqlCommand("SELECT * FROM clientes WHERE Cedula = '" + TextBox7.Text + "';", Conex)
            resultado = comando.ExecuteReader()
            If resultado.HasRows Then
                Return False 'existe
            Else
                Return True 'no existe
            End If
        Catch ex As Exception
            MsgBox("ERROR: " + ex.Message)
            Return False
        Finally
            If resultado IsNot Nothing Then
                resultado.Close()
            End If
            Conex.Close()
        End Try
    End Function

    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conex.Close()
        Placeholder(TextBox1, "Nombre del Producto")
        Placeholder(TextBox2, "Marca del Producto")
        Placeholder(TextBox4, "Cantidad del Producto")
        Placeholder(TextBox3, "Precio del Producto")
        Placeholder(TextBox8, "Nombre del CLiente")
        Placeholder(TextBox7, "Cedula del CLiente")
        Placeholder(TextBox6, "Correo Electronico del CLiente")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If vci(TextBox7.Text) Then 'Buen CI
            If vm(TextBox6.Text) Then 'Mal CI

                If verificar_cedula() Then 'El cliente no existe
                    Try
                        Conex.Open()
                        Dim comand As New MySqlCommand("INSERT INTO clientes(Nombre, Cedula, Correo) VALUES('" + TextBox8.Text + "', '" + TextBox7.Text + "', '" + TextBox6.Text + "');", Conex)
                        Dim resultado = comand.ExecuteNonQuery
                        MsgBox("Registro exitoso")
                    Catch ex As Exception
                        MsgBox("ERROR: " + ex.Message)
                    Finally
                        Conex.Close()
                    End Try
                Else 'El cliente existe
                    MessageBox.Show("El Cliente ya se encuentra registrado")
                End If

            Else 'Mal Correo
                MessageBox.Show("El Correo Electronico esta mal ingresado. Ejemplo (tudireccion@servidordelcorreo.com)")
                TextBox6.Text = ""
            End If
        Else 'Mal CI
            MessageBox.Show("La Cedula de Identidad esta mal ingresado. Ejemplo (30933083)")
            TextBox7.Text = ""
        End If


    End Sub
End Class


'Panel 1 = Crear Producto
'Panel 6 = Crear Cliente