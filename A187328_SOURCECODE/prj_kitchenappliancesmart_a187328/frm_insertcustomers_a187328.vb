Public Class frm_insertcustomers_a187328
    Private Sub frm_insertcustomers_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_customer.DataSource = run_select("select * from tbl_customer_a187328")

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Contact Number"
        grd_customer.Columns(3).HeaderText = "Address"

        txt_custid.Text = generate_custid()
        txt_custname.Text = ""
        txt_phoneno.Text = ""
        txt_addr.Text = ""


    End Sub

    Private Function generate_custid() As String

        Dim lastcustid As String = run_select("select max(fld_customer_id) as maxcustid 
                                                 from tbl_customer_a187328").Rows(0).Item("maxcustid")

        'MsgBox(lastproductid)

        'read starting from 2 character onwards
        Dim nextcustid As String = "C0" & Mid(lastcustid, 2) + 1


        Return nextcustid

    End Function

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click

        Dim mysql As String = "insert into tbl_customer_a187328 values ('" & txt_custid.Text & "', 
                                                                        '" & txt_custname.Text & "',
                                                                        '" & txt_phoneno.Text & "',
                                                                        '" & txt_addr.Text & "')"

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