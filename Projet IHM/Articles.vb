Public Class Articles
    Private Sub Articles_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Êtes-vous sûr(e) de vouloir continuer?" & Environment.NewLine & "" & Environment.NewLine & "Toutes les modifications non enregistrées seront perdues.", "Modifications non enregistrées", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Articles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" And TextBox5.Text = "" And TextBox9.Text = "" And TextBox8.Text = "" And TextBox10.Text = "" And TextBox2.Text = "" And ComboBox1.SelectedIndex = -1 And ComboBox3.SelectedIndex = -1 And ComboBox4.SelectedIndex = -1) Then
            MessageBox.Show("Veuillez sélectionner un article pour le modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox5.Text = "" Or TextBox9.Text = "" Or TextBox8.Text = "" Or TextBox10.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1) Then
                MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For Each item As ListViewItem In ListView1.SelectedItems

                    item.Text = ""
                    item.SubItems(1).Text = TextBox1.Text
                    item.SubItems(2).Text = TextBox2.Text
                    item.SubItems(3).Text = ComboBox1.Text
                    item.SubItems(4).Text = TextBox4.Text
                    item.SubItems(5).Text = ComboBox3.Text
                    item.SubItems(6).Text = TextBox6.Text
                    item.SubItems(7).Text = ComboBox4.Text
                    item.SubItems(8).Text = TextBox5.Text
                    item.SubItems(9).Text = TextBox9.Text
                    item.SubItems(10).Text = TextBox8.Text
                    item.SubItems(11).Text = TextBox10.Text

                Next

                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.SelectedIndex = -1
                TextBox4.Clear()
                ComboBox3.SelectedIndex = -1
                TextBox6.Clear()
                ComboBox4.SelectedIndex = -1
                TextBox5.Clear()
                TextBox9.Clear()
                TextBox8.Clear()
                CheckBox1.Checked = False
                TextBox8.ReadOnly = False
                TextBox10.Clear()
                MessageBox.Show("Article modifié avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" And TextBox5.Text = "" And TextBox9.Text = "" And TextBox8.Text = "" And TextBox10.Text = "" And TextBox2.Text = "" And ComboBox1.SelectedIndex = -1 And ComboBox3.SelectedIndex = -1 And ComboBox4.SelectedIndex = -1) Then
            MessageBox.Show("Veuillez sélectionner un article pour le supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox5.Text = "" Or TextBox9.Text = "" Or TextBox8.Text = "" Or TextBox10.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1) Then
                MessageBox.Show("Veuillez sélectionner un article pour le supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet article?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Else
                    For Each i As ListViewItem In ListView1.SelectedItems
                        ListView1.Items.Remove(i)
                    Next
                    TextBox1.Clear()
                    TextBox2.Clear()
                    ComboBox1.SelectedIndex = -1
                    TextBox4.Clear()
                    ComboBox3.SelectedIndex = -1
                    TextBox6.Clear()
                    ComboBox4.SelectedIndex = -1
                    TextBox5.Clear()
                    TextBox9.Clear()
                    TextBox8.Clear()
                    CheckBox1.Checked = False
                    TextBox8.ReadOnly = False
                    TextBox10.Clear()
                    MessageBox.Show("Article supprimé avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox5.Text = "" Or TextBox9.Text = "" Or TextBox8.Text = "" Or TextBox10.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1) Then
            MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lvi As New ListViewItem With {
            .Text = ""
        }
            lvi.SubItems.AddRange(New String() {TextBox1.Text, TextBox2.Text, ComboBox1.Text, TextBox4.Text, ComboBox3.Text, TextBox6.Text, ComboBox4.Text, TextBox5.Text, TextBox9.Text, TextBox8.Text, TextBox10.Text})
            ListView1.Items.Add(lvi)
            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.SelectedIndex = -1
            TextBox4.Clear()
            ComboBox3.SelectedIndex = -1
            TextBox6.Clear()
            ComboBox4.SelectedIndex = -1
            TextBox5.Clear()
            TextBox9.Clear()
            TextBox8.Clear()
            CheckBox1.Checked = False
            TextBox8.ReadOnly = False
            TextBox10.Clear()
            MessageBox.Show("Article ajouté avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox8.Text = "Service"
        TextBox8.ReadOnly = True
        If CheckBox1.Checked = False Then
            TextBox8.Clear()
            TextBox8.ReadOnly = False
        End If
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        For I As Integer = 0 To ListView1.Items.Count - 1

            For Each item As ListViewItem In ListView1.SelectedItems

                TextBox1.Text = item.SubItems(1).Text
                TextBox2.Text = item.SubItems(2).Text
                ComboBox1.Text = item.SubItems(3).Text
                TextBox4.Text = item.SubItems(4).Text
                ComboBox3.Text = item.SubItems(5).Text
                TextBox6.Text = item.SubItems(6).Text
                ComboBox4.Text = item.SubItems(7).Text
                TextBox5.Text = item.SubItems(8).Text
                TextBox9.Text = item.SubItems(9).Text
                TextBox8.Text = item.SubItems(10).Text
                TextBox10.Text = item.SubItems(11).Text
            Next

        Next
    End Sub
End Class