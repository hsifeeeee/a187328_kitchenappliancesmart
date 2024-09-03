

Public Class frm_updateproducts_a187328

    Dim current_productid As String
    Private Sub frm_updateproducts_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmb_warranty.Items.Add("6 months")
        cmb_warranty.Items.Add("12 months")
        cmb_warranty.Items.Add("24 months")

        cmb_warranty.SelectedIndex = 1


        refresh_grid()

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

        get_current_productid()

    End Sub
    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick

        get_current_productid()

    End Sub
    Private Sub get_current_productid()

        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_productid = grd_products(0, current_row).Value

        'MsgBox(current_code)

        txt_productid.Text = current_productid
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_brand.Text = grd_products(3, current_row).Value
        txt_country.Text = grd_products(4, current_row).Value
        cmb_warranty.Text = grd_products(5, current_row).Value
        txt_power.Text = grd_products(6, current_row).Value

        Try

            pic_product.BackgroundImage = Image.FromFile("pictures/" & current_productid & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("pictures/no_photo.jpg")

        End Try

    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_command("update tbl_products_a187328 set fld_product_name= '" & txt_name.Text & "', 
                                                     fld_price=" & txt_price.Text & ", 
                                                     fld_brand='" & txt_brand.Text & "',
                                                     fld_origin_country='" & txt_country.Text & "',
                                                     fld_warrantylength='" & cmb_warranty.Text & "',
                                                     fld_power_consumption=" & txt_power.Text & "
                                                     where fld_product_id= '" & current_productid & "' ")


        Beep()
        MsgBox("You have successfully updated the product '" & current_productid & " '")

        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you want to delete the product '" & current_productid & "' ?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from tbl_products_a187328 where fld_product_id = '" & current_productid & "'")
            pic_product.BackgroundImage.Dispose()
            My.Computer.FileSystem.DeleteFile("pictures\" & current_productid & ".jpg")

            Beep()
            MsgBox("The product '" & current_productid & "'has been successfully deleted.")

            refresh_grid()

        End If



    End Sub

End Class