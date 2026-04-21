<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        ErrorProvider1 = New ErrorProvider(components)
        Panel1 = New Panel()
        btnKembali = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnSimpan = New Button()
        dgvBarang = New DataGridView()
        txtCari = New TextBox()
        btnBatal = New Button()
        Label10 = New Label()
        cbxUkuran = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        txtJumlah = New TextBox()
        cbxKategori = New ComboBox()
        cbxHarga = New ComboBox()
        cbxStok = New ComboBox()
        cbxNamaMotif = New ComboBox()
        cbxIdBatik = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgvBarang, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OldLace
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(btnKembali)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(dgvBarang)
        Panel1.Controls.Add(txtCari)
        Panel1.Controls.Add(btnBatal)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(cbxUkuran)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtJumlah)
        Panel1.Controls.Add(cbxKategori)
        Panel1.Controls.Add(cbxHarga)
        Panel1.Controls.Add(cbxStok)
        Panel1.Controls.Add(cbxNamaMotif)
        Panel1.Controls.Add(cbxIdBatik)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(47, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(738, 849)
        Panel1.TabIndex = 1
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Gold
        btnKembali.Font = New Font("Constantia", 10.8F)
        btnKembali.Location = New Point(598, 533)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 40)
        btnKembali.TabIndex = 51
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Font = New Font("Constantia", 10.8F)
        btnHapus.Location = New Point(329, 534)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(92, 39)
        btnHapus.TabIndex = 50
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEdit.Font = New Font("Constantia", 10.8F)
        btnEdit.Location = New Point(178, 535)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(96, 38)
        btnEdit.TabIndex = 49
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnSimpan.Font = New Font("Constantia", 10.8F)
        btnSimpan.Location = New Point(39, 535)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(89, 38)
        btnSimpan.TabIndex = 48
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dgvBarang
        ' 
        dgvBarang.BackgroundColor = SystemColors.ButtonHighlight
        dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBarang.Location = New Point(39, 616)
        dgvBarang.Name = "dgvBarang"
        dgvBarang.RowHeadersWidth = 51
        dgvBarang.Size = New Size(653, 215)
        dgvBarang.TabIndex = 47
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCari.Location = New Point(39, 581)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Search"
        txtCari.Size = New Size(653, 29)
        txtCari.TabIndex = 46
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Yellow
        btnBatal.Font = New Font("Constantia", 10.8F)
        btnBatal.Location = New Point(472, 533)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(89, 40)
        btnBatal.TabIndex = 45
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(261, 190)
        Label10.Name = "Label10"
        Label10.Size = New Size(212, 25)
        Label10.TabIndex = 44
        Label10.Text = "Kelola Barang"
        ' 
        ' cbxUkuran
        ' 
        cbxUkuran.Font = New Font("Constantia", 10.8F)
        cbxUkuran.FormattingEnabled = True
        cbxUkuran.Location = New Point(186, 491)
        cbxUkuran.Name = "cbxUkuran"
        cbxUkuran.Size = New Size(506, 30)
        cbxUkuran.TabIndex = 43
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Constantia", 10.8F)
        Label9.Location = New Point(41, 491)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 22)
        Label9.TabIndex = 42
        Label9.Text = "Ukuran"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Constantia", 10.8F)
        Label8.Location = New Point(39, 447)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 22)
        Label8.TabIndex = 41
        Label8.Text = "Kategori"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Font = New Font("Constantia", 10.8F)
        txtJumlah.Location = New Point(186, 315)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.PlaceholderText = "Amount"
        txtJumlah.Size = New Size(506, 29)
        txtJumlah.TabIndex = 40
        ' 
        ' cbxKategori
        ' 
        cbxKategori.Font = New Font("Constantia", 10.8F)
        cbxKategori.FormattingEnabled = True
        cbxKategori.Location = New Point(186, 447)
        cbxKategori.Name = "cbxKategori"
        cbxKategori.Size = New Size(506, 30)
        cbxKategori.TabIndex = 39
        ' 
        ' cbxHarga
        ' 
        cbxHarga.Font = New Font("Constantia", 10.8F)
        cbxHarga.FormattingEnabled = True
        cbxHarga.Location = New Point(186, 359)
        cbxHarga.Name = "cbxHarga"
        cbxHarga.Size = New Size(506, 30)
        cbxHarga.TabIndex = 38
        ' 
        ' cbxStok
        ' 
        cbxStok.Font = New Font("Constantia", 10.8F)
        cbxStok.FormattingEnabled = True
        cbxStok.Location = New Point(186, 403)
        cbxStok.Name = "cbxStok"
        cbxStok.Size = New Size(506, 30)
        cbxStok.TabIndex = 37
        ' 
        ' cbxNamaMotif
        ' 
        cbxNamaMotif.Font = New Font("Constantia", 10.8F)
        cbxNamaMotif.FormattingEnabled = True
        cbxNamaMotif.Location = New Point(186, 271)
        cbxNamaMotif.Name = "cbxNamaMotif"
        cbxNamaMotif.Size = New Size(506, 30)
        cbxNamaMotif.TabIndex = 36
        ' 
        ' cbxIdBatik
        ' 
        cbxIdBatik.Font = New Font("Constantia", 10.8F)
        cbxIdBatik.FormattingEnabled = True
        cbxIdBatik.Location = New Point(186, 227)
        cbxIdBatik.Name = "cbxIdBatik"
        cbxIdBatik.Size = New Size(506, 30)
        cbxIdBatik.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Constantia", 10.8F)
        Label7.Location = New Point(41, 406)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 22)
        Label7.TabIndex = 34
        Label7.Text = "Stok"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Constantia", 10.8F)
        Label6.Location = New Point(39, 362)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 22)
        Label6.TabIndex = 33
        Label6.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Constantia", 10.8F)
        Label5.Location = New Point(41, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 22)
        Label5.TabIndex = 32
        Label5.Text = "Jumlah "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Constantia", 10.8F)
        Label4.Location = New Point(39, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 22)
        Label4.TabIndex = 31
        Label4.Text = "Nama Motif"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Constantia", 10.8F)
        Label3.Location = New Point(39, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 22)
        Label3.TabIndex = 30
        Label3.Text = "ID Batik"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(47, 67)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(738, 164)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Forte", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(368, 25)
        Label2.TabIndex = 5
        Label2.Text = "Kelola Warisan, Pantau Persediaan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ravie", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(497, 54)
        Label1.TabIndex = 4
        Label1.Text = "BATIK STOCK PRO"
        ' 
        ' FormBarang
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(853, 954)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormBarang"
        Text = "FormBarang"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBarang, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxUkuran As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents cbxKategori As ComboBox
    Friend WithEvents cbxHarga As ComboBox
    Friend WithEvents cbxStok As ComboBox
    Friend WithEvents cbxNamaMotif As ComboBox
    Friend WithEvents cbxIdBatik As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnBatal As Button
End Class
