<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Panel1 = New Panel()
        Label3 = New Label()
        btnBatal = New Button()
        btnMasuk = New Button()
        txtNama = New TextBox()
        Label10 = New Label()
        Label12 = New Label()
        txtNoHp = New TextBox()
        txtPw = New TextBox()
        Label11 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OldLace
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnBatal)
        Panel1.Controls.Add(btnMasuk)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtNoHp)
        Panel1.Controls.Add(txtPw)
        Panel1.Controls.Add(Label11)
        Panel1.Location = New Point(73, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(508, 484)
        Panel1.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(194, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 25)
        Label3.TabIndex = 38
        Label3.Text = "User Login"
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Red
        btnBatal.Font = New Font("Constantia", 10.2F)
        btnBatal.ForeColor = SystemColors.ActiveCaptionText
        btnBatal.Location = New Point(329, 417)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 37)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnMasuk.Font = New Font("Constantia", 10.2F)
        btnMasuk.Location = New Point(178, 417)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(94, 37)
        btnMasuk.TabIndex = 14
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Constantia", 10.2F)
        txtNama.Location = New Point(180, 236)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Name"
        txtNama.Size = New Size(243, 28)
        txtNama.TabIndex = 35
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Constantia", 10.2F)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(38, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 21)
        Label10.TabIndex = 32
        Label10.Text = "Nama"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Constantia", 10.2F)
        Label12.Location = New Point(38, 348)
        Label12.Name = "Label12"
        Label12.Size = New Size(66, 21)
        Label12.TabIndex = 34
        Label12.Text = "No. Hp "
        ' 
        ' txtNoHp
        ' 
        txtNoHp.Font = New Font("Constantia", 10.2F)
        txtNoHp.Location = New Point(180, 345)
        txtNoHp.Name = "txtNoHp"
        txtNoHp.PlaceholderText = "No. Handphone"
        txtNoHp.Size = New Size(243, 28)
        txtNoHp.TabIndex = 37
        ' 
        ' txtPw
        ' 
        txtPw.Font = New Font("Constantia", 10.2F)
        txtPw.Location = New Point(180, 287)
        txtPw.Name = "txtPw"
        txtPw.PasswordChar = "*"c
        txtPw.PlaceholderText = "Password"
        txtPw.Size = New Size(243, 28)
        txtPw.TabIndex = 36
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Constantia", 10.2F)
        Label11.Location = New Point(38, 294)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 21)
        Label11.TabIndex = 33
        Label11.Text = "Password"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(73, 59)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(508, 169)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Forte", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(21, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 22)
        Label2.TabIndex = 3
        Label2.Text = "Kelola Warisan, Pantau Persediaan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ravie", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(21, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(350, 38)
        Label1.TabIndex = 2
        Label1.Text = "BATIK STOCK PRO"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(665, 579)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormLogin"
        Text = "FormLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtPw As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnMasuk As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
