Public Class frmSales

    Private Sub frmSales_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        statCurrentEmployee.Text = statCurrentEmployee.ToString & ": " & My.Settings.LoggedUser.ToString
    End Sub
End Class