Public Class Form4

    Private Sub TrafficBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TrafficBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TrafficBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarriercompanyDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.transport". При необходимости она может быть перемещена или удалена.
        Me.TransportTableAdapter.Fill(Me.CarriercompanyDataSet.transport)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.traffic". При необходимости она может быть перемещена или удалена.
        Me.TrafficTableAdapter.Fill(Me.CarriercompanyDataSet.traffic)

    End Sub

   
End Class