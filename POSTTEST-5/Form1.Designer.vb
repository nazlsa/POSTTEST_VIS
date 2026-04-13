<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtID = New TextBox()
        txtNama = New TextBox()
        txtKtg = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtSize = New TextBox()
        Label9 = New Label()
        txtCari = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        btnLihat = New Button()
        btnEdit = New Button()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnTambah = New Button()
        dgvBatik = New DataGridView()
        Panel3 = New Panel()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvBatik, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-5, -14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1242, 250)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Forte", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(380, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(440, 31)
        Label2.TabIndex = 1
        Label2.Text = "Kelola Warisan, Pantau Persediaan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ravie", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(324, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(581, 62)
        Label1.TabIndex = 0
        Label1.Text = "BATIK STOCK PRO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(34, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 1
        Label3.Text = "ID Batik"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(34, 333)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 25)
        Label4.TabIndex = 2
        Label4.Text = "Nama Motif"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(34, 381)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 3
        Label5.Text = "Kategori"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(34, 425)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 25)
        Label6.TabIndex = 4
        Label6.Text = "Ukuran"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(34, 476)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 25)
        Label7.TabIndex = 5
        Label7.Text = "Stok"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(34, 528)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 25)
        Label8.TabIndex = 6
        Label8.Text = "Harga"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Comic Sans MS", 10.2F)
        txtID.Location = New Point(197, 278)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Batik"
        txtID.Size = New Size(424, 31)
        txtID.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Comic Sans MS", 10.2F)
        txtNama.Location = New Point(197, 328)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Motif"
        txtNama.Size = New Size(424, 31)
        txtNama.TabIndex = 8
        ' 
        ' txtKtg
        ' 
        txtKtg.Font = New Font("Comic Sans MS", 10.2F)
        txtKtg.Location = New Point(197, 376)
        txtKtg.Name = "txtKtg"
        txtKtg.PlaceholderText = "Category"
        txtKtg.Size = New Size(424, 31)
        txtKtg.TabIndex = 9
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Comic Sans MS", 10.2F)
        txtHarga.Location = New Point(197, 523)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Price"
        txtHarga.Size = New Size(424, 31)
        txtHarga.TabIndex = 10
        ' 
        ' txtStok
        ' 
        txtStok.Font = New Font("Comic Sans MS", 10.2F)
        txtStok.Location = New Point(197, 471)
        txtStok.Name = "txtStok"
        txtStok.PlaceholderText = "Stock"
        txtStok.Size = New Size(424, 31)
        txtStok.TabIndex = 11
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Comic Sans MS", 10.2F)
        txtSize.Location = New Point(197, 420)
        txtSize.Name = "txtSize"
        txtSize.PlaceholderText = "Size"
        txtSize.Size = New Size(424, 31)
        txtSize.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(34, 580)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 25)
        Label9.TabIndex = 13
        Label9.Text = "Cari Batik"
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Comic Sans MS", 10.2F)
        txtCari.Location = New Point(197, 580)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Search"
        txtCari.Size = New Size(424, 31)
        txtCari.TabIndex = 14
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnLihat
        ' 
        btnLihat.BackColor = Color.Lime
        btnLihat.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        btnLihat.Location = New Point(189, 230)
        btnLihat.Name = "btnLihat"
        btnLihat.Size = New Size(111, 49)
        btnLihat.TabIndex = 17
        btnLihat.Text = "Lihat"
        btnLihat.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEdit.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        btnEdit.Location = New Point(41, 230)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(111, 49)
        btnEdit.TabIndex = 18
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnSimpan.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        btnSimpan.Location = New Point(189, 165)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(111, 50)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        btnHapus.Location = New Point(111, 285)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(108, 52)
        btnHapus.TabIndex = 19
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnTambah.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        btnTambah.Location = New Point(41, 165)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(111, 50)
        btnTambah.TabIndex = 15
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' dgvBatik
        ' 
        dgvBatik.BackgroundColor = SystemColors.ButtonHighlight
        dgvBatik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBatik.Location = New Point(406, 649)
        dgvBatik.Name = "dgvBatik"
        dgvBatik.RowHeadersWidth = 51
        dgvBatik.Size = New Size(765, 377)
        dgvBatik.TabIndex = 20
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(btnEdit)
        Panel3.Controls.Add(btnTambah)
        Panel3.Controls.Add(btnHapus)
        Panel3.Controls.Add(btnSimpan)
        Panel3.Controls.Add(btnLihat)
        Panel3.Location = New Point(34, 649)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(348, 377)
        Panel3.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(74, 106)
        Label10.Name = "Label10"
        Label10.Size = New Size(180, 33)
        Label10.TabIndex = 23
        Label10.Text = "Pilih Tombol"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1229, 1055)
        Controls.Add(Panel3)
        Controls.Add(dgvBatik)
        Controls.Add(txtCari)
        Controls.Add(Label9)
        Controls.Add(txtSize)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtKtg)
        Controls.Add(txtNama)
        Controls.Add(txtID)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvBatik, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKtg As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvBatik As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnLihat As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label

End Class
