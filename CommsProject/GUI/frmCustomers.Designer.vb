<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Me.lblCustomerFName = New System.Windows.Forms.Label()
        Me.txtCustomerFName = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCustomerType = New System.Windows.Forms.Label()
        Me.btnConfCustType = New System.Windows.Forms.Button()
        Me.lblCustomerMName = New System.Windows.Forms.Label()
        Me.txtCustomerMName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblCustomerLName = New System.Windows.Forms.Label()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblCustomerTelNo = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblCustomerEmail = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.datafieldCustomerType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldCustomerFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldCustomerAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldTelNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldMobileNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldCustomerEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomerFName
        '
        Me.lblCustomerFName.AutoSize = True
        Me.lblCustomerFName.Location = New System.Drawing.Point(213, 55)
        Me.lblCustomerFName.Name = "lblCustomerFName"
        Me.lblCustomerFName.Size = New System.Drawing.Size(60, 13)
        Me.lblCustomerFName.TabIndex = 0
        Me.lblCustomerFName.Text = "First Name:"
        '
        'txtCustomerFName
        '
        Me.txtCustomerFName.Location = New System.Drawing.Point(282, 52)
        Me.txtCustomerFName.Name = "txtCustomerFName"
        Me.txtCustomerFName.Size = New System.Drawing.Size(181, 20)
        Me.txtCustomerFName.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'lblCustomerType
        '
        Me.lblCustomerType.AutoSize = True
        Me.lblCustomerType.Location = New System.Drawing.Point(12, 9)
        Me.lblCustomerType.Name = "lblCustomerType"
        Me.lblCustomerType.Size = New System.Drawing.Size(78, 13)
        Me.lblCustomerType.TabIndex = 0
        Me.lblCustomerType.Text = "Customer Type"
        '
        'btnConfCustType
        '
        Me.btnConfCustType.Location = New System.Drawing.Point(202, 23)
        Me.btnConfCustType.Name = "btnConfCustType"
        Me.btnConfCustType.Size = New System.Drawing.Size(151, 23)
        Me.btnConfCustType.TabIndex = 3
        Me.btnConfCustType.Text = "Configure Customer Types"
        Me.btnConfCustType.UseVisualStyleBackColor = True
        '
        'lblCustomerMName
        '
        Me.lblCustomerMName.AutoSize = True
        Me.lblCustomerMName.Location = New System.Drawing.Point(478, 55)
        Me.lblCustomerMName.Name = "lblCustomerMName"
        Me.lblCustomerMName.Size = New System.Drawing.Size(72, 13)
        Me.lblCustomerMName.TabIndex = 4
        Me.lblCustomerMName.Text = "Middle Name:"
        '
        'txtCustomerMName
        '
        Me.txtCustomerMName.Location = New System.Drawing.Point(559, 52)
        Me.txtCustomerMName.Name = "txtCustomerMName"
        Me.txtCustomerMName.Size = New System.Drawing.Size(181, 20)
        Me.txtCustomerMName.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(282, 78)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(181, 20)
        Me.txtLastName.TabIndex = 6
        '
        'lblCustomerLName
        '
        Me.lblCustomerLName.AutoSize = True
        Me.lblCustomerLName.Location = New System.Drawing.Point(212, 81)
        Me.lblCustomerLName.Name = "lblCustomerLName"
        Me.lblCustomerLName.Size = New System.Drawing.Size(61, 13)
        Me.lblCustomerLName.TabIndex = 7
        Me.lblCustomerLName.Text = "Last Name:"
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Location = New System.Drawing.Point(222, 107)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomerAddress.TabIndex = 8
        Me.lblCustomerAddress.Text = " Address:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(282, 104)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 56)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(559, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 20)
        Me.TextBox2.TabIndex = 10
        '
        'lblCustomerTelNo
        '
        Me.lblCustomerTelNo.AutoSize = True
        Me.lblCustomerTelNo.Location = New System.Drawing.Point(469, 81)
        Me.lblCustomerTelNo.Name = "lblCustomerTelNo"
        Me.lblCustomerTelNo.Size = New System.Drawing.Size(81, 13)
        Me.lblCustomerTelNo.TabIndex = 11
        Me.lblCustomerTelNo.Text = "Telephone No.:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(559, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(181, 20)
        Me.TextBox3.TabIndex = 12
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Location = New System.Drawing.Point(489, 107)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(61, 13)
        Me.lblMobileNo.TabIndex = 13
        Me.lblMobileNo.Text = "Mobile No.:"
        '
        'lblCustomerEmail
        '
        Me.lblCustomerEmail.AutoSize = True
        Me.lblCustomerEmail.Location = New System.Drawing.Point(515, 133)
        Me.lblCustomerEmail.Name = "lblCustomerEmail"
        Me.lblCustomerEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblCustomerEmail.TabIndex = 14
        Me.lblCustomerEmail.Text = "Email:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(559, 130)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(181, 20)
        Me.TextBox4.TabIndex = 15
        '
        'dgvCustomer
        '
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.datafieldCustomerType, Me.datafieldCustomerFName, Me.datafieldMName, Me.datafieldLName, Me.datafieldCustomerAddress, Me.datafieldTelNo, Me.datafieldMobileNo, Me.datafieldCustomerEmail})
        Me.dgvCustomer.Location = New System.Drawing.Point(15, 184)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(725, 183)
        Me.dgvCustomer.TabIndex = 16
        '
        'datafieldCustomerType
        '
        Me.datafieldCustomerType.HeaderText = "Customer Type"
        Me.datafieldCustomerType.Name = "datafieldCustomerType"
        '
        'datafieldCustomerFName
        '
        Me.datafieldCustomerFName.HeaderText = "First Name"
        Me.datafieldCustomerFName.Name = "datafieldCustomerFName"
        '
        'datafieldMName
        '
        Me.datafieldMName.HeaderText = "Middle Name"
        Me.datafieldMName.Name = "datafieldMName"
        '
        'datafieldLName
        '
        Me.datafieldLName.HeaderText = "Last Name"
        Me.datafieldLName.Name = "datafieldLName"
        '
        'datafieldCustomerAddress
        '
        Me.datafieldCustomerAddress.HeaderText = "Address"
        Me.datafieldCustomerAddress.Name = "datafieldCustomerAddress"
        '
        'datafieldTelNo
        '
        Me.datafieldTelNo.HeaderText = "Telephone No"
        Me.datafieldTelNo.Name = "datafieldTelNo"
        '
        'datafieldMobileNo
        '
        Me.datafieldMobileNo.HeaderText = "Mobile No"
        Me.datafieldMobileNo.Name = "datafieldMobileNo"
        '
        'datafieldCustomerEmail
        '
        Me.datafieldCustomerEmail.HeaderText = "Email"
        Me.datafieldCustomerEmail.Name = "datafieldCustomerEmail"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(665, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(584, 439)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(584, 155)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(665, 155)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 474)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblCustomerEmail)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblCustomerTelNo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCustomerAddress)
        Me.Controls.Add(Me.lblCustomerLName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtCustomerMName)
        Me.Controls.Add(Me.lblCustomerMName)
        Me.Controls.Add(Me.btnConfCustType)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtCustomerFName)
        Me.Controls.Add(Me.lblCustomerType)
        Me.Controls.Add(Me.lblCustomerFName)
        Me.Name = "frmCustomers"
        Me.Text = "Customer"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomerFName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerFName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomerType As System.Windows.Forms.Label
    Friend WithEvents btnConfCustType As System.Windows.Forms.Button
    Friend WithEvents lblCustomerMName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerLName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerTelNo As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents lblCustomerEmail As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents datafieldCustomerType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldCustomerFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldCustomerAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldTelNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldMobileNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldCustomerEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
