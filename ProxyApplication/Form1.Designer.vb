<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.goTxt = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnUrl = New System.Windows.Forms.Button()
        Me.urlTxt = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 70)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1298, 714)
        Me.WebBrowser1.TabIndex = 18
        '
        'btnSetting
        '
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.Location = New System.Drawing.Point(1172, 12)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(75, 20)
        Me.btnSetting.TabIndex = 17
        Me.btnSetting.Text = "Setting"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1055, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 20)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'goTxt
        '
        Me.goTxt.Location = New System.Drawing.Point(723, 12)
        Me.goTxt.Name = "goTxt"
        Me.goTxt.Size = New System.Drawing.Size(326, 20)
        Me.goTxt.TabIndex = 15
        Me.goTxt.Text = "Search"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(100, 17)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 20)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF.Location = New System.Drawing.Point(62, 17)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(26, 20)
        Me.btnF.TabIndex = 13
        Me.btnF.Text = ">"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(22, 17)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(26, 20)
        Me.btnB.TabIndex = 12
        Me.btnB.Text = "<"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnUrl
        '
        Me.btnUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUrl.Location = New System.Drawing.Point(604, 14)
        Me.btnUrl.Name = "btnUrl"
        Me.btnUrl.Size = New System.Drawing.Size(75, 20)
        Me.btnUrl.TabIndex = 11
        Me.btnUrl.Text = "URL"
        Me.btnUrl.UseVisualStyleBackColor = True
        '
        'urlTxt
        '
        Me.urlTxt.Location = New System.Drawing.Point(206, 14)
        Me.urlTxt.Name = "urlTxt"
        Me.urlTxt.Size = New System.Drawing.Size(392, 20)
        Me.urlTxt.TabIndex = 10
        Me.urlTxt.Text = "Search by Url"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 784)
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
        Me.Name = "Form1"
        Me.Text = "Browser_H"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnSetting As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents goTxt As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnUrl As Button
    Friend WithEvents urlTxt As TextBox
    Friend WithEvents Timer1 As Timer
End Class
