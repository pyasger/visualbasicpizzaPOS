Imports System.IO
Imports System.Text
Imports AxWMPLib



Public Class pizza2
    Private Const c_smallPizzaCost As Decimal = 8.0
    Private Const c_mediumPizzaCost As Decimal = 10.0
    Private Const c_largePizzaCost As Decimal = 12.0
    Private Const c_consumptionTaxRate As Decimal = 0.07D

    Private Const c_cheeseCost As Decimal = 1.99
    Private Const c_sausageCost As Decimal = 3.99
    Private Const c_pepperoniCost As Decimal = 3.99
    Private Const c_greenOliveCost As Decimal = 1.99
    Private Const c_blackOliveCost As Decimal = 1.99
    Private Const c_hamCost As Decimal = 2.99
    Private Const c_pinneappleCost As Decimal = 2.99
    Private Const c_onionCost As Decimal = 1.99
    Private Const c_hamburgerCost As Decimal = 2.99
    Private Const c_mushroomCost As Decimal = 2.99

    Private _transactionLogPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pizza Transaction Log.txt")

    Private _isNameValid As Boolean = False
    Private _isPhoneNumberValid As Boolean = False
    Private _isAddress1Valid As Boolean = False
    Private _isCityValid As Boolean = False
    Private _isZipCodeValid As Boolean = False
    Private _isCreditCardDataValid = False
    Private _foundExistingCustomer = False
    Private _currentOrderNumber As Integer = 0
    Private _paymentLock As Boolean = False

    Private _customersTable As DataTable
    Private Const c_accessProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;" 'MS ACCESS db2007+
    Private _dataSource As String = "Data source=" + Application.StartupPath + "\..\..\pizza.accdb"
    Private _connectionString As String = c_accessProvider + _dataSource


#Region "Form Event Handlers"

    Private Sub frmPizza_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitializeForm()

        Me.AxWindowsMediaPlayer1.URL = Path.Combine(Application.StartupPath, "oceanfade.mp3")
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'slide 68 section 3
        Dim intResult As Integer
        intResult = MessageBox.Show("Do you wish to continue?", "Please Confirm", MessageBoxButtons.YesNo)
        If intResult = Windows.Forms.DialogResult.Yes Then
            ' Perform an action here
        ElseIf intResult = Windows.Forms.DialogResult.No Then
            Me.Close()
        End If
    End Sub

    Private Sub InitializeForm()
        _foundExistingCustomer = False
        LoadCustomers()
        _currentOrderNumber = GetLastOrderNumber() + 1
        Me.txtOrderNumber.Text = _currentOrderNumber.ToString()
        LoadStates()
        cboPayment.SelectedIndex = 0
        ClearToppingChecks()
    End Sub


