﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '24
        cblev1(Button1, Button2)
        cblev1(Button1, Button4)
        fnLev1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '135
        cblev1(Button2, Button1)
        cblev1(Button2, Button3)
        cblev1(Button2, Button5)
        fnLev1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '26
        cblev1(Button3, Button2)
        cblev1(Button3, Button6)
        fnLev1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '157
        cblev1(Button4, Button1)
        cblev1(Button4, Button5)
        cblev1(Button4, Button7)
        fnLev1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '2468
        cblev1(Button5, Button2)
        cblev1(Button5, Button4)
        cblev1(Button5, Button6)
        cblev1(Button5, Button8)
        fnLev1()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '359
        cblev1(Button6, Button3)
        cblev1(Button6, Button5)
        cblev1(Button6, Button9)
        fnLev1()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '48
        cblev1(Button7, Button4)
        cblev1(Button7, Button8)
        fnLev1()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '759
        cblev1(Button8, Button7)
        cblev1(Button8, Button5)
        cblev1(Button8, Button9)
        fnLev1()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '68
        cblev1(Button9, Button6)
        cblev1(Button9, Button8)
        fnLev1()
    End Sub
End Class
