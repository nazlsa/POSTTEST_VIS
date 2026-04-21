<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormData
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormData))
        Panel1 = New Panel()
        Label3 = New Label()
        txtHarga = New TextBox()
        Label10 = New Label()
        txtStok = New TextBox()
        Label11 = New Label()
        txtSize = New TextBox()
        Label12 = New Label()
        txtKtg = New TextBox()
        Label13 = New Label()
        txtNama = New TextBox()
        Label14 = New Label()
        txtID = New TextBox()
        Label15 = New Label()
        btnLanjut = New Button()
        btnEdit = New Button()
        dgvBatik = New DataGridView()
        btnHapus = New Button()
        btnTambah = New Button()
        btnLihat = New Button()
        btnSimpan = New Button()
        txtCari = New TextBox()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        CType(dgvBatik, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OldLace
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtHarga)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtStok)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtKtg)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(btnLanjut)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(dgvBatik)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(btnLihat)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(txtCari)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(79, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(742, 845)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(266, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(248, 25)
        Label3.TabIndex = 53
        Label3.Text = "Halaman Beranda"
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Constantia", 10.8F)
        txtHarga.Location = New Point(179, 458)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Price"
        txtHarga.Size = New Size(529, 29)
        txtHarga.TabIndex = 52
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Constantia", 10.8F)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(45, 461)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 22)
        Label10.TabIndex = 51
        Label10.Text = "Harga"
        ' 
        ' txtStok
        ' 
        txtStok.Font = New Font("Constantia", 10.8F)
        txtStok.Location = New Point(179, 416)
        txtStok.Name = "txtStok"
        txtStok.PlaceholderText = "Stock"
        txtStok.Size = New Size(529, 29)
        txtStok.TabIndex = 50
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Constantia", 10.8F)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(45, 419)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 22)
        Label11.TabIndex = 49
        Label11.Text = "Stok"
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Constantia", 10.8F)
        txtSize.Location = New Point(179, 374)
        txtSize.Name = "txtSize"
        txtSize.PlaceholderText = "Size"
        txtSize.Size = New Size(529, 29)
        txtSize.TabIndex = 48
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Constantia", 10.8F)
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(45, 377)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 22)
        Label12.TabIndex = 47
        Label12.Text = "Ukuran"
        ' 
        ' txtKtg
        ' 
        txtKtg.Font = New Font("Constantia", 10.8F)
        txtKtg.Location = New Point(179, 332)
        txtKtg.Name = "txtKtg"
        txtKtg.PlaceholderText = "Category"
        txtKtg.Size = New Size(529, 29)
        txtKtg.TabIndex = 46
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Constantia", 10.8F)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(45, 335)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 22)
        Label13.TabIndex = 45
        Label13.Text = "Kategori"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Constantia", 10.8F)
        txtNama.Location = New Point(179, 290)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Motif"
        txtNama.Size = New Size(529, 29)
        txtNama.TabIndex = 44
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Constantia", 10.8F)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(45, 293)
        Label14.Name = "Label14"
        Label14.Size = New Size(105, 22)
        Label14.TabIndex = 43
        Label14.Text = "Nama Motif"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Constantia", 10.8F)
        txtID.Location = New Point(179, 251)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Batik"
        txtID.Size = New Size(529, 29)
        txtID.TabIndex = 42
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Constantia", 10.8F)
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(45, 254)
        Label15.Name = "Label15"
        Label15.Size = New Size(76, 22)
        Label15.TabIndex = 41
        Label15.Text = "ID Batik"
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = SystemColors.Highlight
        btnLanjut.Font = New Font("Constantia", 10.8F)
        btnLanjut.ForeColor = SystemColors.ActiveCaptionText
        btnLanjut.Location = New Point(614, 524)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(94, 38)
        btnLanjut.TabIndex = 40
        btnLanjut.Text = "Lanjut"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEdit.Font = New Font("Constantia", 10.8F)
        btnEdit.Location = New Point(266, 524)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(96, 38)
        btnEdit.TabIndex = 37
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' dgvBatik
        ' 
        dgvBatik.BackgroundColor = SystemColors.ButtonHighlight
        dgvBatik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBatik.Location = New Point(45, 603)
        dgvBatik.Name = "dgvBatik"
        dgvBatik.RowHeadersWidth = 51
        dgvBatik.Size = New Size(663, 219)
        dgvBatik.TabIndex = 39
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Font = New Font("Constantia", 10.8F)
        btnHapus.Location = New Point(500, 524)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(98, 38)
        btnHapus.TabIndex = 38
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnTambah.Font = New Font("Constantia", 10.8F)
        btnTambah.Location = New Point(45, 524)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(97, 38)
        btnTambah.TabIndex = 34
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnLihat
        ' 
        btnLihat.BackColor = Color.Lime
        btnLihat.Font = New Font("Constantia", 10.8F)
        btnLihat.Location = New Point(382, 524)
        btnLihat.Name = "btnLihat"
        btnLihat.Size = New Size(98, 38)
        btnLihat.TabIndex = 36
        btnLihat.Text = "Lihat"
        btnLihat.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnSimpan.Font = New Font("Constantia", 10.8F)
        btnSimpan.Location = New Point(148, 524)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(102, 38)
        btnSimpan.TabIndex = 35
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Constantia", 10.8F)
        txtCari.Location = New Point(45, 568)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Search"
        txtCari.Size = New Size(663, 29)
        txtCari.TabIndex = 33
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(756, 195)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Forte", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(33, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(368, 25)
        Label2.TabIndex = 5
        Label2.Text = "Kelola Warisan, Pantau Persediaan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ravie", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(33, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(497, 54)
        Label1.TabIndex = 4
        Label1.Text = "BATIK STOCK PRO"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormData
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(889, 970)
        Controls.Add(Panel1)
        Name = "FormData"
        Text = "FormData"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBatik, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLanjut As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents dgvBatik As DataGridView
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnLihat As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtKtg As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label3 As Label

End Class
