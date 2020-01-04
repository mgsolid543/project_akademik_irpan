<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJadwal
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
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxDosen = New System.Windows.Forms.ComboBox()
        Me.TextBoxWaktu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxMataKuliah = New System.Windows.Forms.ComboBox()
        Me.TextBoxMataKuliah = New System.Windows.Forms.TextBox()
        Me.TextBoxDosen = New System.Windows.Forms.TextBox()
        Me.TextBoxRuangan = New System.Windows.Forms.TextBox()
        Me.ComboBoxRuangan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(422, 304)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 30
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(341, 304)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 29
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(260, 304)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 28
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(179, 304)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 27
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(98, 304)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 26
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(17, 304)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 25
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(478, 130)
        Me.DataGridView1.TabIndex = 24
        '
        'ComboBoxDosen
        '
        Me.ComboBoxDosen.FormattingEnabled = True
        Me.ComboBoxDosen.Location = New System.Drawing.Point(94, 63)
        Me.ComboBoxDosen.Name = "ComboBoxDosen"
        Me.ComboBoxDosen.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDosen.TabIndex = 23
        '
        'TextBoxWaktu
        '
        Me.TextBoxWaktu.Location = New System.Drawing.Point(94, 125)
        Me.TextBoxWaktu.Name = "TextBoxWaktu"
        Me.TextBoxWaktu.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxWaktu.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Waktu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Dosen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mata Kuliah"
        '
        'TextBoxKode
        '
        Me.TextBoxKode.Location = New System.Drawing.Point(94, 5)
        Me.TextBoxKode.Name = "TextBoxKode"
        Me.TextBoxKode.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxKode.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kode"
        '
        'ComboBoxMataKuliah
        '
        Me.ComboBoxMataKuliah.FormattingEnabled = True
        Me.ComboBoxMataKuliah.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.ComboBoxMataKuliah.Location = New System.Drawing.Point(94, 31)
        Me.ComboBoxMataKuliah.Name = "ComboBoxMataKuliah"
        Me.ComboBoxMataKuliah.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMataKuliah.TabIndex = 31
        '
        'TextBoxMataKuliah
        '
        Me.TextBoxMataKuliah.Location = New System.Drawing.Point(221, 31)
        Me.TextBoxMataKuliah.Name = "TextBoxMataKuliah"
        Me.TextBoxMataKuliah.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxMataKuliah.TabIndex = 32
        '
        'TextBoxDosen
        '
        Me.TextBoxDosen.Location = New System.Drawing.Point(221, 63)
        Me.TextBoxDosen.Name = "TextBoxDosen"
        Me.TextBoxDosen.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxDosen.TabIndex = 33
        '
        'TextBoxRuangan
        '
        Me.TextBoxRuangan.Location = New System.Drawing.Point(220, 91)
        Me.TextBoxRuangan.Name = "TextBoxRuangan"
        Me.TextBoxRuangan.Size = New System.Drawing.Size(276, 20)
        Me.TextBoxRuangan.TabIndex = 36
        '
        'ComboBoxRuangan
        '
        Me.ComboBoxRuangan.FormattingEnabled = True
        Me.ComboBoxRuangan.Location = New System.Drawing.Point(94, 90)
        Me.ComboBoxRuangan.Name = "ComboBoxRuangan"
        Me.ComboBoxRuangan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRuangan.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Ruangan"
        '
        'FormJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxRuangan)
        Me.Controls.Add(Me.ComboBoxRuangan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxDosen)
        Me.Controls.Add(Me.TextBoxMataKuliah)
        Me.Controls.Add(Me.ComboBoxMataKuliah)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxDosen)
        Me.Controls.Add(Me.TextBoxWaktu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxKode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormJadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJadwal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxDosen As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxWaktu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMataKuliah As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxMataKuliah As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDosen As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRuangan As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxRuangan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
