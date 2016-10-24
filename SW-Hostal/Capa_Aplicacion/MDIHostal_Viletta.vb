Imports System.Windows.Forms

Public Class MDIHostal_Viletta

   
    Private Sub MDIHostal_Viletta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        FrmRegistrarTipoHabitacion.MdiParent = Me
        FrmRegistrarTipoHabitacion.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        FrmRegistrarHabitacion.MdiParent = Me
        FrmRegistrarHabitacion.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        FrmRegistarAlquiler.MdiParent = Me
        FrmRegistarAlquiler.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmRegistrarClientes.MdiParent = Me
        FrmRegistrarClientes.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DetalleHabitacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalleHabitacionToolStripMenuItem.Click
        FrmDetalleAlquiler.MdiParent = Me
        FrmDetalleAlquiler.Show()
    End Sub

    Private Sub ReportesDiariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesDiariosToolStripMenuItem.Click
        frmreporteDiario.MdiParent = Me
        frmreporteDiario.Show()
    End Sub
End Class
