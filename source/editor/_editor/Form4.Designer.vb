<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim Transport_idLabel As System.Windows.Forms.Label
        Dim Distance_kmLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Me.CarriercompanyDataSet = New _editor.carriercompanyDataSet()
        Me.TrafficBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrafficTableAdapter = New _editor.carriercompanyDataSetTableAdapters.trafficTableAdapter()
        Me.TableAdapterManager = New _editor.carriercompanyDataSetTableAdapters.TableAdapterManager()
        Me.TrafficBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TrafficBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Distance_kmTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TransportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportTableAdapter = New _editor.carriercompanyDataSetTableAdapters.transportTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Transport_idLabel = New System.Windows.Forms.Label()
        Distance_kmLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrafficBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrafficBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrafficBindingNavigator.SuspendLayout()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarriercompanyDataSet
        '
        Me.CarriercompanyDataSet.DataSetName = "carriercompanyDataSet"
        Me.CarriercompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrafficBindingSource
        '
        Me.TrafficBindingSource.DataMember = "traffic"
        Me.TrafficBindingSource.DataSource = Me.CarriercompanyDataSet
        '
        'TrafficTableAdapter
        '
        Me.TrafficTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.brigadesTableAdapter = Nothing
        Me.TableAdapterManager.brigadiersTableAdapter = Nothing
        Me.TableAdapterManager.driversTableAdapter = Nothing
        Me.TableAdapterManager.marksTableAdapter = Nothing
        Me.TableAdapterManager.mastersTableAdapter = Nothing
        Me.TableAdapterManager.trafficTableAdapter = Me.TrafficTableAdapter
        Me.TableAdapterManager.transport_typesTableAdapter = Nothing
        Me.TableAdapterManager.transportTableAdapter = Me.TransportTableAdapter
        Me.TableAdapterManager.truckingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _editor.carriercompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.workersTableAdapter = Nothing
        Me.TableAdapterManager.workshopsTableAdapter = Nothing
        '
        'TrafficBindingNavigator
        '
        Me.TrafficBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TrafficBindingNavigator.BindingSource = Me.TrafficBindingSource
        Me.TrafficBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TrafficBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TrafficBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TrafficBindingNavigatorSaveItem})
        Me.TrafficBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TrafficBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TrafficBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TrafficBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TrafficBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TrafficBindingNavigator.Name = "TrafficBindingNavigator"
        Me.TrafficBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TrafficBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.TrafficBindingNavigator.TabIndex = 0
        Me.TrafficBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'TrafficBindingNavigatorSaveItem
        '
        Me.TrafficBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TrafficBindingNavigatorSaveItem.Image = CType(resources.GetObject("TrafficBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TrafficBindingNavigatorSaveItem.Name = "TrafficBindingNavigatorSaveItem"
        Me.TrafficBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TrafficBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Transport_idLabel
        '
        Transport_idLabel.AutoSize = True
        Transport_idLabel.Location = New System.Drawing.Point(12, 64)
        Transport_idLabel.Name = "Transport_idLabel"
        Transport_idLabel.Size = New System.Drawing.Size(89, 13)
        Transport_idLabel.TabIndex = 1
        Transport_idLabel.Text = "Гос. рег. номер:"
        '
        'Distance_kmLabel
        '
        Distance_kmLabel.AutoSize = True
        Distance_kmLabel.Location = New System.Drawing.Point(12, 91)
        Distance_kmLabel.Name = "Distance_kmLabel"
        Distance_kmLabel.Size = New System.Drawing.Size(66, 13)
        Distance_kmLabel.TabIndex = 3
        Distance_kmLabel.Text = "Дистанция:"
        '
        'Distance_kmTextBox
        '
        Me.Distance_kmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrafficBindingSource, "distance_km", True))
        Me.Distance_kmTextBox.Location = New System.Drawing.Point(107, 88)
        Me.Distance_kmTextBox.Name = "Distance_kmTextBox"
        Me.Distance_kmTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Distance_kmTextBox.TabIndex = 4
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 120)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(36, 13)
        DateLabel.TabIndex = 5
        DateLabel.Text = "Дата:"

        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TrafficBindingSource, "date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(54, 114)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(174, 20)
        Me.DateDateTimePicker.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TrafficBindingSource, "transport_id", True))
        Me.ComboBox1.DataSource = Me.TransportBindingSource
        Me.ComboBox1.DisplayMember = "number"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "id"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Пробег:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Distance_kmLabel)
        Me.Controls.Add(Me.Distance_kmTextBox)
        Me.Controls.Add(Transport_idLabel)
        Me.Controls.Add(Me.TrafficBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "Редактировать"
        CType(Me.CarriercompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrafficBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrafficBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrafficBindingNavigator.ResumeLayout(False)
        Me.TrafficBindingNavigator.PerformLayout()
        CType(Me.TransportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CarriercompanyDataSet As _editor.carriercompanyDataSet
    Friend WithEvents TrafficBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrafficTableAdapter As _editor.carriercompanyDataSetTableAdapters.trafficTableAdapter
    Friend WithEvents TableAdapterManager As _editor.carriercompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrafficBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TrafficBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Distance_kmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransportTableAdapter As _editor.carriercompanyDataSetTableAdapters.transportTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TransportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
