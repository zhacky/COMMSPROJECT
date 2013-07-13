<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picEmployee = New System.Windows.Forms.PictureBox()
        Me.lblEmployeeId = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.txtEmployeeFName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeMName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeLName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephoneNo = New System.Windows.Forms.TextBox()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeUserType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeTelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeMobileNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboUserType = New System.Windows.Forms.ComboBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE RECORD"
        '
        'picEmployee
        '
        Me.picEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picEmployee.Location = New System.Drawing.Point(321, 42)
        Me.picEmployee.Name = "picEmployee"
        Me.picEmployee.Size = New System.Drawing.Size(111, 111)
        Me.picEmployee.TabIndex = 1
        Me.picEmployee.TabStop = False
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.Location = New System.Drawing.Point(67, 18)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(70, 13)
        Me.lblEmployeeId.TabIndex = 2
        Me.lblEmployeeId.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(143, 15)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(172, 20)
        Me.txtEmployeeID.TabIndex = 3
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.EmployeeUserType, Me.EmployeeFName, Me.EmployeeMName, Me.EmployeeLName, Me.EmployeeBirthDate, Me.EmployeeSex, Me.EmployeePosition, Me.EmployeeAddress, Me.EmployeeTelNo, Me.EmployeeMobileNo, Me.EmployeeUserName, Me.EmployeePassword, Me.EmployeeStatus})
        Me.dgvEmployees.Location = New System.Drawing.Point(321, 159)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(417, 227)
        Me.dgvEmployees.TabIndex = 4
        '
        'txtEmployeeFName
        '
        Me.txtEmployeeFName.Location = New System.Drawing.Point(143, 68)
        Me.txtEmployeeFName.Name = "txtEmployeeFName"
        Me.txtEmployeeFName.Size = New System.Drawing.Size(172, 20)
        Me.txtEmployeeFName.TabIndex = 5
        '
        'txtEmployeeMName
        '
        Me.txtEmployeeMName.Location = New System.Drawing.Point(143, 94)
        Me.txtEmployeeMName.Name = "txtEmployeeMName"
        Me.txtEmployeeMName.Size = New System.Drawing.Size(172, 20)
        Me.txtEmployeeMName.TabIndex = 6
        '
        'txtEmployeeLName
        '
        Me.txtEmployeeLName.Location = New System.Drawing.Point(143, 120)
        Me.txtEmployeeLName.Name = "txtEmployeeLName"
        Me.txtEmployeeLName.Size = New System.Drawing.Size(172, 20)
        Me.txtEmployeeLName.TabIndex = 7
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(143, 198)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(172, 20)
        Me.txtPosition.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(143, 224)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(172, 56)
        Me.txtAddress.TabIndex = 11
        '
        'txtTelephoneNo
        '
        Me.txtTelephoneNo.Location = New System.Drawing.Point(143, 286)
        Me.txtTelephoneNo.Name = "txtTelephoneNo"
        Me.txtTelephoneNo.Size = New System.Drawing.Size(172, 20)
        Me.txtTelephoneNo.TabIndex = 12
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(143, 312)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(172, 20)
        Me.txtMobileNo.TabIndex = 13
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(143, 338)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(172, 20)
        Me.txtUserName.TabIndex = 14
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(143, 364)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(172, 20)
        Me.txtPass.TabIndex = 15
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(143, 390)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(172, 21)
        Me.cboStatus.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Employee First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Employee Middle Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Employee Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Birth Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Sex:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Position:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Telephone Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Mobile Number:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 367)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "User Password:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(79, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Username:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(97, 393)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Status:"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(46, 424)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 29
        Me.btnNew.Text = "ADD"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(152, 424)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(258, 424)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 31
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(93, 467)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(203, 467)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Location = New System.Drawing.Point(143, 146)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(172, 20)
        Me.dtpBirthDate.TabIndex = 34
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(143, 172)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(172, 21)
        Me.cboSex.TabIndex = 35
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.Name = "EmployeeID"
        '
        'EmployeeUserType
        '
        Me.EmployeeUserType.HeaderText = "User Type"
        Me.EmployeeUserType.Name = "EmployeeUserType"
        '
        'EmployeeFName
        '
        Me.EmployeeFName.HeaderText = "First Name"
        Me.EmployeeFName.Name = "EmployeeFName"
        '
        'EmployeeMName
        '
        Me.EmployeeMName.HeaderText = "M.I."
        Me.EmployeeMName.Name = "EmployeeMName"
        '
        'EmployeeLName
        '
        Me.EmployeeLName.HeaderText = "Last Name"
        Me.EmployeeLName.Name = "EmployeeLName"
        '
        'EmployeeBirthDate
        '
        Me.EmployeeBirthDate.HeaderText = "Birth Date"
        Me.EmployeeBirthDate.Name = "EmployeeBirthDate"
        '
        'EmployeeSex
        '
        Me.EmployeeSex.HeaderText = "Sex"
        Me.EmployeeSex.Name = "EmployeeSex"
        '
        'EmployeePosition
        '
        Me.EmployeePosition.HeaderText = "Position"
        Me.EmployeePosition.Name = "EmployeePosition"
        '
        'EmployeeAddress
        '
        Me.EmployeeAddress.HeaderText = "Address"
        Me.EmployeeAddress.Name = "EmployeeAddress"
        '
        'EmployeeTelNo
        '
        Me.EmployeeTelNo.HeaderText = "Telephone"
        Me.EmployeeTelNo.Name = "EmployeeTelNo"
        '
        'EmployeeMobileNo
        '
        Me.EmployeeMobileNo.HeaderText = "Mobile"
        Me.EmployeeMobileNo.Name = "EmployeeMobileNo"
        '
        'EmployeeUserName
        '
        Me.EmployeeUserName.HeaderText = "Username"
        Me.EmployeeUserName.Name = "EmployeeUserName"
        '
        'EmployeePassword
        '
        Me.EmployeePassword.HeaderText = "Password"
        Me.EmployeePassword.Name = "EmployeePassword"
        '
        'EmployeeStatus
        '
        Me.EmployeeStatus.HeaderText = "Status"
        Me.EmployeeStatus.Name = "EmployeeStatus"
        '
        'cboUserType
        '
        Me.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserType.FormattingEnabled = True
        Me.cboUserType.Items.AddRange(New Object() {"Admin", "Cashier", "Supply Officer"})
        Me.cboUserType.Location = New System.Drawing.Point(143, 41)
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(172, 21)
        Me.cboUserType.TabIndex = 36
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Location = New System.Drawing.Point(78, 44)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(59, 13)
        Me.lblUserType.TabIndex = 37
        Me.lblUserType.Text = "User Type:"
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 502)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.cboUserType)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.dtpBirthDate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtTelephoneNo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtEmployeeLName)
        Me.Controls.Add(Me.txtEmployeeMName)
        Me.Controls.Add(Me.txtEmployeeFName)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblEmployeeId)
        Me.Controls.Add(Me.picEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmployees"
        Me.Text = "Employee"
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picEmployee As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmployeeId As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmployeeFName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeMName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeLName As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeUserType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeBirthDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeSex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeePosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeTelNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeMobileNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeePassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboUserType As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserType As System.Windows.Forms.Label
End Class
