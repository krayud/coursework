Public Class Form5

    Private Sub TruckingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TruckingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TruckingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarriercompanyDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.transport". При необходимости она может быть перемещена или удалена.
        Me.TransportTableAdapter.Fill(Me.CarriercompanyDataSet.transport)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.truckings". При необходимости она может быть перемещена или удалена.
        Me.TruckingsTableAdapter.Fill(Me.CarriercompanyDataSet.truckings)

    End Sub
End Class