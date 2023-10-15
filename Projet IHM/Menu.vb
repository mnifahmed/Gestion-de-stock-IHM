Public Class MenuForm
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Authentification.Hide()
    End Sub

    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Voulez-vous vraiment quitter?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            Authentification.Close()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Articles.IsHandleCreated Or Bons_de_livraison.IsHandleCreated Or Clients.IsHandleCreated Or Consultation_ventes.IsHandleCreated Or Factures_Client.IsHandleCreated Or Factures_d_Achat.IsHandleCreated Or Fiches_de_stock.IsHandleCreated Or Fournisseurs.IsHandleCreated Then
            If MessageBox.Show("Une ou plusieurs interface(s) sont encore ouverte(s)." & Environment.NewLine & "Toutes les modifications non enregistrées seront perdues." & Environment.NewLine & "" & Environment.NewLine & "Continuer?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Else
                Articles.Dispose()
                Bons_de_livraison.Dispose()
                Clients.Dispose()
                Consultation_ventes.Dispose()
                Factures_Client.Dispose()
                Factures_d_Achat.Dispose()
                Fiches_de_stock.Dispose()
                Fournisseurs.Dispose()
                Me.Dispose()
                Authentification.Show()
            End If
        Else
            Me.Dispose()
            Authentification.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Fournisseurs.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clients.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Articles.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fiches_de_stock.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Factures_Client.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Bons_de_livraison.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Factures_d_Achat.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Consultation_ventes.Show()
    End Sub
End Class