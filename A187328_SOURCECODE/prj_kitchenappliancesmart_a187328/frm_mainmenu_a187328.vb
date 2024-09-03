Public Class frm_mainmenu_a187328

    Private Sub frm_mainmenu_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_productlist_Click(sender As Object, e As EventArgs) Handles btn_productlist.Click

        frm_productlist_a187328.Show()

    End Sub

    Private Sub btn_custlist_Click(sender As Object, e As EventArgs) Handles btn_custlist.Click

        frm_customerlist_a187328.Show()

    End Sub

    Private Sub btn_stafflist_Click(sender As Object, e As EventArgs) Handles btn_stafflist.Click

        frm_stafflist_a187328.Show()

    End Sub

    Private Sub btn_orderlist_Click(sender As Object, e As EventArgs) Handles btn_orderlist.Click

        frm_orderlist_a187328.Show()

    End Sub

    Private Sub btn_orderdesc_Click(sender As Object, e As EventArgs) Handles btn_orderdesc.Click

        frm_orderdesciptionlist_a187328.Show()

    End Sub



    Private Sub frm_mainmenu_a187328_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        End

    End Sub

    Private Sub btn_productdetails_Click(sender As Object, e As EventArgs) Handles btn_productdetails.Click

        frm_productdetails_a187328.Show()

    End Sub

    Private Sub btn_insertproducts_Click(sender As Object, e As EventArgs) Handles btn_insertproducts.Click

        frm_insertproducts_a187328.Show()

    End Sub

    Private Sub btn_updelproduct_Click(sender As Object, e As EventArgs) Handles btn_updelproduct.Click

        frm_updateproducts_a187328.Show()

    End Sub

    Private Sub btn_insertcust_Click(sender As Object, e As EventArgs) Handles btn_insertcust.Click

        frm_insertcustomers_a187328.Show()

    End Sub

    Private Sub btn_updelcust_Click(sender As Object, e As EventArgs) Handles btn_updelcust.Click

        frm_updatecustomers_a187328.Show()

    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click

        frm_insertstaffs_a187328.Show()

    End Sub

    Private Sub btn_updelstaff_Click(sender As Object, e As EventArgs) Handles btn_updelstaff.Click

        frm_updatestaffs_a187328.Show()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        End

    End Sub

    Private Sub btn_makeOrder_Click(sender As Object, e As EventArgs) Handles btn_makeOrder.Click
        frm_makeorder_a187328.Show()
    End Sub

    Private Sub btn_viewOrder_Click(sender As Object, e As EventArgs) Handles btn_viewOrder.Click
        frm_invoice_a187328.Show()
    End Sub
End Class