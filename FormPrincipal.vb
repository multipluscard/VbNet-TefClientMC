Imports System.Runtime.InteropServices
Imports System.Threading

Public Class FormPrincipal
    Public Enum enTipo
        CREDITO = 1
        CREDITO_A_VISTA = 2
        CREDITO_PARC_LOJA = 3
        CREDITO_PAR_ADM = 4
        DEBITO = 5
        ADM = 6
        CANCELAR = 7
        ATV = 8
        RELATORIO = 9
        SOLICITAR_CPF = 10
        LINK_PAGO = 21
        PARCELE_MAIS = 22
        SPLIT_PGTO = 23
        REIMPRESSAO = 24
        REIMPRESSAODIRETO = 25
        CONFIRMA = 26
        DEBITO_A_VISTA = 27
        VENDE_CARTEIRA_DIGITAL_PIX = 28
        LISTAR_LINK_PAGO = 29
        MANUTENCAO_LINK_PAGO = 30

    End Enum

    Public sCNPJCliente As String
    Public sCNPJParceiro As String
    Private sTelefone As String = ""
    Private sTexto As String = ""
    Private sData As String = ""
    Private sControle As String = ""
    Private sRetorno As String = String.Empty

    Private dValor As Double = 0
    Private iCupom As Integer = 0
    Private iParcelas As Integer = 0

    Private sItens As String = ""
    Private iQtdeItens As Integer = 0

