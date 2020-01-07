<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportDosenNIPTertentu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.ButtonTampilkan = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportDosenNIPTertentu1 = New Project_Akademik_Irpan.CrystalReportDosenNIPTertentu()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(53, 10)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxNIP.TabIndex = 1
        '
        'ButtonTampilkan
        '
        Me.ButtonTampilkan.Location = New System.Drawing.Point(319, 8)
        Me.ButtonTampilkan.Name = "ButtonTampilkan"
        Me.ButtonTampilkan.Size = New System.Drawing.Size(107, 23)
        Me.ButtonTampilkan.TabIndex = 2
        Me.ButtonTampilkan.Text = "Tampilkan Report"
        Me.ButtonTampilkan.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(758, 515)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(107, 23)
        Me.ButtonKeluar.TabIndex = 3
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 41)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReportDosenNIPTertentu1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(849, 468)
        Me.CrystalReportViewer1.TabIndex = 4
        '
        'FormReportDosenNIPTertentu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonTampilkan)
        Me.Controls.Add(Me.TextBoxNIP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReportDosenNIPTertentu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReportDosenNIPTertentu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNIP As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTampilkan As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportDosenNIPTertentu1 As Project_Akademik_Irpan.CrystalReportDosenNIPTertentu
End Class
