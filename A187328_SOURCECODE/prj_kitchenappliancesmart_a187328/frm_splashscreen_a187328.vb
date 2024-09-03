Public Class frm_splashscreen_a187328
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        frm_mainmenu_a187328.Show()
        Me.Hide()


    End Sub

    Private Sub frm_splashscreen_a187328_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MsgBox("Welcome to Kitchen Appliances Mart!")

    End Sub

    Private Sub frm_splashscreen_a187328_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        MsgBox("Good Bye!")

    End Sub
End Class
