<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashscreen_a187328
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splashscreen_a187328))
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbl_mart = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_matric = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.Blue
        Me.btn_start.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_start.Location = New System.Drawing.Point(312, 217)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(152, 98)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'lbl_mart
        '
        Me.lbl_mart.AutoSize = True
        Me.lbl_mart.BackColor = System.Drawing.Color.Silver
        Me.lbl_mart.Font = New System.Drawing.Font("Cooper Black", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mart.ForeColor = System.Drawing.Color.Blue
        Me.lbl_mart.Location = New System.Drawing.Point(35, 128)
        Me.lbl_mart.Name = "lbl_mart"
        Me.lbl_mart.Size = New System.Drawing.Size(736, 64)
        Me.lbl_mart.TabIndex = 1
        Me.lbl_mart.Text = "Kitchen Appliances Mart"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Blue
        Me.lbl_name.Location = New System.Drawing.Point(24, 409)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(152, 26)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "YEE XIN JIE"
        '
        'lbl_matric
        '
        Me.lbl_matric.AutoSize = True
        Me.lbl_matric.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matric.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matric.ForeColor = System.Drawing.Color.Blue
        Me.lbl_matric.Location = New System.Drawing.Point(182, 409)
        Me.lbl_matric.Name = "lbl_matric"
        Me.lbl_matric.Size = New System.Drawing.Size(117, 26)
        Me.lbl_matric.TabIndex = 3
        Me.lbl_matric.Text = "(A187328)"
        '
        'frm_splashscreen_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_matric)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_mart)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "frm_splashscreen_a187328"
        Me.Text = "Kitchen Appliances Mart "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents lbl_mart As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_matric As Label
End Class
