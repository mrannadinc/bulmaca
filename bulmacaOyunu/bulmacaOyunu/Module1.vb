Module Module1
    Sub cblev1(ByRef button1 As Button, ByRef button2 As Button)
        If button2.Text = "" Then
            button2.Text = button1.Text
            button1.Text = ""
        End If
    End Sub
    Sub fnLev1()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And Form1.Button4.Text = "4" And
            Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And
            Form1.Button9.Text = "" Then
            MsgBox("Congratulations!You succeeded")
        End If
    End Sub
End Module
