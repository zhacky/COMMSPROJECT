<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.gbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.gbxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(12, 12)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(75, 23)
        Me.btnUsers.TabIndex = 0
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'gbxMenu
        '
        Me.gbxMenu.Controls.Add(Me.btnLogout)
        Me.gbxMenu.Controls.Add(Me.btnCustomer)
        Me.gbxMenu.Controls.Add(Me.btnSupplier)
        Me.gbxMenu.Controls.Add(Me.btnProducts)
        Me.gbxMenu.Controls.Add(Me.btnEmployee)
        Me.gbxMenu.Controls.Add(Me.btnPurchase)
        Me.gbxMenu.Location = New System.Drawing.Point(112, 124)
        Me.gbxMenu.Name = "gbxMenu"
        Me.gbxMenu.Size = New System.Drawing.Size(507, 105)
        Me.gbxMenu.TabIndex = 1
        Me.gbxMenu.TabStop = False
        Me.gbxMenu.Text = "Menu"
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(6, 71)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 0
        Me.btnPurchase.Text = "PURCHASE"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(87, 71)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(75, 23)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.Text = "EMPLOYEE"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(168, 71)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(75, 23)
        Me.btnProducts.TabIndex = 2
        Me.btnProducts.Text = "PRODUCTS"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Location = New System.Drawing.Point(249, 71)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(75, 23)
        Me.btnSupplier.TabIndex = 3
        Me.btnSupplier.Text = "SUPPLIER"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(330, 71)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(90, 23)
        Me.btnCustomer.TabIndex = 4
        Me.btnCustomer.Text = "CUSTOMER"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(426, 71)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 399)
        Me.Controls.Add(Me.gbxMenu)
        Me.Controls.Add(Me.btnUsers)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.gbxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents gbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnPurchase As System.Windows.Forms.Button

End Class
