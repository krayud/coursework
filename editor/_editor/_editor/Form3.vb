Public Class Form3

   
    Private Sub TransportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransportBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarriercompanyDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet1.marks". При необходимости она может быть перемещена или удалена.
        Me.MarksTableAdapter.Fill(Me.CarriercompanyDataSet1.marks)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet1.transport_types". При необходимости она может быть перемещена или удалена.
        Me.Transport_typesTableAdapter.Fill(Me.CarriercompanyDataSet1.transport_types)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "CarriercompanyDataSet.transport". При необходимости она может быть перемещена или удалена.
        Me.TransportTableAdapter.Fill(Me.CarriercompanyDataSet.transport)

    End Sub
End Class