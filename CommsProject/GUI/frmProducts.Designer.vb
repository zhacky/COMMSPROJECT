<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.gboProduct = New System.Windows.Forms.GroupBox()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.txtProductCost = New System.Windows.Forms.TextBox()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.txtProductBrand = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gboProductDetails = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cboProductStatus = New System.Windows.Forms.ComboBox()
        Me.gboProduct.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboProductDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboProduct
        '
        Me.gboProduct.Controls.Add(Me.cboProductStatus)
        Me.gboProduct.Controls.Add(Me.txtSellingPrice)
        Me.gboProduct.Controls.Add(Me.txtProductCost)
        Me.gboProduct.Controls.Add(Me.txtStocks)
        Me.gboProduct.Controls.Add(Me.txtProductBrand)
        Me.gboProduct.Controls.Add(Me.txtProductName)
        Me.gboProduct.Controls.Add(Me.txtProductId)
        Me.gboProduct.Controls.Add(Me.Label7)
        Me.gboProduct.Controls.Add(Me.Label6)
        Me.gboProduct.Controls.Add(Me.Label5)
        Me.gboProduct.Controls.Add(Me.Label4)
        Me.gboProduct.Controls.Add(Me.Label3)
        Me.gboProduct.Controls.Add(Me.Label2)
        Me.gboProduct.Controls.Add(Me.lblProductID)
        Me.gboProduct.Controls.Add(Me.dgvProducts)
        Me.gboProduct.Controls.Add(Me.btnSearch)
        Me.gboProduct.Controls.Add(Me.btnUpdate)
        Me.gboProduct.Controls.Add(Me.btnDelete)
        Me.gboProduct.Controls.Add(Me.btnAdd)
        Me.gboProduct.Controls.Add(Me.gboProductDetails)
        Me.gboProduct.Location = New System.Drawing.Point(12, 52)
        Me.gboProduct.Name = "gboProduct"
        Me.gboProduct.Size = New System.Drawing.Size(658, 410)
        Me.gboProduct.TabIndex = 5
        Me.gboProduct.TabStop = False
        Me.gboProduct.Text = "Product"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(102, 167)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtSellingPrice.TabIndex = 24
        '
        'txtProductCost
        '
        Me.txtProductCost.Location = New System.Drawing.Point(102, 144)
        Me.txtProductCost.Name = "txtProductCost"
        Me.txtProductCost.Size = New System.Drawing.Size(121, 20)
        Me.txtProductCost.TabIndex = 23
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(102, 121)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(121, 20)
        Me.txtStocks.TabIndex = 22
        '
        'txtProductBrand
        '
        Me.txtProductBrand.Location = New System.Drawing.Point(102, 98)
        Me.txtProductBrand.Name = "txtProductBrand"
        Me.txtProductBrand.Size = New System.Drawing.Size(121, 20)
        Me.txtProductBrand.TabIndex = 21
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(102, 75)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(121, 20)
        Me.txtProductName.TabIndex = 20
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(102, 52)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(121, 20)
        Me.txtProductId.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Selling Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Product Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stocks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Brand:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Product Name:"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(35, 55)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 11
        Me.lblProductID.Text = "Product_ID"
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(6, 287)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(640, 117)
        Me.dgvProducts.TabIndex = 10
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(497, 242)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(360, 242)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(223, 243)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(86, 242)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gboProductDetails
        '
        Me.gboProductDetails.Controls.Add(Me.txtDescription)
        Me.gboProductDetails.Controls.Add(Me.lblDescription)
        Me.gboProductDetails.Location = New System.Drawing.Point(365, 19)
        Me.gboProductDetails.Name = "gboProductDetails"
        Me.gboProductDetails.Size = New System.Drawing.Size(287, 113)
        Me.gboProductDetails.TabIndex = 5
        Me.gboProductDetails.TabStop = False
        Me.gboProductDetails.Text = "Product Details"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(76, 36)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(201, 20)
        Me.txtDescription.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(7, 39)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Description:"
        '
        'cboProductStatus
        '
        Me.cboProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductStatus.FormattingEnabled = True
        Me.cboProductStatus.Location = New System.Drawing.Point(102, 190)
        Me.cboProductStatus.Name = "cboProductStatus"
        Me.cboProductStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboProductStatus.TabIndex = 25
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 474)
        Me.Controls.Add(Me.gboProduct)
        Me.Name = "frmProducts"
        Me.Text = "Product"
        Me.gboProduct.ResumeLayout(False)
        Me.gboProduct.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboProductDetails.ResumeLayout(False)
        Me.gboProductDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboProduct As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gboProductDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCost As System.Windows.Forms.TextBox
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
    Friend WithEvents txtProductBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents cboProductStatus As System.Windows.Forms.ComboBox
End Class
