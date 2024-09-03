Public Class frm_makeorder_a187328

    Dim staffTable As New DataTable
    Dim productTable As New DataTable
    Dim customerTable As New DataTable
    Dim orderTable As New DataTable
    Dim subtotal As New Double
    Dim totalOfCart As New Double


    Private Sub frm_makeorder_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("Please make sure you select the information from each category according to the numbering!")
        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        staffTable = run_select("select * from tbl_staff_a187328 order by fld_staff_id")
        productTable = run_select("select * from tbl_products_a187328 order by fld_product_id")
        customerTable = run_select("select * from tbl_customer_a187328 order by fld_customer_id")
        orderTable = run_select("select * from tbl_order_a187328 order by fld_order_id")

        cmb_staffid.DataSource = staffTable
        cmb_staffid.DisplayMember = "fld_staff_id"

        cmb_custid.DataSource = customerTable
        cmb_custid.DisplayMember = "fld_customer_id"

        cmb_prodid.DataSource = productTable
        cmb_prodid.DisplayMember = "fld_product_id"

        txt_orderid.Text = generate_orderid()

    End Sub

    Private Sub cmb_custid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_custid.SelectedIndexChanged

        cmb_custid.Text = customerTable.Rows(cmb_custid.SelectedIndex).Item("fld_customer_id")
        txt_custname.Text = customerTable.Rows(cmb_custid.SelectedIndex).Item("fld_customer_name")
        txt_phoneno.Text = customerTable.Rows(cmb_custid.SelectedIndex).Item("fld_customer_phone_no")
        txt_addr.Text = customerTable.Rows(cmb_custid.SelectedIndex).Item("fld_customer_address")

    End Sub

    Private Sub cmb_staffid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_staffid.SelectedIndexChanged

        cmb_staffid.Text = staffTable.Rows(cmb_staffid.SelectedIndex).Item("fld_staff_id")
        txt_staffname.Text = staffTable.Rows(cmb_staffid.SelectedIndex).Item("fld_staff_name")

    End Sub

    Private Sub cmb_prodid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prodid.SelectedIndexChanged

        cmb_prodid.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_product_id")
        txt_prodname.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_product_name")
        txt_price.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_price")
        txt_brand.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_brand")
        txt_country.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_origin_country")
        txt_warranty.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_warrantylength")
        txt_power.Text = productTable.Rows(cmb_prodid.SelectedIndex).Item("fld_power_consumption")

        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & cmb_prodid.Text & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("pictures/no_photo.jpg")

        End Try

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a187328.Show()

    End Sub

    Private Sub product_total()

        If txt_price.Text.Equals("") Then
            txt_subtotal.Text = "0.00"
        Else
            subtotal = num_quantity.Value * Double.Parse(txt_price.Text)
            txt_subtotal.Text = subtotal.ToString
        End If
    End Sub

    Private Sub num_quantity_ValueChanged(sender As Object, e As EventArgs) Handles num_quantity.ValueChanged

        product_total()

    End Sub

    Private Sub cart_total()

        If grd_neworder.Rows.Count > 0 Then
            totalOfCart = 0.00
            For i As Integer = 0 To grd_neworder.Rows.Count - 1
                totalOfCart += Double.Parse(grd_neworder.Rows(i).Cells(3).Value.ToString)
            Next
        Else
            totalOfCart = 0.00
        End If
        txt_total.Text = totalOfCart
    End Sub


    Private Function generate_orderid() As String

        Dim lastorderid As String = run_select("select max(fld_order_id) as maxorderid from tbl_order_a187328").Rows(0).Item("maxorderid")
        'MsgBox(lastorderid)
        Dim nextorderid As String = "B00" & Mid(lastorderid, 2) + 1
        Return nextorderid


    End Function
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If num_quantity.Value < 1 Then
            MsgBox("Please make sure you select at least one product!")
        Else
            grd_neworder.Rows.Add(cmb_prodid.Text, txt_prodname.Text, num_quantity.Value, subtotal)
            cart_total()
            txt_subtotal.Clear()
        End If

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim order_confirmation = MsgBox("Are you sure the product(s) selected is correct?" & vbCrLf & vbCrLf &
                                        "You will be restricted from removing product once you pressed CONFIRM ORDER button", MsgBoxStyle.YesNo)

        If order_confirmation = MsgBoxResult.Yes Then
            Dim mytransaction As OleDb.OleDbTransaction
            Dim lastrow As Integer = grd_neworder.RowCount

            Try

                Dim datetime As String
                myconnection2.Open()
                mytransaction = myconnection2.BeginTransaction
                datetime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

                Dim orderid As String = txt_orderid.Text
                Dim staffid As String = cmb_staffid.Text
                Dim custid As String = cmb_custid.Text

                Dim ordertablesql As String = $"insert into tbl_order_a187328 values('" & orderid & "','" & staffid & "','" & custid & "','" & DateTime & "')"
                Dim ordertablewriter As New OleDb.OleDbCommand(ordertablesql, myconnection2, mytransaction)
                ordertablewriter.ExecuteNonQuery()



                For i As Integer = 0 To lastrow - 1

                    Dim prodid As String = grd_neworder(0, i).Value
                    ' Dim prodname As String = grd_neworder(1, i).Value
                    Dim quantity As String = grd_neworder(2, i).Value
                    ' Dim prodprice As String = grd_neworder(3, i).Value


                    Dim mysql As String = "insert into tbl_order_description_a187328 values ('" & orderid & "','" & prodid & "'," & quantity & ")"
                    MsgBox(mysql)
                    Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                    mywriter.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()

                'after close connection assuming it is correct
                refresh_grid()
                'to confirm when do another rg, wont see additional records
                'grd_newreg.Rows.Clear()

            Catch ex As Exception

                Beep()
                MsgBox("There is a problem with your transaction:" & vbCrLf & vbCrLf & ex.Message)

                mytransaction.Rollback()
                myconnection2.Close()


            End Try

        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click

        For Each row As DataGridViewRow In grd_neworder.SelectedRows
            grd_neworder.Rows.Remove(row)
        Next
        cart_total()

    End Sub

    Private Sub btn_orderagain_Click(sender As Object, e As EventArgs) Handles btn_orderagain.Click
        Application.Restart()
        Me.Refresh()
    End Sub
End Class