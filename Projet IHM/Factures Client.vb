Public Class Factures_Client
    Private Sub Factures_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Factures_Client_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Êtes-vous sûr(e) de vouloir continuer?" & Environment.NewLine & "" & Environment.NewLine & "Toutes les modifications non enregistrées seront perdues.", "Modifications non enregistrées", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "") Then
            MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lvi As New ListViewItem With {
            .Text = ""
        }
            lvi.SubItems.AddRange(New String() {TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text})
            ListView1.Items.Add(lvi)
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox13.Clear()
            MessageBox.Show("Article ajouté avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub
End Class