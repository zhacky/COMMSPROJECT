Imports System.Windows.Forms

Public Class UsersDialog
    Private boxesEmpty As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If boxesEmpty Then
            If validateFields() Then

            End If
            If (Len(txtUsername.Text) > 2 And Len(txtPassword.Text) > 2) Then
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                If (Len(cboRole.Text) > 2) Then
                    Dim role As String = cboRole.Text
                    Console.WriteLine("Passing values (" & username & "," & password & "," & role & ") to the DataClass: AddUser")
                    DataClass.AddUser(username, password, role)
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    cboRole.SelectedIndex = -1
                    loadUsers()
                Else
                    MessageBox.Show("Please select access level")
                End If
            Else
                MessageBox.Show("The username or password requires at least three(3) characters")
            End If
        Else
            resetFields()
        End If
    End Sub

    Private Sub UsersDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boxesEmpty = True
        btnUpdate.Enabled = False
        loadUsers()
    End Sub

    Private Sub loadUsers()
        lstUsers.Items.Clear()
        Dim userList As String() = DataClass.GetUsers()
        For index = 1 To userList.Length - 1
            Console.WriteLine(userList(index - 1))
        Next
        lstUsers.Items.AddRange(userList)
        resetFields()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lstUsers.SelectedIndex < 0 Then
            MessageBox.Show("Please select a username from the list ")
        Else
            Console.WriteLine("You have selected " & lstUsers.SelectedItem.ToString & " for deletion...")
            If (DialogResult.Yes = MessageBox.Show("Are you sure you want to delete this user?", "Confirm user deletion", MessageBoxButtons.YesNo)) Then
                Console.WriteLine(" " & lstUsers.SelectedItem.ToString & " deleted!")
                DataClass.DeleteUser(lstUsers.SelectedIndex)
                loadUsers()
                resetFields()
            End If

        End If
    End Sub

    Private Sub lstUsers_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstUsers.MouseClick
        Console.WriteLine(" " & lstUsers.SelectedItem)
        Dim userData As String() = DataClass.DisplayUser(lstUsers.SelectedIndex)
        txtUsername.Text = userData(0)
        txtPassword.Text = userData(1)
        cboRole.Text = userData(2)
        boxesEmpty = False
        btnAdd.Text = "Add New"
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Console.WriteLine("You have selected " & lstUsers.SelectedItem.ToString & " for updating...")

        If lstUsers.SelectedIndex < 0 Then
            MessageBox.Show("Please select a username from the list ")
        Else
            If validateFields() Then
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim role As String = cboRole.Text
                Console.WriteLine("Passing values (" & lstUsers.SelectedIndex.ToString & "," & username & "," & password & "," & role & ") to the DataClass: AddUser")
                DataClass.UpdateUser(lstUsers.SelectedIndex, username, password, role)
                Console.WriteLine(" " & lstUsers.SelectedItem.ToString & " updated!")
                loadUsers()
                resetFields()
            End If
           
        End If
    End Sub

    Private Sub resetFields()
        txtUsername.Text = ""
        txtPassword.Text = ""
        cboRole.SelectedIndex = -1
        lstUsers.SelectedIndex = -1
        btnUpdate.Enabled = False
        btnAdd.Text = "Add"
        boxesEmpty = True
    End Sub

    Private Function validateFields() As Boolean
        Dim validated As Boolean = False
        If (Len(txtUsername.Text) > 2 And Len(txtPassword.Text) > 2) Then
            If (Len(cboRole.Text) > 2) Then
                validated = True
            Else
                MessageBox.Show("Please select access level")
            End If
        Else
            MessageBox.Show("The username or password requires at least three(3) characters")
        End If

        Return validated

    End Function

End Class
