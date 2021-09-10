Public Class ClienteConsult
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub ClienteConsult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataSet.ClientesF' Puede moverla o quitarla según sea necesario.
        Me.ClientesFTableAdapter.Fill(Me.PuntoVentaDataSet.ClientesF)

    End Sub

    Private Sub ClientesFBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesFBindingSource.CurrentChanged

    End Sub
End Class