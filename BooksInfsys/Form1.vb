Imports System.Data.SQLite
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.ComponentModel
Imports System.Reflection

Public Class Form1
    Dim lv As ListViewItem
    Dim selected As String


    Private Sub PopListView()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("Book No.", 60)
            .Columns.Add("Title", 130)
            .Columns.Add("Author", 110)
            .Columns.Add("Publisher", 110)
        End With

        openCon()
        sql = "Select * from tbl_BooksInformation order by BookNo"
        cmd = New SQLiteCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            lv = New ListViewItem(dr("bookNo").ToString)
            lv.SubItems.Add(dr("bookTitle"))
            lv.SubItems.Add(dr("bookAuthor"))
            lv.SubItems.Add(dr("bookPublisher"))
            ListView1.Items.Add(lv)
        Loop
        dr.Close()
        cn.Close()
    End Sub

    Private Sub resetForm()
        txtno.Text = Nothing
        txttitle.Text = Nothing
        txtauthor.Text = Nothing
        txtpublisher.Text = Nothing
        txtcopyright.Text = Nothing
        txteditnum.Text = Nothing
        txtnumcop.Text = Nothing
        txtnumpage.Text = Nothing
        txtnumlibr.Text = Nothing

        Me.txttitle.Enabled = False
        Me.txtauthor.Enabled = False
        Me.txtpublisher.Enabled = False
        Me.txtcopyright.Enabled = False
        Me.txteditnum.Enabled = False
        Me.txtnumpage.Enabled = False
        Me.txtnumcop.Enabled = False
        Me.txtnumlibr.Enabled = False

        btnAdd.Text = "Add New"
        btnAdd.Enabled = True
        btnClose.Text = "Close"
        btnUpdate.Text = "Update"
        btnUpdate.Enabled = False
        btnDelete.Text = "Delete"
        btnDelete.ForeColor = Color.Red

        ListView1.Enabled = True
        ListView1.HideSelection = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListView()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ListView1.Enabled = False

        If btnAdd.Text = "Edit" Then
            btnUpdate.Text = "Update"
            btnAdd.Enabled = False
        Else
            ListView1.HideSelection = True
            btnUpdate.Text = "Save"
            txtno.Text = ListView1.Items.Count + 1
        End If

        Me.txttitle.Enabled = True
        Me.txtauthor.Enabled = True
        Me.txtpublisher.Enabled = True
        Me.txtcopyright.Enabled = True
        Me.txteditnum.Enabled = True
        Me.txtnumpage.Enabled = True
        Me.txtnumcop.Enabled = True
        Me.txtnumlibr.Enabled = True
        Me.btnClose.Text = "Cancel"
        Me.btnDelete.Text = "Clear"
        Me.btnDelete.ForeColor = Color.Black
        btnAdd.Enabled = False
        btnUpdate.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtno.Text = "" Or txttitle.Text = "" Or txtauthor.Text = "" Or txtpublisher.Text = "" Or txtcopyright.Text = "" Or txteditnum.Text = "" Or txtnumpage.Text = "" Or txtnumcop.Text = "" Or txtnumlibr.Text = "" Then
            MsgBox("Please complete all data before saving it.", vbExclamation, Me.Text)

        Else
            If btnUpdate.Text = "Save" Then
                If MsgBox("Are you sure to save this record?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                    openCon()
                    sql = "INSERT INTO tbl_BooksInformation (bookNo, bookTitle, bookAuthor, bookPublisher, bookCopyright, bookEditionNum, bookNumPages, bookCopies, bookLibrary) VALUES ('" & Me.txtno.Text & "','" & Me.txttitle.Text & "','" & Me.txtauthor.Text & "','" & Me.txtpublisher.Text & "','" & Me.txtcopyright.Text & "','" & Me.txteditnum.Text & "','" & Me.txtnumcop.Text & "','" & Me.txtnumpage.Text & "','" & Me.txtnumlibr.Text & "')"
                    cmd = New SQLiteCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record Saved!", 64, Me.Text)
                    PopListView()
                    resetForm()
                End If
            Else
                If MsgBox("Are you sure to save this record?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                    openCon()
                    sql = "UPDATE tbl_BooksInformation SET bookTitle = '" & txttitle.Text & "', bookAuthor = '" & txtauthor.Text & "', bookPublisher = '" & txtpublisher.Text & "', bookCopyright = '" & txtcopyright.Text & "', bookEditionNum = '" & txteditnum.Text & "', bookNumPages = '" & txtnumpage.Text & "', bookCopies = '" & txtnumcop.Text & "', bookLibrary = '" & txtnumlibr.Text & "' where bookNo = '" & selected & "'"
                    cmd = New SQLiteCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record Updated!", 64, Me.Text)

                    PopListView()
                    resetForm()
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If Me.btnClose.Text = "Cancel" Then
            resetForm()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        resetForm()
        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1

            selected = ListView1.SelectedItems(i).Text
            openCon()
            sql = "Select * from tbl_BooksInformation where bookNo = '" & selected & "'"
            cmd = New SQLiteCommand(sql, cn)
            dr = cmd.ExecuteReader()

            dr.Read()

            txtno.Text = dr("bookNo")
            txttitle.Text = dr("bookTitle")
            txtauthor.Text = dr("bookAuthor")
            txtpublisher.Text = dr("bookPublisher")
            txtcopyright.Text = dr("bookCopyright")
            txteditnum.Text = dr("bookEditionNum")
            txtnumpage.Text = dr("bookNumPages")
            txtnumcop.Text = dr("bookCopies")
            txtnumlibr.Text = dr("bookLibrary")

            dr.Close()
            cn.Close()
        Next

        btnClose.Text = "Cancel"
        btnAdd.Text = "Edit"
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If btnDelete.Text = "Delete" Then
            If MsgBox("Are you sure to delete this record?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
                openCon()
                sql = "Delete from tbl_BooksInformation where bookNo = '" & selected & "'"
                cmd = New SQLiteCommand(sql, cn)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record Deleted!", 64, Me.Text)
                PopListView()
                resetForm()
            End If
        Else
            txttitle.Text = Nothing
            txtauthor.Text = Nothing
            txtpublisher.Text = Nothing
            txtcopyright.Text = Nothing
            txteditnum.Text = Nothing
            txtnumcop.Text = Nothing
            txtnumpage.Text = Nothing
            txtnumlibr.Text = Nothing
        End If

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txttitle.TextChanged, txtauthor.TextChanged, txtpublisher.TextChanged, txtcopyright.TextChanged, txteditnum.TextChanged, txtnumcop.TextChanged, txtnumpage.TextChanged, txtnumlibr.TextChanged
        If txttitle.Text = "" And txtauthor.Text = "" And txtpublisher.Text = "" And txtcopyright.Text = "" And txteditnum.Text = "" And txtnumpage.Text = "" And txtnumcop.Text = "" And txtnumlibr.Text = "" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub
End Class