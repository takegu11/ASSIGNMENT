<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.KToolStripMenuItem, Me.HóaĐơnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ExitToolStripMenuItem.Text = "Back"
        '
        'KToolStripMenuItem
        '
        Me.KToolStripMenuItem.Name = "KToolStripMenuItem"
        Me.KToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KToolStripMenuItem.Text = "Khách Hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MÃ SẢN PHẨM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TÊN SẢN PHẨM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ĐƠN GIÁ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "MÃ LOẠI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(174, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SẢN PHẨM"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(156, 100)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 11
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(277, 100)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 20)
        Me.txt3.TabIndex = 11
        '
        'dgvSanpham
        '
        Me.dgvSanpham.AllowUserToAddRows = False
        Me.dgvSanpham.AllowUserToDeleteRows = False
        Me.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvSanpham.Location = New System.Drawing.Point(34, 221)
        Me.dgvSanpham.MultiSelect = False
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.ReadOnly = True
        Me.dgvSanpham.RowHeadersVisible = False
        Me.dgvSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanpham.Size = New System.Drawing.Size(462, 214)
        Me.dgvSanpham.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "MaSP"
        Me.Column1.HeaderText = "MaSP"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "TenSP"
        Me.Column2.HeaderText = "TenSP"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DonGia"
        Me.Column3.HeaderText = "DonGia"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "MaLoai"
        Me.Column4.HeaderText = "MaLoai"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(34, 99)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(98, 20)
        Me.txt1.TabIndex = 14
        '
        'btnEnd
        '
        Me.btnEnd.Image = Global.ASSMPS02849.My.Resources.Resources._6
        Me.btnEnd.Location = New System.Drawing.Point(459, 158)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(37, 34)
        Me.btnEnd.TabIndex = 12
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = Global.ASSMPS02849.My.Resources.Resources._5
        Me.btnNext.Location = New System.Drawing.Point(396, 158)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 34)
        Me.btnNext.TabIndex = 12
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.ASSMPS02849.My.Resources.Resources._3
        Me.btnBack.Location = New System.Drawing.Point(340, 158)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(37, 34)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Image = Global.ASSMPS02849.My.Resources.Resources._4
        Me.btnFirst.Location = New System.Drawing.Point(277, 158)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(36, 34)
        Me.btnFirst.TabIndex = 12
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Image = Global.ASSMPS02849.My.Resources.Resources._2
        Me.btnClear.Location = New System.Drawing.Point(218, 158)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(38, 34)
        Me.btnClear.TabIndex = 12
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Image = Global.ASSMPS02849.My.Resources.Resources._1
        Me.btnSua.Location = New System.Drawing.Point(156, 158)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(36, 34)
        Me.btnSua.TabIndex = 12
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.ASSMPS02849.My.Resources.Resources.Capture1
        Me.btnXoa.Location = New System.Drawing.Point(96, 158)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(36, 34)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Image = Global.ASSMPS02849.My.Resources.Resources.Capture
        Me.btnThem.Location = New System.Drawing.Point(34, 158)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(38, 34)
        Me.btnThem.TabIndex = 12
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'cbo1
        '
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Location = New System.Drawing.Point(396, 100)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(100, 21)
        Me.cbo1.TabIndex = 15
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 447)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSanPham"
        Me.Text = "SẢN PHẨM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents cbo1 As System.Windows.Forms.ComboBox
End Class
