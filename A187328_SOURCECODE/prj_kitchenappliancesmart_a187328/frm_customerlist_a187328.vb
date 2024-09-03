Public Class frm_customerlist_a187328
    Private Sub frm_customerlist_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
                                     Data Source = DB_KITCHENAPPLIANCESMART_A187328.accdb;
                                     Persist Security Info=False;"

        Dim mysql As String = "select * from TBL_CUSTOMER_A187328"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_customer.DataSource = mytable

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Contact Number"
        grd_customer.Columns(3).HeaderText = "Address"

    End Sub


End Class