Imports System.Data.OleDb
Public Class DataClass

    Private Shared dataFile As String = Environment.CurrentDirectory.ToString & "\sys\comms.mdb"

    Private Shared connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dataFile
    Private Shared conn As New OleDbConnection(connString)
    '-------Sub routine that adds a user into the database 
    '-------based on the given username,password and role----------
    Shared Sub AddUser(ByVal username As String, ByVal password As String, ByVal role As String)
        

        Dim user_name As String = username
        Dim user_password As String = password
        Dim user_role As String = role
        Console.WriteLine(Environment.CurrentDirectory.ToString)
        Console.WriteLine(dataFile.ToString)
        conn.Open()
        Dim strQuery As New OleDbCommand("INSERT INTO UsersTable(UserName,UserPassword,UserRole) VALUES(?,?,?);", conn)
        strQuery.Parameters.Add("@UserName", OleDbType.VarChar, 255).Value = user_name
        strQuery.Parameters.Add("@UserPassword", OleDbType.VarChar, 255).Value = user_password
        strQuery.Parameters.Add("@UserRole", OleDbType.VarChar, 255).Value = user_role

        Try

            strQuery.ExecuteNonQuery()
        Catch ex As OleDbException
            Console.WriteLine("DataClass: error adding user to the database..." & vbCrLf & ex.Message)
        End Try

        conn.Close()
    End Sub
    '------- Function to get and return the all user data ---------------

    Shared Function GetUsers() As String()

        Dim userList As New List(Of String)
        Dim strQuery As New OleDbCommand("SELECT * FROM UsersTable", conn)
        Dim dr As OleDbDataReader

        conn.Open()

        Try
            dr = strQuery.ExecuteReader()

            While dr.Read
                Console.WriteLine(dr(1).ToString)
                userList.Add(dr(1).ToString)

            End While


        Catch ex As OleDbException
            Console.WriteLine("DataClass: error getting users array" & vbCrLf & ex.Message)
            MessageBox.Show("DataClass: error getting users array" & vbCrLf & ex.Message)

        End Try


        conn.Close()

        Return userList.ToArray
    End Function
    '-------Sub routine that deletes user data in the database
    '-------based on the user ID from GetUserID(List Index)-------------

    Shared Sub DeleteUser(ByVal p1 As Integer)
        Dim userID = GetUserID(p1)
        conn.Open()
        Dim strDelete As New OleDbCommand("DELETE FROM UsersTable WHERE ID=" & userID, conn)
        Try
            strDelete.ExecuteNonQuery()
        Catch ex As OleDbException
            Console.WriteLine("DataClass: error deleting user from table, probably an ID error" & vbCrLf & ex.Message)
        End Try
        conn.Close()
    End Sub
    '-------Sub routine that displays user data in the database
    '-------based on the user ID from GetUserID(List Index)-------------

    Shared Function DisplayUser(ByVal p1 As Integer) As String()

        Dim userID = GetUserID(p1)
        Dim userData As New List(Of String)
        Dim strGetData As New OleDbCommand("SELECT * FROM UsersTable WHERE ID=" & userID, conn)
        Dim drData As OleDbDataReader
        conn.Open()
        Try
            drData = strGetData.ExecuteReader()
            While drData.Read
                userData.AddRange({drData(1), drData(2), drData(3)})
            End While

        Catch ex As OleDbException
            Console.WriteLine("DataClass: error getting user from table, probably an ID error" & vbCrLf & ex.Message)
        End Try
       
        conn.Close()
        Return userData.ToArray
    End Function
    '-------Sub routine that updates the user in the database
    '-------based on the user ID from GetUserID(List Index)-------------
    Shared Sub UpdateUser(ByVal p1 As Integer, ByVal username As String, ByVal password As String, ByVal role As String)
        Dim userID = GetUserID(p1)
        Dim user_name As String = username
        Dim user_password As String = password
        Dim user_role As String = role
        Dim strUpdateData As New OleDbCommand("UPDATE UsersTable SET UserName=(?),UserPassword=(?), UserRole=(?) WHERE ID=" & userID, conn)

        strUpdateData.Parameters.Add("@UserName", OleDbType.VarChar, 255).Value = user_name
        strUpdateData.Parameters.Add("@UserPassword", OleDbType.VarChar, 255).Value = user_password
        strUpdateData.Parameters.Add("@UserRole", OleDbType.VarChar, 255).Value = user_role
        conn.Open()
        Try
            strUpdateData.ExecuteNonQuery()
        Catch ex As OleDbException
            Console.WriteLine("DataClass: error updating user from table, probably an ID error" & vbCrLf & ex.Message)
        End Try

        conn.Close()
    End Sub
    '------- Function to get and return the userID based on the given List Index ---------------
    Private Shared Function GetUserID(ByVal p1 As Integer) As Object
        Dim usersID As New List(Of Integer)

        Dim userID As Integer
        Dim UserIndex As Integer = p1
        Dim strQuery As New OleDbCommand("SELECT * FROM UsersTable", conn)
        Dim dr As OleDbDataReader
        conn.Open()
        Try
            dr = strQuery.ExecuteReader()
            While dr.Read
                Console.WriteLine(dr(0).ToString)
                usersID.Add(dr(0))
            End While
        Catch ex As OleDbException
            Console.WriteLine("DataClass: error getting user data array" & vbCrLf & ex.Message)
        End Try
        conn.Close()
        userID = usersID(UserIndex)
        Return userID
    End Function

    Shared Function SearchUserByName(ByVal p1 As String) As String()
        Dim username As String = p1
        Dim userData As New List(Of String)
        Dim dr As OleDbDataReader
        Dim strQuery As New OleDbCommand("SELECT * FROM UsersTable WHERE UserName=?", conn)
        strQuery.Parameters.Add("@UserName", OleDbType.VarChar, 255).Value = username
        Try
            conn.Open()
            Try
                dr = strQuery.ExecuteReader()
                While dr.Read
                    Console.WriteLine(dr(1).ToString)
                    userData.AddRange({dr(1), dr(2), dr(3)})
                End While
            Catch ex As Exception

            End Try
            conn.Close()
        Catch ex As Exception

            Console.WriteLine("error opening db connection..." & vbCrLf & ex.Message)

        End Try
        Return userData.ToArray
    End Function

 


End Class
