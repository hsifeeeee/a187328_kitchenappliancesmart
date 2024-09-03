<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerlist_a187328
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
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_custlist = New System.Windows.Forms.Label()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(26, 160)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 62
        Me.grd_customer.RowTemplate.Height = 28
        Me.grd_customer.Size = New System.Drawing.Size(732, 264)
        Me.grd_customer.TabIndex = 0
        '
        'lbl_custlist
        '
        Me.lbl_custlist.AutoSize = True
        Me.lbl_custlist.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custlist.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_custlist.Location = New System.Drawing.Point(200, 53)
        Me.lbl_custlist.Name = "lbl_custlist"
        Me.lbl_custlist.Size = New System.Drawing.Size(372, 63)
        Me.lbl_custlist.TabIndex = 1
        Me.lbl_custlist.Text = "Customer List"
        '
        'frm_customerlist_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_custlist)
        Me.Controls.Add(Me.grd_customer)
        Me.Name = "frm_customerlist_a187328"
        Me.Text = "Kitchen Appliances Mart - Customer List"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_custlist As Label
End Class
