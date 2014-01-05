<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Car_idLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.CarriercompanyDataSet = New _editor.carriercompanyDataSet()
        Me.TruckingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TruckingsTableAdapter = New _editor.carriercompanyDataSetTableAdapters.truckingsTableAdapter()
        Me.TableAdapterManager = New _editor.carriercompanyDataSetTableAdapters.TableAdapterManager()
        Me.TransportTableAdapter = New _editor.carriercompanyDataSetTableAdapters.transportTableAdapter()
        Me.TruckingsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TruckingsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Car_idLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TruckingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TruckingsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TruckingsBindingNavigator.SuspendLayout()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car_idLabel
        '
        Car_idLabel.AutoSize = True
        Car_idLabel.Location = New System.Drawing.Point(13, 58)
        Car_idLabel.Name = "Car_idLabel"
        Car_idLabel.Size = New System.Drawing.Size(89, 13)
        Car_idLabel.TabIndex = 3
        Car_idLabel.Text = "Гос. рег. номер:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(13, 85)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(33, 13)
        CargoLabel.TabIndex = 5
        CargoLabel.Text = "Груз:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 115)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(36, 13)
        DateLabel.TabIndex = 7
        DateLabel.Text = "Дата:"
        '
        'CarriercompanyDataSet
        '
        Me.CarriercompanyDataSet.DataSetName = "carriercompanyDataSet"
        Me.CarriercompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TruckingsBindingSource
        '
        Me.TruckingsBindingSource.DataMember = "truckings"
        Me.TruckingsBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'TruckingsTableAdapter
        '
        Me.TruckingsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.truckingsTableAdapter = Me.TruckingsTableAdapter
        Me.TableAdapterManager.UpdateOrder = _editor.carriercompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.workersTableAdapter = Nothing
        Me.TableAdapterManager.workshopsTableAdapter = Nothing
        '
        'TransportTableAdapter
        '
        Me.TransportTableAdapter.ClearBeforeFill = True
        '
        'TruckingsBindingNavigator
        '
        Me.TruckingsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TruckingsBindingNavigator.BindingSource = Me.TruckingsBindingSource
        Me.TruckingsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TruckingsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TruckingsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TruckingsBindingNavigatorSaveItem})
        Me.TruckingsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TruckingsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TruckingsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TruckingsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TruckingsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TruckingsBindingNavigator.Name = "TruckingsBindingNavigator"
        Me.TruckingsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TruckingsBindingNavigator.Size = New System.Drawing.Size(294, 25)
        Me.TruckingsBindingNavigator.TabIndex = 0
        Me.TruckingsBindingNavigator.Text = "BindingNavigator1"
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
        'TruckingsBindingNavigatorSaveItem
        '
        Me.TruckingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TruckingsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TruckingsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TruckingsBindingNavigatorSaveItem.Name = "TruckingsBindingNavigatorSaveItem"
        Me.TruckingsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TruckingsBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TruckingsBindingSource, "cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(86, 82)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CargoTextBox.TabIndex = 6
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TruckingsBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(86, 108)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TruckingsBindingSource, "car_id", True))
        Me.ComboBox1.DataSource = Me.TransportBindingSource
        Me.ComboBox1.DisplayMember = "number"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "id"
        '
        'TransportBindingSource
        '
        Me.TransportBindingSource.DataMember = "transport"
        Me.TransportBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Перевозки:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 162)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Car_idLabel)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.TruckingsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Редактировать"
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TruckingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TruckingsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TruckingsBindingNavigator.ResumeLayout(False)
        Me.TruckingsBindingNavigator.PerformLayout()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarriercompanyDataSet As _editor.carriercompanyDataSet
    Friend WithEvents TruckingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TruckingsTableAdapter As _editor.carriercompanyDataSetTableAdapters.truckingsTableAdapter
    Friend WithEvents TableAdapterManager As _editor.carriercompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TruckingsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TruckingsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransportTableAdapter As _editor.carriercompanyDataSetTableAdapters.transportTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TransportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
