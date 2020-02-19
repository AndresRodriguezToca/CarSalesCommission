<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarSalesCommissionForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NetPriceLabel = New System.Windows.Forms.Label()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.TradeInTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CarPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.InputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Net Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Commission:"
        '
        'NetPriceLabel
        '
        Me.NetPriceLabel.BackColor = System.Drawing.Color.White
        Me.NetPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NetPriceLabel.Location = New System.Drawing.Point(190, 193)
        Me.NetPriceLabel.Name = "NetPriceLabel"
        Me.NetPriceLabel.Size = New System.Drawing.Size(103, 22)
        Me.NetPriceLabel.TabIndex = 7
        Me.NetPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommissionLabel
        '
        Me.CommissionLabel.BackColor = System.Drawing.Color.White
        Me.CommissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CommissionLabel.Location = New System.Drawing.Point(190, 241)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(103, 22)
        Me.CommissionLabel.TabIndex = 8
        Me.CommissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(86, 298)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(88, 34)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 298)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(88, 34)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'TotalButton
        '
        Me.TotalButton.Location = New System.Drawing.Point(86, 351)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(88, 34)
        Me.TotalButton.TabIndex = 11
        Me.TotalButton.Text = "T&otal"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(195, 351)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 34)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.TradeInTextBox)
        Me.InputGroupBox.Controls.Add(Me.Label2)
        Me.InputGroupBox.Controls.Add(Me.CarPriceTextBox)
        Me.InputGroupBox.Controls.Add(Me.Label1)
        Me.InputGroupBox.Location = New System.Drawing.Point(51, 50)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(266, 128)
        Me.InputGroupBox.TabIndex = 13
        Me.InputGroupBox.TabStop = False
        '
        'TradeInTextBox
        '
        Me.TradeInTextBox.Location = New System.Drawing.Point(142, 82)
        Me.TradeInTextBox.Name = "TradeInTextBox"
        Me.TradeInTextBox.Size = New System.Drawing.Size(99, 26)
        Me.TradeInTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Trade-in:"
        '
        'CarPriceTextBox
        '
        Me.CarPriceTextBox.Location = New System.Drawing.Point(142, 27)
        Me.CarPriceTextBox.Name = "CarPriceTextBox"
        Me.CarPriceTextBox.Size = New System.Drawing.Size(99, 26)
        Me.CarPriceTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Car &Price:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Location = New System.Drawing.Point(12, 13)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(44, 20)
        Me.DateLabel.TabIndex = 14
        Me.DateLabel.Text = "Date"
        Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Location = New System.Drawing.Point(283, 13)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(43, 20)
        Me.TimeLabel.TabIndex = 15
        Me.TimeLabel.Text = "Time"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CarSalesCommissionForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(373, 428)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.CommissionLabel)
        Me.Controls.Add(Me.NetPriceLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "CarSalesCommissionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Sales Commission"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NetPriceLabel As System.Windows.Forms.Label
    Friend WithEvents CommissionLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents TotalButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents InputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TradeInTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CarPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents TimeLabel As System.Windows.Forms.Label

End Class
