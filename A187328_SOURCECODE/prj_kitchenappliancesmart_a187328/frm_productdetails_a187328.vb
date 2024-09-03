Public Class frm_productdetails_a187328
    Private Sub frm_productdetails_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "select fld_product_name from tbl_products_a187328 order by fld_product_id"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        lst_productname.DataSource = mytable
        lst_productname.DisplayMember = "fld_product_name"

        refresh_text(lst_productname.Text)

    End Sub

    Private Sub refresh_text(product_name As String)

        'MsgBox(product_name)

        Dim mysql As String = "select * from tbl_products_a187328 where fld_product_name = '" & product_name & "'"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        txt_productname.Text = mytable.Rows(0).Item("fld_product_name")
        txt_productid.Text = mytable.Rows(0).Item("fld_product_id")
        txt_price.Text = mytable.Rows(0).Item("fld_price")
        txt_brand.Text = mytable.Rows(0).Item("fld_brand")
        txt_country.Text = mytable.Rows(0).Item("fld_origin_country")
        txt_warranty.Text = mytable.Rows(0).Item("fld_warrantylength")
        txt_power.Text = mytable.Rows(0).Item("fld_power_consumption")


        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_productid.Text & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("pictures/no_photo.jpg")

        End Try

    End Sub


    Private Sub lst_productname_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productname.MouseClick

        refresh_text(lst_productname.Text)

    End Sub


End Class