#Region "DLL"
    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeCredito(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeCreditoVista(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeCreditoParcLoja(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iParcelas As Integer, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeCreditoParcAdm(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iParcelas As Integer, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeDebito(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeDebitoAVista(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Confirmar(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iNumeroCupom As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Cancelar(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iCupom As Integer, ByVal sControle As String, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Desfazimento(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iNumeroCupom As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function VendeCarteiraDigitalPix(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function LinkPagamento(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal Parcelas As Integer, ByVal dValor As Double, ByVal iNumeroCupom As Integer,
                                          ByVal iQtdeItens As Integer, ByVal sItens As String, ByVal sTelefone As String, ByVal sTexto As String, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function ListarLinkPagamentoPago(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Adm(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Atv(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function SolicitarCPF(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iNumeroCupom As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Reimpressao(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function ReimpressaoDireto(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal sNSU As String, ByVal sData As String, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Relatorio(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function

    <DllImport("TefClientmc.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function ParceleMais(ByVal sCNPJCliente As String, ByVal sCNPJParceiro As String, ByVal dValor As Double, ByVal iNumeroCupom As Integer, ByVal iLeitor As Integer) As <MarshalAs(UnmanagedType.AnsiBStr)>
    String
    End Function
#End Region

    Public Sub New()
        InitializeComponent()
        textData.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub


    Private Sub Transacionar(ByVal tipo As enTipo)
        Try

            Dim vLinhas As List(Of String) = New List(Of String)()
            Dim vTipos As List(Of String) = New List(Of String)()

            sRetorno = String.Empty
            sCNPJCliente = txbCnpj.Text.Trim()
            sCNPJParceiro = txbCnpjParceiro.Text.Trim()
            sTelefone = textTelefone.Text.Trim()
            sTexto = textTexto.Text.Trim()
            sData = textData.Text.Trim()
            sControle = txbControle.Text.Trim()
            sItens = tbItens.Text.Trim()

            Dim sRetornoTransacao = String.Empty
            Dim sMensagemTransacao = String.Empty
            Dim sComprovanteTransacao = String.Empty

            Double.TryParse(txbValor.Text, dValor)
            Integer.TryParse(txbCupom.Text, iCupom)
            Integer.TryParse(txbParcelas.Text, iParcelas)
            Integer.TryParse(tbItens.Text, iQtdeItens)


            If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) Then
                MessageBox.Show("Os campos de CNPJ devem ser preenchidos")
                Return
            End If

            Select Case tipo
                Case enTipo.CREDITO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeCredito(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.CREDITO_A_VISTA
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeCreditoVista(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.CONFIRMA
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = Confirmar(sCNPJCliente, sCNPJParceiro, iCupom)

                Case enTipo.CANCELAR
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse String.IsNullOrWhiteSpace(sControle) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = Cancelar(sCNPJCliente, sCNPJParceiro, dValor, iCupom, sControle, 0)

                Case enTipo.CREDITO_PARC_LOJA
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse iParcelas = 0 OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeCreditoParcLoja(sCNPJCliente, sCNPJParceiro, iParcelas, dValor, iCupom, 0)

                Case enTipo.CREDITO_PAR_ADM
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse iParcelas = 0 OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeCreditoParcAdm(sCNPJCliente, sCNPJParceiro, iParcelas, dValor, iCupom, 0)

                Case enTipo.DEBITO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeDebito(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.DEBITO_A_VISTA
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeDebitoAVista(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.VENDE_CARTEIRA_DIGITAL_PIX
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = VendeCarteiraDigitalPix(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.LINK_PAGO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse String.IsNullOrWhiteSpace(sTelefone) OrElse String.IsNullOrWhiteSpace(sTexto) OrElse iParcelas = 0 OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = LinkPagamento(sCNPJCliente, sCNPJParceiro, iParcelas, dValor, iCupom, iQtdeItens, sItens, sTelefone, sTexto, 0)

                Case enTipo.LISTAR_LINK_PAGO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = ListarLinkPagamentoPago(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.ADM
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = Adm(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.ATV
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = Atv(sCNPJCliente, sCNPJParceiro, iCupom, 0)

                Case enTipo.SOLICITAR_CPF
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = SolicitarCPF(sCNPJCliente, sCNPJParceiro, iCupom)

                Case enTipo.REIMPRESSAO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = Reimpressao(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)

                Case enTipo.REIMPRESSAODIRETO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse String.IsNullOrWhiteSpace(sControle) OrElse String.IsNullOrWhiteSpace(sData) OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = ReimpressaoDireto(sCNPJCliente, sCNPJParceiro, sControle, sData, iCupom, 0)

                Case enTipo.RELATORIO
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = Relatorio(sCNPJCliente, sCNPJParceiro, iCupom, 0)

                Case enTipo.PARCELE_MAIS
                    If String.IsNullOrWhiteSpace(sCNPJCliente) OrElse String.IsNullOrWhiteSpace(sCNPJParceiro) OrElse dValor = 0 OrElse iCupom = 0 Then
                        MessageBox.Show("Verifique os campos solicitados.")
                        Return
                    End If
                    sRetorno = ParceleMais(sCNPJCliente, sCNPJParceiro, dValor, iCupom, 0)
            End Select

            If String.IsNullOrWhiteSpace(sRetorno) Then Return

            'RETORNO
            sRetorno = sRetorno.Replace(Environment.NewLine, "¬")
            vLinhas = sRetorno.Split("¬"c).ToList()
            For Each sLinha In vLinhas
                vTipos = sLinha.Split(";"c).ToList()
                If vTipos(0) = "S" Then
                    sRetornoTransacao = vTipos(1)
                    sMensagemTransacao = vTipos(2)

                    If sRetornoTransacao Is "0" Then
                        MessageBox.Show(sMensagemTransacao)
                        Return
                    End If
                Else
                    If vTipos(0) = "I" Then sComprovanteTransacao = sComprovanteTransacao + vTipos(1) & Environment.NewLine
                End If
            Next

            MessageBox.Show(sMensagemTransacao & Environment.NewLine + sComprovanteTransacao)
            sRetorno = Confirmar(sCNPJCliente, sCNPJParceiro, 12345)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#Region "Funções"
    Private Sub Credito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreditoAVista.Click
        Transacionar(enTipo.CREDITO_A_VISTA)
    End Sub
    Private Sub CreditoParcelamentoLoja_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreditoParcelaLoja.Click
        Transacionar(enTipo.CREDITO_PARC_LOJA)
    End Sub
    Private Sub CreditoParcelamentoADM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreditoParcelaAdm.Click
        Transacionar(enTipo.CREDITO_PAR_ADM)
    End Sub
    Private Sub VendeDebito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVendeDebito.Click
        Transacionar(enTipo.DEBITO)
    End Sub
    Private Sub VendeDebitoAVista_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVendeDebitoAVista.Click
        Transacionar(enTipo.DEBITO_A_VISTA)
    End Sub
    Private Sub CancelarCreditoDebito_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelarDebitoCredito.Click
        Transacionar(enTipo.CANCELAR)
    End Sub
    Private Sub VendeCarteiraDigitalPIX_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviaPix.Click
        Transacionar(enTipo.VENDE_CARTEIRA_DIGITAL_PIX)
    End Sub
    Private Sub LinkPagamento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviaLinkPago.Click
        Transacionar(enTipo.LINK_PAGO)
    End Sub
    Private Sub ListarLinkPagamento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnListaLinkPago.Click
        Transacionar(enTipo.LISTAR_LINK_PAGO)
    End Sub
    Private Sub ADM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdm.Click
        Transacionar(enTipo.ADM)
    End Sub
    Private Sub ATV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtv.Click
        Transacionar(enTipo.ATV)
    End Sub
    Private Sub SolicitarCPF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSolicitarCPF.Click
        Transacionar(enTipo.SOLICITAR_CPF)
    End Sub
    Private Sub Reimpressao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReimpressao.Click
        Transacionar(enTipo.REIMPRESSAO)
    End Sub
    Private Sub ReimpressaoDireta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReimpressaoDireta.Click
        Transacionar(enTipo.REIMPRESSAODIRETO)
    End Sub
    Private Sub Relatorio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelatorio.Click
        Transacionar(enTipo.RELATORIO)
    End Sub
    Private Sub ParceleMais_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnParceleMais.Click
        Transacionar(enTipo.PARCELE_MAIS)
    End Sub
    Private Sub CANCELARPIX_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelarPix.Click
        Transacionar(enTipo.CANCELAR)
    End Sub

    Private Sub btnManutLink_Click(sender As Object, e As EventArgs) Handles btnManutLink.Click
        Transacionar(enTipo.MANUTENCAO_LINK_PAGO)
    End Sub
#End Region


End Class
