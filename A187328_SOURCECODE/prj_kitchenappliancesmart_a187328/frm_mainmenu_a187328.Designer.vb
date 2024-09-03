<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a187328
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a187328))
        Me.btn_productlist = New System.Windows.Forms.Button()
        Me.btn_custlist = New System.Windows.Forms.Button()
        Me.btn_stafflist = New System.Windows.Forms.Button()
        Me.btn_orderlist = New System.Windows.Forms.Button()
        Me.lbl_mainmenu = New System.Windows.Forms.Label()
        Me.btn_orderdesc = New System.Windows.Forms.Button()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_productdetails = New System.Windows.Forms.Button()
        Me.btn_insertproducts = New System.Windows.Forms.Button()
        Me.btn_updelproduct = New System.Windows.Forms.Button()
        Me.btn_insertcust = New System.Windows.Forms.Button()
        Me.btn_updelcust = New System.Windows.Forms.Button()
        Me.btn_insertstaff = New System.Windows.Forms.Button()
        Me.btn_updelstaff = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btn_makeOrder = New System.Windows.Forms.Button()
        Me.btn_viewOrder = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_productlist
        '
        Me.btn_productlist.BackColor = System.Drawing.Color.Teal
        Me.btn_productlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productlist.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_productlist.Location = New System.Drawing.Point(285, 143)
        Me.btn_productlist.Name = "btn_productlist"
        Me.btn_productlist.Size = New System.Drawing.Size(222, 68)
        Me.btn_productlist.TabIndex = 0
        Me.btn_productlist.Text = "List"
        Me.btn_productlist.UseVisualStyleBackColor = False
        '
        'btn_custlist
        '
        Me.btn_custlist.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_custlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_custlist.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_custlist.Location = New System.Drawing.Point(856, 163)
        Me.btn_custlist.Name = "btn_custlist"
        Me.btn_custlist.Size = New System.Drawing.Size(219, 68)
        Me.btn_custlist.TabIndex = 1
        Me.btn_custlist.Text = "List"
        Me.btn_custlist.UseVisualStyleBackColor = False
        '
        'btn_stafflist
        '
        Me.btn_stafflist.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_stafflist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stafflist.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_stafflist.Location = New System.Drawing.Point(288, 512)
        Me.btn_stafflist.Name = "btn_stafflist"
        Me.btn_stafflist.Size = New System.Drawing.Size(219, 68)
        Me.btn_stafflist.TabIndex = 2
        Me.btn_stafflist.Text = "List"
        Me.btn_stafflist.UseVisualStyleBackColor = False
        '
        'btn_orderlist
        '
        Me.btn_orderlist.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_orderlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderlist.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_orderlist.Location = New System.Drawing.Point(856, 448)
        Me.btn_orderlist.Name = "btn_orderlist"
        Me.btn_orderlist.Size = New System.Drawing.Size(249, 68)
        Me.btn_orderlist.TabIndex = 3
        Me.btn_orderlist.Text = " List"
        Me.btn_orderlist.UseVisualStyleBackColor = False
        '
        'lbl_mainmenu
        '
        Me.lbl_mainmenu.AutoSize = True
        Me.lbl_mainmenu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mainmenu.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mainmenu.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_mainmenu.Location = New System.Drawing.Point(454, 22)
        Me.lbl_mainmenu.Name = "lbl_mainmenu"
        Me.lbl_mainmenu.Size = New System.Drawing.Size(311, 63)
        Me.lbl_mainmenu.TabIndex = 4
        Me.lbl_mainmenu.Text = "Main Menu"
        '
        'btn_orderdesc
        '
        Me.btn_orderdesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_orderdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdesc.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_orderdesc.Location = New System.Drawing.Point(856, 522)
        Me.btn_orderdesc.Name = "btn_orderdesc"
        Me.btn_orderdesc.Size = New System.Drawing.Size(249, 68)
        Me.btn_orderdesc.TabIndex = 5
        Me.btn_orderdesc.Text = "Description List"
        Me.btn_orderdesc.UseVisualStyleBackColor = False
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(340, 94)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(523, 25)
        Me.lbl_instruction.TabIndex = 6
        Me.lbl_instruction.Text = "Click the button from each category to execute your choice:"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Maroon
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_exit.Location = New System.Drawing.Point(501, 753)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(158, 71)
        Me.btn_exit.TabIndex = 7
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_productdetails
        '
        Me.btn_productdetails.BackColor = System.Drawing.Color.Teal
        Me.btn_productdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productdetails.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_productdetails.Location = New System.Drawing.Point(285, 217)
        Me.btn_productdetails.Name = "btn_productdetails"
        Me.btn_productdetails.Size = New System.Drawing.Size(222, 68)
        Me.btn_productdetails.TabIndex = 8
        Me.btn_productdetails.Text = "Catalog"
        Me.btn_productdetails.UseVisualStyleBackColor = False
        '
        'btn_insertproducts
        '
        Me.btn_insertproducts.BackColor = System.Drawing.Color.Teal
        Me.btn_insertproducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertproducts.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_insertproducts.Location = New System.Drawing.Point(288, 291)
        Me.btn_insertproducts.Name = "btn_insertproducts"
        Me.btn_insertproducts.Size = New System.Drawing.Size(219, 68)
        Me.btn_insertproducts.TabIndex = 9
        Me.btn_insertproducts.Text = "lnsert "
        Me.btn_insertproducts.UseVisualStyleBackColor = False
        '
        'btn_updelproduct
        '
        Me.btn_updelproduct.BackColor = System.Drawing.Color.Teal
        Me.btn_updelproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updelproduct.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_updelproduct.Location = New System.Drawing.Point(288, 365)
        Me.btn_updelproduct.Name = "btn_updelproduct"
        Me.btn_updelproduct.Size = New System.Drawing.Size(219, 68)
        Me.btn_updelproduct.TabIndex = 10
        Me.btn_updelproduct.Text = "Update or Delete"
        Me.btn_updelproduct.UseVisualStyleBackColor = False
        '
        'btn_insertcust
        '
        Me.btn_insertcust.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_insertcust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertcust.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_insertcust.Location = New System.Drawing.Point(856, 237)
        Me.btn_insertcust.Name = "btn_insertcust"
        Me.btn_insertcust.Size = New System.Drawing.Size(219, 68)
        Me.btn_insertcust.TabIndex = 11
        Me.btn_insertcust.Text = "Insert"
        Me.btn_insertcust.UseVisualStyleBackColor = False
        '
        'btn_updelcust
        '
        Me.btn_updelcust.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_updelcust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updelcust.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_updelcust.Location = New System.Drawing.Point(856, 311)
        Me.btn_updelcust.Name = "btn_updelcust"
        Me.btn_updelcust.Size = New System.Drawing.Size(219, 68)
        Me.btn_updelcust.TabIndex = 12
        Me.btn_updelcust.Text = "Update or Delete"
        Me.btn_updelcust.UseVisualStyleBackColor = False
        '
        'btn_insertstaff
        '
        Me.btn_insertstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_insertstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertstaff.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_insertstaff.Location = New System.Drawing.Point(288, 586)
        Me.btn_insertstaff.Name = "btn_insertstaff"
        Me.btn_insertstaff.Size = New System.Drawing.Size(219, 68)
        Me.btn_insertstaff.TabIndex = 13
        Me.btn_insertstaff.Text = "Insert "
        Me.btn_insertstaff.UseVisualStyleBackColor = False
        '
        'btn_updelstaff
        '
        Me.btn_updelstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_updelstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updelstaff.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_updelstaff.Location = New System.Drawing.Point(288, 660)
        Me.btn_updelstaff.Name = "btn_updelstaff"
        Me.btn_updelstaff.Size = New System.Drawing.Size(219, 68)
        Me.btn_updelstaff.TabIndex = 14
        Me.btn_updelstaff.Text = "Update or Delete"
        Me.btn_updelstaff.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.Location = New System.Drawing.Point(83, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 41)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(645, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 41)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(111, 495)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 41)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Staff"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(679, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 41)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Order"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(75, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 164)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(75, 562)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 157)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(650, 214)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 164)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(652, 527)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(161, 157)
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'btn_makeOrder
        '
        Me.btn_makeOrder.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_makeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_makeOrder.Location = New System.Drawing.Point(856, 596)
        Me.btn_makeOrder.Name = "btn_makeOrder"
        Me.btn_makeOrder.Size = New System.Drawing.Size(249, 68)
        Me.btn_makeOrder.TabIndex = 24
        Me.btn_makeOrder.Text = "Make Order"
        Me.btn_makeOrder.UseVisualStyleBackColor = False
        '
        'btn_viewOrder
        '
        Me.btn_viewOrder.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_viewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_viewOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_viewOrder.Location = New System.Drawing.Point(856, 670)
        Me.btn_viewOrder.Name = "btn_viewOrder"
        Me.btn_viewOrder.Size = New System.Drawing.Size(249, 68)
        Me.btn_viewOrder.TabIndex = 25
        Me.btn_viewOrder.Text = "Invoice"
        Me.btn_viewOrder.UseVisualStyleBackColor = False
        '
        'frm_mainmenu_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1162, 841)
        Me.Controls.Add(Me.btn_viewOrder)
        Me.Controls.Add(Me.btn_makeOrder)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_updelstaff)
        Me.Controls.Add(Me.btn_insertstaff)
        Me.Controls.Add(Me.btn_updelcust)
        Me.Controls.Add(Me.btn_insertcust)
        Me.Controls.Add(Me.btn_updelproduct)
        Me.Controls.Add(Me.btn_insertproducts)
        Me.Controls.Add(Me.btn_productdetails)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.btn_orderdesc)
        Me.Controls.Add(Me.lbl_mainmenu)
        Me.Controls.Add(Me.btn_orderlist)
        Me.Controls.Add(Me.btn_stafflist)
        Me.Controls.Add(Me.btn_custlist)
        Me.Controls.Add(Me.btn_productlist)
        Me.Name = "frm_mainmenu_a187328"
        Me.Text = "Kitchen Appliances Mart - Main Menu "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_productlist As Button
    Friend WithEvents btn_custlist As Button
    Friend WithEvents btn_stafflist As Button
    Friend WithEvents btn_orderlist As Button
    Friend WithEvents lbl_mainmenu As Label
    Friend WithEvents btn_orderdesc As Button
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_productdetails As Button
    Friend WithEvents btn_insertproducts As Button
    Friend WithEvents btn_updelproduct As Button
    Friend WithEvents btn_insertcust As Button
    Friend WithEvents btn_updelcust As Button
    Friend WithEvents btn_insertstaff As Button
    Friend WithEvents btn_updelstaff As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_makeOrder As Button
    Friend WithEvents btn_viewOrder As Button
End Class
