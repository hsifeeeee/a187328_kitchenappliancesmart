<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdesciptionlist_a187328
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
        Me.lbl_orderdesc = New System.Windows.Forms.Label()
        Me.grd_orderdesc = New System.Windows.Forms.DataGridView()
        CType(Me.grd_orderdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_orderdesc
        '
        Me.lbl_orderdesc.AutoSize = True
        Me.lbl_orderdesc.BackColor = System.Drawing.Color.Beige
        Me.lbl_orderdesc.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderdesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_orderdesc.Location = New System.Drawing.Point(35, 39)
        Me.lbl_orderdesc.Name = "lbl_orderdesc"
        Me.lbl_orderdesc.Size = New System.Drawing.Size(576, 63)
        Me.lbl_orderdesc.TabIndex = 3
        Me.lbl_orderdesc.Text = "Order Description List"
        '
        'grd_orderdesc
        '
        Me.grd_orderdesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderdesc.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_orderdesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdesc.Location = New System.Drawing.Point(34, 147)
        Me.grd_orderdesc.Name = "grd_orderdesc"
        Me.grd_orderdesc.RowHeadersWidth = 62
        Me.grd_orderdesc.RowTemplate.Height = 28
        Me.grd_orderdesc.Size = New System.Drawing.Size(577, 264)
        Me.grd_orderdesc.TabIndex = 2
        '
        'frm_orderdesciptionlist_a187328
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.lbl_orderdesc)
        Me.Controls.Add(Me.grd_orderdesc)
        Me.Name = "frm_orderdesciptionlist_a187328"
        Me.Text = "Kitchen Appliances Mart - Order Description List "
        CType(Me.grd_orderdesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_orderdesc As Label
    Friend WithEvents grd_orderdesc As DataGridView
End Class
