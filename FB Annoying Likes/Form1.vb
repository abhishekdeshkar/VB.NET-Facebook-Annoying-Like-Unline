Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fb_web.Navigate("http://www.facebook.com")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Like the post and then Unlike it xD
        LikePost()
        Delay(8)
        UnLikePost()

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Timer1.Enabled = True
        Timer1.Interval = "20000"
        Timer1.Start()
    End Sub

    Private Sub btn_go_Click(sender As Object, e As EventArgs) Handles btn_go.Click
        fb_web.Navigate(txt_url.Text)
    End Sub

    Public Sub LikePost()
        Dim allelements As HtmlElementCollection = fb_web.Document.All
        Try

            For Each webpageelement As HtmlElement In allelements
                If webpageelement.GetAttribute("classname") = "UFILikeLink _4x9- _4x9_ _48-k" Then
                    'If webpageelement.GetAttribute("classname") = "UFILikeLink" Then
                    webpageelement.InvokeMember("click")
                    Delay(1)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UnLikePost()
        'UFILikeLink _4x9- _4x9_ _48-k UFILinkBright

        Dim allelements As HtmlElementCollection = fb_web.Document.All
        Try

            For Each webpageelement As HtmlElement In allelements
                'If webpageelement.GetAttribute("classname") = "UFILikeLink" Then
                If webpageelement.GetAttribute("classname") = "UFILikeLink _4x9- _4x9_ _48-k UFILinkBright" Then
                        webpageelement.InvokeMember("click")
                        Delay(1)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub
End Class
