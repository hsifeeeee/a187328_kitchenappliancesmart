<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a187328
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a187328))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.num_quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.grp_product = New System.Windows.Forms.GroupBox()
        Me.cmb_prodid = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_prodname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.cmb_staffid = New System.Windows.Forms.ComboBox()
        Me.grp_customer = New System.Windows.Forms.GroupBox()
        Me.txt_addr = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_custid = New System.Windows.Forms.ComboBox()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grp_cart = New System.Windows.Forms.GroupBox()
        Me.btn_orderagain = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.grd_neworder = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grp_staff = New System.Windows.Forms.GroupBox()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_product.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_customer.SuspendLayout()
        Me.grp_cart.SuspendLayout()
        CType(Me.grd_neworder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_staff.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 20)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "ID"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.SaddleBrown
        Me.btn_add.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_add.Location = New System.Drawing.Point(321, 453)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(135, 38)
        Me.btn_add.TabIndex = 23
        Me.btn_add.Text = "Add to Cart"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(170, 515)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "RM"
        '
        'num_quantity
        '
        Me.num_quantity.Location = New System.Drawing.Point(21, 465)
        Me.num_quantity.Name = "num_quantity"
        Me.num_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_quantity.Size = New System.Drawing.Size(176, 26)
        Me.num_quantity.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 509)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 29)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Total Price:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(210, 511)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(163, 26)
        Me.txt_subtotal.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 439)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(173, 400)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "W"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(219, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "RM"
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(21, 397)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.Size = New System.Drawing.Size(147, 26)
        Me.txt_power.TabIndex = 15
        '
        'grp_product
        '
        Me.grp_product.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grp_product.Controls.Add(Me.cmb_prodid)
        Me.grp_product.Controls.Add(Me.btn_add)
        Me.grp_product.Controls.Add(Me.Label15)
        Me.grp_product.Controls.Add(Me.num_quantity)
        Me.grp_product.Controls.Add(Me.Label14)
        Me.grp_product.Controls.Add(Me.txt_subtotal)
        Me.grp_product.Controls.Add(Me.Label13)
        Me.grp_product.Controls.Add(Me.Label12)
        Me.grp_product.Controls.Add(Me.Label11)
        Me.grp_product.Controls.Add(Me.txt_power)
        Me.grp_product.Controls.Add(Me.Label10)
        Me.grp_product.Controls.Add(Me.txt_warranty)
        Me.grp_product.Controls.Add(Me.Label9)
        Me.grp_product.Controls.Add(Me.txt_country)
        Me.grp_product.Controls.Add(Me.Label8)
        Me.grp_product.Controls.Add(Me.txt_brand)
        Me.grp_product.Controls.Add(Me.txt_price)
        Me.grp_product.Controls.Add(Me.txt_prodname)
        Me.grp_product.Controls.Add(Me.Label7)
        Me.grp_product.Controls.Add(Me.Label6)
        Me.grp_product.Controls.Add(Me.Label5)
        Me.grp_product.Controls.Add(Me.Label4)
        Me.grp_product.Controls.Add(Me.pic_product)
        Me.grp_product.Location = New System.Drawing.Point(265, 48)
        Me.grp_product.Name = "grp_product"
        Me.grp_product.Size = New System.Drawing.Size(480, 556)
        Me.grp_product.TabIndex = 27
        Me.grp_product.TabStop = False
        Me.grp_product.Text = "3. Select Product"
        '
        'cmb_prodid
        '
        Me.cmb_prodid.FormattingEnabled = True
        Me.cmb_prodid.Location = New System.Drawing.Point(21, 74)
        Me.cmb_prodid.Name = "cmb_prodid"
        Me.cmb_prodid.Size = New System.Drawing.Size(176, 28)
        Me.cmb_prodid.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Power Consumption"
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(22, 333)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(175, 26)
        Me.txt_warranty.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Warranty Length"
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(21, 267)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(176, 26)
        Me.txt_country.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Origin Country"
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(22, 201)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(175, 26)
        Me.txt_brand.TabIndex = 9
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(258, 76)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(152, 26)
        Me.txt_price.TabIndex = 8
        '
        'txt_prodname
        '
        Me.txt_prodname.Location = New System.Drawing.Point(21, 141)
        Me.txt_prodname.Name = "txt_prodname"
        Me.txt_prodname.Size = New System.Drawing.Size(435, 26)
        Me.txt_prodname.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Brand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(224, 178)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(232, 252)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'cmb_staffid
        '
        Me.cmb_staffid.FormattingEnabled = True
        Me.cmb_staffid.Location = New System.Drawing.Point(14, 67)
        Me.cmb_staffid.Name = "cmb_staffid"
        Me.cmb_staffid.Size = New System.Drawing.Size(153, 28)
        Me.cmb_staffid.TabIndex = 25
        '
        'grp_customer
        '
        Me.grp_customer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grp_customer.Controls.Add(Me.txt_addr)
        Me.grp_customer.Controls.Add(Me.Label19)
        Me.grp_customer.Controls.Add(Me.txt_phoneno)
        Me.grp_customer.Controls.Add(Me.Label18)
        Me.grp_customer.Controls.Add(Me.cmb_custid)
        Me.grp_customer.Controls.Add(Me.txt_custname)
        Me.grp_customer.Controls.Add(Me.Label17)
        Me.grp_customer.Controls.Add(Me.Label16)
        Me.grp_customer.Location = New System.Drawing.Point(16, 306)
        Me.grp_customer.Name = "grp_customer"
        Me.grp_customer.Size = New System.Drawing.Size(234, 298)
        Me.grp_customer.TabIndex = 28
        Me.grp_customer.TabStop = False
        Me.grp_customer.Text = "2. Select Customer"
        '
        'txt_addr
        '
        Me.txt_addr.Location = New System.Drawing.Point(16, 252)
        Me.txt_addr.Name = "txt_addr"
        Me.txt_addr.Size = New System.Drawing.Size(204, 26)
        Me.txt_addr.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 229)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 20)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Address"
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(16, 191)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(153, 26)
        Me.txt_phoneno.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 20)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Contact Number"
        '
        'cmb_custid
        '
        Me.cmb_custid.FormattingEnabled = True
        Me.cmb_custid.Location = New System.Drawing.Point(16, 67)
        Me.cmb_custid.Name = "cmb_custid"
        Me.cmb_custid.Size = New System.Drawing.Size(153, 28)
        Me.cmb_custid.TabIndex = 26
        '
        'txt_custname
        '
        Me.txt_custname.Location = New System.Drawing.Point(16, 129)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(153, 26)
        Me.txt_custname.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 20)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Name"
        '
        'grp_cart
        '
        Me.grp_cart.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grp_cart.Controls.Add(Me.btn_orderagain)
        Me.grp_cart.Controls.Add(Me.btn_confirm)
        Me.grp_cart.Controls.Add(Me.btn_remove)
        Me.grp_cart.Controls.Add(Me.grd_neworder)
        Me.grp_cart.Location = New System.Drawing.Point(765, 48)
        Me.grp_cart.Name = "grp_cart"
        Me.grp_cart.Size = New System.Drawing.Size(531, 374)
        Me.grp_cart.TabIndex = 29
        Me.grp_cart.TabStop = False
        Me.grp_cart.Text = "4. Confirm or Remove Products in Shopping Cart"
        '
        'btn_orderagain
        '
        Me.btn_orderagain.BackColor = System.Drawing.Color.SaddleBrown
        Me.btn_orderagain.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_orderagain.Location = New System.Drawing.Point(353, 315)
        Me.btn_orderagain.Name = "btn_orderagain"
        Me.btn_orderagain.Size = New System.Drawing.Size(156, 44)
        Me.btn_orderagain.TabIndex = 3
        Me.btn_orderagain.Text = "Order Again"
        Me.btn_orderagain.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.SaddleBrown
        Me.btn_confirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_confirm.Location = New System.Drawing.Point(191, 316)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(156, 44)
        Me.btn_confirm.TabIndex = 2
        Me.btn_confirm.Text = "Confirm Order"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.SaddleBrown
        Me.btn_remove.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_remove.Location = New System.Drawing.Point(31, 316)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(154, 44)
        Me.btn_remove.TabIndex = 1
        Me.btn_remove.Text = "Remove Product"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'grd_neworder
        '
        Me.grd_neworder.AllowUserToAddRows = False
        Me.grd_neworder.AllowUserToDeleteRows = False
        Me.grd_neworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_neworder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_neworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_neworder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.grd_neworder.Location = New System.Drawing.Point(17, 41)
        Me.grd_neworder.Name = "grd_neworder"
        Me.grd_neworder.ReadOnly = True
        Me.grd_neworder.RowHeadersWidth = 62
        Me.grd_neworder.RowTemplate.Height = 28
        Me.grd_neworder.Size = New System.Drawing.Size(499, 263)
        Me.grd_neworder.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(952, 472)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 20)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "RM"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(799, 466)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(148, 29)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Total Price:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(992, 468)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(251, 26)
        Me.txt_total.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = " ID "
        '
        'grp_staff
        '
        Me.grp_staff.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grp_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.grp_staff.Controls.Add(Me.txt_staffname)
        Me.grp_staff.Controls.Add(Me.Label1)
        Me.grp_staff.Controls.Add(Me.Label3)
        Me.grp_staff.Controls.Add(Me.cmb_staffid)
        Me.grp_staff.Location = New System.Drawing.Point(16, 115)
        Me.grp_staff.Name = "grp_staff"
        Me.grp_staff.Size = New System.Drawing.Size(234, 171)
        Me.grp_staff.TabIndex = 34
        Me.grp_staff.TabStop = False
        Me.grp_staff.Text = "1. Select Staff"
        '
        'txt_staffname
        '
        Me.txt_staffname.Location = New System.Drawing.Point(14, 129)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(153, 26)
        Me.txt_staffname.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 51)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Make Order"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(907, 510)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 29)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Order ID:"
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(1033, 513)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.ReadOnly = True
        Me.txt_orderid.Size = New System.Drawing.Size(104, 26)
        Me.txt_orderid.TabIndex = 37
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_back.Location = New System.Drawing.Point(927, 557)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 47)
        Me.btn_back.TabIndex = 38
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Red
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_exit.Location = New System.Drawing.Point(1033, 557)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 47)
        Me.btn_exit.TabIndex = 39
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Subtotal"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'frm_makeorder_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1309, 632)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grp_staff)
        Me.Controls.Add(Me.grp_product)
        Me.Controls.Add(Me.grp_customer)
        Me.Controls.Add(Me.grp_cart)
        Me.Name = "frm_makeorder_a187328"
        Me.Text = "Kitchen Appliances Mart - Make Order"
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_product.ResumeLayout(False)
        Me.grp_product.PerformLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_customer.ResumeLayout(False)
        Me.grp_customer.PerformLayout()
        Me.grp_cart.ResumeLayout(False)
        CType(Me.grd_neworder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_staff.ResumeLayout(False)
        Me.grp_staff.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents num_quantity As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_power As TextBox
    Friend WithEvents grp_product As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_country As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_prodname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents cmb_staffid As ComboBox
    Friend WithEvents grp_customer As GroupBox
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents grp_cart As GroupBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents grd_neworder As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents grp_staff As GroupBox
    Friend WithEvents txt_staffname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_prodid As ComboBox
    Friend WithEvents txt_addr As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmb_custid As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_orderid As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_orderagain As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
