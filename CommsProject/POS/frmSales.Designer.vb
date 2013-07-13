<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.stbSalesStatus = New System.Windows.Forms.StatusStrip()
        Me.statCurrentEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.panAmounts = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblSubAmount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.dgvSaleItems = New System.Windows.Forms.DataGridView()
        Me.datafieldProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datafieldAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboProductCode = New System.Windows.Forms.ComboBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnProductSearch = New System.Windows.Forms.Button()
        Me.lblProductQty = New System.Windows.Forms.Label()
        Me.txtProductQty = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.cboCustomerSearch = New System.Windows.Forms.ComboBox()
        Me.stbSalesStatus.SuspendLayout()
        Me.panAmounts.SuspendLayout()
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stbSalesStatus
        '
        Me.stbSalesStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statCurrentEmployee})
        Me.stbSalesStatus.Location = New System.Drawing.Point(0, 543)
        Me.stbSalesStatus.Name = "stbSalesStatus"
        Me.stbSalesStatus.Size = New System.Drawing.Size(848, 22)
        Me.stbSalesStatus.TabIndex = 0
        Me.stbSalesStatus.Text = "StatusStrip1"
        '
        'statCurrentEmployee
        '
        Me.statCurrentEmployee.Name = "statCurrentEmployee"
        Me.statCurrentEmployee.Size = New System.Drawing.Size(36, 17)
        Me.statCurrentEmployee.Text = "User: "
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(12, 33)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(85, 13)
        Me.lblCustomer.TabIndex = 1
        Me.lblCustomer.Text = "Customer Name:"
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(361, 47)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnNewCustomer.TabIndex = 3
        Me.btnNewCustomer.Text = "NEW"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'panAmounts
        '
        Me.panAmounts.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panAmounts.Controls.Add(Me.Panel2)
        Me.panAmounts.Controls.Add(Me.lblTotalAmount)
        Me.panAmounts.Controls.Add(Me.lblTaxAmount)
        Me.panAmounts.Controls.Add(Me.lblSubAmount)
        Me.panAmounts.Controls.Add(Me.lblTax)
        Me.panAmounts.Controls.Add(Me.lblTotal)
        Me.panAmounts.Controls.Add(Me.lblSubTotal)
        Me.panAmounts.Location = New System.Drawing.Point(570, 12)
        Me.panAmounts.Name = "panAmounts"
        Me.panAmounts.Size = New System.Drawing.Size(266, 138)
        Me.panAmounts.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(15, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 2)
        Me.Panel2.TabIndex = 7
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("DS-Digital", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalAmount.Location = New System.Drawing.Point(128, 89)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(135, 35)
        Me.lblTotalAmount.TabIndex = 6
        Me.lblTotalAmount.Text = "8,040.00"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("DS-Digital", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.ForeColor = System.Drawing.Color.Lime
        Me.lblTaxAmount.Location = New System.Drawing.Point(194, 44)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(69, 27)
        Me.lblTaxAmount.TabIndex = 6
        Me.lblTaxAmount.Text = "40.00"
        Me.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubAmount
        '
        Me.lblSubAmount.AutoSize = True
        Me.lblSubAmount.Font = New System.Drawing.Font("DS-Digital", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubAmount.ForeColor = System.Drawing.Color.Lime
        Me.lblSubAmount.Location = New System.Drawing.Point(163, 5)
        Me.lblSubAmount.Name = "lblSubAmount"
        Me.lblSubAmount.Size = New System.Drawing.Size(100, 27)
        Me.lblSubAmount.TabIndex = 6
        Me.lblSubAmount.Text = "8,000.00"
        Me.lblSubAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.White
        Me.lblTax.Location = New System.Drawing.Point(51, 50)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(42, 20)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(39, 102)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(54, 20)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.White
        Me.lblSubTotal.Location = New System.Drawing.Point(1, 11)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(92, 20)
        Me.lblSubTotal.TabIndex = 5
        Me.lblSubTotal.Text = "Sub-Total:"
        '
        'dgvSaleItems
        '
        Me.dgvSaleItems.AllowUserToResizeColumns = False
        Me.dgvSaleItems.AllowUserToResizeRows = False
        Me.dgvSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaleItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.datafieldProductCode, Me.datafieldProductName, Me.datafieldQuantity, Me.datafieldPrice, Me.datafieldAmount})
        Me.dgvSaleItems.Location = New System.Drawing.Point(12, 223)
        Me.dgvSaleItems.Name = "dgvSaleItems"
        Me.dgvSaleItems.RowHeadersVisible = False
        Me.dgvSaleItems.Size = New System.Drawing.Size(824, 317)
        Me.dgvSaleItems.TabIndex = 6
        '
        'datafieldProductCode
        '
        Me.datafieldProductCode.HeaderText = "Code"
        Me.datafieldProductCode.Name = "datafieldProductCode"
        '
        'datafieldProductName
        '
        Me.datafieldProductName.HeaderText = "Item"
        Me.datafieldProductName.Name = "datafieldProductName"
        '
        'datafieldQuantity
        '
        Me.datafieldQuantity.HeaderText = "Qty"
        Me.datafieldQuantity.Name = "datafieldQuantity"
        '
        'datafieldPrice
        '
        Me.datafieldPrice.HeaderText = "Unit Price"
        Me.datafieldPrice.Name = "datafieldPrice"
        '
        'datafieldAmount
        '
        Me.datafieldAmount.HeaderText = "Amount"
        Me.datafieldAmount.Name = "datafieldAmount"
        '
        'cboProductCode
        '
        Me.cboProductCode.FormattingEnabled = True
        Me.cboProductCode.Location = New System.Drawing.Point(12, 164)
        Me.cboProductCode.Name = "cboProductCode"
        Me.cboProductCode.Size = New System.Drawing.Size(121, 21)
        Me.cboProductCode.TabIndex = 7
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(12, 148)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(75, 13)
        Me.lblItem.TabIndex = 8
        Me.lblItem.Text = "Product Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Product Name:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(12, 124)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(262, 20)
        Me.txtProductName.TabIndex = 10
        '
        'btnProductSearch
        '
        Me.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProductSearch.Location = New System.Drawing.Point(280, 121)
        Me.btnProductSearch.Name = "btnProductSearch"
        Me.btnProductSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnProductSearch.TabIndex = 11
        Me.btnProductSearch.Text = "SEARCH"
        Me.btnProductSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProductSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProductSearch.UseVisualStyleBackColor = True
        '
        'lblProductQty
        '
        Me.lblProductQty.AutoSize = True
        Me.lblProductQty.Location = New System.Drawing.Point(140, 148)
        Me.lblProductQty.Name = "lblProductQty"
        Me.lblProductQty.Size = New System.Drawing.Size(46, 13)
        Me.lblProductQty.TabIndex = 12
        Me.lblProductQty.Text = "Quantity"
        '
        'txtProductQty
        '
        Me.txtProductQty.Location = New System.Drawing.Point(143, 164)
        Me.txtProductQty.Name = "txtProductQty"
        Me.txtProductQty.Size = New System.Drawing.Size(131, 20)
        Me.txtProductQty.TabIndex = 13
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(361, 162)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 14
        Me.btnPay.Text = "Pay (F4)"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(280, 162)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 15
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(361, 122)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearchCustomer.Location = New System.Drawing.Point(280, 47)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCustomer.TabIndex = 5
        Me.btnSearchCustomer.Text = "SEARCH"
        Me.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'cboCustomerSearch
        '
        Me.cboCustomerSearch.FormattingEnabled = True
        Me.cboCustomerSearch.Location = New System.Drawing.Point(12, 49)
        Me.cboCustomerSearch.Name = "cboCustomerSearch"
        Me.cboCustomerSearch.Size = New System.Drawing.Size(262, 21)
        Me.cboCustomerSearch.TabIndex = 2
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 565)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtProductQty)
        Me.Controls.Add(Me.lblProductQty)
        Me.Controls.Add(Me.btnProductSearch)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.cboProductCode)
        Me.Controls.Add(Me.dgvSaleItems)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.panAmounts)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.cboCustomerSearch)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.stbSalesStatus)
        Me.Name = "frmSales"
        Me.Text = "Sales"
        Me.stbSalesStatus.ResumeLayout(False)
        Me.stbSalesStatus.PerformLayout()
        Me.panAmounts.ResumeLayout(False)
        Me.panAmounts.PerformLayout()
        CType(Me.dgvSaleItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stbSalesStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents statCurrentEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents panAmounts As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblTaxAmount As System.Windows.Forms.Label
    Friend WithEvents lblSubAmount As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents dgvSaleItems As System.Windows.Forms.DataGridView
    Friend WithEvents cboProductCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents btnProductSearch As System.Windows.Forms.Button
    Friend WithEvents lblProductQty As System.Windows.Forms.Label
    Friend WithEvents txtProductQty As System.Windows.Forms.TextBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents datafieldProductCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datafieldAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboCustomerSearch As System.Windows.Forms.ComboBox
End Class
