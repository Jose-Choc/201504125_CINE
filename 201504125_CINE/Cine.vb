Public Class Cine
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("Esta seguro de salir", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            Close()
        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        subLimpiar()
    End Sub
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        If indice < 9 Then

            Dim cine = valCine(CmBxCine.SelectedItem)
            Dim funcion = valFuncion(CmBxFuncion.SelectedItem)
            Dim precio = precios(cine, funcion)
            subTotal(indice) = precio
            Dim desc1 = calcDescuent1(cine, funcion) * precio
            descuent1(indice) = desc1
            Dim desc2 = calcDescuent2(sumaSubTotal(indice))
            descuent2(indice) = desc2
            Dim tot = precio - desc1 - desc2
            total(indice) = tot


            LtBxCine.Items.Add(CmBxCine.SelectedItem)
            LtBxFuncion.Items.Add(CmBxFuncion.SelectedItem)
            LtBxSubTotal.Items.Add(precio)
            LtBxDesc1.Items.Add(desc1)
            LtBxDesc2.Items.Add(desc2)
            LtBxTotal.Items.Add(tot)
        Else
            MessageBox.Show("Haz llegado al limite de datos")
        subLimpiar()
        End If

        indice += 1
    End Sub
    Public Sub subLimpiar()
        LtBxCine.Items.Clear()
        LtBxFuncion.Items.Clear()
        LtBxSubTotal.Items.Clear()
        LtBxDesc1.Items.Clear()
        LtBxDesc2.Items.Clear()
        LtBxTotal.Items.Clear()
    End Sub
End Class
