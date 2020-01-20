<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser_E
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
        Me.urlTxt = New System.Windows.Forms.TextBox()
        Me.btnUrl = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.goTxt = New System.Windows.Forms.TextBox()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'urlTxt
        '
        Me.urlTxt.Location = New System.Drawing.Point(206, 22)
        Me.urlTxt.Name = "urlTxt"
        Me.urlTxt.Size = New System.Drawing.Size(392, 20)
        Me.urlTxt.TabIndex = 0
        Me.urlTxt.Text = "Search by Url"
        '
        'btnUrl
        '
        Me.btnUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUrl.Location = New System.Drawing.Point(604, 19)
        Me.btnUrl.Name = "btnUrl"
        Me.btnUrl.Size = New System.Drawing.Size(75, 23)
        Me.btnUrl.TabIndex = 1
        Me.btnUrl.Text = "URL"
        Me.btnUrl.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(22, 22)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(26, 23)
        Me.btnB.TabIndex = 2
        Me.btnB.Text = "<"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF.Location = New System.Drawing.Point(62, 22)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(26, 23)
        Me.btnF.TabIndex = 3
        Me.btnF.Text = ">"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(100, 22)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1055, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'goTxt
        '
        Me.goTxt.Location = New System.Drawing.Point(723, 20)
        Me.goTxt.Name = "goTxt"
        Me.goTxt.Size = New System.Drawing.Size(326, 20)
        Me.goTxt.TabIndex = 5
        Me.goTxt.Text = "Search"
        '
        'btnSetting
        '
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.Location = New System.Drawing.Point(1172, 17)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(75, 23)
        Me.btnSetting.TabIndex = 8
        Me.btnSetting.Text = "Setting"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 63)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1312, 644)
        Me.WebBrowser1.TabIndex = 9
        '
        'Browser_E
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 707)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.goTxt)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnUrl)
        Me.Controls.Add(Me.urlTxt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Browser_E"
        Me.Text = "Browser_E"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents urlTxt As TextBox
    Friend WithEvents btnUrl As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents goTxt As TextBox
    Friend WithEvents btnSetting As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer1 As Timer
End Class
