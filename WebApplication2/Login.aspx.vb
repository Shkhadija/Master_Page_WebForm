Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)

        If txtUser.Text = "admin" And txtPass.Text = "123" Then
            Response.Redirect("Calculyator.aspx")
        Else
            lblMsg.Text = "Username və ya password səhvdir!"
        End If

    End Sub

End Class