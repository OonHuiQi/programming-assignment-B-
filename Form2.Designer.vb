<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.YeildPerHectareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp7.Database1DataSet()
        Me.Yeild_per_hectareTableAdapter = New WindowsApp7.Database1DataSetTableAdapters.yeild_per_hectareTableAdapter()
        Me.YeildPerHectareBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New WindowsApp7.Database2DataSet()
        Me.Database2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet1 = New WindowsApp7.Database2DataSet1()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New WindowsApp7.Database2DataSet1TableAdapters.Table1TableAdapter()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.close = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.avg = New System.Windows.Forms.Button()
        Me.sum = New System.Windows.Forms.Button()
        Me.min = New System.Windows.Forms.Button()
        Me.max = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet4 = New WindowsApp7.Database2DataSet4()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet3 = New WindowsApp7.Database2DataSet3()
        Me.Table1TableAdapter1 = New WindowsApp7.Database2DataSet3TableAdapters.Table1TableAdapter()
        Me.Table1TableAdapter2 = New WindowsApp7.Database2DataSet4TableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New WindowsApp7.Database2DataSet4TableAdapters.TableAdapterManager()
        CType(Me.YeildPerHectareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YeildPerHectareBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YeildPerHectareBindingSource
        '
        Me.YeildPerHectareBindingSource.DataMember = "yeild per hectare"
        Me.YeildPerHectareBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Yeild_per_hectareTableAdapter
        '
        Me.Yeild_per_hectareTableAdapter.ClearBeforeFill = True
        '
        'YeildPerHectareBindingSource1
        '
        Me.YeildPerHectareBindingSource1.DataMember = "yeild per hectare"
        Me.YeildPerHectareBindingSource1.DataSource = Me.Database1DataSet
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database2DataSetBindingSource
        '
        Me.Database2DataSetBindingSource.DataSource = Me.Database2DataSet
        Me.Database2DataSetBindingSource.Position = 0
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database2DataSet1
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Chart1
        '
        ChartArea2.AxisX.Title = "Year"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.Title = "Yield per Hectare (Estate)(kg)"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.DataSource = Me.Table1BindingSource
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(21, 30)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = " Yield per Hectare"
        Series2.XValueMember = "Year"
        Series2.YValueMembers = "Yeild per Hectare (Estate) (Kg)"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(514, 468)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'close
        '
        Me.close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.close.Font = New System.Drawing.Font("Baskerville Old Face", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.Location = New System.Drawing.Point(1081, 487)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(118, 35)
        Me.close.TabIndex = 5
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.avg)
        Me.GroupBox1.Controls.Add(Me.sum)
        Me.GroupBox1.Controls.Add(Me.min)
        Me.GroupBox1.Controls.Add(Me.max)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(552, 315)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(511, 183)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA ANALYSIS"
        '
        'avg
        '
        Me.avg.Location = New System.Drawing.Point(264, 116)
        Me.avg.Name = "avg"
        Me.avg.Size = New System.Drawing.Size(93, 43)
        Me.avg.TabIndex = 39
        Me.avg.Text = "Average"
        Me.avg.UseVisualStyleBackColor = True
        '
        'sum
        '
        Me.sum.Location = New System.Drawing.Point(264, 42)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(93, 43)
        Me.sum.TabIndex = 38
        Me.sum.Text = "Sum"
        Me.sum.UseVisualStyleBackColor = True
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(14, 116)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(93, 40)
        Me.min.TabIndex = 34
        Me.min.Text = "Minimum"
        Me.min.UseVisualStyleBackColor = True
        '
        'max
        '
        Me.max.Location = New System.Drawing.Point(14, 42)
        Me.max.Name = "max"
        Me.max.Size = New System.Drawing.Size(93, 43)
        Me.max.TabIndex = 33
        Me.max.Text = "Maximum"
        Me.max.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(362, 125)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(127, 26)
        Me.TextBox5.TabIndex = 32
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(362, 51)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(127, 26)
        Me.TextBox4.TabIndex = 30
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 124)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 26)
        Me.TextBox3.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(112, 51)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 26)
        Me.TextBox2.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(571, 30)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(430, 261)
        Me.DataGridView1.TabIndex = 37
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.Width = 125
        '
        'YeildPerHectareEstateKgDataGridViewTextBoxColumn
        '
        Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn.DataPropertyName = "Yeild per Hectare (Estate) (Kg)"
        Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn.HeaderText = "Yeild per Hectare (Estate) (Kg)"
        Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn.Name = "YeildPerHectareEstateKgDataGridViewTextBoxColumn"
        Me.YeildPerHectareEstateKgDataGridViewTextBoxColumn.Width = 125
        '
        'Table1BindingSource2
        '
        Me.Table1BindingSource2.DataMember = "Table1"
        Me.Table1BindingSource2.DataSource = Me.Database2DataSet4
        '
        'Database2DataSet4
        '
        Me.Database2DataSet4.DataSetName = "Database2DataSet4"
        Me.Database2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.Database2DataSet3
        '
        'Database2DataSet3
        '
        Me.Database2DataSet3.DataSetName = "Database2DataSet3"
        Me.Database2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'Table1TableAdapter2
        '
        Me.Table1TableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter2
        Me.TableAdapterManager.UpdateOrder = WindowsApp7.Database2DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1210, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.Chart1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "Chart of Year VS Yield per Hectare"
        CType(Me.YeildPerHectareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YeildPerHectareBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents YeildPerHectareBindingSource As BindingSource
    Friend WithEvents Yeild_per_hectareTableAdapter As Database1DataSetTableAdapters.yeild_per_hectareTableAdapter
    Friend WithEvents YeildPerHectareBindingSource1 As BindingSource
    Friend WithEvents Database2DataSetBindingSource As BindingSource
    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents Database2DataSet1 As Database2DataSet1
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database2DataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents close As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database2DataSet3 As Database2DataSet3
    Friend WithEvents Table1BindingSource1 As BindingSource
    Friend WithEvents Table1TableAdapter1 As Database2DataSet3TableAdapters.Table1TableAdapter
    Friend WithEvents Database2DataSet4 As Database2DataSet4
    Friend WithEvents Table1BindingSource2 As BindingSource
    Friend WithEvents Table1TableAdapter2 As Database2DataSet4TableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Database2DataSet4TableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YeildPerHectareEstateKgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents max As Button
    Friend WithEvents min As Button
    Friend WithEvents sum As Button
    Friend WithEvents avg As Button
End Class
