Public Class frm_updatecustomers_a187328

    Dim current_custid As String
    Private Sub frm_updatecustomers_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_customer.DataSource = run_select("select * from tbl_customer_a187328")

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Contact Number"
        grd_customer.Columns(3).HeaderText = "Address"

        get_current_custid()

    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_custid()

    End Sub
    Private Sub get_current_custid()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_custid = grd_customer(0, current_row).Value

        'MsgBox(current_custid)

        txt_custid.Text = current_custid
        txt_custname.Text = grd_customer(1, current_row).Value
        txt_phoneno.Text = grd_customer(2, current_row).Value
        txt_addr.Text = grd_customer(3, current_row).Value

    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_command("update tbl_customer_a187328 set fld_customer_name= '" & txt_custname.Text & "', 
                                                     fld_customer_phone_no=" & txt_phoneno.Text & ", 
                                                     fld_customer_address='" & txt_addr.Text & "' where fld_customer_id= '" & current_custid & "' ")

        Beep()
        MsgBox("You have successfully updated the customer '" & current_custid & " '")

        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to delete the customer '" & current_custid & "' ?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from tbl_customer_a187328 where fld_customer_id = '" & current_custid & "'")

            Beep()
            MsgBox("The customer '" & current_custid & "'has been successfully deleted.")

            refresh_grid()

        End If

    End Sub


End Class