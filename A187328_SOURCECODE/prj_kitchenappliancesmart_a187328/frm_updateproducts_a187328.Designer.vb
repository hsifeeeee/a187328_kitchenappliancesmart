<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproducts_a187328
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
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.lbl_step2 = New System.Windows.Forms.Label()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_step1 = New System.Windows.Forms.Label()
        Me.lbl_updatedeleteproducts = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.lbl_power = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_warranty = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Indigo
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(1041, 449)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(124, 103)
        Me.btn_update.TabIndex = 27
        Me.btn_update.Text = "UPDATE PRODUCT"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_delete.Location = New System.Drawing.Point(1041, 572)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 103)
        Me.btn_delete.TabIndex = 26
        Me.btn_delete.Text = "DELETE PRODUCT"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(160, 487)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(499, 26)
        Me.txt_name.TabIndex = 21
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(157, 463)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(136, 22)
        Me.lbl_name.TabIndex = 20
        Me.lbl_name.Text = "Product Name"
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(22, 487)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.ReadOnly = True
        Me.txt_productid.Size = New System.Drawing.Size(132, 26)
        Me.txt_productid.TabIndex = 19
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.Location = New System.Drawing.Point(19, 463)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(104, 22)
        Me.lbl_productid.TabIndex = 18
        Me.lbl_productid.Text = "Product ID"
        '
        'lbl_step2
        '
        Me.lbl_step2.AutoSize = True
        Me.lbl_step2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_step2.Location = New System.Drawing.Point(23, 414)
        Me.lbl_step2.Name = "lbl_step2"
        Me.lbl_step2.Size = New System.Drawing.Size(508, 20)
        Me.lbl_step2.TabIndex = 17
        Me.lbl_step2.Text = "STEP 2 : Edit the data you want to change and click the update button:"
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(27, 111)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.RowHeadersWidth = 62
        Me.grd_products.RowTemplate.Height = 28
        Me.grd_products.Size = New System.Drawing.Size(1138, 269)
        Me.grd_products.TabIndex = 16
        '
        'lbl_step1
        '
        Me.lbl_step1.AutoSize = True
        Me.lbl_step1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_step1.Location = New System.Drawing.Point(35, 88)
        Me.lbl_step1.Name = "lbl_step1"
        Me.lbl_step1.Size = New System.Drawing.Size(309, 20)
        Me.lbl_step1.TabIndex = 15
        Me.lbl_step1.Text = "STEP 1: Select product from the list below:"
        '
        'lbl_updatedeleteproducts
        '
        Me.lbl_updatedeleteproducts.AutoSize = True
        Me.lbl_updatedeleteproducts.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_updatedeleteproducts.Location = New System.Drawing.Point(259, 9)
        Me.lbl_updatedeleteproducts.Name = "lbl_updatedeleteproducts"
        Me.lbl_updatedeleteproducts.Size = New System.Drawing.Size(660, 63)
        Me.lbl_updatedeleteproducts.TabIndex = 14
        Me.lbl_updatedeleteproducts.Text = "Update or Delete Products"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(19, 547)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(56, 22)
        Me.lbl_price.TabIndex = 28
        Me.lbl_price.Text = "Price"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(52, 572)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(169, 26)
        Me.txt_price.TabIndex = 29
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(227, 572)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(218, 26)
        Me.txt_brand.TabIndex = 31
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(225, 547)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(63, 22)
        Me.lbl_brand.TabIndex = 30
        Me.lbl_brand.Text = "Brand"
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(451, 572)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(208, 26)
        Me.txt_country.TabIndex = 33
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_country.Location = New System.Drawing.Point(449, 547)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(140, 22)
        Me.lbl_country.TabIndex = 32
        Me.lbl_country.Text = "Origin Country"
        '
        'lbl_warranty
        '
        Me.lbl_warranty.AutoSize = True
        Me.lbl_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warranty.Location = New System.Drawing.Point(21, 624)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(158, 22)
        Me.lbl_warranty.TabIndex = 34
        Me.lbl_warranty.Text = "Warranty Length"
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(207, 649)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.Size = New System.Drawing.Size(207, 26)
        Me.txt_power.TabIndex = 37
        '
        'lbl_power
        '
        Me.lbl_power.AutoSize = True
        Me.lbl_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_power.Location = New System.Drawing.Point(205, 624)
        Me.lbl_power.Name = "lbl_power"
        Me.lbl_power.Size = New System.Drawing.Size(194, 22)
        Me.lbl_power.TabIndex = 36
        Me.lbl_power.Text = "Power Consumption "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 575)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "RM"
        '
        'cmb_warranty
        '
        Me.cmb_warranty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_warranty.FormattingEnabled = True
        Me.cmb_warranty.Location = New System.Drawing.Point(23, 649)
        Me.cmb_warranty.Name = "cmb_warranty"
        Me.cmb_warranty.Size = New System.Drawing.Size(177, 28)
        Me.cmb_warranty.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 672)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 41
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(679, 395)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(281, 281)
        Me.pic_product.TabIndex = 42
        Me.pic_product.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(418, 648)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "W"
        '
        'frm_updateproducts_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1193, 707)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_warranty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_power)
        Me.Controls.Add(Me.lbl_power)
        Me.Controls.Add(Me.lbl_warranty)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.lbl_step2)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_step1)
        Me.Controls.Add(Me.lbl_updatedeleteproducts)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Name = "frm_updateproducts_a187328"
        Me.Text = "Kitchen Appliances Mart - Update or Delete Products"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_productid As TextBox
    Friend WithEvents lbl_productid As Label
    Friend WithEvents lbl_step2 As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_step1 As Label
    Friend WithEvents lbl_updatedeleteproducts As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lbl_country As Label
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents txt_power As TextBox
    Friend WithEvents lbl_power As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_warranty As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
End Class
