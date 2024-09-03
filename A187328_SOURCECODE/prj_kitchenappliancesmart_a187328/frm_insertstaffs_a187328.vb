Public Class frm_insertstaffs_a187328

    Private Sub frm_insertstaffs_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()


    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select* from tbl_staff_a187328")

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"

        txt_staffid.Text = generate_staffid()
        txt_staffname.Text = ""

    End Sub
    Private Function generate_staffid() As String

        Dim laststaffid As String = run_select("select max(fld_staff_id) as maxstaffid 
                                                 from tbl_staff_a187328").Rows(0).Item("maxstaffid")

        'MsgBox(lastproductid)

        'read starting from 2 character onwards
        Dim nextstaffid As String = "S0" & Mid(laststaffid, 2) + 1


        Return nextstaffid

    End Function

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        Dim mysql As String = "insert into tbl_staff_a187328 values ('" & txt_staffid.Text & "', 
                                                                        '" & txt_staffname.Text & "')"

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)


        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered:" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub
End Class