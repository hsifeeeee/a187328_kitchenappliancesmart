Module mod_globals_a187328

    Public username As String

    Public myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
                                     Data Source = DB_KITCHENAPPLIANCESMART_A187328.accdb;
                                     Persist Security Info=False;"

    Public myconnection2 As New OleDb.OleDbConnection(myconnection)


    Public Function run_select(mysql As String) As DataTable

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try

            myreader.Fill(mytable)

        Catch ex As Exception

            Beep()
            MsgBox("There is an error in your selected SQL! " & ex.Message)

        End Try

        Return mytable

    End Function

    Public Sub run_command(mysql As String)

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("There is an error in data you entered or changed:" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

End Module
