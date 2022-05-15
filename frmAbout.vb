Public Class frmAbout
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Me.Close()
        Me.Hide()
        Dim newMainfrm As frmMain = New frmMain()

        newMainfrm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class