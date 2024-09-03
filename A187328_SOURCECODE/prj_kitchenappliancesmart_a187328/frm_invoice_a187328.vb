Public Class frm_invoice_a187328

    Dim productTable As New DataTable
    Dim customerTable As New DataTable
    Dim orderDescTable As New DataTable
    Dim orderTable As New DataTable

    Private Sub frm_invoice_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a187328.Show()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Me.Close()

    End Sub

    Private Sub refresh_grid()

        customerTable = run_select("select * from tbl_customer_a187328 order by fld_customer_id")
        orderDescTable = run_select("select * from tbl_order_description_a187328")
        orderTable = run_select("select * from tbl_order_a187328 order by fld_order_id")

        cmb_orderid.DataSource = orderTable
        cmb_orderid.DisplayMember = "fld_order_id"

        refresh_orderid()
    End Sub

    Private Sub cmb_orderid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_orderid.SelectedIndexChanged

        refresh_orderid()

        'Dim orderid = cmb_orderid.Text
        'Dim orderRec = "fld_order_id = orderid"

        'Dim orderRows() As DataRow = orderTable.Select(orderRec)
        'Dim orderDescRows() As DataRow = orderDescTable.Select(orderRec)
        Dim orderIdString As String
        orderIdString = $"FLD_ORDER_ID = '{cmb_orderid.Text}'"
        Dim orderRows() As DataRow = orderTable.Select(orderIdString)
        Dim orderDescRows() As DataRow = orderDescTable.Select(orderIdString)

        If orderRows.Count > 0 Then
            lbl_datetime.Text = orderRows(0).Item("fld_datetime")
            lbl_custid.Text = orderRows(0).Item("fld_order_cust_id")


        End If

        Dim totalOfCart As New Double

        If orderDescRows.Count > 0 Then
            totalOfCart = 0
            For i As Integer = 0 To orderDescRows.Count - 1

                Dim prodid As String = orderDescRows(i).Item("fld_product_id")            
                productTable = run_select("select * from tbl_products_a187328 order by fld_product_id")


                Dim quantity As Integer = orderDescRows(i).Item("fld_quantity")
                Dim productPrice As Double = Double.Parse(Format(productTable.Rows(0).Item("FLD_PRICE"), "0.00"))
                Dim subtotal As Double = productPrice * quantity
                totalOfCart += subtotal
                grd_invoice.Rows.Add(prodid, quantity, Format(subtotal, "0.00"))
            Next
        End If
        lbl_total.Text = Format(totalOfCart, "0.00")
    End Sub

    Private Sub refresh_orderid()

        For Each row As DataGridViewRow In grd_invoice.Rows
            grd_invoice.Rows.RemoveAt(grd_invoice.Rows.Count - 1)
        Next
        If grd_invoice.Rows.Count > 0 Then
            grd_invoice.Rows.RemoveAt(0)
        End If

    End Sub
End Class