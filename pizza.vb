Public Class frmPizza

    Dim sngPrice As Single = 0.0 'class-level
    Dim sngTopping As Integer = 0

    Private Property dtmCurrent As Date

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblCustZip_Click(sender As System.Object, e As System.EventArgs) Handles lblCustZip.Click

    End Sub

    Private Sub lblTime_Click(sender As System.Object, e As System.EventArgs) Handles lblTime.Click


    End Sub

    Private Sub frmPizza_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("HI")
    End Sub

    Private Sub btnPrice_Click(sender As System.Object, e As System.EventArgs) Handles btnPrice.Click
        Dim sngTop As Single = 10.25
        Dim sngSubTotal As Single = 0.0 ' local variable
        Dim sngPrice As Single = 0.0
        sngPrice = sngSubTotal + sngTop
        Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Bisque
        Me.BackColor = Color.Brown
    End Sub

    Private Sub cboPayment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPayment.SelectedIndexChanged

    End Sub
End Class
