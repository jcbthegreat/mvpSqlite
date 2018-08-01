Module validationForInputs

    Public Function inputValidation(check As Boolean) As Boolean

        If Form1.secTxtBox.Text = "" And Form1.firstnameTxtBox.Text = "" And Form1.lastnameTxtBox.Text = "" _
            And Form1.genderTxtBox.Text = "" And Form1.ageTxtBox.Text = "" And Form1.points1TxtBox.Text = "" _
            And Form1.points2TxtBox.Text = "" Then


            Return check = True

        Else

            Return check = False

        End If





    End Function

End Module
