Public Class Clients
    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Clients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Êtes-vous sûr(e) de vouloir continuer?" & Environment.NewLine & "" & Environment.NewLine & "Toutes les modifications non enregistrées seront perdues.", "Modifications non enregistrées", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox3.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" And TextBox1.Text = "" And ComboBox2.SelectedIndex = -1) Then
            MessageBox.Show("Veuillez sélectionner un client pour le modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox1.Text = "" Or ComboBox2.SelectedIndex = -1) Then
                MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For Each item As ListViewItem In ListView1.SelectedItems

                    item.Text = ""
                    item.SubItems(1).Text = TextBox1.Text
                    item.SubItems(2).Text = ComboBox2.Text
                    item.SubItems(3).Text = TextBox3.Text
                    item.SubItems(4).Text = TextBox4.Text
                    item.SubItems(5).Text = TextBox6.Text
                    item.SubItems(6).Text = TextBox7.Text
                    item.SubItems(7).Text = TextBox8.Text

                Next

                TextBox1.Clear()
                ComboBox2.SelectedIndex = -1
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                MessageBox.Show("Client modifié avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox3.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" And TextBox1.Text = "" And ComboBox2.SelectedIndex = -1) Then
            MessageBox.Show("Veuillez sélectionner un client pour le supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox1.Text = "" Or ComboBox2.SelectedIndex = -1) Then
                MessageBox.Show("Veuillez sélectionner un client pour le supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Else
                    For Each i As ListViewItem In ListView1.SelectedItems
                        ListView1.Items.Remove(i)
                    Next
                    TextBox1.Clear()
                    ComboBox2.SelectedIndex = -1
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox6.Clear()
                    TextBox7.Clear()
                    TextBox8.Clear()
                    MessageBox.Show("Client supprimé avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox1.Text = "" Or ComboBox2.SelectedIndex = -1) Then
            MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lvi As New ListViewItem With {
            .Text = ""
        }
            lvi.SubItems.AddRange(New String() {TextBox1.Text, ComboBox2.Text, TextBox3.Text, TextBox4.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text})
            ListView1.Items.Add(lvi)
            TextBox1.Clear()
            ComboBox2.SelectedIndex = -1
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            MessageBox.Show("Client ajouté avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        For I As Integer = 0 To ListView1.Items.Count - 1

            For Each item As ListViewItem In ListView1.SelectedItems

                TextBox1.Text = item.SubItems(1).Text
                ComboBox2.Text = item.SubItems(2).Text
                TextBox3.Text = item.SubItems(3).Text
                TextBox4.Text = item.SubItems(4).Text
                TextBox6.Text = item.SubItems(5).Text
                TextBox7.Text = item.SubItems(6).Text
                TextBox8.Text = item.SubItems(7).Text
            Next

        Next
    End Sub
End Class