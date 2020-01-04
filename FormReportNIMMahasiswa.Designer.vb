<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportNIMMahasiswa
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
        Me.ButtonSelesai = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNIM = New System.Windows.Forms.TextBox()
        Me.ButtonTampilkan = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportNIMMahasiswa1 = New Project_Akademik_Irpan.CrystalReportNIMMahasiswa()
        Me.SuspendLayout()
        '
        'ButtonSelesai
        '
        Me.ButtonSelesai.Location = New System.Drawing.Point(477, 363)
        Me.ButtonSelesai.Name = "ButtonSelesai"
        Me.ButtonSelesai.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelesai.TabIndex = 0
        Me.ButtonSelesai.Text = "Selesai"
        Me.ButtonSelesai.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIM"
        '
        'TextBoxNIM
        '
        Me.TextBoxNIM.Location = New System.Drawing.Point(70, 26)
        Me.TextBoxNIM.Name = "TextBoxNIM"
        Me.TextBoxNIM.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxNIM.TabIndex = 2
        '
        'ButtonTampilkan
        '
        Me.ButtonTampilkan.Location = New System.Drawing.Point(429, 21)
        Me.ButtonTampilkan.Name = "ButtonTampilkan"
        Me.ButtonTampilkan.Size = New System.Drawing.Size(132, 23)
        Me.ButtonTampilkan.TabIndex = 4
        Me.ButtonTampilkan.Text = "Tampilkan"
        Me.ButtonTampilkan.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(27, 52)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReportNIMMahasiswa1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(534, 305)
        Me.CrystalReportViewer1.TabIndex = 3
        '
        'FormReportNIMMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 410)
        Me.Controls.Add(Me.ButtonTampilkan)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.TextBoxNIM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSelesai)
        Me.Name = "FormReportNIMMahasiswa"
        Me.Text = "FormReportNIMMahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSelesai As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNIM As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportNIMMahasiswa1 As Project_Akademik_Irpan.CrystalReportNIMMahasiswa
    Friend WithEvents ButtonTampilkan As System.Windows.Forms.Button
End Class
