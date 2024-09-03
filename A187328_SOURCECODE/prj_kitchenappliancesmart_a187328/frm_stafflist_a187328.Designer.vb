<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stafflist_a187328
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
        Me.lbl_stafflist = New System.Windows.Forms.Label()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_stafflist
        '
        Me.lbl_stafflist.AutoSize = True
        Me.lbl_stafflist.BackColor = System.Drawing.Color.Beige
        Me.lbl_stafflist.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stafflist.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_stafflist.Location = New System.Drawing.Point(133, 43)
        Me.lbl_stafflist.Name = "lbl_stafflist"
        Me.lbl_stafflist.Size = New System.Drawing.Size(251, 63)
        Me.lbl_stafflist.TabIndex = 3
        Me.lbl_stafflist.Text = "Staff List"
        '
        'grd_staff
        '
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(34, 147)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 62
        Me.grd_staff.RowTemplate.Height = 28
        Me.grd_staff.Size = New System.Drawing.Size(440, 264)
        Me.grd_staff.TabIndex = 2
        '
        'frm_stafflist_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(503, 450)
        Me.Controls.Add(Me.lbl_stafflist)
        Me.Controls.Add(Me.grd_staff)
        Me.Name = "frm_stafflist_a187328"
        Me.Text = "Kitchen Appliances Mart - Staff List"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_stafflist As Label
    Friend WithEvents grd_staff As DataGridView
End Class
