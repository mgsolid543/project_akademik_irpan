<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKRS
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
        Me.TextBoxJurusan = New System.Windows.Forms.TextBox()
        Me.ComboBoxJurusan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxMahasiswa = New System.Windows.Forms.TextBox()
        Me.TextBoxMataKuliah = New System.Windows.Forms.TextBox()
        Me.ComboBoxMataKuliah = New System.Windows.Forms.ComboBox()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxMahasiswa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxJurusan
        '
        Me.TextBoxJurusan.Location = New System.Drawing.Point(215, 95)
        Me.TextBoxJurusan.Name = "TextBoxJurusan"
        Me.TextBoxJurusan.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxJurusan.TabIndex = 56
        '
        'ComboBoxJurusan
        '
        Me.ComboBoxJurusan.FormattingEnabled = True
        Me.ComboBoxJurusan.Location = New System.Drawing.Point(89, 94)
        Me.ComboBoxJurusan.Name = "ComboBoxJurusan"
        Me.ComboBoxJurusan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxJurusan.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Jurusan"
        '
        'TextBoxMahasiswa
        '
        Me.TextBoxMahasiswa.Location = New System.Drawing.Point(216, 67)
        Me.TextBoxMahasiswa.Name = "TextBoxMahasiswa"
        Me.TextBoxMahasiswa.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxMahasiswa.TabIndex = 53
        '
        'TextBoxMataKuliah
        '
        Me.TextBoxMataKuliah.Location = New System.Drawing.Point(216, 35)
        Me.TextBoxMataKuliah.Name = "TextBoxMataKuliah"
        Me.TextBoxMataKuliah.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxMataKuliah.TabIndex = 52
        '
        'ComboBoxMataKuliah
        '
        Me.ComboBoxMataKuliah.FormattingEnabled = True
        Me.ComboBoxMataKuliah.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.ComboBoxMataKuliah.Location = New System.Drawing.Point(89, 35)
        Me.ComboBoxMataKuliah.Name = "ComboBoxMataKuliah"
        Me.ComboBoxMataKuliah.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMataKuliah.TabIndex = 51
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(817, 358)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 50
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(736, 358)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 49
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(655, 358)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 48
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(574, 358)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 47
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(493, 358)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 46
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(412, 358)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 45
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(878, 231)
        Me.DataGridView1.TabIndex = 44
        '
        'ComboBoxMahasiswa
        '
        Me.ComboBoxMahasiswa.FormattingEnabled = True
        Me.ComboBoxMahasiswa.Location = New System.Drawing.Point(89, 67)
        Me.ComboBoxMahasiswa.Name = "ComboBoxMahasiswa"
        Me.ComboBoxMahasiswa.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMahasiswa.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Mata Kuliah"
        '
        'TextBoxKode
        '
        Me.TextBoxKode.Location = New System.Drawing.Point(89, 9)
        Me.TextBoxKode.Name = "TextBoxKode"
        Me.TextBoxKode.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxKode.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Kode"
        '
        'FormKRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxJurusan)
        Me.Controls.Add(Me.ComboBoxJurusan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxMahasiswa)
        Me.Controls.Add(Me.TextBoxMataKuliah)
        Me.Controls.Add(Me.ComboBoxMataKuliah)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxMahasiswa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxKode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormKRS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKRS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxJurusan As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMahasiswa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMataKuliah As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxMataKuliah As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxMahasiswa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
