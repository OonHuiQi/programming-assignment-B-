
Imports System.Data
Imports System.ComponentModel
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database2DataSet1.Table1)
        'TODO: This line of code loads data into the 'Database1DataSet.yeild_per_hectare' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database2DataSet1.Table1)
    End Sub
    Private Sub exist_Click(sender As Object, e As EventArgs) Handles Exist.Click
        On Error GoTo saveerr
        For i As Integer = 0 To DataGridView2.RowCount - 1

            If DataGridView2.Rows(i).Cells(1).Value.ToString = TextBox1.Text Then
                MsgBox("Year found")

            End If
        Next

saveerr:
        Exit Sub
    End Sub

    Private Sub A_sort_Click(sender As Object, e As EventArgs) Handles A_sort.Click
        DataGridView2.Sort(DataGridView2.Columns(2), ListSortDirection.Ascending)
    End Sub

    Private Sub D_sort_Click(sender As Object, e As EventArgs) Handles D_sort.Click
        DataGridView2.Sort(DataGridView2.Columns(2), ListSortDirection.Descending)
    End Sub

    Private Sub First_Click(sender As Object, e As EventArgs) Handles First.Click
        Table1BindingSource.MoveFirst()
    End Sub

    Private Sub previous_Click(sender As Object, e As EventArgs) Handles previous.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub movenext_Click(sender As Object, e As EventArgs) Handles movenext.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub last_Click(sender As Object, e As EventArgs) Handles last.Click
        Table1BindingSource.MoveLast()
    End Sub

    Private Sub add_data_Click(sender As Object, e As EventArgs) Handles add_data.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Database2DataSet1.Table1)
        MsgBox("OK, BOSS" & vbNewLine & "Your data sucessfully save.")
SaveErr:
        Exit Sub
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Table1BindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub nextform_Click_1(sender As Object, e As EventArgs) Handles nextform.Click
        If MessageBox.Show("Are you sure want to go Form 2?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Form2.Show()
        Else
            MyBase.Close()

        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        End
    End Sub
End Class
