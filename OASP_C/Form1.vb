Imports OASP_C.ExBodegaService
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim objetoLeer As New WSDL_BODEGAS.ReadResponse
            objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaReadByIDResponseMessage_sync
            Dim cliente As New WSDL_BODEGAS.Y640YVQUY_WSDL_BODEGASClient
            cliente.ClientCredentials.UserName.UserName = "_BODEGACS"
            cliente.ClientCredentials.UserName.Password = "Welcome08"
            Dim leerrequest As New WSDL_BODEGAS.ReadRequest
            cliente.Open()
            leerrequest.EX_BodegaExistencia_BodegaReadByIDQuery_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaReadByIDQueryMessage_sync
            leerrequest.EX_BodegaExistencia_BodegaReadByIDQuery_sync.EX_Bodega = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaReadByIDQuery
            leerrequest.EX_BodegaExistencia_BodegaReadByIDQuery_sync.EX_Bodega.Id = TextBox1.Text
            objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaReadByIDResponseMessage_sync
            objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync = cliente.Read(leerrequest.EX_BodegaExistencia_BodegaReadByIDQuery_sync)
                TextBox2.Text = objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync.EX_Bodega.CodAlmacen.Value.ToString
                TextBox3.Text = objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync.EX_Bodega.Nalmacen.Value.ToString
                TextBox4.Text = objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync.EX_Bodega.Citem.Value.ToString
                TextBox5.Text = objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync.EX_Bodega.Ditem.Value.ToString
                TextBox6.Text = objetoLeer.EX_BodegaExistencia_BodegaReadByIDResponse_sync.EX_Bodega.CantDisp.Value.ToString
            ' MessageBox.Show(ajjj.IF_BodegaReadByIDResponse_sync.IF_Bodega.SAP_UUID.ToString)
            cliente.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim objetoEscribir As New WSDL_BODEGAS.CreateResponse
            Dim cliente As New WSDL_BODEGAS.Y640YVQUY_WSDL_BODEGASClient
            cliente.ClientCredentials.UserName.UserName = "_BODEGACS"
            cliente.ClientCredentials.UserName.Password = "Welcome08"
            Dim leerrequest As New WSDL_BODEGAS.CreateRequest
            cliente.Open()
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaCreateRequestMessage_sync
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaCreateRequest
            objetoEscribir.EX_BodegaExistencia_BodegaCreateConfirmation_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaCreateConfirmationMessage_sync
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Id = TextBox1.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CodAlmacen = New WSDL_BODEGAS.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CodAlmacen.Value = TextBox2.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Nalmacen = New WSDL_BODEGAS.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Nalmacen.Value = TextBox3.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Citem = New WSDL_BODEGAS.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Citem.Value = TextBox4.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Ditem = New WSDL_BODEGAS.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Ditem.Value = TextBox5.Text
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CantDisp = New WSDL_BODEGAS.Quantity
            leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CantDisp.Value = TextBox6.Text
            objetoEscribir.EX_BodegaExistencia_BodegaCreateConfirmation_sync = cliente.Create(leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync)
            cliente.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objetoActualizar As New WSDL_BODEGAS.UpdateResponse
        Dim cliente As New WSDL_BODEGAS.Y640YVQUY_WSDL_BODEGASClient
        cliente.ClientCredentials.UserName.UserName = "_BODEGACS"
        cliente.ClientCredentials.UserName.Password = "Welcome08"
        Dim leerrequest As New WSDL_BODEGAS.UpdateRequest
        cliente.Open()
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaUpdateRequestMessage_sync
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaUpdateRequest
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Id = TextBox1.Text
        objetoActualizar.EX_BodegaExistencia_BodegaUpdateConfirmation_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaUpdateConfirmationMessage_sync
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.CodAlmacen = New WSDL_BODEGAS.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.CodAlmacen.Value = TextBox2.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Nalmacen = New WSDL_BODEGAS.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Nalmacen.Value = TextBox3.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Citem = New WSDL_BODEGAS.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Citem.Value = TextBox4.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Ditem = New WSDL_BODEGAS.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.Ditem.Value = TextBox5.Text
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.CantDisp = New WSDL_BODEGAS.Quantity
        leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync.EX_Bodega.CantDisp.Value = TextBox6.Text
        objetoActualizar.EX_BodegaExistencia_BodegaUpdateConfirmation_sync = cliente.Update(leerrequest.EX_BodegaExistencia_BodegaUpdateRequest_sync)
        MessageBox.Show("asdf")
        cliente.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim request As W.GetBodegaType = New W.GetBodegaType
        'request.ToString()
        Dim response As W.GetBodegaResponseType = New W.GetBodegaResponseType

        Try
            Dim cliente As W.ipostep_vP0010000101in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient =
            New W.ipostep_vP0010000101in_WCSX_comsapb1ivplatformruntime_INB_WS_CALL_SYNC_XPT_INB_WS_CALL_SYNC_XPTipo_procClient

            cliente.ClientCredentials.UserName.UserName = "B1iruntime"
            cliente.ClientCredentials.UserName.Password = "12345678"
            cliente.Open()
            response = cliente.ZGetBodega(request)
            Dim val As Integer
            val = 2
            For Each a As W.GetBodegaResponseTypeRow In response.GetBodegaResult

                DataGridView1.Rows.Add(New String() {a.WhsCode, a.WhsName, a.itemcode, a.Dscription, a.OnHand})
                cliente.Close()
                Dim objetoEscribir As New WSDL_BODEGAS.CreateResponse
                Dim cliente2 As New WSDL_BODEGAS.Y640YVQUY_WSDL_BODEGASClient
                cliente2.ClientCredentials.UserName.UserName = "_BODEGACS"
                cliente2.ClientCredentials.UserName.Password = "Welcome08"
                Dim leerrequest As New WSDL_BODEGAS.CreateRequest
                cliente2.Open()
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaCreateRequestMessage_sync
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaCreateRequest
                objetoEscribir.EX_BodegaExistencia_BodegaCreateConfirmation_sync = New WSDL_BODEGAS.EX_BodegaExistencia_BodegaCreateConfirmationMessage_sync
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Id = val
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CodAlmacen = New WSDL_BODEGAS.Text
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CodAlmacen.Value = a.WhsCode
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Nalmacen = New WSDL_BODEGAS.Text
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Nalmacen.Value = a.WhsName
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Citem = New WSDL_BODEGAS.Text
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Citem.Value = a.itemcode
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Ditem = New WSDL_BODEGAS.Text
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.Ditem.Value = a.Dscription
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CantDisp = New WSDL_BODEGAS.Quantity
                leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync.EX_Bodega.CantDisp.Value = a.OnHand
                objetoEscribir.EX_BodegaExistencia_BodegaCreateConfirmation_sync = cliente2.Create(leerrequest.EX_BodegaExistencia_BodegaCreateRequest_sync)
                cliente2.Close()
                val = val + 1
            Next

            'Dim row As W.GetBodegaResponseTypeRow = response.GetBodegaResult.GetValue(1)
            'DataGridView1.Rows.Add(New String() {row.WhsCode, row.WhsName, row.itemcode, row.Dscription, row.OnHand})
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        'MessageBox.Show("DobleClick")
        Button4_Click(sender, e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button4_Click(sender, e)
    End Sub

End Class