#End Region


    Private Sub AxWindowsMediaPlayer1_MediaError(ByVal sender As Object, _
ByVal e As _WMPOCXEvents_MediaErrorEvent) Handles AxWindowsMediaPlayer1.MediaError
        Try
            ' If the file is corrupt or missing, show the 
            ' hexadecimal error code and URL.
            Dim errSource As WMPLib.IWMPMedia2 = e.pMediaObject
            Dim errorItem As WMPLib.IWMPErrorItem = errSource.Error
            MessageBox.Show("Media error " + errorItem.errorCode.ToString("X") _
                            + " in " + errSource.sourceURL)
        Catch ex As InvalidCastException
            ' In case pMediaObject is not an IWMPMedia item.
            MessageBox.Show("Player error.")
        End Try
    End Sub

    Private Sub LoadCustomers()
        Dim selectAllCustomersCmd As String = "SELECT * FROM tblCustomer"
        Using customerAdapter As New OleDb.OleDbDataAdapter(selectAllCustomersCmd, _connectionString)
            _customersTable = New DataTable()
            customerAdapter.Fill(_customersTable)
        End Using
    End Sub

    Private Function GetLastOrderNumber() As Integer
        System.Threading.Thread.Sleep(1000)
        Dim getHighestOrderNumberCmd As String = "SELECT TOP 1 fldOrderNum FROM tblOrders ORDER BY fldOrderNum DESC"
        Dim highestOrderNumber As Integer = 0
        Using orderCommand As New OleDb.OleDbCommand(getHighestOrderNumberCmd, New OleDb.OleDbConnection(_connectionString))
            orderCommand.Connection.Open()
            highestOrderNumber = orderCommand.ExecuteScalar()
            orderCommand.Connection.Close()
        End Using
        Return highestOrderNumber
    End Function

    Private Sub CalculatePrice()

        Dim basePizzaCost As Decimal = 0D
        If (radSmall.Checked) Then
            basePizzaCost = c_smallPizzaCost
        ElseIf radMedium.Checked Then
            basePizzaCost = c_mediumPizzaCost
        ElseIf radLarge.Checked Then
            basePizzaCost = c_largePizzaCost
        End If


        Dim toppingCost As Decimal = 0D
        If chkBlackOlives.Checked Then
            toppingCost += c_blackOliveCost
        End If

        If chkCheese.Checked Then
            toppingCost += c_cheeseCost
        End If

        If chkGreenOlives.Checked Then
            toppingCost += c_greenOliveCost
        End If

        If chkHam.Checked Then
            toppingCost += c_hamCost
        End If

        If chkHamburger.Checked Then
            toppingCost += c_hamburgerCost
        End If

        If chkMushrooms.Checked Then
            toppingCost += c_mushroomCost
        End If

        If chkOnions.Checked Then
            toppingCost += c_onionCost
        End If

        If chkPepperoni.Checked Then
            toppingCost += c_pepperoniCost
        End If

        If chkPinapple.Checked Then
            toppingCost += c_pinneappleCost
        End If

        If chkSausage.Checked Then
            toppingCost += c_sausageCost
        End If


        Dim singlePizzaCost As Decimal = basePizzaCost + toppingCost


        Dim pizzaQty As Integer = Convert.ToInt32(NuUpDown1.Value)
        Dim totalOrderCost As Decimal = singlePizzaCost * pizzaQty
        Dim tax As Decimal = totalOrderCost * c_consumptionTaxRate

        lblSubPri.Text = String.Format("{0:C}", totalOrderCost)
        lblTaxPri.Text = String.Format("{0:C}", tax)
        lblTotPri.Text = String.Format("{0:C}", totalOrderCost + tax)

    End Sub

    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click

        SaveOrder()

        SaveCustomer()

        CalculatePrice()

        WriteOutOrder()

        ResetForm(Nothing, Nothing)

        InitializeForm()

        LoadCustomers()

    End Sub

    Private Sub SaveOrder()


        Dim insertCommand As New OleDb.OleDbCommand("INSERT INTO tblOrders (fldPhone, fldOrderNum, fldOrderDate, fldOrderSize, " & _
                                                    "fldOrderQty, fldTop1, fldTop2, fldTop3, fldTop4, fldTop5, fldTop6, fldTop7, fldTop8, fldTop9, fldTop10 ) " & _
                                                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                                                    New OleDb.OleDbConnection(_connectionString))
        insertCommand.Connection.Open()
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldPhone", mtbPhnNum.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldOrderNum", _currentOrderNumber))
        Dim dateParameter As New OleDb.OleDbParameter("fldOrderDate", System.Data.OleDb.OleDbType.Date, 22)
        dateParameter.Value = System.DateTime.Now
        insertCommand.Parameters.Add(dateParameter)
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldOrderSize", GetPizzaSize))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldOrderQty", System.Convert.ToInt32(Me.NuUpDown1.Value)))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop1", Me.chkBlackOlives.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop2", Me.chkCheese.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop3", Me.chkGreenOlives.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop4", Me.chkHam.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop5", Me.chkHamburger.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop6", Me.chkMushrooms.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop7", Me.chkOnions.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop8", Me.chkPepperoni.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop9", Me.chkPinapple.Checked))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldTop10", Me.chkSausage.Checked))

        insertCommand.ExecuteNonQuery()
        insertCommand.Connection.Close()
        insertCommand.Dispose()

    End Sub

    Private Sub SaveCustomer()

        Dim customerExistsCmd As String = "SELECT fldCustName FROM tblCustomer WHERE fldPhone = ?"
        Dim doesCustomerExist As Boolean = False
        Using customerCommand As New OleDb.OleDbCommand(customerExistsCmd, New OleDb.OleDbConnection(_connectionString))
            customerCommand.Parameters.Add(New OleDb.OleDbParameter("fldPhone", mtbPhnNum.Text))
            customerCommand.Connection.Open()
            If customerCommand.ExecuteScalar() <> Nothing Then
                doesCustomerExist = True
            Else
                doesCustomerExist = False
            End If
            customerCommand.Connection.Close()
        End Using

        If doesCustomerExist Then
            UpdateCustomer()
        Else
            InsertCustomer()
        End If
    End Sub

    Private Function GetPizzaSize() As String
        If radSmall.Checked Then
            Return "Small"
        ElseIf radMedium.Checked Then
            Return "Medium"
        ElseIf radLarge.Checked Then
            Return "Large"
        End If
    End Function

    Private Sub InsertCustomer()
        Dim insertCommand As New OleDb.OleDbCommand("INSERT INTO tblCustomer (fldPhone, fldCustName, fldCustAddr1, fldCustAddr2, " & _
                                   "fldCustCity, fldCustState, fldCustZip) " & _
                                   "VALUES (?, ?, ?, ?, ?, ?, ?)",
                                   New OleDb.OleDbConnection(_connectionString))
        insertCommand.Connection.Open()
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldPhone", mtbPhnNum.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustName", txtCusNam.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustAddr1", txtCustAdd1.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustAddr2", txtCustAdd2.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustCity", txtCustCty.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustState", cboCustSta.Text))
        insertCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustZip", mtbZipCo.Text))


        insertCommand.ExecuteNonQuery()
        insertCommand.Connection.Close()
        insertCommand.Dispose()
    End Sub

    Private Sub UpdateCustomer()
        'then UPDATE
        Dim updateCommand As New OleDb.OleDbCommand("UPDATE tblCustomer SET fldPhone = ?, fldCustName = ?, fldCustAddr1 = ?, fldCustAddr2 = ?, fldCustCity = ?, fldCustState = ?, fldCustZip = ? " & _
                                                    "WHERE fldPhone = ?", New OleDb.OleDbConnection(_connectionString))
        updateCommand.Connection.Open()
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldPhone", mtbPhnNum.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustName", txtCusNam.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustAddr1", txtCustAdd1.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustAddr2", txtCustAdd2.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustCity", txtCustCty.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustState", cboCustSta.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldCustZip", mtbZipCo.Text))
        updateCommand.Parameters.Add(New OleDb.OleDbParameter("fldPhone", mtbPhnNum.Text))

        updateCommand.ExecuteNonQuery()
        updateCommand.Connection.Close()
        updateCommand.Dispose()
    End Sub

    Private Sub WriteOutOrder()

        _currentOrderNumber += 1
        Dim orderText As New StringBuilder()
        orderText.Append("Order Number: " & _currentOrderNumber.ToString())
        orderText.AppendLine()
        orderText.Append("Name: " & txtCusNam.Text)
        orderText.AppendLine()
        orderText.Append("Address1: " & txtCustAdd1.Text)
        orderText.AppendLine()
        orderText.Append("Address2: " & txtCustAdd2.Text)
        orderText.AppendLine()
        orderText.Append("City: " & txtCustCty.Text)
        orderText.AppendLine()
        orderText.Append("State: " & cboCustSta.SelectedText)
        orderText.AppendLine()
        orderText.Append("Zip: " & mtbZipCo.Text)
        orderText.AppendLine()

        If radSmall.Checked Then
            orderText.Append("Pizza Size: small")
            orderText.AppendLine()
        ElseIf radMedium.Checked Then
            orderText.Append("Pizza Size: medium")
            orderText.AppendLine()
        ElseIf radLarge.Checked Then
            orderText.Append("Pizza Size: large")
            orderText.AppendLine()
        End If

        If chkBlackOlives.Checked Then
            orderText.Append("Black Olives")
            orderText.AppendLine()
        End If
        If chkCheese.Checked Then
            orderText.Append("Cheese")
            orderText.AppendLine()
        End If
        If chkGreenOlives.Checked Then
            orderText.Append("Green Olives")
            orderText.AppendLine()
        End If
        If chkHam.Checked Then
            orderText.Append("Ham")
            orderText.AppendLine()
        End If
        If chkHamburger.Checked Then
            orderText.Append("Hamburger")
            orderText.AppendLine()
        End If
        If chkMushrooms.Checked Then
            orderText.Append("Mushrooms")
            orderText.AppendLine()
        End If
        If chkOnions.Checked Then
            orderText.Append("Onions")
            orderText.AppendLine()
        End If
        If chkPepperoni.Checked Then
            orderText.Append("Pepperoni")
            orderText.AppendLine()
        End If
        If chkPinapple.Checked Then
            orderText.Append("Pinapple")
            orderText.AppendLine()
        End If
        If chkSausage.Checked Then
            orderText.Append("Sausage")
            orderText.AppendLine()
        End If

        orderText.Append("Qty: " & NuUpDown1.Value.ToString())
        orderText.AppendLine()
        orderText.Append("Total Price: " & lblTotPri.Text)

        orderText.AppendLine()
        orderText.AppendLine()
        orderText.AppendLine()


        Dim orderStream As New StreamWriter(_transactionLogPath, True, Encoding.ASCII)
        orderStream.Write(orderText.ToString())
        orderStream.Close()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now

    End Sub

    Private Sub ResetForm(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

        mtbPhnNum.Clear()
        txtCusNam.Clear()
        txtCustAdd1.Clear()
        txtCustAdd2.Clear()
        txtCustCty.Clear()
        mtbZipCo.Clear()

    End Sub

    Private Sub LoadStates()
        Dim stateListReader As StreamReader
        stateListReader = File.OpenText(Application.StartupPath + "\..\..\stateAbbrev.txt")
        While Not stateListReader.EndOfStream
            cboCustSta.Items.Add(stateListReader.ReadLine())
        End While
        cboCustSta.SelectedItem = "MN"
    End Sub

    Private Sub CheckValidInput()
        Dim isPaymentValid As Boolean = False
        If Me.cboPayment.SelectedItem = "Cash" Or cboPayment.SelectedItem = "Check" Then
            isPaymentValid = True
        Else
            If _isCreditCardDataValid Then
                isPaymentValid = True
            Else
                isPaymentValid = False
            End If
        End If


        If _isAddress1Valid And
            _isCityValid And
            _isNameValid And
            _isPhoneNumberValid And
            isPaymentValid And
            _isZipCodeValid Then
            btnAccept.Enabled = True
        Else
            btnAccept.Enabled = False
        End If
    End Sub

#Region " Address Validation Event Handlers "
    Private Sub mtbPhnNum_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbPhnNum.LostFocus

        If mtbPhnNum.Text.Length > 0 Then
            _isPhoneNumberValid = True
        Else
            _isPhoneNumberValid = False
        End If
        CheckValidInput()
    End Sub

    Private Sub txtCusNam_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCusNam.KeyPress, txtCustCty.KeyPress
        'Allows a-z, A-Z, or backspace
        Select Case e.KeyChar
            Case CChar("a") To CChar("z")
            Case CChar("A") To CChar("Z")
            Case CChar(Microsoft.VisualBasic.vbBack)
            Case CChar(" ")
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtCusNam_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCusNam.LostFocus
        If Not String.IsNullOrEmpty(txtCusNam.Text) Then
            _isNameValid = True
        Else
            _isNameValid = False
        End If
        CheckValidInput()
    End Sub

    Private Sub txtCustAdd1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustAdd1.LostFocus
        If Not String.IsNullOrEmpty(txtCustAdd1.Text) Then
            _isAddress1Valid = True
        Else
            _isAddress1Valid = False
        End If
        CheckValidInput()
    End Sub

    Private Sub txtCustCty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustCty.LostFocus
        If Not String.IsNullOrEmpty(txtCustCty.Text) Then
            _isCityValid = True
        Else
            _isCityValid = False
        End If
        CheckValidInput()
    End Sub

    Private Sub mtbZipCo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbZipCo.LostFocus
        If Not String.IsNullOrEmpty(mtbZipCo.Text) Then
            _isZipCodeValid = True
        Else
            _isZipCodeValid = False
        End If
        CheckValidInput()
    End Sub
#End Region

#Region " Price Calculation Event Handlers "
    Private Sub chkCheese_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheese.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkSausage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSausage.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkPepperoni_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPepperoni.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkGreenOlives_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGreenOlives.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkBlackOlives_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBlackOlives.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkHam_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHam.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkPinapple_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPinapple.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkOnions_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOnions.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkHamburger_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHamburger.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub chkMushrooms_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMushrooms.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radSmall_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSmall.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radMedium_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radMedium.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub radLarge_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLarge.CheckedChanged
        CalculatePrice()
    End Sub

    Private Sub NuUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NuUpDown1.ValueChanged
        CalculatePrice()
    End Sub
#End Region

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        'slide 68 section 3
        Dim intResult As Integer
        intResult = MessageBox.Show("Do you wish to continue?", "Please Confirm", MessageBoxButtons.YesNo)
        If intResult = Windows.Forms.DialogResult.Yes Then
            ' Perform an action here
        ElseIf intResult = Windows.Forms.DialogResult.No Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Searches the cached datCust object to see if there is a match
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCusNam_TextChanged(sender As System.Object, e As System.EventArgs) Handles mtbPhnNum.TextChanged
        If Not _foundExistingCustomer And Not _customersTable Is Nothing Then

            For intIdx = 0 To _customersTable.Rows.Count - 1
                If mtbPhnNum.Text = CStr(_customersTable.Rows(intIdx)("fldPhone")) Then
                    _foundExistingCustomer = True
                    txtCusNam.Text = _customersTable.Rows(intIdx)("fldCustName").ToString
                    txtCustAdd1.Text = _customersTable.Rows(intIdx)("fldCustAddr1").ToString
                    txtCustAdd2.Text = _customersTable.Rows(intIdx)("fldCustAddr2").ToString
                    txtCustCty.Text = _customersTable.Rows(intIdx)("fldCustCity").ToString
                    cboCustSta.Text = _customersTable.Rows(intIdx)("fldCustState").ToString
                    mtbZipCo.Text = _customersTable.Rows(intIdx)("fldCustZip").ToString

                    _isAddress1Valid = True
                    _isCityValid = True
                    _isNameValid = True
                    _isPhoneNumberValid = True
                    _isZipCodeValid = True
                    CheckValidInput()
                End If
            Next

            'if found, load last Order

            Using findLastOrderCmd As New OleDb.OleDbCommand("SELECT * FROM tblOrders WHERE fldPhone = ? ORDER BY fldOrderDate DESC", New OleDb.OleDbConnection(_connectionString))
                findLastOrderCmd.Connection.Open()
                findLastOrderCmd.Parameters.Add(New OleDb.OleDbParameter("fldPhone", mtbPhnNum.Text))
                Dim matchingOrdersReader As OleDb.OleDbDataReader = findLastOrderCmd.ExecuteReader()
                matchingOrdersReader.Read() 'grab the first record
                If matchingOrdersReader.HasRows Then


                    Dim lastPizzaSize As String = matchingOrdersReader.GetString(3)
                    If lastPizzaSize = "Small" Then
                        radSmall.Checked = True
                    ElseIf lastPizzaSize = "Medium" Then
                        radMedium.Checked = True
                    ElseIf lastPizzaSize = "Large" Then
                        radLarge.Checked = True
                    Else
                        Throw New InvalidOperationException("Unknown pizza size")
                    End If

                    Me.NuUpDown1.Value = System.Convert.ToDecimal(matchingOrdersReader.GetDouble(4))
                    Me.chkBlackOlives.Checked = matchingOrdersReader.GetBoolean(5)
                    Me.chkCheese.Checked = matchingOrdersReader.GetBoolean(6)
                    Me.chkGreenOlives.Checked = matchingOrdersReader.GetBoolean(7)
                    Me.chkHam.Checked = matchingOrdersReader.GetBoolean(8)
                    Me.chkHamburger.Checked = matchingOrdersReader.GetBoolean(9)
                    Me.chkMushrooms.Checked = matchingOrdersReader.GetBoolean(10)
                    Me.chkOnions.Checked = matchingOrdersReader.GetBoolean(11)
                    Me.chkPepperoni.Checked = matchingOrdersReader.GetBoolean(12)
                    Me.chkPinapple.Checked = matchingOrdersReader.GetBoolean(13)
                    Me.chkSausage.Checked = matchingOrdersReader.GetBoolean(14)

                End If
                '  findLastOrderCmd.Connection.Close()
            End Using
        End If
    End Sub

    Private Sub PaymentMenu_Click(sender As System.Object, e As System.EventArgs) Handles CashToolStripMenuItem.Click, CheckToolStripMenuItem.Click, VisaToolStripMenuItem.Click, MastercardToolStripMenuItem.Click, DiscoverToolStripMenuItem.Click, AmericanExpressToolStripMenuItem.Click
        Dim paymentType As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        _paymentLock = True
        HandlePaymentType(paymentType.Text)
        _paymentLock = False
    End Sub

    Private Sub cboPayment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPayment.SelectedIndexChanged
        If Not _paymentLock Then
            HandlePaymentType(cboPayment.SelectedItem)
        End If
    End Sub

    Private Sub ClearToppingChecks()
        Me.chkBlackOlives.Checked = False
        Me.chkCheese.Checked = False
        Me.chkGreenOlives.Checked = False
        Me.chkHam.Checked = False
        Me.chkHamburger.Checked = False
        Me.chkMushrooms.Checked = False
        Me.chkOnions.Checked = False
        Me.chkPepperoni.Checked = False
        Me.chkPinapple.Checked = False
        Me.chkSausage.Checked = False
    End Sub

    Private Sub ClearMenuChecks()
        CashToolStripMenuItem.Checked = False
        CheckToolStripMenuItem.Checked = False
        VisaToolStripMenuItem.Checked = False
        MastercardToolStripMenuItem.Checked = False
        AmericanExpressToolStripMenuItem.Checked = False
        DiscoverToolStripMenuItem.Checked = False
    End Sub

    Private Sub HandlePaymentType(ByVal paymentType As String)
        ClearMenuChecks()
        Select Case paymentType
            Case "Cash"
                cboPayment.SelectedItem = "Cash"
                CashToolStripMenuItem.Checked = True
            Case "Check"
                cboPayment.SelectedItem = "Check"
                CheckToolStripMenuItem.Checked = True
            Case "Visa"
                cboPayment.SelectedItem = "Visa"
                VisaToolStripMenuItem.Checked = True
            Case "Master Card"
                cboPayment.SelectedItem = "Master Card"
                MastercardToolStripMenuItem.Checked = True
            Case "American Express"
                cboPayment.SelectedItem = "American Express"
                AmericanExpressToolStripMenuItem.Checked = True
            Case "Discover"
                cboPayment.SelectedItem = "Discover"
                DiscoverToolStripMenuItem.Checked = True
            Case Else
                Throw New System.InvalidOperationException("Unknown menu item selected")
        End Select

        If paymentType <> "Cash" And paymentType <> "Check" Then
            Dim creditCardForm As New CreditCardInputForm()
            creditCardForm.CreditCardType = cboPayment.SelectedItem

            If creditCardForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                _isCreditCardDataValid = True
            Else
                _isCreditCardDataValid = False
            End If
        End If

        CheckValidInput()

    End Sub

    Private Sub chkMute_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMute.CheckedChanged
        If chkMute.Checked Then
            Me.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            Me.AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub
End Class

