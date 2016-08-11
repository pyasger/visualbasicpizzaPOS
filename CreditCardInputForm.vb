Public Class CreditCardInputForm
    'Private Sub subFillCusttable()
    '    Dim odaPizza As OleDb.OleDbDataAdapter
    '    Dim strDatabase As String
    '    Dim strSQL As String


    '    Dim strDataSrc As String = "Data Source = " + Application.StartupPath + "\..\..\Pizza.accdb"

    '    'strDatabase = "C:\Pizza.mdb"
    '    StrConn = "Provider=Microsoft.ACEOLEDB12.0;"
    '    strConn = strConn & "Data Source=" & strDatabase
    '    strSQL = "SELECT * FROM tblCustomer"

    '    '***********Fill CUSTOMER TABLE*******************
    '    odaPizza = New OleDb.OleDbDataAdapter(strSQL, strConn)
    '    datCust = New DataTable()
    '    odaPizza.Fill(datCust)
    '    odaPizza.Dispose()


    'End Sub
    'Private Sub btnAcc_Click(sender As System.Object, e As System.EventArgs) Handles btnAct.Click
    '    Try
    '        VariantType(odaCust = New OleDb.OleDbDataAdapter(strSQL, strConnection))
    '        Dim cmdBld As New OleDb.OleDbCommandBuilder(odaCust)
    '        Dim newCust As DataRow
    '        newCust = datCust.NewRow    'DatCust is the datatable
    '        newCust("fldPhone") = mtbPhnNum.Text
    '        newCust("fldCustName") = txtCusNam.Text
    '        newCust("fldCustAddr1") = txtCustAdd1.Text
    '        newCust("fldCustAddr2") = txtCustAdd2.Text
    '        newCust("fldCustCity") = txtCustCty.Text
    '        newCust("fldCustState") = cboCustSta.Text
    '        newCust("fldCustZip") = mtbZipCo.Text
    '        datCust.Rows.Add(newCust)   'Add datarow to table
    '        cmdBld.GetUpdateCommand()   'collect updates to datatable
    '        odaCust.Update(datCust)     'write updates to database
    '    Catch ex As Exception
    '        MessageBox.Show("Customer Already Exists - Customer not added!", "Customer Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private _creditCardType As String = "N/A"

    Public Property CreditCardType As String
        Get
            Return _creditCardType
        End Get
        Set(value As String)
            _creditCardType = value
        End Set
    End Property

    Private Sub cardtransactions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblCreditCardType.Text = _creditCardType
        Me.drpExpiryMonth.SelectedItem = Date.Now.Month.ToString()
        Me.drpExpiryYear.SelectedItem = Date.Now.Year.ToString()
    End Sub



    Private Sub txtCCH_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCCHolder.MaskInputRejected
        Me.txtWarning.Text = "Credit card holder is invalid"
    End Sub

    Private Sub mtbCCN_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtbCCNumber.MaskInputRejected
        Me.txtWarning.Text = "Credit card number is invalid"
    End Sub

    Private Sub drpEY_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles drpExpiryYear.SelectedIndexChanged
        CheckInputValidity()
    End Sub

    Private Sub drpEM_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles drpExpiryMonth.SelectedIndexChanged
        CheckInputValidity()
    End Sub

    Private Sub mtbCCN_TextChanged(sender As System.Object, e As System.EventArgs) Handles mtbCCNumber.TextChanged
        CheckInputValidity()
    End Sub

    Private Sub CheckInputValidity()
        Dim isCCHolderValid = False
        If Me.txtCCHolder.TextLength > 2 Then
            isCCHolderValid = True
        Else
            isCCHolderValid = False
        End If

        Dim isCCNumberValid = False
        If Not mtbCCNumber.MaskFull Then
            Me.txtWarning.Text = "Credit card number is invalid"
            isCCNumberValid = False
        Else
            Me.txtWarning.Text = String.Empty
            isCCNumberValid = True
        End If

        Dim isCreditCardExpiryValid As Boolean = False
        If Me.drpExpiryMonth.SelectedItem < Date.Today.Month And drpExpiryYear.SelectedItem <= Date.Today.Year Then
            isCreditCardExpiryValid = False
            Me.txtWarning.Text += "  Credit card has expired"
        Else
            isCreditCardExpiryValid = True
            Me.txtWarning.Text = String.Empty
        End If

        If isCCHolderValid And isCCNumberValid And isCreditCardExpiryValid Then
            Me.btnAccept.Enabled = True
        Else
            Me.btnAccept.Enabled = False
        End If
    End Sub
End Class