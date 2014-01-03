Public Class Form2

    Private Sub DriversBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DriversBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DriversBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarriercompanyDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.transport". При необходимости она может быть перемещена или удалена.
        Me.TransportTableAdapter.Fill(Me.CarriercompanyDataSet.transport)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.brigades". При необходимости она может быть перемещена или удалена.
        Me.BrigadesTableAdapter.Fill(Me.CarriercompanyDataSet.brigades)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.drivers". При необходимости она может быть перемещена или удалена.
        Me.DriversTableAdapter.Fill(Me.CarriercompanyDataSet.drivers)

    End Sub
End Class