<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCardInputForm
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
        Me.txtCCHolder = New System.Windows.Forms.MaskedTextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.drpExpiryMonth = New System.Windows.Forms.ComboBox()
        Me.drpExpiryYear = New System.Windows.Forms.ComboBox()
        Me.mtbCCNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtWarning = New System.Windows.Forms.TextBox()
        Me.lblCreditCardType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCCHolder
        '
        Me.txtCCHolder.Location = New System.Drawing.Point(123, 40)
        Me.txtCCHolder.Name = "txtCCHolder"
        Me.txtCCHolder.Size = New System.Drawing.Size(112, 20)
        Me.txtCCHolder.TabIndex = 0
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAccept.Enabled = False
        Me.btnAccept.Location = New System.Drawing.Point(52, 240)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(176, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Credit Card Holder:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Credit Card Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Expiration Month:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Expiration Year:"
        '
        'drpExpiryMonth
        '
        Me.drpExpiryMonth.FormattingEnabled = True
        Me.drpExpiryMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.drpExpiryMonth.Location = New System.Drawing.Point(123, 116)
        Me.drpExpiryMonth.Name = "drpExpiryMonth"
        Me.drpExpiryMonth.Size = New System.Drawing.Size(49, 21)
        Me.drpExpiryMonth.TabIndex = 3
        Me.drpExpiryMonth.Text = "2"
        '
        'drpExpiryYear
        '
        Me.drpExpiryYear.FormattingEnabled = True
        Me.drpExpiryYear.Items.AddRange(New Object() {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.drpExpiryYear.Location = New System.Drawing.Point(123, 154)
        Me.drpExpiryYear.Name = "drpExpiryYear"
        Me.drpExpiryYear.Size = New System.Drawing.Size(49, 21)
        Me.drpExpiryYear.TabIndex = 4
        Me.drpExpiryYear.Text = "2012"
        '
        'mtbCCNumber
        '
        Me.mtbCCNumber.Location = New System.Drawing.Point(123, 78)
        Me.mtbCCNumber.Mask = "0000-0000-0000-0000"
        Me.mtbCCNumber.Name = "mtbCCNumber"
        Me.mtbCCNumber.Size = New System.Drawing.Size(112, 20)
        Me.mtbCCNumber.TabIndex = 2
        '
        'txtWarning
        '
        Me.txtWarning.Enabled = False
        Me.txtWarning.ForeColor = System.Drawing.Color.Red
        Me.txtWarning.Location = New System.Drawing.Point(52, 182)
        Me.txtWarning.Multiline = True
        Me.txtWarning.Name = "txtWarning"
        Me.txtWarning.Size = New System.Drawing.Size(199, 47)
        Me.txtWarning.TabIndex = 12
        '
        'lblCreditCardType
        '
        Me.lblCreditCardType.AutoSize = True
        Me.lblCreditCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardType.Location = New System.Drawing.Point(0, 9)
        Me.lblCreditCardType.MinimumSize = New System.Drawing.Size(280, 0)
        Me.lblCreditCardType.Name = "lblCreditCardType"
        Me.lblCreditCardType.Size = New System.Drawing.Size(280, 24)
        Me.lblCreditCardType.TabIndex = 13
        Me.lblCreditCardType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreditCardInputForm
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(291, 275)
        Me.Controls.Add(Me.lblCreditCardType)
        Me.Controls.Add(Me.txtWarning)
        Me.Controls.Add(Me.mtbCCNumber)
        Me.Controls.Add(Me.drpExpiryYear)
        Me.Controls.Add(Me.drpExpiryMonth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtCCHolder)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditCardInputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter CC Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCCHolder As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents drpExpiryMonth As System.Windows.Forms.ComboBox
    Friend WithEvents drpExpiryYear As System.Windows.Forms.ComboBox
    Friend WithEvents mtbCCNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtWarning As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditCardType As System.Windows.Forms.Label
End Class
