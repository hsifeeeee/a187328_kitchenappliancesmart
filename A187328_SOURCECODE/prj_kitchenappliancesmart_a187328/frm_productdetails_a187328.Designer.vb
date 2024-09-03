<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a187328
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a187328))
        Me.lbl_productcatalogue = New System.Windows.Forms.Label()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.lst_productname = New System.Windows.Forms.ListBox()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.lbl_country = New System.Windows.Forms.Label()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.lbl_warranty = New System.Windows.Forms.Label()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.lbl_power = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_productcatalogue
        '
        Me.lbl_productcatalogue.AutoSize = True
        Me.lbl_productcatalogue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productcatalogue.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productcatalogue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_productcatalogue.Location = New System.Drawing.Point(355, 33)
        Me.lbl_productcatalogue.Name = "lbl_productcatalogue"
        Me.lbl_productcatalogue.Size = New System.Drawing.Size(421, 63)
        Me.lbl_productcatalogue.TabIndex = 0
        Me.lbl_productcatalogue.Text = "Product Catalog"
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.SaddleBrown
        Me.lbl_instruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_instruction.Location = New System.Drawing.Point(53, 130)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_instruction.Size = New System.Drawing.Size(392, 20)
        Me.lbl_instruction.TabIndex = 1
        Me.lbl_instruction.Text = "Select the PRODUCT NAME from the list below:"
        '
        'lst_productname
        '
        Me.lst_productname.FormattingEnabled = True
        Me.lst_productname.ItemHeight = 20
        Me.lst_productname.Location = New System.Drawing.Point(55, 154)
        Me.lst_productname.Name = "lst_productname"
        Me.lst_productname.Size = New System.Drawing.Size(407, 424)
        Me.lst_productname.TabIndex = 2
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_productid.Location = New System.Drawing.Point(484, 155)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(104, 22)
        Me.lbl_productid.TabIndex = 3
        Me.lbl_productid.Text = "Product ID"
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(488, 178)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.ReadOnly = True
        Me.txt_productid.Size = New System.Drawing.Size(184, 26)
        Me.txt_productid.TabIndex = 4
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(697, 178)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.ReadOnly = True
        Me.txt_productname.Size = New System.Drawing.Size(389, 26)
        Me.txt_productname.TabIndex = 6
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_productname.Location = New System.Drawing.Point(693, 155)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(61, 22)
        Me.lbl_productname.TabIndex = 5
        Me.lbl_productname.Text = "Name"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(524, 257)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(148, 26)
        Me.txt_price.TabIndex = 8
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_price.Location = New System.Drawing.Point(484, 234)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(56, 22)
        Me.lbl_price.TabIndex = 7
        Me.lbl_price.Text = "Price"
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(488, 326)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(184, 26)
        Me.txt_brand.TabIndex = 10
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_brand.Location = New System.Drawing.Point(484, 303)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(63, 22)
        Me.lbl_brand.TabIndex = 9
        Me.lbl_brand.Text = "Brand"
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(488, 401)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.ReadOnly = True
        Me.txt_country.Size = New System.Drawing.Size(184, 26)
        Me.txt_country.TabIndex = 12
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.BackColor = System.Drawing.Color.Transparent
        Me.lbl_country.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_country.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_country.Location = New System.Drawing.Point(484, 378)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(140, 22)
        Me.lbl_country.TabIndex = 11
        Me.lbl_country.Text = "Origin Country"
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(488, 476)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.ReadOnly = True
        Me.txt_warranty.Size = New System.Drawing.Size(184, 26)
        Me.txt_warranty.TabIndex = 14
        '
        'lbl_warranty
        '
        Me.lbl_warranty.AutoSize = True
        Me.lbl_warranty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warranty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_warranty.Location = New System.Drawing.Point(484, 453)
        Me.lbl_warranty.Name = "lbl_warranty"
        Me.lbl_warranty.Size = New System.Drawing.Size(158, 22)
        Me.lbl_warranty.TabIndex = 13
        Me.lbl_warranty.Text = "Warranty Length"
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(488, 552)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.ReadOnly = True
        Me.txt_power.Size = New System.Drawing.Size(154, 26)
        Me.txt_power.TabIndex = 16
        '
        'lbl_power
        '
        Me.lbl_power.AutoSize = True
        Me.lbl_power.BackColor = System.Drawing.Color.Transparent
        Me.lbl_power.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_power.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_power.Location = New System.Drawing.Point(484, 529)
        Me.lbl_power.Name = "lbl_power"
        Me.lbl_power.Size = New System.Drawing.Size(188, 22)
        Me.lbl_power.TabIndex = 15
        Me.lbl_power.Text = "Power Consumption"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(697, 234)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(389, 344)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(486, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "RM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(646, 555)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "W"
        '
        'frm_productdetails_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1142, 690)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_power)
        Me.Controls.Add(Me.lbl_power)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.lbl_warranty)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.lst_productname)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.lbl_productcatalogue)
        Me.Name = "frm_productdetails_a187328"
        Me.Text = "Kitchen Appliances Mart - Product Catalog"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_productcatalogue As Label
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents lst_productname As ListBox
    Friend WithEvents lbl_productid As Label
    Friend WithEvents txt_productid As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents lbl_productname As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lbl_country As Label
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents lbl_warranty As Label
    Friend WithEvents txt_power As TextBox
    Friend WithEvents lbl_power As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
