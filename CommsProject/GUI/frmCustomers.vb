Public Class frmCustomers

    Private Sub frmCustomers_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()

    End Sub

    Private Sub btnConfCustType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfCustType.Click
        dlgCustomerType.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class