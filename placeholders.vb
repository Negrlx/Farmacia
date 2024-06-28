Module placeholders

    Public ph As Boolean = True
    Public Sub Placeholder(textBox As TextBox, placeholderText As String)
        textBox.Tag = placeholderText
        textBox.ForeColor = SystemColors.ScrollBar
        textBox.Text = placeholderText
        ph = True
        AddHandler textBox.GotFocus,
            Sub(sender As Object, e As EventArgs)
                Dim tb = DirectCast(sender, TextBox)
                If tb.Text = tb.Tag Then
                    tb.Text = ""
                    tb.ForeColor = SystemColors.ControlText
                    ph = False
                End If
            End Sub

        AddHandler textBox.LostFocus,
            Sub(sender As Object, e As EventArgs)
                Dim tb = DirectCast(sender, TextBox)
                If String.IsNullOrWhiteSpace(tb.Text) Then
                    tb.Text = tb.Tag
                    tb.ForeColor = SystemColors.ScrollBar
                End If
            End Sub


    End Sub

    Public Sub PPlaceholder(textBox As TextBox, placeholderText As String)
        textBox.Tag = placeholderText
        textBox.ForeColor = SystemColors.ScrollBar
        textBox.Text = placeholderText
        ph = True
        AddHandler textBox.GotFocus,
            Sub(sender As Object, e As EventArgs)
                Dim tb = DirectCast(sender, TextBox)
                If tb.Text = tb.Tag Then
                    tb.Text = ""
                    textBox.PasswordChar = "*"c
                    tb.ForeColor = SystemColors.ControlText
                    ph = False
                End If
            End Sub

        AddHandler textBox.LostFocus,
            Sub(sender As Object, e As EventArgs)
                Dim tb = DirectCast(sender, TextBox)
                If String.IsNullOrWhiteSpace(tb.Text) Then
                    tb.Text = tb.Tag
                    textBox.PasswordChar = ControlChars.NullChar
                    tb.ForeColor = SystemColors.ScrollBar
                End If
            End Sub


    End Sub

    Public Sub SetPasswordField(textBox As TextBox)
        textBox.PasswordChar = "*"c
    End Sub

    ' Método para alternar la visibilidad de la contraseña
    Public Sub TogglePasswordVisibility(textBox As TextBox, button As PictureBox)
        If textBox.PasswordChar = "*"c Then

            textBox.PasswordChar = ControlChars.NullChar
            button.Text = "Ocultar Contraseña"
        Else
            ' Ocultar el texto de la contraseña
            textBox.PasswordChar = "*"c
            button.Text = "Mostrar Contraseña"
        End If
    End Sub

End Module
