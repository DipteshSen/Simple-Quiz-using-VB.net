Public Class Form7
    Private frm1 As Form1
    Public Sub New(ByVal frm1 As Form1)
        InitializeComponent()
        Me.frm1 = frm1
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = frm1.marks.ToString & "/ 10"
        Label1.Text += frm1.username + " !"


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()

    End Sub
End Class