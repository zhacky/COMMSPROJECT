Public Class Dashboard

    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        Dim users As New UsersDialog
        users.Show()

    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
