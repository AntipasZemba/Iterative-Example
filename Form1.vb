Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intDays As Integer
        Dim dblTotalPay As Double

        Dim blnValidated As Boolean = True

        Get_Validate_Days(intDays, blnValidated)

        If blnValidated Then
            dblTotalPay = Determine_TotalPay(intDays)
            Display_TotalPay(dblTotalPay)
        End If
    End Sub

    Private Sub Get_Validate_Days(ByRef intDays As Integer, ByRef blnValidated As Boolean)
        If Integer.TryParse(txtDays.Text, intDays) Then
            If intDays > 0 Then
            Else
                MessageBox.Show("Days must be greater than 0")
                blnValidated = False
                txtDays.Focus()
            End If
        Else
            MessageBox.Show("Days must be numeric")
            blnValidated = False
            txtDays.Focus()
        End If
    End Sub

    Private Function Determine_TotalPay(ByVal intDays As Integer) As Double
        Dim intCounter As Integer = 1
        Dim dblSalary As Double = 0.01
        Dim dblTotalPay As Double

        For intCounter = 1 To intDays
            dblTotalPay += dblSalary

            dblSalary = dblSalary * 2
        Next

        Return dblTotalPay
    End Function

    Private Sub Display_TotalPay(ByVal dblTotalPay As Double)
        lblSalary.Text = dblTotalPay.ToString("C")
    End Sub
End Class
