Public Class Form6
    Private frm1 As Form1
    Public Sub New(ByVal frm1 As Form1)
        InitializeComponent()
        Me.frm1 = frm1
    End Sub
    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        MsgBox("Incorrect Answer !", MsgBoxStyle.Exclamation)
        nextquestion()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        frm1.marks += 2
        MsgBox("Incorrect Answer !", MsgBoxStyle.Exclamation)
        nextquestion()
    End Sub

    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles Guna2TileButton4.Click
        frm1.marks += 2
        MsgBox("Correct Answer !", MsgBoxStyle.Information)
        'MsgBox("Marks: " & frm1.marks)
        nextquestion()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        MsgBox("Incorrect Answer !", MsgBoxStyle.Exclamation)
        nextquestion()
    End Sub

    Private Sub nextquestion()
        Me.Hide()
        Dim frm As New Form7(frm1)
        frm.TopMost = True
        frm.Show()
    End Sub
End Class