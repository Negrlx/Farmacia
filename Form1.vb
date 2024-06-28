Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Class Form1


    Public comand As New MySqlConnection
    Public selection As MySqlCommand = New MySqlCommand
    Public phv As Boolean = placeholders.ph

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectarr()
        Placeholder(TextBox1, "USUARIO")
        PPlaceholder(TextBox2, "CONTRASEÑA")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "USUARIO" Then phv = False

        If (TextBox1.Text = "" Or phv) Then
            MessageBox.Show("Dato vacio")
        Else
            Dim comando = New MySqlCommand("SELECT * FROM usuarios Where username = '" + TextBox1.Text + "';", Conex)
            Dim resultado = comando.ExecuteReader
            resultado.Read()
            If (resultado.HasRows) Then
                Dim vp As String = resultado("password").ToString()
                If (vp = TextBox2.Text) Then
                    MessageBox.Show("Bienvenido " + resultado("fullname"))
                    Me.Hide()
                    Iv.Show()
                Else
                    MessageBox.Show("ERROR, Contraseña Erronea")
                End If
            Else
                MessageBox.Show("ERROR, Usuario Inexistente")
            End If
            resultado.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        RP.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        ' Llamar al método para enviar el SMS
        'msg.SendSms()

        '' Informar al usuario que el mensaje fue enviado
        'MessageBox.Show("SMS enviado correctamente.")

        'Dim Destino As String = "santiagoaparcedo01@gmail.com"
        'Enviar(Destino)

        Form2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (TextBox2.Text <> "" AndAlso TextBox2.Text <> "CONTRASEÑA") Then
            placeholders.TogglePasswordVisibility(TextBox2, PictureBox2)
            PictureBox2.Hide()
            PictureBox3.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox2.Text <> "" AndAlso TextBox2.Text <> "CONTRASEÑA" Then
            TogglePasswordVisibility(TextBox2, PictureBox2)
            PictureBox2.Show()
            PictureBox3.Hide()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
