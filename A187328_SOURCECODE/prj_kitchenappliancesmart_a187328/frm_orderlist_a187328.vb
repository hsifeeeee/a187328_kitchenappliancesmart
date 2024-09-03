Public Class frm_orderlist_a187328
    Private Sub frm_orderlist_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
                                     Data Source = DB_KITCHENAPPLIANCESMART_A187328.accdb;
                                     Persist Security Info=False;"

        Dim mysql As String = "select * from TBL_ORDER_A187328"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_order.DataSource = mytable

        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(1).HeaderText = "Order Staff ID"
        grd_order.Columns(2).HeaderText = "Order Customer ID"
        grd_order.Columns(3).HeaderText = "Order Date/Time"

    End Sub
End Class