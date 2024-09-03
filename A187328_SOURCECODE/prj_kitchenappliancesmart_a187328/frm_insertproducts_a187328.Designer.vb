<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproducts_a187328
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
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.lbl_power = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmb_warranty = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(30, 89)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.RowHeadersWidth = 62
        Me.grd_products.RowTemplate.Height = 28
        Me.grd_products.Size = New System.Drawing.Size(1203, 258)
        Me.grd_products.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(396, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insert New Products"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(724, 365)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(307, 300)
        Me.pic_product.TabIndex = 2
        Me.pic_product.TabStop = False
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Tomato
        Me.lbl_instruction.ForeColor = System.Drawing.Color.White
        Me.lbl_instruction.Location = New System.Drawing.Point(25, 365)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(298, 20)
        Me.lbl_instruction.TabIndex = 3
        Me.lbl_instruction.Text = "Insert the details of a new product below:"
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.Location = New System.Drawing.Point(25, 399)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(104, 22)
        Me.lbl_productid.TabIndex = 4
        Me.lbl_productid.Text = "Product ID"
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(29, 422)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.ReadOnly = True
        Me.txt_productid.Size = New System.Drawing.Size(177, 26)
        Me.txt_productid.TabIndex = 5
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(223, 487)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(245, 26)
        Me.txt_brand.TabIndex = 7
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(219, 464)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(63, 22)
        Me.lbl_brand.TabIndex = 6
        Me.lbl_brand.Text = "Brand"
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(481, 487)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(203, 26)
        Me.txt_country.TabIndex = 9
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_country.Location = New System.Drawing.Point(477, 464)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(140, 22)
        Me.lbl_country.TabIndex = 8
        Me.lbl_country.Text = "Origin Country"
        '
        'lbl_warranty
        '
        Me.lbl_warranty.AutoSize = True
        Me.lbl_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warranty.Location = New System.Drawing.Point(25, 532)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(158, 22)
        Me.lbl_warranty.TabIndex = 10
        Me.lbl_warranty.Text = "Warranty Length"
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(223, 555)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.Size = New System.Drawing.Size(199, 26)
        Me.txt_power.TabIndex = 13
        '
        'lbl_power
        '
        Me.lbl_power.AutoSize = True
        Me.lbl_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_power.Location = New System.Drawing.Point(219, 532)
        Me.lbl_power.Name = "lbl_power"
        Me.lbl_power.Size = New System.Drawing.Size(188, 22)
        Me.lbl_power.TabIndex = 12
        Me.lbl_power.Text = "Power Consumption"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(223, 422)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(461, 26)
        Me.txt_name.TabIndex = 15
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(219, 399)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(136, 22)
        Me.lbl_productname.TabIndex = 14
        Me.lbl_productname.Text = "Product Name"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(61, 487)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(145, 26)
        Me.txt_price.TabIndex = 17
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(25, 464)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(56, 22)
        Me.lbl_price.TabIndex = 16
        Me.lbl_price.Text = "Price"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Maroon
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_insert.Location = New System.Drawing.Point(1054, 593)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(179, 72)
        Me.btn_insert.TabIndex = 18
        Me.btn_insert.Text = "INSERT PRODUCT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.Sienna
        Me.btn_picture.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_picture.Location = New System.Drawing.Point(29, 601)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(340, 32)
        Me.btn_picture.TabIndex = 19
        Me.btn_picture.Text = "Click to Select Product Picture from File"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(29, 639)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(655, 26)
        Me.txt_picture.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "RM"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmb_warranty
        '
        Me.cmb_warranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_warranty.FormattingEnabled = True
        Me.cmb_warranty.Location = New System.Drawing.Point(29, 555)
        Me.cmb_warranty.Name = "cmb_warranty"
        Me.cmb_warranty.Size = New System.Drawing.Size(177, 28)
        Me.cmb_warranty.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(426, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "W"
        '
        'frm_insertproducts_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1261, 703)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_warranty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.txt_power)
        Me.Controls.Add(Me.lbl_power)
        Me.Controls.Add(Me.lbl_warranty)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_products)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "frm_insertproducts_a187328"
        Me.Text = "Kitchen Appliances Mart - Insert New Products"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_products As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents lbl_productid As Label
    Friend WithEvents txt_productid As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lbl_country As Label
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents txt_power As TextBox
    Friend WithEvents lbl_power As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_productname As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmb_warranty As ComboBox
    Friend WithEvents Label3 As Label
End Class
