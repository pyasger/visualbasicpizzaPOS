<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizza))
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.MTxtZipCo = New System.Windows.Forms.MaskedTextBox()
        Me.CboCustSta = New System.Windows.Forms.ComboBox()
        Me.lblCustZip = New System.Windows.Forms.Label()
        Me.lblCustSta = New System.Windows.Forms.Label()
        Me.LblCustCit = New System.Windows.Forms.Label()
        Me.lblCustAds2 = New System.Windows.Forms.Label()
        Me.lblCustAds1 = New System.Windows.Forms.Label()
        Me.txtCustCty = New System.Windows.Forms.TextBox()
        Me.txtCustAdd2 = New System.Windows.Forms.TextBox()
        Me.txtCustAdd1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCusNam = New System.Windows.Forms.TextBox()
        Me.MsktxtPhnNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.grpOrdInfo = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.grpTop100 = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkGreenOlives = New System.Windows.Forms.CheckBox()
        Me.chkBlackOlives = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkPinapple = New System.Windows.Forms.CheckBox()
        Me.chkHamburger = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblQuanity = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.grpPricing = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picTeddy = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpCustomerInfo.SuspendLayout()
        Me.grpAction.SuspendLayout()
        Me.grpOrdInfo.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.grpTop100.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.grpPricing.SuspendLayout()
        CType(Me.picTeddy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpCustomerInfo.Controls.Add(Me.MTxtZipCo)
        Me.grpCustomerInfo.Controls.Add(Me.CboCustSta)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustZip)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustSta)
        Me.grpCustomerInfo.Controls.Add(Me.LblCustCit)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustAds2)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustAds1)
        Me.grpCustomerInfo.Controls.Add(Me.txtCustCty)
        Me.grpCustomerInfo.Controls.Add(Me.txtCustAdd2)
        Me.grpCustomerInfo.Controls.Add(Me.txtCustAdd1)
        Me.grpCustomerInfo.Controls.Add(Me.Label2)
        Me.grpCustomerInfo.Controls.Add(Me.Label1)
        Me.grpCustomerInfo.Controls.Add(Me.txtCusNam)
        Me.grpCustomerInfo.Controls.Add(Me.MsktxtPhnNum)
        Me.grpCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpCustomerInfo.Location = New System.Drawing.Point(3, 85)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Size = New System.Drawing.Size(270, 354)
        Me.grpCustomerInfo.TabIndex = 0
        Me.grpCustomerInfo.TabStop = False
        Me.grpCustomerInfo.Text = "customer info"
        '
        'MTxtZipCo
        '
        Me.MTxtZipCo.Location = New System.Drawing.Point(143, 268)
        Me.MTxtZipCo.Mask = "00000-9999"
        Me.MTxtZipCo.Name = "MTxtZipCo"
        Me.MTxtZipCo.Size = New System.Drawing.Size(63, 20)
        Me.MTxtZipCo.TabIndex = 0
        '
        'CboCustSta
        '
        Me.CboCustSta.FormattingEnabled = True
        Me.CboCustSta.Location = New System.Drawing.Point(143, 232)
        Me.CboCustSta.Name = "CboCustSta"
        Me.CboCustSta.Size = New System.Drawing.Size(39, 21)
        Me.CboCustSta.TabIndex = 12
        '
        'lblCustZip
        '
        Me.lblCustZip.AutoSize = True
        Me.lblCustZip.ForeColor = System.Drawing.Color.White
        Me.lblCustZip.Location = New System.Drawing.Point(21, 268)
        Me.lblCustZip.Name = "lblCustZip"
        Me.lblCustZip.Size = New System.Drawing.Size(100, 13)
        Me.lblCustZip.TabIndex = 13
        Me.lblCustZip.Text = "Customer Zip Code "
        '
        'lblCustSta
        '
        Me.lblCustSta.AutoSize = True
        Me.lblCustSta.ForeColor = System.Drawing.Color.White
        Me.lblCustSta.Location = New System.Drawing.Point(18, 232)
        Me.lblCustSta.Name = "lblCustSta"
        Me.lblCustSta.Size = New System.Drawing.Size(82, 13)
        Me.lblCustSta.TabIndex = 11
        Me.lblCustSta.Text = "Customer State "
        '
        'LblCustCit
        '
        Me.LblCustCit.AutoSize = True
        Me.LblCustCit.ForeColor = System.Drawing.Color.White
        Me.LblCustCit.Location = New System.Drawing.Point(15, 195)
        Me.LblCustCit.Name = "LblCustCit"
        Me.LblCustCit.Size = New System.Drawing.Size(74, 13)
        Me.LblCustCit.TabIndex = 9
        Me.LblCustCit.Text = "Customer City "
        '
        'lblCustAds2
        '
        Me.lblCustAds2.AutoSize = True
        Me.lblCustAds2.ForeColor = System.Drawing.Color.White
        Me.lblCustAds2.Location = New System.Drawing.Point(15, 155)
        Me.lblCustAds2.Name = "lblCustAds2"
        Me.lblCustAds2.Size = New System.Drawing.Size(101, 13)
        Me.lblCustAds2.TabIndex = 7
        Me.lblCustAds2.Text = "Customer Address2 "
        '
        'lblCustAds1
        '
        Me.lblCustAds1.AutoSize = True
        Me.lblCustAds1.ForeColor = System.Drawing.Color.White
        Me.lblCustAds1.Location = New System.Drawing.Point(15, 117)
        Me.lblCustAds1.Name = "lblCustAds1"
        Me.lblCustAds1.Size = New System.Drawing.Size(101, 13)
        Me.lblCustAds1.TabIndex = 5
        Me.lblCustAds1.Text = "Customer Address1 "
        '
        'txtCustCty
        '
        Me.txtCustCty.Location = New System.Drawing.Point(143, 195)
        Me.txtCustCty.Name = "txtCustCty"
        Me.txtCustCty.Size = New System.Drawing.Size(100, 20)
        Me.txtCustCty.TabIndex = 10
        '
        'txtCustAdd2
        '
        Me.txtCustAdd2.Location = New System.Drawing.Point(143, 155)
        Me.txtCustAdd2.Name = "txtCustAdd2"
        Me.txtCustAdd2.Size = New System.Drawing.Size(100, 20)
        Me.txtCustAdd2.TabIndex = 8
        '
        'txtCustAdd1
        '
        Me.txtCustAdd1.Location = New System.Drawing.Point(143, 117)
        Me.txtCustAdd1.Name = "txtCustAdd1"
        Me.txtCustAdd1.Size = New System.Drawing.Size(100, 20)
        Me.txtCustAdd1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Name "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Phone Number "
        '
        'txtCusNam
        '
        Me.txtCusNam.Location = New System.Drawing.Point(143, 82)
        Me.txtCusNam.Name = "txtCusNam"
        Me.txtCusNam.Size = New System.Drawing.Size(100, 20)
        Me.txtCusNam.TabIndex = 4
        '
        'MsktxtPhnNum
        '
        Me.MsktxtPhnNum.Location = New System.Drawing.Point(143, 35)
        Me.MsktxtPhnNum.Mask = "(999) 000-0000"
        Me.MsktxtPhnNum.Name = "MsktxtPhnNum"
        Me.MsktxtPhnNum.Size = New System.Drawing.Size(79, 20)
        Me.MsktxtPhnNum.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(235, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "The pizza place"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(667, 3)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(26, 13)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "time"
        '
        'grpAction
        '
        Me.grpAction.BackColor = System.Drawing.Color.Transparent
        Me.grpAction.Controls.Add(Me.btnClose)
        Me.grpAction.Controls.Add(Me.btnReset)
        Me.grpAction.Controls.Add(Me.btnAccept)
        Me.grpAction.Controls.Add(Me.btnPrice)
        Me.grpAction.ForeColor = System.Drawing.Color.Black
        Me.grpAction.Location = New System.Drawing.Point(112, 467)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(432, 60)
        Me.grpAction.TabIndex = 5
        Me.grpAction.TabStop = False
        Me.grpAction.Text = "actions"
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(328, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "E&xit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(229, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(130, 19)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 1
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(31, 19)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnPrice.TabIndex = 0
        Me.btnPrice.Text = "&Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'grpOrdInfo
        '
        Me.grpOrdInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpOrdInfo.Controls.Add(Me.Label11)
        Me.grpOrdInfo.Controls.Add(Me.grpSize)
        Me.grpOrdInfo.Controls.Add(Me.grpTop100)
        Me.grpOrdInfo.Controls.Add(Me.NumericUpDown1)
        Me.grpOrdInfo.Controls.Add(Me.lblOrderNumber)
        Me.grpOrdInfo.Controls.Add(Me.lblQuanity)
        Me.grpOrdInfo.Location = New System.Drawing.Point(301, 95)
        Me.grpOrdInfo.Name = "grpOrdInfo"
        Me.grpOrdInfo.Size = New System.Drawing.Size(179, 335)
        Me.grpOrdInfo.TabIndex = 20
        Me.grpOrdInfo.TabStop = False
        Me.grpOrdInfo.Text = "Order Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(122, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "(Max 10)"
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radMedium)
        Me.grpSize.Location = New System.Drawing.Point(24, 33)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(114, 68)
        Me.grpSize.TabIndex = 13
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "size"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(6, 15)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(84, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "small ($8.00)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 45)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(90, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "large ($12.00)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 30)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(103, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "medium ($10.00)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'grpTop100
        '
        Me.grpTop100.BackColor = System.Drawing.Color.Transparent
        Me.grpTop100.Controls.Add(Me.chkCheese)
        Me.grpTop100.Controls.Add(Me.chkSausage)
        Me.grpTop100.Controls.Add(Me.chkPepperoni)
        Me.grpTop100.Controls.Add(Me.chkGreenOlives)
        Me.grpTop100.Controls.Add(Me.chkBlackOlives)
        Me.grpTop100.Controls.Add(Me.chkHam)
        Me.grpTop100.Controls.Add(Me.chkMushrooms)
        Me.grpTop100.Controls.Add(Me.chkPinapple)
        Me.grpTop100.Controls.Add(Me.chkHamburger)
        Me.grpTop100.Controls.Add(Me.chkOnions)
        Me.grpTop100.Location = New System.Drawing.Point(24, 107)
        Me.grpTop100.Name = "grpTop100"
        Me.grpTop100.Size = New System.Drawing.Size(115, 196)
        Me.grpTop100.TabIndex = 0
        Me.grpTop100.TabStop = False
        Me.grpTop100.Text = "Toppings ($1.00)"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(6, 19)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(61, 17)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(6, 37)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(66, 17)
        Me.chkSausage.TabIndex = 2
        Me.chkSausage.Text = "sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(6, 57)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(73, 17)
        Me.chkPepperoni.TabIndex = 3
        Me.chkPepperoni.Text = "pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkGreenOlives
        '
        Me.chkGreenOlives.AutoSize = True
        Me.chkGreenOlives.Location = New System.Drawing.Point(6, 76)
        Me.chkGreenOlives.Name = "chkGreenOlives"
        Me.chkGreenOlives.Size = New System.Drawing.Size(83, 17)
        Me.chkGreenOlives.TabIndex = 4
        Me.chkGreenOlives.Text = "green olives"
        Me.chkGreenOlives.UseVisualStyleBackColor = True
        '
        'chkBlackOlives
        '
        Me.chkBlackOlives.AutoSize = True
        Me.chkBlackOlives.Location = New System.Drawing.Point(6, 95)
        Me.chkBlackOlives.Name = "chkBlackOlives"
        Me.chkBlackOlives.Size = New System.Drawing.Size(82, 17)
        Me.chkBlackOlives.TabIndex = 5
        Me.chkBlackOlives.Text = "black olives"
        Me.chkBlackOlives.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(6, 110)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(46, 17)
        Me.chkHam.TabIndex = 6
        Me.chkHam.Text = "ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(6, 171)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(79, 17)
        Me.chkMushrooms.TabIndex = 10
        Me.chkMushrooms.Text = "mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkPinapple
        '
        Me.chkPinapple.AutoSize = True
        Me.chkPinapple.Location = New System.Drawing.Point(6, 126)
        Me.chkPinapple.Name = "chkPinapple"
        Me.chkPinapple.Size = New System.Drawing.Size(66, 17)
        Me.chkPinapple.TabIndex = 7
        Me.chkPinapple.Text = "pinapple"
        Me.chkPinapple.UseVisualStyleBackColor = True
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(6, 156)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(76, 17)
        Me.chkHamburger.TabIndex = 9
        Me.chkHamburger.Text = "hamburger"
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(6, 141)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(57, 17)
        Me.chkOnions.TabIndex = 8
        Me.chkOnions.Text = "onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(82, 309)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(31, 20)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(50, 16)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(69, 13)
        Me.lblOrderNumber.TabIndex = 6
        Me.lblOrderNumber.Text = "order number"
        '
        'lblQuanity
        '
        Me.lblQuanity.AutoSize = True
        Me.lblQuanity.Location = New System.Drawing.Point(27, 315)
        Me.lblQuanity.Name = "lblQuanity"
        Me.lblQuanity.Size = New System.Drawing.Size(44, 13)
        Me.lblQuanity.TabIndex = 1
        Me.lblQuanity.Text = "quanity:"
        '
        'grpPayment
        '
        Me.grpPayment.BackColor = System.Drawing.Color.Transparent
        Me.grpPayment.Controls.Add(Me.cboPayment)
        Me.grpPayment.Location = New System.Drawing.Point(486, 232)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(165, 67)
        Me.grpPayment.TabIndex = 21
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "payment"
        '
        'cboPayment
        '
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Items.AddRange(New Object() {"visa", "mastercars", "american express"})
        Me.cboPayment.Location = New System.Drawing.Point(28, 28)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(121, 21)
        Me.cboPayment.TabIndex = 0
        '
        'grpPricing
        '
        Me.grpPricing.BackColor = System.Drawing.Color.Transparent
        Me.grpPricing.Controls.Add(Me.Label10)
        Me.grpPricing.Controls.Add(Me.Label9)
        Me.grpPricing.Controls.Add(Me.Label4)
        Me.grpPricing.Controls.Add(Me.Label8)
        Me.grpPricing.Controls.Add(Me.Label7)
        Me.grpPricing.Controls.Add(Me.Label6)
        Me.grpPricing.Controls.Add(Me.Label5)
        Me.grpPricing.Location = New System.Drawing.Point(501, 328)
        Me.grpPricing.Name = "grpPricing"
        Me.grpPricing.Size = New System.Drawing.Size(150, 102)
        Me.grpPricing.TabIndex = 19
        Me.grpPricing.TabStop = False
        Me.grpPricing.Text = "pricing"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Label9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "______________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "subtotal"
        '
        'picTeddy
        '
        Me.picTeddy.BackColor = System.Drawing.Color.Transparent
        Me.picTeddy.Image = CType(resources.GetObject("picTeddy.Image"), System.Drawing.Image)
        Me.picTeddy.Location = New System.Drawing.Point(511, 103)
        Me.picTeddy.Name = "picTeddy"
        Me.picTeddy.Size = New System.Drawing.Size(124, 103)
        Me.picTeddy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeddy.TabIndex = 18
        Me.picTeddy.TabStop = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(27, 597)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "change color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPizza
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(884, 662)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpOrdInfo)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpPricing)
        Me.Controls.Add(Me.picTeddy)
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Name = "frmPizza"
        Me.Text = "pizza"
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.grpCustomerInfo.PerformLayout()
        Me.grpAction.ResumeLayout(False)
        Me.grpOrdInfo.ResumeLayout(False)
        Me.grpOrdInfo.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpTop100.ResumeLayout(False)
        Me.grpTop100.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPricing.ResumeLayout(False)
        Me.grpPricing.PerformLayout()
        CType(Me.picTeddy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents MTxtZipCo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CboCustSta As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustZip As System.Windows.Forms.Label
    Friend WithEvents lblCustSta As System.Windows.Forms.Label
    Friend WithEvents LblCustCit As System.Windows.Forms.Label
    Friend WithEvents lblCustAds2 As System.Windows.Forms.Label
    Friend WithEvents lblCustAds1 As System.Windows.Forms.Label
    Friend WithEvents txtCustCty As System.Windows.Forms.TextBox
    Friend WithEvents txtCustAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCustAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCusNam As System.Windows.Forms.TextBox
    Friend WithEvents MsktxtPhnNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents grpAction As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnPrice As System.Windows.Forms.Button
    Friend WithEvents grpOrdInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents grpTop100 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkSausage As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkGreenOlives As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlackOlives As System.Windows.Forms.CheckBox
    Friend WithEvents chkHam As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkPinapple As System.Windows.Forms.CheckBox
    Friend WithEvents chkHamburger As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents lblQuanity As System.Windows.Forms.Label
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents cboPayment As System.Windows.Forms.ComboBox
    Friend WithEvents grpPricing As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picTeddy As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
