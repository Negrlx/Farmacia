﻿Imports System.Net.Mail

Public Class Form2

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            Dim currentTextBox As TextBox = CType(sender, TextBox)
            currentTextBox.Text = e.KeyChar.ToString()
            e.Handled = True
            SelectNextControl(currentTextBox, True, True, True, True)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pss As String = TextBox1.Text + TextBox2.Text + TextBox5.Text + TextBox4.Text + TextBox3.Text
        Dim vd As String = ("11111")


        If (pss = vd) Then
            Form1.Hide()
            Me.Close()
            C.Show()
        Else
            MessageBox.Show("CODIGO DE AUTORIZACION INCORRECTO")
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class