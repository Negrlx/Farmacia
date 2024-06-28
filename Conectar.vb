Imports MySql.Data
Imports MySql.Data.MySqlClient
Module Conectar
    Public Conex As MySqlConnection
    Sub Conectarr()
        Dim Cnc = "Server = localhost; Database = farmacia; Port = 3306; user id = root; password = ;"
        Try
            Conex = New MySqlConnection(Cnc)
            Conex.ConnectionString = Cnc
            Conex.Open()

        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub
End Module
