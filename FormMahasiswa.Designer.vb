<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMahasiswa
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
        Me.TextBoxNIM = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'TextBoxNIM
        '
        Me.TextBoxNIM.Location = New System.Drawing.Point(90, 13)
        Me.TextBoxNIM.Name = "TextBoxNIM"
        Me.TextBoxNIM.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNIM.TabIndex = 1
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(90, 42)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Kelamin"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(90, 109)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(403, 20)
        Me.TextBoxAlamat.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'ComboBoxJenisKelamin
        '
        Me.ComboBoxJenisKelamin.FormattingEnabled = True
        Me.ComboBoxJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.ComboBoxJenisKelamin.Location = New System.Drawing.Point(90, 74)
        Me.ComboBoxJenisKelamin.Name = "ComboBoxJenisKelamin"
        Me.ComboBoxJenisKelamin.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxJenisKelamin.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(478, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(13, 315)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 10
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(94, 315)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 11
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(175, 315)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 12
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(256, 315)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 13
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(337, 315)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 14
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(418, 315)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 15
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxJenisKelamin)
        Me.Controls.Add(Me.TextBoxAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNIM)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMahasiswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNIM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
End Class
