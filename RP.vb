Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Twilio.Rest.Verify.V2

Public Class RP
    Private Sub RP_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Public vrg As Boolean = True 'Si es true es tlf, sino mail
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Show()
        Button2.Hide()
        Panel3.Hide()
        Button3.Show()
        vrg = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Show()
        Button3.Hide()
        Panel2.Hide()
        Button2.Show()
        vrg = True
    End Sub

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

    Public exuser As Boolean = True '

    Public Function verificar() As Boolean

        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (vrg) Then
            Try
                Dim comando = New MySqlCommand("SELECT * FROM usuarios Where phone = '" + TextBox2.Text + "';", Conex)
                Dim resultado = comando.ExecuteReader
                resultado.Read()
                If (resultado.HasRows) Then
                    exuser = True
                    msg.SendSms(TextBox2.Text)
                Else

                    exuser = False
                End If
                resultado.Close()
            Catch ex As Exception
                MsgBox("ERROR: " + ex.Message)
            End Try
        Else
            Try
                Dim comando = New MySqlCommand("SELECT * FROM usuarios Where mail = '" + TextBox1.Text + "';", Conex)
                Dim resultado = comando.ExecuteReader
                resultado.Read()
                If (resultado.HasRows) Then
                    exuser = True 'existe
                    msg.Enviar(TextBox3.Text)
                Else
                    exuser = False
                End If
                resultado.Close()
            Catch ex As Exception
                MsgBox("ERROR: " + ex.Message)
            End Try
        End If
        If (exuser) Then

            vld.Show()
        Else
            MessageBox.Show("Informacion No Existente")
            TextBox2.Text = ""
            TextBox1.Text = ""
        End If

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (TextBox5.Text = TextBox4.Text) Then
            If (vrg) Then

                If (vtlf(TextBox2.Text)) Then
                    Try
                        Dim comand = New MySqlCommand("UPDATE usuarios SET password = '" + TextBox5.Text + "' WHERE phone = '" + TextBox2.Text + "';", Conex)
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
                If (vm(TextBox3.Text)) Then
                    Try
                        Dim comand = New MySqlCommand("UPDATE usuarios SET mail = '" + TextBox5.Text + "' WHERE phone = '" + TextBox1.Text + "';", Conex)
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
        Else
            MsgBox("Las contraseñas deben coincidir")
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub RP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Placeholder(TextBox2, "Numero de Telefono (4-)")
        PPlaceholder(TextBox1, "CORREO ELECTRONICO")
        PPlaceholder(TextBox3, "Confirmar Contraseña")
        Placeholder(TextBox5, "CONTRASEÑA")
        Placeholder(TextBox4, "CONFIRMAR CONTRASEÑA")
    End Sub
End Class