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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        grpTambah = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        grpHapus = New GroupBox()
        btnHapus = New Button()
        txtHapusJudul = New TextBox()
        Label3 = New Label()
        dgvDaftarBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        CType(dgvDaftarBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpTambah
        ' 
        grpTambah.BackgroundImage = CType(resources.GetObject("grpTambah.BackgroundImage"), Image)
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(Label2)
        grpTambah.Controls.Add(Label1)
        grpTambah.Location = New Point(611, 25)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(426, 241)
        grpTambah.TabIndex = 0
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.AntiqueWhite
        btnTambah.Location = New Point(302, 180)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 38)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = SystemColors.ButtonFace
        txtGenre.Location = New Point(133, 107)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(263, 30)
        txtGenre.TabIndex = 3
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = SystemColors.ButtonFace
        txtJudul.Location = New Point(133, 49)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(263, 30)
        txtJudul.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AntiqueWhite
        Label2.Location = New Point(16, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 23)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AntiqueWhite
        Label1.Location = New Point(16, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 23)
        Label1.TabIndex = 0
        Label1.Text = "Judul  Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.BackColor = SystemColors.Info
        grpHapus.BackgroundImage = CType(resources.GetObject("grpHapus.BackgroundImage"), Image)
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(txtHapusJudul)
        grpHapus.Controls.Add(Label3)
        grpHapus.Location = New Point(611, 298)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(426, 249)
        grpHapus.TabIndex = 1
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.AntiqueWhite
        btnHapus.Location = New Point(302, 175)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 37)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.BackColor = SystemColors.ButtonFace
        txtHapusJudul.Location = New Point(151, 53)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(245, 30)
        txtHapusJudul.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.AntiqueWhite
        Label3.Location = New Point(22, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 23)
        Label3.TabIndex = 0
        Label3.Text = "Judul Buku"
        ' 
        ' dgvDaftarBuku
        ' 
        dgvDaftarBuku.BackgroundColor = Color.FloralWhite
        dgvDaftarBuku.BorderStyle = BorderStyle.Fixed3D
        dgvDaftarBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDaftarBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvDaftarBuku.Location = New Point(39, 25)
        dgvDaftarBuku.Name = "dgvDaftarBuku"
        dgvDaftarBuku.RowHeadersWidth = 51
        dgvDaftarBuku.Size = New Size(445, 522)
        dgvDaftarBuku.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Judul Buku"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1071, 623)
        Controls.Add(dgvDaftarBuku)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        Text = "Form1"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        CType(dgvDaftarBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDaftarBuku As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
