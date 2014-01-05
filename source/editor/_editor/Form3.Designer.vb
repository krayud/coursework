<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TypeLabel As System.Windows.Forms.Label
        Dim MarkLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.CarriercompanyDataSet = New _editor.carriercompanyDataSet()
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportTableAdapter = New _editor.carriercompanyDataSetTableAdapters.transportTableAdapter()
        Me.TableAdapterManager = New _editor.carriercompanyDataSetTableAdapters.TableAdapterManager()
        Me.TransportBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TransporttypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarriercompanyDataSet1 = New _editor.carriercompanyDataSet()
        Me.Transport_typesTableAdapter = New _editor.carriercompanyDataSetTableAdapters.transport_typesTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarksTableAdapter = New _editor.carriercompanyDataSetTableAdapters.marksTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        TypeLabel = New System.Windows.Forms.Label()
        MarkLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        NumberLabel = New System.Windows.Forms.Label()
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransportBindingNavigator.SuspendLayout()
        CType(Me.TransporttypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarriercompanyDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(38, 97)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(29, 13)
        TypeLabel.TabIndex = 3
        TypeLabel.Text = "Тип:"
        '
        'MarkLabel
        '
        MarkLabel.AutoSize = True
        MarkLabel.Location = New System.Drawing.Point(38, 70)
        MarkLabel.Name = "MarkLabel"
        MarkLabel.Size = New System.Drawing.Size(43, 13)
        MarkLabel.TabIndex = 5
        MarkLabel.Text = "Марка:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(38, 124)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(65, 13)
        PriceLabel.TabIndex = 7
        PriceLabel.Text = "Стоимость:"
        '
        'NumberLabel
        '
        NumberLabel.AutoSize = True
        NumberLabel.Location = New System.Drawing.Point(38, 150)
        NumberLabel.Name = "NumberLabel"
        NumberLabel.Size = New System.Drawing.Size(89, 13)
        NumberLabel.TabIndex = 9
        NumberLabel.Text = "Гос. рег. номер:"
        '
        'CarriercompanyDataSet
        '
        Me.CarriercompanyDataSet.DataSetName = "carriercompanyDataSet"
        Me.CarriercompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransportBindingSource
        '
        Me.TransportBindingSource.DataMember = "transport"
        Me.TransportBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'TransportTableAdapter
        '
        Me.TransportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.brigadesTableAdapter = Nothing
        Me.TableAdapterManager.brigadiersTableAdapter = Nothing
        Me.TableAdapterManager.driversTableAdapter = Nothing
        Me.TableAdapterManager.marksTableAdapter = Nothing
        Me.TableAdapterManager.mastersTableAdapter = Nothing
        Me.TableAdapterManager.trafficTableAdapter = Nothing
        Me.TableAdapterManager.transport_typesTableAdapter = Nothing
        Me.TableAdapterManager.transportTableAdapter = Me.TransportTableAdapter
        Me.TableAdapterManager.truckingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _editor.carriercompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.workersTableAdapter = Nothing
        Me.TableAdapterManager.workshopsTableAdapter = Nothing
        '
        'TransportBindingNavigator
        '
        Me.TransportBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransportBindingNavigator.BindingSource = Me.TransportBindingSource
        Me.TransportBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransportBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransportBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransportBindingNavigatorSaveItem})
        Me.TransportBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransportBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransportBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransportBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransportBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransportBindingNavigator.Name = "TransportBindingNavigator"
        Me.TransportBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransportBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.TransportBindingNavigator.TabIndex = 0
        Me.TransportBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TransportBindingNavigatorSaveItem
        '
        Me.TransportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransportBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransportBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransportBindingNavigatorSaveItem.Name = "TransportBindingNavigatorSaveItem"
        Me.TransportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TransportBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(110, 121)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransportBindingSource, "type", True))
        Me.ComboBox1.DataSource = Me.TransporttypesBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(89, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.ValueMember = "id"
        '
        'TransporttypesBindingSource
        '
        Me.TransporttypesBindingSource.DataMember = "transport_types"
        Me.TransporttypesBindingSource.DataSource = Me.CarriercompanyDataSet1
        '
        'CarriercompanyDataSet1
        '
        Me.CarriercompanyDataSet1.DataSetName = "carriercompanyDataSet"
        Me.CarriercompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Transport_typesTableAdapter
        '
        Me.Transport_typesTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransportBindingSource, "mark", True))
        Me.ComboBox2.DataSource = Me.MarksBindingSource
        Me.ComboBox2.DisplayMember = "name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(89, 67)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 12
        Me.ComboBox2.ValueMember = "id"
        '
        'MarksBindingSource
        '
        Me.MarksBindingSource.DataMember = "marks"
        Me.MarksBindingSource.DataSource = Me.CarriercompanyDataSet1
        '
        'MarksTableAdapter
        '
        Me.MarksTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Транспорт:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBindingSource, "number", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(133, 147)
        Me.MaskedTextBox1.Mask = "L000LL"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(77, 20)
        Me.MaskedTextBox1.TabIndex = 14
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(MarkLabel)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(NumberLabel)
        Me.Controls.Add(Me.TransportBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Редактировать"
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransportBindingNavigator.ResumeLayout(False)
        Me.TransportBindingNavigator.PerformLayout()
        CType(Me.TransporttypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarriercompanyDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarriercompanyDataSet As _editor.carriercompanyDataSet
    Friend WithEvents TransportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransportTableAdapter As _editor.carriercompanyDataSetTableAdapters.transportTableAdapter
    Friend WithEvents TableAdapterManager As _editor.carriercompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransportBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TransportBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CarriercompanyDataSet1 As _editor.carriercompanyDataSet
    Friend WithEvents TransporttypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Transport_typesTableAdapter As _editor.carriercompanyDataSetTableAdapters.transport_typesTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarksTableAdapter As _editor.carriercompanyDataSetTableAdapters.marksTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
