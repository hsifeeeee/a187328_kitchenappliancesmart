

Public Class frm_insertproducts_a187328

    Dim defaultpicture As String = Application.StartupPath & "\pictures\no_photo.jpg"

    Private Sub frm_insertproducts_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        cmb_warranty.Items.Add("6 months")
        cmb_warranty.Items.Add("12 months")
        cmb_warranty.Items.Add("24 months")

        cmb_warranty.SelectedIndex = 1



    End Sub

    Private Sub refresh_grid()

        grd_products.DataSource = run_select("select * from tbl_products_a187328 order by fld_product_id")

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Origin Country"
        grd_products.Columns(5).HeaderText = "Warranty"
        grd_products.Columns(6).HeaderText = "Power Consumption"

        txt_productid.Text = generate_productid()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_country.Text = ""
        txt_power.Text = ""


        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_productid() As String

        Dim lastproductid As String = run_select("select max(fld_product_id) as maxproductid 
                                                 from tbl_products_a187328").Rows(0).Item("maxproductid")

        'MsgBox(lastproductid)

        'read starting from 2 character onwards
        Dim nextproductid As String = "P" & Mid(lastproductid, 2) + 1

        Return nextproductid

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "insert into tbl_products_a187328 values ('" & txt_productid.Text & "', 
                                                                        '" & txt_name.Text & "', 
                                                                        " & txt_price.Text & ", 
                                                                        '" & txt_brand.Text & "',
                                                                        '" & txt_country.Text & "', 
                                                                        '" & cmb_warranty.Text & "', 
                                                                        " & txt_power.Text & ")"

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)



        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_productid.Text & ".jpg")

            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered:" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click


        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg) | *.jpg"
        OpenFileDialog1.ShowDialog()

        If (OpenFileDialog1.FileName = "") Then
            OpenFileDialog1.FileName = defaultpicture
        End If

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub
End Class