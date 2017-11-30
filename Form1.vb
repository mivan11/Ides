Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WB.Navigate("http://google.com")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ides.Click
        WB.Navigate(Tekst.Text)
        While WB.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        End While
    End Sub
    Private Sub textBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tekst.KeyDown
        If e.KeyCode = Keys.Enter Then
            WB.Navigate(Tekst.Text)
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles nazad.Click
        WB.GoBack()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles naprijed.Click
        WB.GoForward()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles osvjezi.Click
        WB.Refresh()
    End Sub

    Private Sub WB_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted

    End Sub

    Private Sub pocetna_Click(sender As Object, e As EventArgs) Handles pocetna.Click
        WB.Navigate("http://google.com")
    End Sub
End Class
