Public Class Authentification
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Or (TextBox1.Text = "" And TextBox2.Text = "") Then
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("Veuillez donner votre nom d'utilisateur et mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
                TextBox1.Clear()
                TextBox2.Clear()
                MenuForm.Show()
            Else
                TextBox1.Clear()
                TextBox2.Clear()
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class