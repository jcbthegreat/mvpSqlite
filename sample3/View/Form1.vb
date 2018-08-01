Imports System.Data.SQLite

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectData()

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        insertTbl()

    End Sub

    Private Sub createTblBtn_Click(sender As Object, e As EventArgs) Handles createTblBtn.Click
        CreateTable()

    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        updateTable()

    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        deleteData()

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFields()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        PopulateFields()

    End Sub

    Private Sub exportBtn_Click(sender As Object, e As EventArgs) Handles exportBtn.Click
        ExportToExcel()

    End Sub

    Private Sub createDatabaseBtn_Click(sender As Object, e As EventArgs) Handles createDatabaseBtn.Click
        CreateDB()

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        cancelBtnFunction()
    End Sub
End Class
