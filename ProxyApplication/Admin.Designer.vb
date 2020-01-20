<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hostTxt3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Div2 = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUBlock = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hostTxt2 = New System.Windows.Forms.TextBox()
        Me.btnBlock = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hostTxt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Div1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnViewBLK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.eid = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Div3 = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.goTxt = New System.Windows.Forms.TextBox()
        Me.cpyHost = New System.Windows.Forms.TextBox()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnBlock)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.hostTxt1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Div1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 565)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Block \ Restrict User"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.hostTxt3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Div2)
        Me.GroupBox3.Controls.Add(Me.btnChange)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 172)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Change Status "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Host  Address :"
        '
        'hostTxt3
        '
        Me.hostTxt3.Location = New System.Drawing.Point(170, 84)
        Me.hostTxt3.Name = "hostTxt3"
        Me.hostTxt3.Size = New System.Drawing.Size(201, 20)
        Me.hostTxt3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Division :"
        '
        'Div2
        '
        Me.Div2.Location = New System.Drawing.Point(170, 41)
        Me.Div2.Name = "Div2"
        Me.Div2.Size = New System.Drawing.Size(42, 20)
        Me.Div2.TabIndex = 5
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(61, 133)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(310, 23)
        Me.btnChange.TabIndex = 0
        Me.btnChange.Text = "Update"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUBlock)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.hostTxt2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 139)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UnBlock Site "
        '
        'btnUBlock
        '
        Me.btnUBlock.Location = New System.Drawing.Point(61, 95)
        Me.btnUBlock.Name = "btnUBlock"
        Me.btnUBlock.Size = New System.Drawing.Size(310, 23)
        Me.btnUBlock.TabIndex = 0
        Me.btnUBlock.Text = "Un Block"
        Me.btnUBlock.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Host  Address :"
        '
        'hostTxt2
        '
        Me.hostTxt2.Location = New System.Drawing.Point(162, 44)
        Me.hostTxt2.Name = "hostTxt2"
        Me.hostTxt2.Size = New System.Drawing.Size(201, 20)
        Me.hostTxt2.TabIndex = 3
        '
        'btnBlock
        '
        Me.btnBlock.Location = New System.Drawing.Point(67, 159)
        Me.btnBlock.Name = "btnBlock"
        Me.btnBlock.Size = New System.Drawing.Size(310, 23)
        Me.btnBlock.TabIndex = 0
        Me.btnBlock.Text = "Block"
        Me.btnBlock.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Host  Address :"
        '
        'hostTxt1
        '
        Me.hostTxt1.Location = New System.Drawing.Point(164, 101)
        Me.hostTxt1.Name = "hostTxt1"
        Me.hostTxt1.Size = New System.Drawing.Size(201, 20)
        Me.hostTxt1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Division :"
        '
        'Div1
        '
        Me.Div1.Location = New System.Drawing.Point(164, 58)
        Me.Div1.Name = "Div1"
        Me.Div1.Size = New System.Drawing.Size(42, 20)
        Me.Div1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnViewBLK)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.eid)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.btnSearch1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Div3)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 583)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1335, 227)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Status"
        '
        'btnViewBLK
        '
        Me.btnViewBLK.Location = New System.Drawing.Point(1052, 17)
        Me.btnViewBLK.Name = "btnViewBLK"
        Me.btnViewBLK.Size = New System.Drawing.Size(155, 23)
        Me.btnViewBLK.TabIndex = 15
        Me.btnViewBLK.Text = "Search Block Site"
        Me.btnViewBLK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID :"
        '
        'eid
        '
        Me.eid.Location = New System.Drawing.Point(323, 14)
        Me.eid.Name = "eid"
        Me.eid.Size = New System.Drawing.Size(70, 20)
        Me.eid.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1329, 178)
        Me.DataGridView1.TabIndex = 12
        '
        'btnSearch1
        '
        Me.btnSearch1.Location = New System.Drawing.Point(408, 12)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(140, 23)
        Me.btnSearch1.TabIndex = 11
        Me.btnSearch1.Text = "Search Site History"
        Me.btnSearch1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(917, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Division :"
        '
        'Div3
        '
        Me.Div3.Location = New System.Drawing.Point(992, 19)
        Me.Div3.Name = "Div3"
        Me.Div3.Size = New System.Drawing.Size(42, 20)
        Me.Div3.TabIndex = 9
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(462, 47)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(861, 530)
        Me.WebBrowser1.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1132, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'goTxt
        '
        Me.goTxt.Location = New System.Drawing.Point(800, 14)
        Me.goTxt.Name = "goTxt"
        Me.goTxt.Size = New System.Drawing.Size(326, 20)
        Me.goTxt.TabIndex = 10
        Me.goTxt.Text = "Search"
        '
        'cpyHost
        '
        Me.cpyHost.Location = New System.Drawing.Point(465, 14)
        Me.cpyHost.Name = "cpyHost"
        Me.cpyHost.Size = New System.Drawing.Size(232, 20)
        Me.cpyHost.TabIndex = 9
        Me.cpyHost.Text = "Copy the Host URl from HERE"
        '
        'btnF
        '
        Me.btnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF.Location = New System.Drawing.Point(749, 13)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(26, 23)
        Me.btnF.TabIndex = 14
        Me.btnF.Text = ">"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(709, 13)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(26, 23)
        Me.btnB.TabIndex = 13
        Me.btnB.Text = "<"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1236, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 810)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.goTxt)
        Me.Controls.Add(Me.cpyHost)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBlock As Button
    Friend WithEvents Div1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hostTxt1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnChange As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUBlock As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents hostTxt2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents hostTxt3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Div2 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSearch1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Div3 As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnSearch As Button
    Friend WithEvents goTxt As TextBox
    Friend WithEvents cpyHost As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnF As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents eid As TextBox
    Friend WithEvents btnViewBLK As Button
End Class
