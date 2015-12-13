Public Class UpdateDialog

    Private Sub UpdateDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal message As String, ByVal title As String, ByVal link As String)
        InitializeComponent()

        Label1.Text = message
        Me.Text = title
        Button1.Text = "Ok"
        Button2.Text = "Download"
        Button2.Tag = link

        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.No
        Process.Start(Me.Button2.Tag)
        Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class