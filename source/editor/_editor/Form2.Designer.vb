<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim Brigade_idLabel As System.Windows.Forms.Label
        Dim Car_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CarriercompanyDataSet = New _editor.carriercompanyDataSet()
        Me.DriversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriversTableAdapter = New _editor.carriercompanyDataSetTableAdapters.driversTableAdapter()
        Me.TableAdapterManager = New _editor.carriercompanyDataSetTableAdapters.TableAdapterManager()
        Me.BrigadesTableAdapter = New _editor.carriercompanyDataSetTableAdapters.brigadesTableAdapter()
        Me.TransportTableAdapter = New _editor.carriercompanyDataSetTableAdapters.transportTableAdapter()
        Me.DriversBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DriversBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Brigade_idComboBox = New System.Windows.Forms.ComboBox()
        Me.BrigadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Brigade_idLabel = New System.Windows.Forms.Label()
        Car_idLabel = New System.Windows.Forms.Label()
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DriversBindingNavigator.SuspendLayout()
        CType(Me.BrigadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(35, 69)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(37, 13)
        NameLabel.TabIndex = 1
        NameLabel.Text = "ФИО:"
        '
        'Brigade_idLabel
        '
        Brigade_idLabel.AutoSize = True
        Brigade_idLabel.Location = New System.Drawing.Point(35, 96)
        Brigade_idLabel.Name = "Brigade_idLabel"
        Brigade_idLabel.Size = New System.Drawing.Size(52, 13)
        Brigade_idLabel.TabIndex = 3
        Brigade_idLabel.Text = "Бригада:"
        '
        'Car_idLabel
        '
        Car_idLabel.AutoSize = True
        Car_idLabel.Location = New System.Drawing.Point(35, 123)
        Car_idLabel.Name = "Car_idLabel"
        Car_idLabel.Size = New System.Drawing.Size(72, 13)
        Car_idLabel.TabIndex = 5
        Car_idLabel.Text = "Автомобиль:"
        '
        'CarriercompanyDataSet
        '
        Me.CarriercompanyDataSet.DataSetName = "carriercompanyDataSet"
        Me.CarriercompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DriversBindingSource
        '
        Me.DriversBindingSource.DataMember = "drivers"
        Me.DriversBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'DriversTableAdapter
        '
        Me.DriversTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.brigadesTableAdapter = Me.BrigadesTableAdapter
        Me.TableAdapterManager.brigadiersTableAdapter = Nothing
        Me.TableAdapterManager.driversTableAdapter = Me.DriversTableAdapter
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
        'BrigadesTableAdapter
        '
        Me.BrigadesTableAdapter.ClearBeforeFill = True
        '
        'TransportTableAdapter
        '
        Me.TransportTableAdapter.ClearBeforeFill = True
        '
        'DriversBindingNavigator
        '
        Me.DriversBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DriversBindingNavigator.BindingSource = Me.DriversBindingSource
        Me.DriversBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DriversBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DriversBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DriversBindingNavigatorSaveItem})
        Me.DriversBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DriversBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DriversBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DriversBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DriversBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DriversBindingNavigator.Name = "DriversBindingNavigator"
        Me.DriversBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DriversBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.DriversBindingNavigator.TabIndex = 0
        Me.DriversBindingNavigator.Text = "BindingNavigator1"
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
        'DriversBindingNavigatorSaveItem
        '
        Me.DriversBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DriversBindingNavigatorSaveItem.Image = CType(resources.GetObject("DriversBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DriversBindingNavigatorSaveItem.Name = "DriversBindingNavigatorSaveItem"
        Me.DriversBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DriversBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(78, 66)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(150, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'Brigade_idComboBox
        '
        Me.Brigade_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriversBindingSource, "brigade_id", True))
        Me.Brigade_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DriversBindingSource, "brigade_id", True))
        Me.Brigade_idComboBox.DataSource = Me.BrigadesBindingSource
        Me.Brigade_idComboBox.DisplayMember = "id"
        Me.Brigade_idComboBox.FormattingEnabled = True
        Me.Brigade_idComboBox.Location = New System.Drawing.Point(93, 93)
        Me.Brigade_idComboBox.Name = "Brigade_idComboBox"
        Me.Brigade_idComboBox.Size = New System.Drawing.Size(135, 21)
        Me.Brigade_idComboBox.TabIndex = 4
        Me.Brigade_idComboBox.ValueMember = "id"
        '
        'BrigadesBindingSource
        '
        Me.BrigadesBindingSource.DataMember = "brigades"
        Me.BrigadesBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'TransportBindingSource
        '
        Me.TransportBindingSource.DataMember = "transport"
        Me.TransportBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DriversBindingSource, "car_id", True))
        Me.ComboBox1.DataSource = Me.TransportBindingSource
        Me.ComboBox1.DisplayMember = "number"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Водители:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Car_idLabel)
        Me.Controls.Add(Brigade_idLabel)
        Me.Controls.Add(Me.Brigade_idComboBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DriversBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Редактировать"
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DriversBindingNavigator.ResumeLayout(False)
        Me.DriversBindingNavigator.PerformLayout()
        CType(Me.BrigadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarriercompanyDataSet As _editor.carriercompanyDataSet
    Friend WithEvents DriversBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriversTableAdapter As _editor.carriercompanyDataSetTableAdapters.driversTableAdapter
    Friend WithEvents TableAdapterManager As _editor.carriercompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DriversBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DriversBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brigade_idComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BrigadesTableAdapter As _editor.carriercompanyDataSetTableAdapters.brigadesTableAdapter
    Friend WithEvents BrigadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransportTableAdapter As _editor.carriercompanyDataSetTableAdapters.transportTableAdapter
    Friend WithEvents TransportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
