Public Class Form1
    Public marks As Integer = 0
    Public username As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AjaxSamplesDataSet.Customers' table. You can move, or remove it, as needed.
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.CustomersTableAdapter.Fill(Me.AjaxSamplesDataSet.Customers)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.username = Guna2TextBox2.Text
        Me.Hide()
        Dim frm As New Form2(Me)
        frm.TopMost = True
        frm.Show()

    End Sub
End Class
