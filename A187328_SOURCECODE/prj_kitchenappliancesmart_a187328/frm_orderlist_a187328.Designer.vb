<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderlist_a187328
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_orderlist = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_orderlist
        '
        Me.lbl_orderlist.AutoSize = True
        Me.lbl_orderlist.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderlist.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lbl_orderlist.Location = New System.Drawing.Point(296, 43)
        Me.lbl_orderlist.Name = "lbl_orderlist"
        Me.lbl_orderlist.Size = New System.Drawing.Size(284, 63)
        Me.lbl_orderlist.TabIndex = 3
        Me.lbl_orderlist.Text = "Order List"
        '
        'grd_order
        '
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(34, 147)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 62
        Me.grd_order.RowTemplate.Height = 28
        Me.grd_order.Size = New System.Drawing.Size(799, 264)
        Me.grd_order.TabIndex = 2
        '
        'frm_orderlist_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(867, 476)
        Me.Controls.Add(Me.lbl_orderlist)
        Me.Controls.Add(Me.grd_order)
        Me.Name = "frm_orderlist_a187328"
        Me.Text = "Kitchen Appliances Mart - Order List"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_orderlist As Label
    Friend WithEvents grd_order As DataGridView
End Class
