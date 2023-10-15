Public Class Consultation_ventes
    Private Sub Consultation_ventes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Consultation_ventes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Êtes-vous sûr(e) de vouloir continuer?" & Environment.NewLine & "" & Environment.NewLine & "Toutes les modifications non enregistrées seront perdues.", "Modifications non enregistrées", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class