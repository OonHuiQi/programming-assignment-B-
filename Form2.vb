Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet4.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter2.Fill(Me.Database2DataSet4.Table1)
        'TODO: This line of code loads data into the 'Database2DataSet3.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.Database2DataSet3.Table1)
        'TODO: This line of code loads data into the 'Database2DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database2DataSet1.Table1)


    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        End

    End Sub

    Private Sub max_Click(sender As Object, e As EventArgs) Handles max.Click
        TextBox2.Text = (From row As DataGridViewRow In DataGridView1.Rows
                         Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                         Select Convert.ToInt32(row.Cells(2).FormattedValue)).Max().ToString()
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        TextBox3.Text = (From row As DataGridViewRow In DataGridView1.Rows
                         Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                         Select Convert.ToInt32(row.Cells(2).FormattedValue)).Min().ToString()
    End Sub

    Private Sub sum_Click(sender As Object, e As EventArgs) Handles sum.Click
        Dim sum As Integer
        Dim i As Integer

        For i = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value
        Next

        TextBox4.Text = sum.ToString()
    End Sub

    Private Sub avg_Click(sender As Object, e As EventArgs) Handles avg.Click
        Dim avg As Double
        Dim sum As Integer
        Dim i As Integer

        For i = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value
        Next

        avg = sum / DataGridView1.Rows.Count()
        TextBox5.Text = avg.ToString("##.###")
    End Sub
End Class