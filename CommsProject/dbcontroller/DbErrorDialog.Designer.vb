<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBErrorDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OpenDbDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.lblErrorInfo = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.txtDbFile = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OpenDbDialog
        '
        Me.OpenDbDialog.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 127)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblErrorInfo
        '
        Me.lblErrorInfo.AutoSize = True
        Me.lblErrorInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblErrorInfo.Name = "lblErrorInfo"
        Me.lblErrorInfo.Size = New System.Drawing.Size(0, 24)
        Me.lblErrorInfo.TabIndex = 2
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 156)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.Location = New System.Drawing.Point(93, 132)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(0, 13)
        Me.lblDirectory.TabIndex = 4
        '
        'txtDbFile
        '
        Me.txtDbFile.Location = New System.Drawing.Point(99, 129)
        Me.txtDbFile.Name = "txtDbFile"
        Me.txtDbFile.Size = New System.Drawing.Size(324, 20)
        Me.txtDbFile.TabIndex = 5
        '
        'DBErrorDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.txtDbFile)
        Me.Controls.Add(Me.lblDirectory)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblErrorInfo)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DBErrorDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OpenDbDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents lblErrorInfo As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
    Friend WithEvents txtDbFile As System.Windows.Forms.TextBox

End Class
