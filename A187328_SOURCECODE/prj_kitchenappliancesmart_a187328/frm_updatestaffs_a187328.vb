Public Class frm_updatestaffs_a187328

    Dim current_staffid As String
    Private Sub frm_updatestaffs_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select* from tbl_staff_a187328")

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"

        get_current_staffid()

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_staffid()

    End Sub
    Private Sub get_current_staffid()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_staffid = grd_staff(0, current_row).Value

        'MsgBox(current_staffid)

        txt_staffid.Text = current_staffid
        txt_staffname.Text = grd_staff(1, current_row).Value

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_command("update tbl_staff_a187328 set fld_staff_name= '" & txt_staffname.Text & "' where fld_staff_id= '" & current_staffid & "' ")

        Beep()
        MsgBox("You have successfully updated the staff '" & current_staffid & " '")

        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to delete the staff '" & current_staffid & "' ?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from tbl_staff_a187328 where fld_staff_id = '" & current_staffid & "'")

            Beep()
            MsgBox("The staff '" & current_staffid & "'has been successfully deleted.")

            refresh_grid()

        End If


    End Sub


End Class