Public Class frmSales

    Private Sub frmSales_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dashboard.Show()
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        onLoadActivities()
       
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        dlgPayment.Show()
    End Sub


  

    Private Sub onLoadActivities()
        statCurrentEmployee.Text = statCurrentEmployee.ToString & ": " & My.Settings.LoggedUser.ToString
        'reset values
        lblSubAmount.Text = "0.00"
        lblTaxAmount.Text = "0.00"
        lblTotalAmount.Text = "0.00"
        Dim locX As Integer = 264
        Console.WriteLine("distance: " & lblSubAmount.Right.ToString - lblSubAmount.Left)

        lblSubAmount.Left = locX - (lblSubAmount.Right - lblSubAmount.Left)
        lblTaxAmount.Left = locX - (lblTaxAmount.Right - lblTaxAmount.Left)
        lblTotalAmount.Left = locX - (lblTotalAmount.Right - lblTotalAmount.Left)


        

    End Sub

    Private Sub frmSales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        '---listen for F6 key press
        If e.KeyCode = Keys.F6 Then
            dlgPayment.Show()

        End If
    End Sub
End Class