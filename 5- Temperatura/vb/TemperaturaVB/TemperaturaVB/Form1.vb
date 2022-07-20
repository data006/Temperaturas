Public Class frmTemperatura




    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim tempEntrada, tempSalida As Double

        If (txtIn.Text IsNot String.Empty) And Not txtIn.Text = "." And Not txtIn.Text = "-" And Not txtIn.Text = ".-" And Not txtIn.Text = "-." And Not txtIn.Text.Contains(".-") Then



            tempEntrada = Val(txtIn.Text)

            If radinC.Checked Then



                If radOutF.Checked Then

                    tempSalida = tempEntrada * 1.8 + 32
                    txtOut.Text = tempSalida

                ElseIf radOutK.Checked Then

                    If tempEntrada >= (-273.15) Then

                        tempSalida = tempEntrada + 273.15
                        txtOut.Text = tempSalida

                    ElseIf tempEntrada < (-273.15) Then

                        txtOut.Text = 0
                        MsgBox("La temperatura no puede ser menor a 0 Kelvin")

                    End If


                ElseIf radOutR.Checked Then

                    If tempEntrada >= (-273.15) Then

                        tempSalida = tempEntrada * 1.8 + 491.67
                        txtOut.Text = tempSalida

                    ElseIf tempEntrada < (-273.15) Then

                        txtOut.Text = 0
                        MsgBox("La temperatura no puede ser menor a 0 Rankine")

                    End If



                End If

            ElseIf radInF.Checked Then

                If radOutC.Checked Then

                    tempSalida = (tempEntrada - 32) / 1.8
                    txtOut.Text = tempSalida

                ElseIf radOutK.Checked Then

                    If tempEntrada >= (-459.67) Then

                        tempSalida = ((tempEntrada - 32) / 1.8) + 273.15
                        txtOut.Text = tempSalida

                    ElseIf tempEntrada < (-459.67) Then

                        txtOut.Text = 0
                        MsgBox("La temperatura no puede ser menor a 0 Kelvin")

                    End If



                ElseIf radOutR.Checked Then

                    If tempEntrada >= (-459.67) Then

                        tempSalida = tempEntrada + 459.67
                        txtOut.Text = tempSalida

                    ElseIf tempEntrada < (-459.67) Then

                        txtOut.Text = 0
                        MsgBox("La temperatura no puede ser menor a 0 Rankine")

                    End If



                End If

            ElseIf radInK.Checked Then

                If tempEntrada < 0 Then

                    MsgBox("La temperatura no puede ser menor a 0 Kelvin")



                ElseIf radOutC.Checked Then

                    tempSalida = (tempEntrada - 273.15)
                    txtOut.Text = tempSalida

                ElseIf radOutF.Checked Then

                    tempSalida = ((tempEntrada - 273.15) * 1.8) + 32
                    txtOut.Text = tempSalida

                ElseIf radOutR.Checked Then

                    tempSalida = tempEntrada * 1.8
                    txtOut.Text = tempSalida

                End If

            ElseIf radInR.Checked Then

                If tempEntrada < 0 Then

                    MsgBox("La temperatura no puede ser menor a 0 Rankine")

                ElseIf radOutC.Checked Then

                    tempSalida = (tempEntrada - 491.67) * (5 / 9)
                    txtOut.Text = tempSalida

                ElseIf radOutF.Checked Then

                    tempSalida = ((tempEntrada - 459.67))
                    txtOut.Text = tempSalida

                ElseIf radOutK.Checked Then

                    tempSalida = tempEntrada * (5 / 9)
                    txtOut.Text = tempSalida

                End If

            End If
        End If

    End Sub

    Private Sub radinC_CheckedChanged(sender As Object, e As EventArgs) Handles radinC.CheckedChanged

        If radinC.Checked Then

            radOutC.Enabled = False
            radOutF.Checked = True

        Else

            radOutC.Enabled = True

        End If

    End Sub

    Private Sub radInF_CheckedChanged(sender As Object, e As EventArgs) Handles radInF.CheckedChanged

        If radInF.Checked Then

            radOutF.Enabled = False
            radOutK.Checked = True

        Else

            radOutF.Enabled = True

        End If

    End Sub

    Private Sub radInK_CheckedChanged(sender As Object, e As EventArgs) Handles radInK.CheckedChanged

        If radInK.Checked Then

            radOutK.Enabled = False
            radOutR.Checked = True

        Else

            radOutK.Enabled = True

        End If

    End Sub

    Private Sub radInR_CheckedChanged(sender As Object, e As EventArgs) Handles radInR.CheckedChanged

        If radInR.Checked Then

            radOutR.Enabled = False
            radOutC.Checked = True

        Else

            radOutR.Enabled = True

        End If

    End Sub

    Private Sub txtIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIn.KeyPress


        If txtIn.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtIn.Text.Contains(".") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
        ElseIf Not txtIn.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"
        ElseIf txtIn.Text.Contains(".") And txtIn.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If






    End Sub
End Class
