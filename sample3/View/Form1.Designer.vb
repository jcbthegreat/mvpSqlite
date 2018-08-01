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
        Me.addBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.exportBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.createTblBtn = New System.Windows.Forms.Button()
        Me.secTxtBox = New System.Windows.Forms.TextBox()
        Me.firstnameTxtBox = New System.Windows.Forms.TextBox()
        Me.lastnameTxtBox = New System.Windows.Forms.TextBox()
        Me.genderTxtBox = New System.Windows.Forms.TextBox()
        Me.ageTxtBox = New System.Windows.Forms.TextBox()
        Me.points1TxtBox = New System.Windows.Forms.TextBox()
        Me.points2TxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.createDatabaseBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(12, 233)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(111, 32)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(247, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 361)
        Me.DataGridView1.TabIndex = 1
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(129, 233)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(111, 32)
        Me.updateBtn.TabIndex = 2
        Me.updateBtn.Text = "UPDATE"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(12, 271)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(111, 32)
        Me.delBtn.TabIndex = 3
        Me.delBtn.Text = "DELETE"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(129, 271)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(111, 32)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = "C INPUTS"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'exportBtn
        '
        Me.exportBtn.Location = New System.Drawing.Point(12, 309)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(228, 38)
        Me.exportBtn.TabIndex = 5
        Me.exportBtn.Text = "EXPORT TO EXCEL"
        Me.exportBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(37, 374)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(158, 24)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "EXIT APPLICATION"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'createTblBtn
        '
        Me.createTblBtn.Location = New System.Drawing.Point(411, 374)
        Me.createTblBtn.Name = "createTblBtn"
        Me.createTblBtn.Size = New System.Drawing.Size(158, 24)
        Me.createTblBtn.TabIndex = 7
        Me.createTblBtn.Text = "Create Table if not Exist"
        Me.createTblBtn.UseVisualStyleBackColor = True
        '
        'secTxtBox
        '
        Me.secTxtBox.Location = New System.Drawing.Point(95, 27)
        Me.secTxtBox.Name = "secTxtBox"
        Me.secTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.secTxtBox.TabIndex = 8
        '
        'firstnameTxtBox
        '
        Me.firstnameTxtBox.Location = New System.Drawing.Point(95, 53)
        Me.firstnameTxtBox.Name = "firstnameTxtBox"
        Me.firstnameTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.firstnameTxtBox.TabIndex = 9
        '
        'lastnameTxtBox
        '
        Me.lastnameTxtBox.Location = New System.Drawing.Point(95, 79)
        Me.lastnameTxtBox.Name = "lastnameTxtBox"
        Me.lastnameTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.lastnameTxtBox.TabIndex = 10
        '
        'genderTxtBox
        '
        Me.genderTxtBox.Location = New System.Drawing.Point(95, 105)
        Me.genderTxtBox.Name = "genderTxtBox"
        Me.genderTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.genderTxtBox.TabIndex = 11
        '
        'ageTxtBox
        '
        Me.ageTxtBox.Location = New System.Drawing.Point(95, 131)
        Me.ageTxtBox.Name = "ageTxtBox"
        Me.ageTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.ageTxtBox.TabIndex = 12
        '
        'points1TxtBox
        '
        Me.points1TxtBox.Location = New System.Drawing.Point(95, 157)
        Me.points1TxtBox.Name = "points1TxtBox"
        Me.points1TxtBox.Size = New System.Drawing.Size(136, 20)
        Me.points1TxtBox.TabIndex = 13
        '
        'points2TxtBox
        '
        Me.points2TxtBox.Location = New System.Drawing.Point(95, 183)
        Me.points2TxtBox.Name = "points2TxtBox"
        Me.points2TxtBox.Size = New System.Drawing.Size(136, 20)
        Me.points2TxtBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Lastname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Points 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Points 2"
        '
        'createDatabaseBtn
        '
        Me.createDatabaseBtn.Location = New System.Drawing.Point(247, 374)
        Me.createDatabaseBtn.Name = "createDatabaseBtn"
        Me.createDatabaseBtn.Size = New System.Drawing.Size(158, 24)
        Me.createDatabaseBtn.TabIndex = 22
        Me.createDatabaseBtn.Text = "Create Database if not Exist"
        Me.createDatabaseBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(12, 309)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(228, 38)
        Me.cancelBtn.TabIndex = 23
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 404)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.createDatabaseBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.points2TxtBox)
        Me.Controls.Add(Me.points1TxtBox)
        Me.Controls.Add(Me.ageTxtBox)
        Me.Controls.Add(Me.genderTxtBox)
        Me.Controls.Add(Me.lastnameTxtBox)
        Me.Controls.Add(Me.firstnameTxtBox)
        Me.Controls.Add(Me.secTxtBox)
        Me.Controls.Add(Me.createTblBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.exportBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.addBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sample 3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents updateBtn As Button
    Friend WithEvents delBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents exportBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents createTblBtn As Button
    Friend WithEvents secTxtBox As TextBox
    Friend WithEvents firstnameTxtBox As TextBox
    Friend WithEvents lastnameTxtBox As TextBox
    Friend WithEvents genderTxtBox As TextBox
    Friend WithEvents ageTxtBox As TextBox
    Friend WithEvents points1TxtBox As TextBox
    Friend WithEvents points2TxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents createDatabaseBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
