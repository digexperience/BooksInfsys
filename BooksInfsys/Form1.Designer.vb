<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpublisher = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcopyright = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txteditnum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnumpage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumcop = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumlibr = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book No.:"
        '
        'txtno
        '
        Me.txtno.Enabled = False
        Me.txtno.Location = New System.Drawing.Point(138, 40)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(189, 20)
        Me.txtno.TabIndex = 1
        '
        'txttitle
        '
        Me.txttitle.Enabled = False
        Me.txttitle.Location = New System.Drawing.Point(138, 66)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(189, 20)
        Me.txttitle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Title:"
        '
        'txtauthor
        '
        Me.txtauthor.Enabled = False
        Me.txtauthor.Location = New System.Drawing.Point(138, 92)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(189, 20)
        Me.txtauthor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Author:"
        '
        'txtpublisher
        '
        Me.txtpublisher.Enabled = False
        Me.txtpublisher.Location = New System.Drawing.Point(138, 118)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.Size = New System.Drawing.Size(189, 20)
        Me.txtpublisher.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Publisher:"
        '
        'txtcopyright
        '
        Me.txtcopyright.Enabled = False
        Me.txtcopyright.Location = New System.Drawing.Point(138, 144)
        Me.txtcopyright.Name = "txtcopyright"
        Me.txtcopyright.Size = New System.Drawing.Size(189, 20)
        Me.txtcopyright.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Copyright for the book:"
        '
        'txteditnum
        '
        Me.txteditnum.Enabled = False
        Me.txteditnum.Location = New System.Drawing.Point(138, 170)
        Me.txteditnum.Name = "txteditnum"
        Me.txteditnum.Size = New System.Drawing.Size(189, 20)
        Me.txteditnum.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Edition Number:"
        '
        'txtnumpage
        '
        Me.txtnumpage.Enabled = False
        Me.txtnumpage.Location = New System.Drawing.Point(138, 196)
        Me.txtnumpage.Name = "txtnumpage"
        Me.txtnumpage.Size = New System.Drawing.Size(189, 20)
        Me.txtnumpage.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Number of Pages:"
        '
        'txtnumcop
        '
        Me.txtnumcop.Enabled = False
        Me.txtnumcop.Location = New System.Drawing.Point(138, 222)
        Me.txtnumcop.Name = "txtnumcop"
        Me.txtnumcop.Size = New System.Drawing.Size(189, 20)
        Me.txtnumcop.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Number of Copies:"
        '
        'txtnumlibr
        '
        Me.txtnumlibr.Enabled = False
        Me.txtnumlibr.Location = New System.Drawing.Point(138, 248)
        Me.txtnumlibr.Name = "txtnumlibr"
        Me.txtnumlibr.Size = New System.Drawing.Size(189, 20)
        Me.txtnumlibr.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Name of Library:"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(345, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(414, 228)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(345, 274)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(450, 274)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 23)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(555, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(660, 274)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 322)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtnumlibr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnumcop)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnumpage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txteditnum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcopyright)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpublisher)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Books Information System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtauthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpublisher As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcopyright As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txteditnum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnumpage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnumcop As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumlibr As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
End Class
