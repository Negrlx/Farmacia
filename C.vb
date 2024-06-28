Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class C

    Public comand As New MySqlConnection
    Public selection As MySqlCommand = New MySqlCommand

    Public phv As Boolean = placeholders.ph
    Private Sub C_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub


    Dim exuser As Boolean = False

    Private Sub verificar_usuario()
        Try
            Dim comando = New MySqlCommand("SELECT * FROM usuarios Where username = '" + TextBox2.Text + "';", Conex)
            Dim resultado = comando.ExecuteReader
            resultado.Read()
            If (resultado.HasRows) Then
                exuser = False 'existe
            Else
                exuser = True  'no existe
            End If
            resultado.Close()
        Catch ex As Exception
            MsgBox("ERROR: " + ex.Message)
        End Try

    End Sub






    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Placeholder(TextBox1, "Nombre Completo")
        Placeholder(TextBox2, "Usuario")
        PPlaceholder(TextBox4, "Contraseña")
        PPlaceholder(TextBox3, "Confirmar Contraseña")
        Placeholder(TextBox7, "NUMERO DE RECUPERACION (+58-)")
        Placeholder(TextBox8, "CORREO DE RECUPERACION")
    End Sub


    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox2.Text <> "" AndAlso TextBox2.Text <> "CONTRASEÑA" Then
            TogglePasswordVisibility(TextBox3, PictureBox2)
            TogglePasswordVisibility(TextBox4, PictureBox2)
            PictureBox3.Show()
            PictureBox4.Hide()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (TextBox2.Text <> "" AndAlso TextBox2.Text <> "CONTRASEÑA") Then
            TogglePasswordVisibility(TextBox3, PictureBox2)
            TogglePasswordVisibility(TextBox4, PictureBox2)
            PictureBox3.Hide()
            PictureBox4.Show()
        End If
    End Sub

    Public Function vcpp(cp As String) As Boolean
        If cp.Length < 8 Then
            Return False
        End If
        Return True
    End Function


    Public ct As Boolean = True 'es tlf, si es falso es mail
    Public Function vtlf(tlf As String) As Boolean
        If tlf.Length <> 10 Then
            Return False
        End If
        If Not tlf.All(AddressOf Char.IsDigit) Then
            Return False
        End If
        If tlf.Chars(0) <> "4"c Then
            Return False
        End If
        Return True
    End Function

    Public Function vm(inputString As String) As Boolean
        If Not inputString.Contains("@") Then
            Return False
        End If
        If Not inputString.EndsWith(".com") Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text <> "Nombre Completo" Then phv = False
        If TextBox2.Text <> "Usuario" Then phv = False
        If TextBox4.Text <> "Contraseña" Then phv = False
        If TextBox3.Text <> "Confirmar Contraseña" Then phv = False

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" AndAlso phv Then
            MsgBox("Faltan datos")
        Else

            If TextBox4.Text = TextBox3.Text Then
                If (vcpp(TextBox4.Text)) Then
                    verificar_usuario()
                    If (exuser) Then
                        Try
                            Dim comand = New MySqlCommand("INSERT INTO usuarios(fullname,username,password) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "');", Conex)
                            Dim resultado = comand.ExecuteNonQuery
                            MsgBox("Registro exitoso")
                            Panel1.Hide()
                            Panel8.Show()
                        Catch ex As Exception
                            MsgBox("ERROR: " + ex.Message)
                        End Try
                    Else
                        MsgBox("El usuario ya existe")
                        TextBox2.Text = ""
                        exuser = False 'Reinicia Busqueda
                    End If
                Else
                    MsgBox("Las contraseñas debe tener mas de 8 caracteres")
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                End If

            Else
                    MsgBox("Las contraseñas deben coincidir")
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                End If
            End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        If (ct) Then

            If (vtlf(TextBox7.Text)) Then
                Try
                    Dim comand = New MySqlCommand("UPDATE usuarios SET phone = '" + TextBox7.Text + "' WHERE username = '" + TextBox2.Text + "';", Conex)
                    Dim resultado = comand.ExecuteNonQuery
                    MessageBox.Show("Registro exitoso")
                    Me.Close()
                    Form1.Show()
                Catch ex As Exception
                    MessageBox.Show("ERROR: " + ex.Message)
                End Try
            Else
                MessageBox.Show("Error, numero de tlf mal ingresado. EJEMPLO (4248351320)")
            End If
        Else
            If (vm(TextBox8.Text)) Then
                Try
                    Dim comand = New MySqlCommand("UPDATE usuarios SET mail = '" + TextBox8.Text + "' WHERE username = '" + TextBox2.Text + "';", Conex)
                    Dim resultado = comand.ExecuteNonQuery
                    MessageBox.Show("Registro exitoso")
                    Me.Close()
                    Form1.Show()
                Catch ex As Exception
                    MessageBox.Show("ERROR: " + ex.Message)
                End Try
            Else
                MessageBox.Show("Error, mail mal ingresado. EJEMPLO (tucorreo@tuservidor.com)")
            End If


        End If



    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'correo
        Panel10.Show()
        Button6.Show()
        Panel9.Hide()
        Button5.Hide()
        ct = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'tlf
        Panel10.Hide()
        Button6.Hide()
        Panel9.Show()
        Button5.Show()
        ct = True
    End Sub
End Class