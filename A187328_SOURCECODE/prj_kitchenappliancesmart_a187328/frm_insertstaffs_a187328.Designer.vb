<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaffs_a187328
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
        Me.lbl_insertrstaff = New System.Windows.Forms.Label()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.lbl_staffname = New System.Windows.Forms.Label()
        Me.btn_staff = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_insertrstaff
        '
        Me.lbl_insertrstaff.AutoSize = True
        Me.lbl_insertrstaff.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_insertrstaff.Location = New System.Drawing.Point(180, 23)
        Me.lbl_insertrstaff.Name = "lbl_insertrstaff"
        Me.lbl_insertrstaff.Size = New System.Drawing.Size(441, 63)
        Me.lbl_insertrstaff.TabIndex = 0
        Me.lbl_insertrstaff.Text = "Insert New Staffs"
        '
        'grd_staff
        '
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(33, 98)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 62
        Me.grd_staff.RowTemplate.Height = 28
        Me.grd_staff.Size = New System.Drawing.Size(424, 323)
        Me.grd_staff.TabIndex = 1
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(505, 105)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(77, 22)
        Me.lbl_staffid.TabIndex = 2
        Me.lbl_staffid.Text = "Staff ID"
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(509, 128)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(225, 26)
        Me.txt_staffid.TabIndex = 3
        '
        'txt_staffname
        '
        Me.txt_staffname.Location = New System.Drawing.Point(509, 231)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(225, 26)
        Me.txt_staffname.TabIndex = 5
        '
        'lbl_staffname
        '
        Me.lbl_staffname.AutoSize = True
        Me.lbl_staffname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffname.Location = New System.Drawing.Point(505, 208)
        Me.lbl_staffname.Name = "lbl_staffname"
        Me.lbl_staffname.Size = New System.Drawing.Size(109, 22)
        Me.lbl_staffname.TabIndex = 4
        Me.lbl_staffname.Text = "Staff Name"
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_staff.Location = New System.Drawing.Point(600, 346)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(134, 75)
        Me.btn_staff.TabIndex = 6
        Me.btn_staff.Text = "INSERT STAFF"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'frm_insertstaffs_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.lbl_staffname)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_insertrstaff)
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.Name = "frm_insertstaffs_a187328"
        Me.Text = "Kitchen Appliances Mart - Insert New Staffs"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_insertrstaff As Label
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents txt_staffname As TextBox
    Friend WithEvents lbl_staffname As Label
    Friend WithEvents btn_staff As Button
End Class
