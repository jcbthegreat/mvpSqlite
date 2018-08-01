Imports System.Data.SQLite
Imports Excel = Microsoft.Office.Interop.Excel
Module Presenter

    Private id As String

    'Insert QUERIES
    Public Sub insertTbl()

        If inputValidation(check:=True) Then
            MsgBox("Please Complete the info.", MsgBoxStyle.Exclamation, "System")

        ElseIf inputValidation(check:=False) Then

            loadFunction(Sqlquery:="INSERT INTO infosTable VALUES (null, '" & Form1.secTxtBox.Text & "',
                                                                 '" & Form1.firstnameTxtBox.Text & "',
                                                                 '" & Form1.lastnameTxtBox.Text & "',
                                                                 '" & Form1.genderTxtBox.Text & "', 
                                                                 '" & Form1.ageTxtBox.Text & "',
                                                                 '" & Form1.points1TxtBox.Text & "',
                                                                 '" & Form1.points2TxtBox.Text & "' )")
            MsgBox("Information successfully Added!", MsgBoxStyle.Information, "System")
            selectData()

        End If

    End Sub

    'Select QUERIES
    Public Sub selectData()

        loadFunction(Sqlquery:="SELECT * FROM infosTable")
        BtnBehavior(en:=True)

    End Sub

    'Create TABLE query
    Public Sub CreateTable()

        loadFunction(Sqlquery:="CREATE TABLE infosTable(
                       Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                       Section TEXT NOT NULL,
                       FirstName TEXT NOT NULL,
                       LastName TEXT NOT NULL,
                       Gender TEXT NOT NULL,
                       Age TEXT NOT NULL,
                       Points1 INTEGER NOT NULL,
                       Points2 INTEGER NOT NULL
                        );")

    End Sub

    'Update QUERIES
    Public Sub updateTable()


        If inputValidation(check:=True) Then
            MsgBox("Update Failed! Some Field(s) is Empty. Please Try Again", MsgBoxStyle.Exclamation, "System")

            'ElseIf Form1.genderTxtBox.Text IsNot "Male" Or "Female" Then
            '    MsgBox("Gender Textbox must be 'Male' Or 'Female' only!", "Invalid Gender", MsgBoxStyle.Exclamation)

        ElseIf inputValidation(check:=False) Then
            'if the information is correct and valid then 
            'load the Function UPDATE QUERY
            loadFunction(Sqlquery:="UPDATE infosTable SET Section = '" & Form1.secTxtBox.Text & "', 
                                                  Firstname = '" & Form1.firstnameTxtBox.Text & "', 
                                                  Lastname = '" & Form1.lastnameTxtBox.Text & "',
                                                  Gender = '" & Form1.genderTxtBox.Text & "', 
                                                  Age = '" & Form1.ageTxtBox.Text & "',
                                                  Points1 = '" & Form1.points1TxtBox.Text & "',
                                                  Points2 = '" & Form1.points2TxtBox.Text & "'
                                                  WHERE Id = '" & id & "'")

            MsgBox("Data has been changed successfully", MsgBoxStyle.Information, "Updated Data")
            BtnBehavior(en:=True)
            'Refresh DataGridView For Updated data
            selectData()

            'Clear Fields after Updating
            clearFields()

        End If
    End Sub

    'Delete QUERIES
    Public Sub deleteData()

        If MsgBox("Are you sure you want to Delete " & Form1.firstnameTxtBox.Text + " " + Form1.lastnameTxtBox.Text & " With ID of : " & id, "System", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Data: " & Form1.firstnameTxtBox.Text + Form1.lastnameTxtBox.Text & " ID: " & id & " Has Been Deleted.", MsgBoxStyle.Information, "System")

            'if the user confirmation to delete information equal to yes then 
            'load the Function with DELETE query
            loadFunction(Sqlquery:="DELETE FROM infosTable WHERE id = '" & id & "'")

            'Refresh DataGridView from Form1
            selectData()

            BtnBehavior(en:=True)
            'Clear Fields afterwards
            clearFields()
        End If


    End Sub

    'Other Functions
    Public Sub PopulateFields()

        id = Form1.DataGridView1.Item(0, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.secTxtBox.Text = Form1.DataGridView1.Item(1, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.firstnameTxtBox.Text = Form1.DataGridView1.Item(2, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.lastnameTxtBox.Text = Form1.DataGridView1.Item(3, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.genderTxtBox.Text = Form1.DataGridView1.Item(4, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.ageTxtBox.Text = Form1.DataGridView1.Item(5, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.points1TxtBox.Text = Form1.DataGridView1.Item(6, Form1.DataGridView1.CurrentRow.Index).Value
        Form1.points2TxtBox.Text = Form1.DataGridView1.Item(7, Form1.DataGridView1.CurrentRow.Index).Value

        BtnBehavior(en:=False)

    End Sub

    Public Sub cancelBtnFunction()

        clearFields()
        BtnBehavior(en:=True)
    End Sub
    'Buttons Behavior in Form1
    Public Function BtnBehavior(en As Boolean) As Boolean

        If en = True Then
            Form1.addBtn.Enabled = True
            Form1.exportBtn.Visible = True
            Form1.exportBtn.Enabled = True
            Form1.updateBtn.Enabled = False
            Form1.delBtn.Enabled = False
            Form1.cancelBtn.Visible = False


        ElseIf en = False Then
            Form1.addBtn.Enabled = False
            Form1.exportBtn.Visible = False
            Form1.updateBtn.Enabled = True
            Form1.delBtn.Enabled = True
            Form1.cancelBtn.Visible = True

        End If

        Return en
    End Function


    'Clear Fields
    Public Sub clearFields()

        'clear the id variable b'cause the value of selected id will remain in id variable
        'it can be delete accidentally or update without a validation
        id = ""

        Form1.secTxtBox.Clear()
        Form1.firstnameTxtBox.Clear()
        Form1.lastnameTxtBox.Clear()
        Form1.genderTxtBox.Clear()
        Form1.ageTxtBox.Clear()
        Form1.points1TxtBox.Clear()
        Form1.points2TxtBox.Clear()

    End Sub

    'Export DATA from DATAGRIDVIEW To Microsoft EXCEL
    Public Sub ExportToExcel()

        Dim xa As New Excel.Application
        Dim ws As Excel.Worksheet
        Dim wb As Excel.Workbook

        xa.Visible = True
        wb = xa.Workbooks.Add
        ws = xa.Worksheets("Sheet1")

        'column to array
        Dim ArrayC(,) As Object
        ReDim ArrayC(0, Model.table.Columns.Count - 1)
        For DataC As Integer = 0 To Model.table.Columns.Count - 1
            ArrayC(0, DataC) = Model.table.Columns(DataC).ColumnName
        Next
        'rows to array
        Dim ArrayR(,) As Object
        ReDim ArrayR(Model.table.Rows.Count - 1, Model.table.Columns.Count - 1)
        For r As Integer = 0 To Model.table.Rows.Count - 1
            For c As Integer = 0 To Model.table.Columns.Count - 1
                ArrayR(r, c) = Model.table.Rows(r).Item(c).ToString
            Next
        Next

        With ws

            Dim rcount, ccount As Integer

            ccount = Model.table.Columns.Count
            rcount = Model.table.Rows.Count

            'column header
            .Range(.Range(.Cells(18, 1), .Cells(18, ccount)).Address).Value = ArrayC
            .Range(.Range(.Cells(18, 1), .Cells(18, ccount)).Address).Font.Bold = True


            'rows
            .Range(.Range(.Cells(19, 1), .Cells(rcount + 18, ccount)).Address).Value = ArrayR
            .Cells.EntireColumn.AutoFit()

            .Range(.Cells(18, 1).address, .Cells(18, ccount).address).Interior.ColorIndex = 37
            .Range(.Cells(19, 1).address, .Cells(rcount + 18, ccount).address).Style.Font.ColorIndex = 1

            .UsedRange.Borders.LineStyle = True

            'Chart

            Dim chartPage As Excel.Chart
            Dim xlCharts As Excel.ChartObjects
            Dim myChart As Excel.ChartObject
            Dim chartRange As Excel.Range

            xlCharts = .ChartObjects
            myChart = xlCharts.Add(0, 0, 600, 255)
            chartPage = myChart.Chart
            chartRange = .Range(.Range(.Cells(18, 6), .Cells(rcount + 18, 8)).Address)
            chartPage.SetSourceData(Source:=chartRange)
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered
            chartPage.SeriesCollection(1).Interior.colorIndex = 22
            'chartPage.SeriesCollection(2).Interior.ColorIndex = 37


            ' first get range of cells from sheet 1 that will be used by pivot
            Dim xRange As Excel.Range = CType(ws, Excel.Worksheet).Range(.Cells(18, 1).address, .Cells(rcount + 18, 8).address)

            ws = CType(wb.Worksheets.Add(), Excel.Worksheet)
            ws.Name = "Sheet 2"
            ws.Move(After:=wb.Worksheets(wb.Worksheets.Count))
            ' specify first cell for pivot table on the second sheet
            Dim xRange2 As Excel.Range = CType(ws, Excel.Worksheet).Range("A1")

            ' Create pivot cache and table
            Dim ptCache As Excel.PivotCache = wb.PivotCaches.Add(Excel.XlPivotTableSourceType.xlDatabase, xRange)
            Dim ptTable As Excel.PivotTable = ws.PivotTables.Add(PivotCache:=ptCache, TableDestination:=xRange2, TableName:="Pivot Table")

            Dim ptField As Excel.PivotField
            ptField = ptTable.PivotFields("Gender")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlPageField
                .Name = " Gender"
            End With
            ptField = ptTable.PivotFields("Age")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlPageField
                .Name = " Age"
            End With

            'design
            ptTable.TableStyle2 = "PivotStyleLight16"
            'layout report
            ptTable.RowAxisLayout(Excel.XlLayoutRowType.xlCompactRow)

            ' add row
            ptField = ptTable.PivotFields("Section")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlRowField
                .Name = " Section"
                ' sub total layout at bottom
                .LayoutSubtotalLocation = Excel.XlSubtototalLocationType.xlAtBottom
            End With

            ptField = ptTable.PivotFields("FirstName")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlRowField
                .Name = " First Name"
            End With

            ptField = ptTable.PivotFields("LastName")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlRowField
                .Name = " Last Name"
            End With


            'column total
            ptField = ptTable.PivotFields("Points1")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlDataField
                .Function = Excel.XlConsolidationFunction.xlSum
                .Name = " Sum of Points 1"
                .Position = 1
            End With

            ptField = ptTable.PivotFields("Points2")
            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlDataField
                .Function = Excel.XlConsolidationFunction.xlSum
                .Name = " Sum of Points 2"
                .Position = 2
            End With
            ptField = ptTable.PivotFields("Data")

            With ptField
                .Orientation = Excel.XlPivotFieldOrientation.xlColumnField
                .Name = Nothing
            End With

        End With
    End Sub

    'Create DATABASE file
    Public Sub CreateDB()

        'If there is no database existing, use this method to create Database File
        'SQLiteConnection.CreateFile("C:\\\Location\database file")
        'Example:
        SQLiteConnection.CreateFile("F:\\\userJorge\databases\dbjorgesample.db3")

    End Sub

End Module
