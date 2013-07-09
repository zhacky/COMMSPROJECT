Public Class frmEmployees

    Private Sub frmEmployees_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If (DialogResult.OK = MessageBox.Show("Close this window?", "Confirm closing...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) Then
            Me.Close()
        End If
    End Sub
End Class