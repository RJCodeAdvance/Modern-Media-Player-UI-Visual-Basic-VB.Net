Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()

        PanelMediaSubmenu.Visible = False
        PanelPlaylistSubmenu.Visible = False
        PanelToolsSubmenu.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        showSubmenu(PanelMediaSubmenu)
    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        showSubmenu(PanelPlaylistSubmenu)
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        showSubmenu(PanelToolsSubmenu)
    End Sub

#Region "Buttons Submenu"
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        openChildForm(New Form2())
        '...
        'your codes
        '...
        hideSubmenu()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        openChildForm(New Form3())
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub
#End Region

    Private Sub btnEqualizer_Click(sender As Object, e As EventArgs) Handles btnEqualizer.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        '...
        'your codes
        '...
        hideSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
