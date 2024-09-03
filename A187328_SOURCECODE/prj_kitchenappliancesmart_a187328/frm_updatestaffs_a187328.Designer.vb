<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatestaffs_a187328
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_step2 = New System.Windows.Forms.Label()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_step1 = New System.Windows.Forms.Label()
        Me.lbl_updatedeletestaffs = New System.Windows.Forms.Label()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(128, 544)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(209, 42)
        Me.btn_update.TabIndex = 49
        Me.btn_update.Text = "UPDATE STAFF"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_delete.Location = New System.Drawing.Point(354, 544)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(221, 42)
        Me.btn_delete.TabIndex = 48
        Me.btn_delete.Text = "DELETE STAFF"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_staffname
        '
        Me.txt_staffname.Location = New System.Drawing.Point(267, 496)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(499, 26)
        Me.txt_staffname.TabIndex = 47
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(264, 472)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(109, 22)
        Me.lbl_name.TabIndex = 46
        Me.lbl_name.Text = "Staff Name"
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(129, 496)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(132, 26)
        Me.txt_staffid.TabIndex = 45
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.Location = New System.Drawing.Point(126, 472)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(77, 22)
        Me.lbl_staffid.TabIndex = 44
        Me.lbl_staffid.Text = "Staff ID"
        '
        'lbl_step2
        '
        Me.lbl_step2.AutoSize = True
        Me.lbl_step2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_step2.Location = New System.Drawing.Point(138, 431)
        Me.lbl_step2.Name = "lbl_step2"
        Me.lbl_step2.Size = New System.Drawing.Size(508, 20)
        Me.lbl_step2.TabIndex = 43
        Me.lbl_step2.Text = "STEP 2 : Edit the data you want to change and click the update button:"
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(128, 137)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.RowHeadersWidth = 62
        Me.grd_staff.RowTemplate.Height = 28
        Me.grd_staff.Size = New System.Drawing.Size(699, 275)
        Me.grd_staff.TabIndex = 42
        '
        'lbl_step1
        '
        Me.lbl_step1.AutoSize = True
        Me.lbl_step1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_step1.Location = New System.Drawing.Point(136, 114)
        Me.lbl_step1.Name = "lbl_step1"
        Me.lbl_step1.Size = New System.Drawing.Size(287, 20)
        Me.lbl_step1.TabIndex = 41
        Me.lbl_step1.Text = "STEP 1: Select staff from the list below:"
        '
        'lbl_updatedeletestaffs
        '
        Me.lbl_updatedeletestaffs.AutoSize = True
        Me.lbl_updatedeletestaffs.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_updatedeletestaffs.Location = New System.Drawing.Point(131, 36)
        Me.lbl_updatedeletestaffs.Name = "lbl_updatedeletestaffs"
        Me.lbl_updatedeletestaffs.Size = New System.Drawing.Size(583, 63)
        Me.lbl_updatedeletestaffs.TabIndex = 40
        Me.lbl_updatedeletestaffs.Text = "Update or Delete Staffs"
        '
        'frm_updatestaffs_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(953, 639)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_step2)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_step1)
        Me.Controls.Add(Me.lbl_updatedeletestaffs)
        Me.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Name = "frm_updatestaffs_a187328"
        Me.Text = "Kitchen Appliances Mart - Update or Delete Staffs"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_staffname As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_step2 As Label
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_step1 As Label
    Friend WithEvents lbl_updatedeletestaffs As Label
End Class
