Public Class frm_orderdesciptionlist_a187328
    Private Sub frm_orderdesciptionlist_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
                                     Data Source = DB_KITCHENAPPLIANCESMART_A187328.accdb;
                                     Persist Security Info=False;"

        Dim mysql As String = "select * from TBL_ORDER_DESCRIPTION_A187328"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_orderdesc.DataSource = mytable

        grd_orderdesc.Columns(0).HeaderText = "Customer Order"
        grd_orderdesc.Columns(1).HeaderText = "Ordered Product"
        grd_orderdesc.Columns(2).HeaderText = "Quantity"

    End Sub


End Class