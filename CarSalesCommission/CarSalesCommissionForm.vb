﻿'Program:       CarSalesCommission
'Programmer:    Andres Rodriguez Toca
'Description:   allow the user to enter the price of the car and the trade-in, if they have one
'               then calculate the net price and commission of the sale

Public Class CarSalesCommissionForm
    Const COMMISSION_RATE As Double = 0.1

    Dim CarPrice As Double
    Dim TradeInValue As Double
    Dim GrossPay As Double
    Dim TotalNumberCarSold As Integer = 0
    Dim CommissionSale As Double
    Dim TotalCommissionEarned As Double = 0

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear Price of the Car Sold
        CarPriceTextBox.Text = ""
        'Clear Trade-In Value
        TradeInTextBox.Text = ""
        'Clear Net Price
        NetPriceLabel.Text = ""
        'Clear Commission Earned
        CommissionLabel.Text = ""
        'Enable Calculate Button
        CalculateButton.Enabled = True
        'Disable Clear Button
        ClearButton.Enabled = False
        'Focus on Car Price
        CarPriceTextBox.Focus()

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Capture Car Price
        'Validate Car Price
        Try
            CarPrice = Double.Parse(CarPriceTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Non-numeric input for Car Price, please enter only numeric values", "Input error")
            CarPriceTextBox.SelectAll()
            CarPriceTextBox.Focus()
            Exit Sub
        End Try
        'Capture Trade-in Value
        'Validate Trade-In Value
        If TradeInTextBox.Text <> "" And TradeInTextBox.Text <> " " Then
            Try
                TradeInValue = Double.Parse(TradeInTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Non-numeric input for Trade-In, please enter only numeric values", "Input error")
                TradeInTextBox.SelectAll()
                TradeInTextBox.Focus()
                Exit Sub
            End Try
        End If
        'Calculate Net Price of the Car Sold
        If TradeInValue > 0 Then
            GrossPay = CarPrice - TradeInValue
        Else
            GrossPay = CarPrice
        End If
        'Calculate Commission of the Sale
        CommissionSale = GrossPay * COMMISSION_RATE

        'Add one to the Total Number of Cars Sold
        TotalNumberCarSold += 1

        'Add Commission Sale to the Total Commission Earned
        TotalCommissionEarned += CommissionSale

        'Display Net Price of the Car Sold
        NetPriceLabel.Text = GrossPay.ToString("c")
        'Display Commission of the Sale
        CommissionLabel.Text = CommissionSale.ToString("c")

        NetPriceLabel.Enabled = False
        CommissionLabel.Enabled = False
        CalculateButton.Enabled = False
        ClearButton.Enabled = True


    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        'Display Total Commission Earned
        'Display Total Number of Car Sold
        MessageBox.Show("The Total Number of the Car Sold is " & TotalNumberCarSold & " and the Total Commission Earned is " & TotalCommissionEarned.ToString("c"), "Total Income", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Display Total Commission Earned
        'Display Total Number of Car Sold
        MessageBox.Show("The Total Number of the Car Sold is " & TotalNumberCarSold & " and the Total Commission Earned is " & TotalCommissionEarned.ToString("c"), "Total Income", MessageBoxButtons.OK)
        'Exit Program
        Close()
    End Sub

    Private Sub CarSalesCommissionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateLabel.Text = Now.ToString(“d”)
        TimeLabel.Text = Now.ToString(“t”)
    End Sub
End Class