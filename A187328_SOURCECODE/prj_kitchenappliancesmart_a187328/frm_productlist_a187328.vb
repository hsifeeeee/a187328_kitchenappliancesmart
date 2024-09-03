Public Class frm_productlist_a187328

    Private Sub frm_productlist_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
                                     Data Source = DB_KITCHENAPPLIANCESMART_A187328.accdb;
                                     Persist Security Info=False;"

        Dim mysql As String = "select * from TBL_PRODUCTS_A187328"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_products.DataSource = mytable

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Origin Country"
        grd_products.Columns(5).HeaderText = "Warranty"
        grd_products.Columns(6).HeaderText = "Power Consumption"

    End Sub

End Class