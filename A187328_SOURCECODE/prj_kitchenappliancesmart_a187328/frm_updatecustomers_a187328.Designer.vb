<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomers_a187328
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
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.lbl_step2 = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_step1 = New System.Windows.Forms.Label()
        Me.lbl_updatedeletestaffs = New System.Windows.Forms.Label()
        Me.lbl_phoneno = New System.Windows.Forms.Label()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.txt_addr = New System.Windows.Forms.TextBox()
        Me.lbl_addr = New System.Windows.Forms.Label()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(306, 544)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(209, 42)
        Me.btn_update.TabIndex = 59
        Me.btn_update.Text = "UPDATE CUSTOMER"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_delete.Location = New System.Drawing.Point(535, 544)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(221, 42)
        Me.btn_delete.TabIndex = 58
        Me.btn_delete.Text = "DELETE CUSTOMER"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_custname
        '
        Me.txt_custname.Location = New System.Drawing.Point(191, 421)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(284, 26)
        Me.txt_custname.TabIndex = 57
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(189, 397)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(152, 22)
        Me.lbl_name.TabIndex = 56
        Me.lbl_name.Text = "Customer Name"
        '
        'txt_custid
        '
        Me.txt_custid.Location = New System.Drawing.Point(53, 421)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(132, 26)
        Me.txt_custid.TabIndex = 55
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.Location = New System.Drawing.Point(50, 397)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(120, 22)
        Me.lbl_custid.TabIndex = 54
        Me.lbl_custid.Text = "Customer ID"
        '
        'lbl_step2
        '
        Me.lbl_step2.AutoSize = True
        Me.lbl_step2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_step2.Location = New System.Drawing.Point(62, 356)
        Me.lbl_step2.Name = "lbl_step2"
        Me.lbl_step2.Size = New System.Drawing.Size(508, 20)
        Me.lbl_step2.TabIndex = 53
        Me.lbl_step2.Text = "STEP 2 : Edit the data you want to change and click the update button:"
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(54, 121)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 62
        Me.grd_customer.RowTemplate.Height = 28
        Me.grd_customer.Size = New System.Drawing.Size(702, 219)
        Me.grd_customer.TabIndex = 52
        '
        'lbl_step1
        '
        Me.lbl_step1.AutoSize = True
        Me.lbl_step1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_step1.Location = New System.Drawing.Point(62, 98)
        Me.lbl_step1.Name = "lbl_step1"
        Me.lbl_step1.Size = New System.Drawing.Size(321, 20)
        Me.lbl_step1.TabIndex = 51
        Me.lbl_step1.Text = "STEP 1: Select customer from the list below:"
        '
        'lbl_updatedeletestaffs
        '
        Me.lbl_updatedeletestaffs.AutoSize = True
        Me.lbl_updatedeletestaffs.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_updatedeletestaffs.Location = New System.Drawing.Point(57, 20)
        Me.lbl_updatedeletestaffs.Name = "lbl_updatedeletestaffs"
        Me.lbl_updatedeletestaffs.Size = New System.Drawing.Size(705, 63)
        Me.lbl_updatedeletestaffs.TabIndex = 50
        Me.lbl_updatedeletestaffs.Text = "Update or Delete Customers"
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phoneno.Location = New System.Drawing.Point(52, 460)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(154, 22)
        Me.lbl_phoneno.TabIndex = 60
        Me.lbl_phoneno.Text = "Contact Number"
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(52, 484)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(248, 26)
        Me.txt_phoneno.TabIndex = 61
        '
        'txt_addr
        '
        Me.txt_addr.Location = New System.Drawing.Point(306, 484)
        Me.txt_addr.Name = "txt_addr"
        Me.txt_addr.Size = New System.Drawing.Size(450, 26)
        Me.txt_addr.TabIndex = 63
        '
        'lbl_addr
        '
        Me.lbl_addr.AutoSize = True
        Me.lbl_addr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addr.Location = New System.Drawing.Point(306, 460)
        Me.lbl_addr.Name = "lbl_addr"
        Me.lbl_addr.Size = New System.Drawing.Size(83, 22)
        Me.lbl_addr.TabIndex = 62
        Me.lbl_addr.Text = "Address"
        '
        'frm_updatecustomers_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(812, 625)
        Me.Controls.Add(Me.txt_addr)
        Me.Controls.Add(Me.lbl_addr)
        Me.Controls.Add(Me.txt_phoneno)
        Me.Controls.Add(Me.lbl_phoneno)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_custname)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_custid)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.lbl_step2)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_step1)
        Me.Controls.Add(Me.lbl_updatedeletestaffs)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "frm_updatecustomers_a187328"
        Me.Text = "Kitchen Appliances Mart - Update or Delete Customers"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents lbl_custid As Label
    Friend WithEvents lbl_step2 As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_step1 As Label
    Friend WithEvents lbl_updatedeletestaffs As Label
    Friend WithEvents lbl_phoneno As Label
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents txt_addr As TextBox
    Friend WithEvents lbl_addr As Label
End Class
