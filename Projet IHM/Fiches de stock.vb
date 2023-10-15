Public Class Fiches_de_stock
    Private Sub Fiches_de_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Fiches_de_stock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Êtes-vous sûr(e) de vouloir continuer?" & Environment.NewLine & "" & Environment.NewLine & "Toutes les modifications non enregistrées seront perdues.", "Modifications non enregistrées", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox3.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "") And (TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "") Then
            MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (TextBox3.Text <> "") Then
                Dim lvi As New ListViewItem With {
                .Text = ""
            }
                lvi.SubItems.AddRange(New String() {TextBox3.Text, DateTimePicker1.Text, TextBox1.Text, TextBox2.Text})
                ListView1.Items.Add(lvi)
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox2.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                MessageBox.Show("Stock ajouté avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If (TextBox4.Text <> "") Then
                    Dim lvi As New ListViewItem With {
                .Text = ""
            }
                    lvi.SubItems.AddRange(New String() {"", "", "", "", TextBox4.Text, DateTimePicker2.Text, TextBox5.Text, TextBox6.Text})
                    ListView1.Items.Add(lvi)
                    TextBox1.Clear()
                    TextBox3.Clear()
                    TextBox2.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()
                    TextBox6.Clear()
                    MessageBox.Show("Stock ajouté avec succès.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        DateTimePicker2.Enabled = False
        If (TextBox3.Text = "") Then
            DateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        DateTimePicker1.Enabled = False
        If (TextBox4.Text = "") Then
            DateTimePicker1.Enabled = True
        End If
    End Sub
End Class