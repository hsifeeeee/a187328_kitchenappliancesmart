<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomers_a187328
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
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.lbl_custname = New System.Windows.Forms.Label()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.lbl_custid = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_insertrcust = New System.Windows.Forms.Label()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.lbl_phoneno = New System.Windows.Forms.Label()
        Me.txt_addr = New System.Windows.Forms.TextBox()
        Me.lbl_addr = New System.Windows.Forms.Label()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.SaddleBrown
        Me.btn_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_customer.Location = New System.Drawing.Point(706, 403)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(134, 75)
        Me.btn_customer.TabIndex = 13
        Me.btn_customer.Text = "INSERT CUSTOMER"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'txt_custname
        '
        Me.txt_custname.Location = New System.Drawing.Point(198, 383)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(225, 26)
        Me.txt_custname.TabIndex = 12
        '
        'lbl_custname
        '
        Me.lbl_custname.AutoSize = True
        Me.lbl_custname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custname.Location = New System.Drawing.Point(194, 360)
        Me.lbl_custname.Name = "lbl_custname"
        Me.lbl_custname.Size = New System.Drawing.Size(152, 22)
        Me.lbl_custname.TabIndex = 11
        Me.lbl_custname.Text = "Customer Name"
        '
        'txt_custid
        '
        Me.txt_custid.Location = New System.Drawing.Point(27, 383)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(150, 26)
        Me.txt_custid.TabIndex = 10
        '
        'lbl_custid
        '
        Me.lbl_custid.AutoSize = True
        Me.lbl_custid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custid.Location = New System.Drawing.Point(23, 360)
        Me.lbl_custid.Name = "lbl_custid"
        Me.lbl_custid.Size = New System.Drawing.Size(120, 22)
        Me.lbl_custid.TabIndex = 9
        Me.lbl_custid.Text = "Customer ID"
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(27, 101)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 62
        Me.grd_customer.RowTemplate.Height = 28
        Me.grd_customer.Size = New System.Drawing.Size(813, 229)
        Me.grd_customer.TabIndex = 8
        '
        'lbl_insertrcust
        '
        Me.lbl_insertrcust.AutoSize = True
        Me.lbl_insertrcust.BackColor = System.Drawing.Color.Transparent
        Me.lbl_insertrcust.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_insertrcust.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_insertrcust.Location = New System.Drawing.Point(154, 19)
        Me.lbl_insertrcust.Name = "lbl_insertrcust"
        Me.lbl_insertrcust.Size = New System.Drawing.Size(563, 63)
        Me.lbl_insertrcust.TabIndex = 7
        Me.lbl_insertrcust.Text = "Insert New Customers"
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(443, 383)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(225, 26)
        Me.txt_phoneno.TabIndex = 15
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phoneno.Location = New System.Drawing.Point(439, 360)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(154, 22)
        Me.lbl_phoneno.TabIndex = 14
        Me.lbl_phoneno.Text = "Contact Number"
        '
        'txt_addr
        '
        Me.txt_addr.Location = New System.Drawing.Point(27, 451)
        Me.txt_addr.Name = "txt_addr"
        Me.txt_addr.Size = New System.Drawing.Size(641, 26)
        Me.txt_addr.TabIndex = 17
        '
        'lbl_addr
        '
        Me.lbl_addr.AutoSize = True
        Me.lbl_addr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addr.Location = New System.Drawing.Point(23, 428)
        Me.lbl_addr.Name = "lbl_addr"
        Me.lbl_addr.Size = New System.Drawing.Size(83, 22)
        Me.lbl_addr.TabIndex = 16
        Me.lbl_addr.Text = "Address"
        '
        'frm_insertcustomers_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(870, 506)
        Me.Controls.Add(Me.txt_addr)
        Me.Controls.Add(Me.lbl_addr)
        Me.Controls.Add(Me.txt_phoneno)
        Me.Controls.Add(Me.lbl_phoneno)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.txt_custname)
        Me.Controls.Add(Me.lbl_custname)
        Me.Controls.Add(Me.txt_custid)
        Me.Controls.Add(Me.lbl_custid)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_insertrcust)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frm_insertcustomers_a187328"
        Me.Text = "Kitchen Appliances Mart - Insert New Customers"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_customer As Button
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents lbl_custname As Label
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents lbl_custid As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_insertrcust As Label
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents lbl_phoneno As Label
    Friend WithEvents txt_addr As TextBox
    Friend WithEvents lbl_addr As Label
End Class
