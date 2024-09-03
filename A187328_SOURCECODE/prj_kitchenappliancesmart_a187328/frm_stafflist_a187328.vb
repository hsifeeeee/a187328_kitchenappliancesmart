Public Class frm_stafflist_a187328
    Private Sub frm_stafflist_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
                                     Data Source = DB_KITCHENAPPLIANCESMART_A187328.accdb;
                                     Persist Security Info=False;"

        Dim mysql As String = "select * from TBL_STAFF_A187328"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_staff.DataSource = mytable

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"

    End Sub


End Class