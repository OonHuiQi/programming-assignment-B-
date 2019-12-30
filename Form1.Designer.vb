<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim Yeild_per_Hectare__Estate___Kg_Label As System.Windows.Forms.Label
        Me.First = New System.Windows.Forms.Button()
        Me.add_data = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.previous = New System.Windows.Forms.Button()
        Me.movenext = New System.Windows.Forms.Button()
        Me.last = New System.Windows.Forms.Button()
        Me.A_sort = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Exist = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet1 = New WindowsApp7.Database2DataSet1()
        Me.Table1TableAdapter = New WindowsApp7.Database2DataSet1TableAdapters.Table1TableAdapter()
        Me.TableAdapterManager1 = New WindowsApp7.Database2DataSet1TableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.Yeild_per_Hectare__Estate___Kg_TextBox = New System.Windows.Forms.TextBox()
        Me.nextform = New System.Windows.Forms.Button()
        Me.D_sort = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        Yeild_per_Hectare__Estate___Kg_Label = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(12, 80)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(26, 17)
        IDLabel.TabIndex = 21
        IDLabel.Text = "ID:"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearLabel.Location = New System.Drawing.Point(12, 127)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(42, 17)
        YearLabel.TabIndex = 22
        YearLabel.Text = "Year:"
        '
        'Yeild_per_Hectare__Estate___Kg_Label
        '
        Yeild_per_Hectare__Estate___Kg_Label.AutoSize = True
        Yeild_per_Hectare__Estate___Kg_Label.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Yeild_per_Hectare__Estate___Kg_Label.Location = New System.Drawing.Point(12, 168)
        Yeild_per_Hectare__Estate___Kg_Label.Name = "Yeild_per_Hectare__Estate___Kg_Label"
        Yeild_per_Hectare__Estate___Kg_Label.Size = New System.Drawing.Size(215, 17)
        Yeild_per_Hectare__Estate___Kg_Label.TabIndex = 23
        Yeild_per_Hectare__Estate___Kg_Label.Text = "Yeild per Hectare (Estate) (Kg):"
        '
        'First
        '
        Me.First.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First.Location = New System.Drawing.Point(44, 278)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(75, 31)
        Me.First.TabIndex = 1
        Me.First.Text = "First"
        Me.First.UseVisualStyleBackColor = True
        '
        'add_data
        '
        Me.add_data.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_data.Location = New System.Drawing.Point(92, 329)
        Me.add_data.Name = "add_data"
        Me.add_data.Size = New System.Drawing.Size(75, 31)
        Me.add_data.TabIndex = 2
        Me.add_data.Text = "Add"
        Me.add_data.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(307, 329)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 31)
        Me.delete.TabIndex = 3
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(198, 329)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(75, 31)
        Me.update.TabIndex = 4
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'previous
        '
        Me.previous.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous.Location = New System.Drawing.Point(143, 278)
        Me.previous.Name = "previous"
        Me.previous.Size = New System.Drawing.Size(84, 31)
        Me.previous.TabIndex = 6
        Me.previous.Text = "Previous"
        Me.previous.UseVisualStyleBackColor = True
        '
        'movenext
        '
        Me.movenext.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movenext.Location = New System.Drawing.Point(254, 278)
        Me.movenext.Name = "movenext"
        Me.movenext.Size = New System.Drawing.Size(75, 31)
        Me.movenext.TabIndex = 7
        Me.movenext.Text = "Next"
        Me.movenext.UseVisualStyleBackColor = True
        '
        'last
        '
        Me.last.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last.Location = New System.Drawing.Point(347, 278)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(75, 31)
        Me.last.TabIndex = 14
        Me.last.Text = "Last"
        Me.last.UseVisualStyleBackColor = True
        '
        'A_sort
        '
        Me.A_sort.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_sort.Location = New System.Drawing.Point(254, 204)
        Me.A_sort.Name = "A_sort"
        Me.A_sort.Size = New System.Drawing.Size(80, 25)
        Me.A_sort.TabIndex = 16
        Me.A_sort.Text = "A-Sort"
        Me.A_sort.UseVisualStyleBackColor = True
        '
        'close
        '
        Me.close.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.Location = New System.Drawing.Point(264, 407)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(158, 31)
        Me.close.TabIndex = 17
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 22)
        Me.TextBox1.TabIndex = 18
        '
        'Exist
        '
        Me.Exist.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exist.Location = New System.Drawing.Point(332, 20)
        Me.Exist.Name = "Exist"
        Me.Exist.Size = New System.Drawing.Size(90, 28)
        Me.Exist.TabIndex = 19
        Me.Exist.Text = "Exist"
        Me.Exist.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView2.DataSource = Me.Table1BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(471, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(429, 412)
        Me.DataGridView2.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Year"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Year"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Yeild per Hectare (Estate) (Kg)"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Yield per Hectare (Estate) (Kg)"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database2DataSet1
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager1.UpdateOrder = WindowsApp7.Database2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(254, 75)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(168, 22)
        Me.IDTextBox.TabIndex = 22
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(254, 122)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(168, 22)
        Me.YearTextBox.TabIndex = 23
        '
        'Yeild_per_Hectare__Estate___Kg_TextBox
        '
        Me.Yeild_per_Hectare__Estate___Kg_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Yeild per Hectare (Estate) (Kg)", True))
        Me.Yeild_per_Hectare__Estate___Kg_TextBox.Location = New System.Drawing.Point(254, 165)
        Me.Yeild_per_Hectare__Estate___Kg_TextBox.Name = "Yeild_per_Hectare__Estate___Kg_TextBox"
        Me.Yeild_per_Hectare__Estate___Kg_TextBox.Size = New System.Drawing.Size(168, 22)
        Me.Yeild_per_Hectare__Estate___Kg_TextBox.TabIndex = 24
        '
        'nextform
        '
        Me.nextform.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextform.Location = New System.Drawing.Point(44, 407)
        Me.nextform.Name = "nextform"
        Me.nextform.Size = New System.Drawing.Size(158, 31)
        Me.nextform.TabIndex = 33
        Me.nextform.Text = "Next Form"
        Me.nextform.UseVisualStyleBackColor = True
        '
        'D_sort
        '
        Me.D_sort.Font = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_sort.Location = New System.Drawing.Point(347, 204)
        Me.D_sort.Name = "D_sort"
        Me.D_sort.Size = New System.Drawing.Size(75, 25)
        Me.D_sort.TabIndex = 34
        Me.D_sort.Text = "D-Sort"
        Me.D_sort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.D_sort)
        Me.Controls.Add(Me.nextform)
        Me.Controls.Add(Yeild_per_Hectare__Estate___Kg_Label)
        Me.Controls.Add(Me.Yeild_per_Hectare__Estate___Kg_TextBox)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Exist)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.A_sort)
        Me.Controls.Add(Me.last)
        Me.Controls.Add(Me.movenext)
        Me.Controls.Add(Me.previous)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.add_data)
        Me.Controls.Add(Me.First)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents First As Button
    Friend WithEvents add_data As Button
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents previous As Button
    Friend WithEvents movenext As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YeildPerHectareEstateKgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents last As Button
    Friend WithEvents A_sort As Button
    Friend WithEvents close As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Exist As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Database2DataSet1 As Database2DataSet1
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database2DataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager1 As Database2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents Yeild_per_Hectare__Estate___Kg_TextBox As TextBox
    Friend WithEvents nextform As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents D_sort As Button
End Class
