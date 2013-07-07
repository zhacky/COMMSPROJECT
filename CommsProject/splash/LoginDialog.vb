Public Class LoginDialog

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim LoginCounter As Integer = 0
    Private Username As String = "Zhack"
    Private Password As String = "feedback"

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        testLogin()


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub testLogin()
        Dim userData As String() = DataClass.SearchUserByName(UsernameTextBox.ToString)
        ' Console.WriteLine("Username data: password:" & userData(2) & " role:" & userData(3))


        LoginCounter += 1
        If (UsernameTextBox.Text = Username AndAlso PasswordTextBox.Text = Password) Then
            Console.WriteLine("Sucessfully logged in...")
            Dashboard.Show()
            Me.Close()

        Else
            PasswordTextBox.Clear()
            PasswordTextBox.Focus()
            If LoginCounter = 3 Then
                MessageBox.Show("You've attempted to login 3 times unsuccessfully" & _
                                vbCrLf & "Application will now exit...")
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim s As String = PasswordTextBox.ToString
            If PasswordTextBox.Text = String.Empty Then
                PasswordTextBox.Focus()
            Else
                testLogin()
            End If
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            testLogin()
        End If
    End Sub
End Class
