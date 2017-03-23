Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim objetoLeer As New WSDL_BODEGAS.ReadResponse
            objetoLeer.IF_BodegaReadByIDResponse_sync = New WSDL_BODEGAS.IF_BodegaReadByIDResponseMessage_sync
            Dim cliente As New WSDL_BODEGAS.Y640YVQUY_WBodegaClient
            cliente.ClientCredentials.UserName.UserName = "_BODEGAS"
            cliente.ClientCredentials.UserName.Password = "Welcome08"
            Dim leerrequest As New WSDL_BODEGAS.ReadRequest
            cliente.Open()
            leerrequest.IF_BodegaReadByIDQuery_sync = New WSDL_BODEGAS.IF_BodegaReadByIDQueryMessage_sync
            leerrequest.IF_BodegaReadByIDQuery_sync.IF_Bodega = New WSDL_BODEGAS.IF_BodegaReadByIDQuery
            leerrequest.IF_BodegaReadByIDQuery_sync.IF_Bodega.CodAlmacen = TextBox1.Text
            objetoLeer.IF_BodegaReadByIDResponse_sync = New WSDL_BODEGAS.IF_BodegaReadByIDResponseMessage_sync
            objetoLeer.IF_BodegaReadByIDResponse_sync = cliente.Read(leerrequest.IF_BodegaReadByIDQuery_sync)
            TextBox2.Text = objetoLeer.IF_BodegaReadByIDResponse_sync.IF_Bodega.Nalmacen.Value.ToString
            TextBox3.Text = objetoLeer.IF_BodegaReadByIDResponse_sync.IF_Bodega.Citem.Value.ToString
            TextBox4.Text = objetoLeer.IF_BodegaReadByIDResponse_sync.IF_Bodega.Ditem.Value.ToString
            TextBox5.Text = objetoLeer.IF_BodegaReadByIDResponse_sync.IF_Bodega.CantDisp.Value.ToString
            ' MessageBox.Show(ajjj.IF_BodegaReadByIDResponse_sync.IF_Bodega.SAP_UUID.ToString)
            cliente.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim objetoEscribir As New WSDL_BODEGAS.CreateResponse
            objetoEscribir.IF_BodegaCreateConfirmation_sync = New WSDL_BODEGAS.IF_BodegaCreateConfirmationMessage_sync
            Dim cliente As New WSDL_BODEGAS.Y640YVQUY_WBodegaClient
            cliente.ClientCredentials.UserName.UserName = "_BODEGAS"
            cliente.ClientCredentials.UserName.Password = "Welcome08"
            Dim leerrequest As New WSDL_BODEGAS.CreateRequest
            cliente.Open()
            leerrequest.IF_BodegaCreateRequest_sync = New WSDL_BODEGAS.IF_BodegaCreateRequestMessage_sync
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega = New WSDL_BODEGAS.IF_BodegaCreateRequest
            objetoEscribir.IF_BodegaCreateConfirmation_sync = New WSDL_BODEGAS.IF_BodegaCreateConfirmationMessage_sync
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.CodAlmacen = TextBox1.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.Nalmacen = New WSDL_BODEGAS.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.Nalmacen.Value = TextBox2.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.Citem = New WSDL_BODEGAS.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.Citem.Value = TextBox3.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.Ditem = New WSDL_BODEGAS.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.Ditem.Value = TextBox4.Text
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.CantDisp = New WSDL_BODEGAS.Quantity
            leerrequest.IF_BodegaCreateRequest_sync.IF_Bodega.CantDisp.Value = TextBox5.Text
            objetoEscribir.IF_BodegaCreateConfirmation_sync = cliente.Create(leerrequest.IF_BodegaCreateRequest_sync)
            ' MessageBox.Show(ajjj.IF_BodegaReadByIDResponse_sync.IF_Bodega.SAP_UUID.ToString)
            cliente.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objetoActualizar As New WSDL_BODEGAS.UpdateResponse
        objetoActualizar.IF_BodegaUpdateConfirmation_sync = New WSDL_BODEGAS.IF_BodegaUpdateConfirmationMessage_sync
        Dim cliente As New WSDL_BODEGAS.Y640YVQUY_WBodegaClient
        cliente.ClientCredentials.UserName.UserName = "_BODEGAS"
        cliente.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequest As New WSDL_BODEGAS.UpdateRequest
        cliente.Open()
        leerrequest.IF_BodegaUpdateRequest_sync = New WSDL_BODEGAS.IF_BodegaUpdateRequestMessage_sync
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega = New WSDL_BODEGAS.IF_BodegaUpdateRequest
        objetoActualizar.IF_BodegaUpdateConfirmation_sync = New WSDL_BODEGAS.IF_BodegaUpdateConfirmationMessage_sync

        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.CodAlmacen = TextBox1.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.Nalmacen = New WSDL_BODEGAS.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.Nalmacen.Value = TextBox2.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.Citem = New WSDL_BODEGAS.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.Citem.Value = TextBox3.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.Ditem = New WSDL_BODEGAS.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.Ditem.Value = TextBox4.Text
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.CantDisp = New WSDL_BODEGAS.Quantity
        leerrequest.IF_BodegaUpdateRequest_sync.IF_Bodega.CantDisp.Value = TextBox5.Text
        objetoActualizar.IF_BodegaUpdateConfirmation_sync = cliente.Update(leerrequest.IF_BodegaUpdateRequest_sync)
        ' MessageBox.Show(ajjj.IF_BodegaReadByIDResponse_sync.IF_Bodega.SAP_UUID.ToString)
        MessageBox.Show("Actualizo Correctamente")
        cliente.Close()
    End Sub
End Class
