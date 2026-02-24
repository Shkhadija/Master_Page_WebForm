Public Class Calculator
    Inherits System.Web.UI.Page

    Private Function TryGetNumbers(ByRef n1 As Double, ByRef n2 As Double) As Boolean

        If Not Double.TryParse(txtNum1.Text, n1) Then
            lblResult.Text = "1-ci xana üçün düzgün ədəd daxil edin."
            txtNum1.Focus()
            Return False
        End If

        If Not Double.TryParse(txtNum2.Text, n2) Then
            lblResult.Text = "2-ci xana üçün düzgün ədəd daxil edin."
            txtNum2.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub ClearInputs()
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtNum1.Focus()
    End Sub


    Protected Sub btnAdd_Click(sender As Object, e As EventArgs)
        Dim n1 As Double, n2 As Double
        If Not TryGetNumbers(n1, n2) Then Exit Sub

        lblResult.Text = "Nəticə: " & (n1 + n2)
        ClearInputs()
    End Sub


    Protected Sub btnSub_Click(sender As Object, e As EventArgs)
        Dim n1 As Double, n2 As Double
        If Not TryGetNumbers(n1, n2) Then Exit Sub

        lblResult.Text = "Nəticə: " & (n1 - n2)
        ClearInputs()
    End Sub


    Protected Sub btnMul_Click(sender As Object, e As EventArgs)
        Dim n1 As Double, n2 As Double
        If Not TryGetNumbers(n1, n2) Then Exit Sub

        lblResult.Text = "Nəticə: " & (n1 * n2)
        ClearInputs()
    End Sub


    Protected Sub btnDiv_Click(sender As Object, e As EventArgs)
        Dim n1 As Double, n2 As Double
        If Not TryGetNumbers(n1, n2) Then Exit Sub

        If n2 = 0 Then
            lblResult.Text = "0-a bölmək olmaz!"
            txtNum2.Focus()
            Exit Sub
        End If

        lblResult.Text = "Nəticə: " & (n1 / n2)
        ClearInputs()
    End Sub

End Class