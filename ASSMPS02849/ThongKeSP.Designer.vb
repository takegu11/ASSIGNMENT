<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongke
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
        Me.dgvThongke = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTim = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.dgvThongke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvThongke
        '
        Me.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongke.Location = New System.Drawing.Point(12, 110)
        Me.dgvThongke.Name = "dgvThongke"
        Me.dgvThongke.Size = New System.Drawing.Size(449, 169)
        Me.dgvThongke.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btnTim)
        Me.TabPage1.Controls.Add(Me.txtTim)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(441, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SanPham"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ASSMPS02849.My.Resources.Resources._2
        Me.Button1.Location = New System.Drawing.Point(160, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTim
        '
        Me.txtTim.Location = New System.Drawing.Point(6, 14)
        Me.txtTim.Name = "txtTim"
        Me.txtTim.Size = New System.Drawing.Size(100, 20)
        Me.txtTim.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(449, 100)
        Me.TabControl1.TabIndex = 1
        '
        'btnTim
        '
        Me.btnTim.Image = Global.ASSMPS02849.My.Resources.Resources.Capture2
        Me.btnTim.Location = New System.Drawing.Point(112, 6)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(42, 35)
        Me.btnTim.TabIndex = 1
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmThongke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 290)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.dgvThongke)
        Me.Name = "frmThongke"
        Me.Text = "THỐNG KÊ SẢN PHẨM"
        CType(Me.dgvThongke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvThongke As System.Windows.Forms.DataGridView
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents txtTim As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
End Class
