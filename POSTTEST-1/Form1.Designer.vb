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
        Label1 = New Label()
        Label2 = New Label()
        txt2 = New TextBox()
        txt1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 23)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(199, 213)
        txt2.Name = "txt2"
        txt2.ReadOnly = True
        txt2.Size = New Size(213, 30)
        txt2.TabIndex = 2
        ' 
        ' txt1
        ' 
        txt1.ForeColor = Color.Teal
        txt1.Location = New Point(199, 102)
        txt1.Name = "txt1"
        txt1.Size = New Size(213, 30)
        txt1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Menu
        Button1.Location = New Point(199, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 37)
        Button1.TabIndex = 4
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Menu
        Button2.Location = New Point(312, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 37)
        Button2.TabIndex = 5
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(199, 266)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(17, 23)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "-"
        lblPredikat.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txt1)
        Controls.Add(txt2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblPredikat As Label

End Class
