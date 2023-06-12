<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabTipo = New System.Windows.Forms.TabControl()
        Me.tabPageCartao = New System.Windows.Forms.TabPage()
        Me.btnCancelarDebitoCredito = New System.Windows.Forms.Button()
        Me.tabCreditoDebito = New System.Windows.Forms.TabControl()
        Me.tabCredito = New System.Windows.Forms.TabPage()
        Me.btnCreditoAVista = New System.Windows.Forms.Button()
        Me.btnCreditoParcelaAdm = New System.Windows.Forms.Button()
        Me.btnCreditoParcelaLoja = New System.Windows.Forms.Button()
        Me.tabDebito = New System.Windows.Forms.TabPage()
        Me.btnVendeDebitoAVista = New System.Windows.Forms.Button()
        Me.btnVendeDebito = New System.Windows.Forms.Button()
        Me.lbCorOrientacaoCartao = New System.Windows.Forms.Label()
        Me.tabPageQRMultiplus = New System.Windows.Forms.TabPage()
        Me.btnCancelarPix = New System.Windows.Forms.Button()
        Me.tabPix = New System.Windows.Forms.TabControl()
        Me.tabPageQRPix = New System.Windows.Forms.TabPage()
        Me.btnEnviaPix = New System.Windows.Forms.Button()
        Me.lbCorOrientacaoQRMultiplus = New System.Windows.Forms.Label()
        Me.tabPageLinkPago = New System.Windows.Forms.TabPage()
        Me.lbCorOrientacaoLinkPago = New System.Windows.Forms.Label()
        Me.tabLinkPago = New System.Windows.Forms.TabControl()
        Me.tabPageLinkPagoLP = New System.Windows.Forms.TabPage()
        Me.tbItens = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbQtdeItens = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnManutLink = New System.Windows.Forms.Button()
        Me.btnListaLinkPago = New System.Windows.Forms.Button()
        Me.btnEnviaLinkPago = New System.Windows.Forms.Button()
        Me.tabPageClient = New System.Windows.Forms.TabPage()
        Me.lbCorOrientacaoClient = New System.Windows.Forms.Label()
        Me.tabClient = New System.Windows.Forms.TabControl()
        Me.tabPageClientClient = New System.Windows.Forms.TabPage()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.btnReimpressaoDireta = New System.Windows.Forms.Button()
        Me.btnReimpressao = New System.Windows.Forms.Button()
        Me.btnSolicitarCPF = New System.Windows.Forms.Button()
        Me.btnAtv = New System.Windows.Forms.Button()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.tabPageOutros = New System.Windows.Forms.TabPage()
        Me.lbCorOrientacaoOutros = New System.Windows.Forms.Label()
        Me.tabParceleMais = New System.Windows.Forms.TabControl()
        Me.tabPageOutrosParceleMais = New System.Windows.Forms.TabPage()
        Me.btnParceleMais = New System.Windows.Forms.Button()
        Me.panelParametros = New System.Windows.Forms.Panel()
        Me.textTexto = New System.Windows.Forms.TextBox()
        Me.textData = New System.Windows.Forms.TextBox()
        Me.textTelefone = New System.Windows.Forms.TextBox()
        Me.labelTexto = New System.Windows.Forms.Label()
        Me.txbCnpjParceiro = New System.Windows.Forms.TextBox()
        Me.labelData = New System.Windows.Forms.Label()
        Me.txbParcelas = New System.Windows.Forms.TextBox()
        Me.labelTelefone = New System.Windows.Forms.Label()
        Me.txbCnpj = New System.Windows.Forms.TextBox()
        Me.labelParceiro = New System.Windows.Forms.Label()
        Me.txbCupom = New System.Windows.Forms.TextBox()
        Me.txbControle = New System.Windows.Forms.TextBox()
        Me.labelControle = New System.Windows.Forms.Label()
        Me.txbValor = New System.Windows.Forms.TextBox()
        Me.labelCNPJ = New System.Windows.Forms.Label()
        Me.labelValor = New System.Windows.Forms.Label()
        Me.labelParcela = New System.Windows.Forms.Label()
        Me.labelCupom = New System.Windows.Forms.Label()
        Me.tabTipo.SuspendLayout()
        Me.tabPageCartao.SuspendLayout()
        Me.tabCreditoDebito.SuspendLayout()
        Me.tabCredito.SuspendLayout()
        Me.tabDebito.SuspendLayout()
        Me.tabPageQRMultiplus.SuspendLayout()
        Me.tabPix.SuspendLayout()
        Me.tabPageQRPix.SuspendLayout()
        Me.tabPageLinkPago.SuspendLayout()
        Me.tabLinkPago.SuspendLayout()
        Me.tabPageLinkPagoLP.SuspendLayout()
        Me.tabPageClient.SuspendLayout()
        Me.tabClient.SuspendLayout()
        Me.tabPageClientClient.SuspendLayout()
        Me.tabPageOutros.SuspendLayout()
        Me.tabParceleMais.SuspendLayout()
        Me.tabPageOutrosParceleMais.SuspendLayout()
        Me.panelParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTipo
        '
        Me.tabTipo.Controls.Add(Me.tabPageCartao)
        Me.tabTipo.Controls.Add(Me.tabPageQRMultiplus)
        Me.tabTipo.Controls.Add(Me.tabPageLinkPago)
        Me.tabTipo.Controls.Add(Me.tabPageClient)
        Me.tabTipo.Controls.Add(Me.tabPageOutros)
        Me.tabTipo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tabTipo.HotTrack = True
        Me.tabTipo.ItemSize = New System.Drawing.Size(90, 45)
        Me.tabTipo.Location = New System.Drawing.Point(6, 195)
        Me.tabTipo.Multiline = True
        Me.tabTipo.Name = "tabTipo"
        Me.tabTipo.Padding = New System.Drawing.Point(6, 5)
        Me.tabTipo.SelectedIndex = 0
        Me.tabTipo.Size = New System.Drawing.Size(453, 313)
        Me.tabTipo.TabIndex = 36
        '
        'tabPageCartao
        '
        Me.tabPageCartao.Controls.Add(Me.btnCancelarDebitoCredito)
        Me.tabPageCartao.Controls.Add(Me.tabCreditoDebito)
        Me.tabPageCartao.Controls.Add(Me.lbCorOrientacaoCartao)
        Me.tabPageCartao.Location = New System.Drawing.Point(4, 49)
        Me.tabPageCartao.Name = "tabPageCartao"
        Me.tabPageCartao.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCartao.Size = New System.Drawing.Size(445, 260)
        Me.tabPageCartao.TabIndex = 0
        Me.tabPageCartao.Text = "CARTÃO"
        Me.tabPageCartao.UseVisualStyleBackColor = True
        '
        'btnCancelarDebitoCredito
        '
        Me.btnCancelarDebitoCredito.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCancelarDebitoCredito.Location = New System.Drawing.Point(8, 215)
        Me.btnCancelarDebitoCredito.Name = "btnCancelarDebitoCredito"
        Me.btnCancelarDebitoCredito.Size = New System.Drawing.Size(99, 32)
        Me.btnCancelarDebitoCredito.TabIndex = 43
        Me.btnCancelarDebitoCredito.Text = "CANCELAR"
        Me.btnCancelarDebitoCredito.UseVisualStyleBackColor = False
        '
        'tabCreditoDebito
        '
        Me.tabCreditoDebito.Controls.Add(Me.tabCredito)
        Me.tabCreditoDebito.Controls.Add(Me.tabDebito)
        Me.tabCreditoDebito.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCreditoDebito.Location = New System.Drawing.Point(6, 6)
        Me.tabCreditoDebito.Name = "tabCreditoDebito"
        Me.tabCreditoDebito.SelectedIndex = 0
        Me.tabCreditoDebito.Size = New System.Drawing.Size(436, 202)
        Me.tabCreditoDebito.TabIndex = 9
        '
        'tabCredito
        '
        Me.tabCredito.Controls.Add(Me.btnCreditoAVista)
        Me.tabCredito.Controls.Add(Me.btnCreditoParcelaAdm)
        Me.tabCredito.Controls.Add(Me.btnCreditoParcelaLoja)
        Me.tabCredito.Location = New System.Drawing.Point(4, 24)
        Me.tabCredito.Name = "tabCredito"
        Me.tabCredito.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCredito.Size = New System.Drawing.Size(428, 174)
        Me.tabCredito.TabIndex = 1
        Me.tabCredito.Text = "CREDITO"
        Me.tabCredito.UseVisualStyleBackColor = True
        '
        'btnCreditoAVista
        '
        Me.btnCreditoAVista.Location = New System.Drawing.Point(6, 6)
        Me.btnCreditoAVista.Name = "btnCreditoAVista"
        Me.btnCreditoAVista.Size = New System.Drawing.Size(170, 46)
        Me.btnCreditoAVista.TabIndex = 34
        Me.btnCreditoAVista.Text = "CREDITO A VISTA"
        Me.btnCreditoAVista.UseVisualStyleBackColor = True
        '
        'btnCreditoParcelaAdm
        '
        Me.btnCreditoParcelaAdm.Location = New System.Drawing.Point(6, 59)
        Me.btnCreditoParcelaAdm.Name = "btnCreditoParcelaAdm"
        Me.btnCreditoParcelaAdm.Size = New System.Drawing.Size(170, 46)
        Me.btnCreditoParcelaAdm.TabIndex = 33
        Me.btnCreditoParcelaAdm.Text = "CREDITO PARCELAMENTO ADM "
        Me.btnCreditoParcelaAdm.UseVisualStyleBackColor = True
        '
        'btnCreditoParcelaLoja
        '
        Me.btnCreditoParcelaLoja.Location = New System.Drawing.Point(6, 112)
        Me.btnCreditoParcelaLoja.Name = "btnCreditoParcelaLoja"
        Me.btnCreditoParcelaLoja.Size = New System.Drawing.Size(170, 46)
        Me.btnCreditoParcelaLoja.TabIndex = 32
        Me.btnCreditoParcelaLoja.Text = "CREDITO PARCELAMENTO LOJA"
        Me.btnCreditoParcelaLoja.UseVisualStyleBackColor = True
        '
        'tabDebito
        '
        Me.tabDebito.Controls.Add(Me.btnVendeDebitoAVista)
        Me.tabDebito.Controls.Add(Me.btnVendeDebito)
        Me.tabDebito.Location = New System.Drawing.Point(4, 24)
        Me.tabDebito.Name = "tabDebito"
        Me.tabDebito.Size = New System.Drawing.Size(428, 174)
        Me.tabDebito.TabIndex = 2
        Me.tabDebito.Text = "DEBITO"
        Me.tabDebito.UseVisualStyleBackColor = True
        '
        'btnVendeDebitoAVista
        '
        Me.btnVendeDebitoAVista.Location = New System.Drawing.Point(6, 59)
        Me.btnVendeDebitoAVista.Name = "btnVendeDebitoAVista"
        Me.btnVendeDebitoAVista.Size = New System.Drawing.Size(170, 46)
        Me.btnVendeDebitoAVista.TabIndex = 25
        Me.btnVendeDebitoAVista.Text = "VENDE DEBITO A VISTA"
        Me.btnVendeDebitoAVista.UseVisualStyleBackColor = True
        '
        'btnVendeDebito
        '
        Me.btnVendeDebito.Location = New System.Drawing.Point(6, 6)
        Me.btnVendeDebito.Name = "btnVendeDebito"
        Me.btnVendeDebito.Size = New System.Drawing.Size(170, 46)
        Me.btnVendeDebito.TabIndex = 24
        Me.btnVendeDebito.Text = "VENDE DEBITO"
        Me.btnVendeDebito.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoCartao
        '
        Me.lbCorOrientacaoCartao.AutoSize = True
        Me.lbCorOrientacaoCartao.BackColor = System.Drawing.Color.CadetBlue
        Me.lbCorOrientacaoCartao.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoCartao.ForeColor = System.Drawing.Color.CadetBlue
        Me.lbCorOrientacaoCartao.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoCartao.Name = "lbCorOrientacaoCartao"
        Me.lbCorOrientacaoCartao.Size = New System.Drawing.Size(442, 7)
        Me.lbCorOrientacaoCartao.TabIndex = 39
        Me.lbCorOrientacaoCartao.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'tabPageQRMultiplus
        '
        Me.tabPageQRMultiplus.Controls.Add(Me.btnCancelarPix)
        Me.tabPageQRMultiplus.Controls.Add(Me.tabPix)
        Me.tabPageQRMultiplus.Controls.Add(Me.lbCorOrientacaoQRMultiplus)
        Me.tabPageQRMultiplus.Location = New System.Drawing.Point(4, 49)
        Me.tabPageQRMultiplus.Name = "tabPageQRMultiplus"
        Me.tabPageQRMultiplus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageQRMultiplus.Size = New System.Drawing.Size(445, 260)
        Me.tabPageQRMultiplus.TabIndex = 1
        Me.tabPageQRMultiplus.Text = "QRMULTIPLUS"
        Me.tabPageQRMultiplus.UseVisualStyleBackColor = True
        '
        'btnCancelarPix
        '
        Me.btnCancelarPix.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCancelarPix.Location = New System.Drawing.Point(8, 215)
        Me.btnCancelarPix.Name = "btnCancelarPix"
        Me.btnCancelarPix.Size = New System.Drawing.Size(99, 32)
        Me.btnCancelarPix.TabIndex = 45
        Me.btnCancelarPix.Text = "CANCELAR"
        Me.btnCancelarPix.UseVisualStyleBackColor = False
        '
        'tabPix
        '
        Me.tabPix.Controls.Add(Me.tabPageQRPix)
        Me.tabPix.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tabPix.Location = New System.Drawing.Point(6, 6)
        Me.tabPix.Name = "tabPix"
        Me.tabPix.SelectedIndex = 0
        Me.tabPix.Size = New System.Drawing.Size(436, 202)
        Me.tabPix.TabIndex = 44
        '
        'tabPageQRPix
        '
        Me.tabPageQRPix.Controls.Add(Me.btnEnviaPix)
        Me.tabPageQRPix.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tabPageQRPix.Location = New System.Drawing.Point(4, 24)
        Me.tabPageQRPix.Name = "tabPageQRPix"
        Me.tabPageQRPix.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageQRPix.Size = New System.Drawing.Size(428, 174)
        Me.tabPageQRPix.TabIndex = 0
        Me.tabPageQRPix.Text = "PIX"
        Me.tabPageQRPix.UseVisualStyleBackColor = True
        '
        'btnEnviaPix
        '
        Me.btnEnviaPix.Location = New System.Drawing.Point(6, 6)
        Me.btnEnviaPix.Name = "btnEnviaPix"
        Me.btnEnviaPix.Size = New System.Drawing.Size(170, 46)
        Me.btnEnviaPix.TabIndex = 39
        Me.btnEnviaPix.Text = "ENVIA"
        Me.btnEnviaPix.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoQRMultiplus
        '
        Me.lbCorOrientacaoQRMultiplus.AutoSize = True
        Me.lbCorOrientacaoQRMultiplus.BackColor = System.Drawing.Color.Pink
        Me.lbCorOrientacaoQRMultiplus.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoQRMultiplus.ForeColor = System.Drawing.Color.Pink
        Me.lbCorOrientacaoQRMultiplus.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoQRMultiplus.Name = "lbCorOrientacaoQRMultiplus"
        Me.lbCorOrientacaoQRMultiplus.Size = New System.Drawing.Size(442, 7)
        Me.lbCorOrientacaoQRMultiplus.TabIndex = 43
        Me.lbCorOrientacaoQRMultiplus.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'tabPageLinkPago
        '
        Me.tabPageLinkPago.Controls.Add(Me.lbCorOrientacaoLinkPago)
        Me.tabPageLinkPago.Controls.Add(Me.tabLinkPago)
        Me.tabPageLinkPago.Location = New System.Drawing.Point(4, 49)
        Me.tabPageLinkPago.Name = "tabPageLinkPago"
        Me.tabPageLinkPago.Size = New System.Drawing.Size(445, 260)
        Me.tabPageLinkPago.TabIndex = 2
        Me.tabPageLinkPago.Text = "LINKPAGO"
        Me.tabPageLinkPago.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoLinkPago
        '
        Me.lbCorOrientacaoLinkPago.AutoSize = True
        Me.lbCorOrientacaoLinkPago.BackColor = System.Drawing.Color.SkyBlue
        Me.lbCorOrientacaoLinkPago.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoLinkPago.ForeColor = System.Drawing.Color.SkyBlue
        Me.lbCorOrientacaoLinkPago.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoLinkPago.Name = "lbCorOrientacaoLinkPago"
        Me.lbCorOrientacaoLinkPago.Size = New System.Drawing.Size(442, 7)
        Me.lbCorOrientacaoLinkPago.TabIndex = 47
        Me.lbCorOrientacaoLinkPago.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'tabLinkPago
        '
        Me.tabLinkPago.Controls.Add(Me.tabPageLinkPagoLP)
        Me.tabLinkPago.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tabLinkPago.Location = New System.Drawing.Point(6, 6)
        Me.tabLinkPago.Name = "tabLinkPago"
        Me.tabLinkPago.SelectedIndex = 0
        Me.tabLinkPago.Size = New System.Drawing.Size(436, 251)
        Me.tabLinkPago.TabIndex = 0
        '
        'tabPageLinkPagoLP
        '
        Me.tabPageLinkPagoLP.Controls.Add(Me.tbItens)
        Me.tabPageLinkPagoLP.Controls.Add(Me.label1)
        Me.tabPageLinkPagoLP.Controls.Add(Me.tbQtdeItens)
        Me.tabPageLinkPagoLP.Controls.Add(Me.label2)
        Me.tabPageLinkPagoLP.Controls.Add(Me.btnManutLink)
        Me.tabPageLinkPagoLP.Controls.Add(Me.btnListaLinkPago)
        Me.tabPageLinkPagoLP.Controls.Add(Me.btnEnviaLinkPago)
        Me.tabPageLinkPagoLP.Location = New System.Drawing.Point(4, 24)
        Me.tabPageLinkPagoLP.Name = "tabPageLinkPagoLP"
        Me.tabPageLinkPagoLP.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageLinkPagoLP.Size = New System.Drawing.Size(428, 223)
        Me.tabPageLinkPagoLP.TabIndex = 0
        Me.tabPageLinkPagoLP.Text = "LINKPAGO"
        Me.tabPageLinkPagoLP.UseVisualStyleBackColor = True
        '
        'tbItens
        '
        Me.tbItens.Location = New System.Drawing.Point(6, 186)
        Me.tbItens.Name = "tbItens"
        Me.tbItens.Size = New System.Drawing.Size(354, 20)
        Me.tbItens.TabIndex = 54
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label1.Location = New System.Drawing.Point(3, 168)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 16)
        Me.label1.TabIndex = 53
        Me.label1.Text = "ITENS"
        '
        'tbQtdeItens
        '
        Me.tbQtdeItens.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.tbQtdeItens.Location = New System.Drawing.Point(6, 141)
        Me.tbQtdeItens.Name = "tbQtdeItens"
        Me.tbQtdeItens.Size = New System.Drawing.Size(100, 21)
        Me.tbQtdeItens.TabIndex = 56
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label2.Location = New System.Drawing.Point(3, 125)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(73, 16)
        Me.label2.TabIndex = 55
        Me.label2.Text = "QTDE ITENS"
        '
        'btnManutLink
        '
        Me.btnManutLink.Location = New System.Drawing.Point(208, 6)
        Me.btnManutLink.Name = "btnManutLink"
        Me.btnManutLink.Size = New System.Drawing.Size(170, 46)
        Me.btnManutLink.TabIndex = 52
        Me.btnManutLink.Text = "MANUTENÇÃO"
        Me.btnManutLink.UseVisualStyleBackColor = True
        '
        'btnListaLinkPago
        '
        Me.btnListaLinkPago.Location = New System.Drawing.Point(6, 58)
        Me.btnListaLinkPago.Name = "btnListaLinkPago"
        Me.btnListaLinkPago.Size = New System.Drawing.Size(170, 46)
        Me.btnListaLinkPago.TabIndex = 46
        Me.btnListaLinkPago.Text = "LISTAR LINKS"
        Me.btnListaLinkPago.UseVisualStyleBackColor = True
        '
        'btnEnviaLinkPago
        '
        Me.btnEnviaLinkPago.Location = New System.Drawing.Point(6, 6)
        Me.btnEnviaLinkPago.Name = "btnEnviaLinkPago"
        Me.btnEnviaLinkPago.Size = New System.Drawing.Size(170, 46)
        Me.btnEnviaLinkPago.TabIndex = 39
        Me.btnEnviaLinkPago.Text = "ENVIA"
        Me.btnEnviaLinkPago.UseVisualStyleBackColor = True
        '
        'tabPageClient
        '
        Me.tabPageClient.Controls.Add(Me.lbCorOrientacaoClient)
        Me.tabPageClient.Controls.Add(Me.tabClient)
        Me.tabPageClient.Location = New System.Drawing.Point(4, 49)
        Me.tabPageClient.Name = "tabPageClient"
        Me.tabPageClient.Size = New System.Drawing.Size(445, 260)
        Me.tabPageClient.TabIndex = 3
        Me.tabPageClient.Text = "CLIENT"
        Me.tabPageClient.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoClient
        '
        Me.lbCorOrientacaoClient.AutoSize = True
        Me.lbCorOrientacaoClient.BackColor = System.Drawing.Color.Salmon
        Me.lbCorOrientacaoClient.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoClient.ForeColor = System.Drawing.Color.Salmon
        Me.lbCorOrientacaoClient.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoClient.Name = "lbCorOrientacaoClient"
        Me.lbCorOrientacaoClient.Size = New System.Drawing.Size(442, 7)
        Me.lbCorOrientacaoClient.TabIndex = 40
        Me.lbCorOrientacaoClient.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'tabClient
        '
        Me.tabClient.Controls.Add(Me.tabPageClientClient)
        Me.tabClient.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tabClient.Location = New System.Drawing.Point(6, 6)
        Me.tabClient.Name = "tabClient"
        Me.tabClient.SelectedIndex = 0
        Me.tabClient.Size = New System.Drawing.Size(436, 202)
        Me.tabClient.TabIndex = 0
        '
        'tabPageClientClient
        '
        Me.tabPageClientClient.Controls.Add(Me.btnRelatorio)
        Me.tabPageClientClient.Controls.Add(Me.btnReimpressaoDireta)
        Me.tabPageClientClient.Controls.Add(Me.btnReimpressao)
        Me.tabPageClientClient.Controls.Add(Me.btnSolicitarCPF)
        Me.tabPageClientClient.Controls.Add(Me.btnAtv)
        Me.tabPageClientClient.Controls.Add(Me.btnAdm)
        Me.tabPageClientClient.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageClientClient.Location = New System.Drawing.Point(4, 24)
        Me.tabPageClientClient.Name = "tabPageClientClient"
        Me.tabPageClientClient.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageClientClient.Size = New System.Drawing.Size(428, 174)
        Me.tabPageClientClient.TabIndex = 0
        Me.tabPageClientClient.Text = "CLIENT"
        Me.tabPageClientClient.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Location = New System.Drawing.Point(182, 112)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(170, 46)
        Me.btnRelatorio.TabIndex = 8
        Me.btnRelatorio.Text = "RELATORIO"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'btnReimpressaoDireta
        '
        Me.btnReimpressaoDireta.Location = New System.Drawing.Point(182, 59)
        Me.btnReimpressaoDireta.Name = "btnReimpressaoDireta"
        Me.btnReimpressaoDireta.Size = New System.Drawing.Size(170, 46)
        Me.btnReimpressaoDireta.TabIndex = 7
        Me.btnReimpressaoDireta.Text = "REIMPRESSAO DIRETA"
        Me.btnReimpressaoDireta.UseVisualStyleBackColor = True
        '
        'btnReimpressao
        '
        Me.btnReimpressao.Location = New System.Drawing.Point(182, 6)
        Me.btnReimpressao.Name = "btnReimpressao"
        Me.btnReimpressao.Size = New System.Drawing.Size(170, 46)
        Me.btnReimpressao.TabIndex = 6
        Me.btnReimpressao.Text = "REIMPRESSAO"
        Me.btnReimpressao.UseVisualStyleBackColor = True
        '
        'btnSolicitarCPF
        '
        Me.btnSolicitarCPF.Location = New System.Drawing.Point(6, 112)
        Me.btnSolicitarCPF.Name = "btnSolicitarCPF"
        Me.btnSolicitarCPF.Size = New System.Drawing.Size(170, 46)
        Me.btnSolicitarCPF.TabIndex = 5
        Me.btnSolicitarCPF.Text = "SOLICITAR CPF"
        Me.btnSolicitarCPF.UseVisualStyleBackColor = True
        '
        'btnAtv
        '
        Me.btnAtv.Location = New System.Drawing.Point(6, 59)
        Me.btnAtv.Name = "btnAtv"
        Me.btnAtv.Size = New System.Drawing.Size(170, 46)
        Me.btnAtv.TabIndex = 4
        Me.btnAtv.Text = "ATV"
        Me.btnAtv.UseVisualStyleBackColor = True
        '
        'btnAdm
        '
        Me.btnAdm.Location = New System.Drawing.Point(6, 6)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(170, 46)
        Me.btnAdm.TabIndex = 3
        Me.btnAdm.Text = "ADM"
        Me.btnAdm.UseVisualStyleBackColor = True
        '
        'tabPageOutros
        '
        Me.tabPageOutros.Controls.Add(Me.lbCorOrientacaoOutros)
        Me.tabPageOutros.Controls.Add(Me.tabParceleMais)
        Me.tabPageOutros.Location = New System.Drawing.Point(4, 49)
        Me.tabPageOutros.Name = "tabPageOutros"
        Me.tabPageOutros.Size = New System.Drawing.Size(445, 260)
        Me.tabPageOutros.TabIndex = 4
        Me.tabPageOutros.Text = "OUTROS"
        Me.tabPageOutros.UseVisualStyleBackColor = True
        '
        'lbCorOrientacaoOutros
        '
        Me.lbCorOrientacaoOutros.AutoSize = True
        Me.lbCorOrientacaoOutros.BackColor = System.Drawing.Color.Goldenrod
        Me.lbCorOrientacaoOutros.Font = New System.Drawing.Font("Arial", 5.0!)
        Me.lbCorOrientacaoOutros.ForeColor = System.Drawing.Color.Goldenrod
        Me.lbCorOrientacaoOutros.Location = New System.Drawing.Point(0, -4)
        Me.lbCorOrientacaoOutros.Name = "lbCorOrientacaoOutros"
        Me.lbCorOrientacaoOutros.Size = New System.Drawing.Size(442, 7)
        Me.lbCorOrientacaoOutros.TabIndex = 41
        Me.lbCorOrientacaoOutros.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'tabParceleMais
        '
        Me.tabParceleMais.Controls.Add(Me.tabPageOutrosParceleMais)
        Me.tabParceleMais.Font = New System.Drawing.Font("Arial Narrow", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.tabParceleMais.Location = New System.Drawing.Point(6, 6)
        Me.tabParceleMais.Name = "tabParceleMais"
        Me.tabParceleMais.SelectedIndex = 0
        Me.tabParceleMais.Size = New System.Drawing.Size(436, 202)
        Me.tabParceleMais.TabIndex = 0
        '
        'tabPageOutrosParceleMais
        '
        Me.tabPageOutrosParceleMais.Controls.Add(Me.btnParceleMais)
        Me.tabPageOutrosParceleMais.Location = New System.Drawing.Point(4, 24)
        Me.tabPageOutrosParceleMais.Name = "tabPageOutrosParceleMais"
        Me.tabPageOutrosParceleMais.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageOutrosParceleMais.Size = New System.Drawing.Size(428, 174)
        Me.tabPageOutrosParceleMais.TabIndex = 0
        Me.tabPageOutrosParceleMais.Text = "PARCELE MAIS"
        Me.tabPageOutrosParceleMais.UseVisualStyleBackColor = True
        '
        'btnParceleMais
        '
        Me.btnParceleMais.Location = New System.Drawing.Point(6, 6)
        Me.btnParceleMais.Name = "btnParceleMais"
        Me.btnParceleMais.Size = New System.Drawing.Size(170, 46)
        Me.btnParceleMais.TabIndex = 2
        Me.btnParceleMais.Text = "PARCELE MAIS"
        Me.btnParceleMais.UseVisualStyleBackColor = True
        '
        'panelParametros
        '
        Me.panelParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelParametros.Controls.Add(Me.textTexto)
        Me.panelParametros.Controls.Add(Me.textData)
        Me.panelParametros.Controls.Add(Me.textTelefone)
        Me.panelParametros.Controls.Add(Me.labelTexto)
        Me.panelParametros.Controls.Add(Me.txbCnpjParceiro)
        Me.panelParametros.Controls.Add(Me.labelData)
        Me.panelParametros.Controls.Add(Me.txbParcelas)
        Me.panelParametros.Controls.Add(Me.labelTelefone)
        Me.panelParametros.Controls.Add(Me.txbCnpj)
        Me.panelParametros.Controls.Add(Me.labelParceiro)
        Me.panelParametros.Controls.Add(Me.txbCupom)
        Me.panelParametros.Controls.Add(Me.txbControle)
        Me.panelParametros.Controls.Add(Me.labelControle)
        Me.panelParametros.Controls.Add(Me.txbValor)
        Me.panelParametros.Controls.Add(Me.labelCNPJ)
        Me.panelParametros.Controls.Add(Me.labelValor)
        Me.panelParametros.Controls.Add(Me.labelParcela)
        Me.panelParametros.Controls.Add(Me.labelCupom)
        Me.panelParametros.Location = New System.Drawing.Point(8, 6)
        Me.panelParametros.Name = "panelParametros"
        Me.panelParametros.Size = New System.Drawing.Size(452, 176)
        Me.panelParametros.TabIndex = 37
        '
        'textTexto
        '
        Me.textTexto.Location = New System.Drawing.Point(8, 141)
        Me.textTexto.Name = "textTexto"
        Me.textTexto.Size = New System.Drawing.Size(354, 20)
        Me.textTexto.TabIndex = 13
        '
        'textData
        '
        Me.textData.Location = New System.Drawing.Point(252, 21)
        Me.textData.Name = "textData"
        Me.textData.Size = New System.Drawing.Size(100, 20)
        Me.textData.TabIndex = 12
        '
        'textTelefone
        '
        Me.textTelefone.Location = New System.Drawing.Point(252, 60)
        Me.textTelefone.Name = "textTelefone"
        Me.textTelefone.Size = New System.Drawing.Size(100, 20)
        Me.textTelefone.TabIndex = 12
        '
        'labelTexto
        '
        Me.labelTexto.AutoSize = True
        Me.labelTexto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelTexto.Location = New System.Drawing.Point(5, 123)
        Me.labelTexto.Name = "labelTexto"
        Me.labelTexto.Size = New System.Drawing.Size(44, 16)
        Me.labelTexto.TabIndex = 7
        Me.labelTexto.Text = "TEXTO"
        '
        'txbCnpjParceiro
        '
        Me.txbCnpjParceiro.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.txbCnpjParceiro.Location = New System.Drawing.Point(130, 96)
        Me.txbCnpjParceiro.Name = "txbCnpjParceiro"
        Me.txbCnpjParceiro.Size = New System.Drawing.Size(100, 21)
        Me.txbCnpjParceiro.TabIndex = 36
        '
        'labelData
        '
        Me.labelData.AutoSize = True
        Me.labelData.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelData.Location = New System.Drawing.Point(249, 4)
        Me.labelData.Name = "labelData"
        Me.labelData.Size = New System.Drawing.Size(39, 16)
        Me.labelData.TabIndex = 6
        Me.labelData.Text = "DATA"
        '
        'txbParcelas
        '
        Me.txbParcelas.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.txbParcelas.Location = New System.Drawing.Point(8, 58)
        Me.txbParcelas.Name = "txbParcelas"
        Me.txbParcelas.Size = New System.Drawing.Size(100, 21)
        Me.txbParcelas.TabIndex = 32
        '
        'labelTelefone
        '
        Me.labelTelefone.AutoSize = True
        Me.labelTelefone.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelTelefone.Location = New System.Drawing.Point(249, 43)
        Me.labelTelefone.Name = "labelTelefone"
        Me.labelTelefone.Size = New System.Drawing.Size(66, 16)
        Me.labelTelefone.TabIndex = 6
        Me.labelTelefone.Text = "TELEFONE"
        '
        'txbCnpj
        '
        Me.txbCnpj.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.txbCnpj.Location = New System.Drawing.Point(8, 96)
        Me.txbCnpj.Name = "txbCnpj"
        Me.txbCnpj.Size = New System.Drawing.Size(100, 21)
        Me.txbCnpj.TabIndex = 35
        '
        'labelParceiro
        '
        Me.labelParceiro.AutoSize = True
        Me.labelParceiro.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelParceiro.Location = New System.Drawing.Point(128, 80)
        Me.labelParceiro.Name = "labelParceiro"
        Me.labelParceiro.Size = New System.Drawing.Size(97, 16)
        Me.labelParceiro.TabIndex = 34
        Me.labelParceiro.Text = "CNPJ PARCEIRO"
        '
        'txbCupom
        '
        Me.txbCupom.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.txbCupom.Location = New System.Drawing.Point(130, 21)
        Me.txbCupom.Name = "txbCupom"
        Me.txbCupom.Size = New System.Drawing.Size(100, 21)
        Me.txbCupom.TabIndex = 27
        '
        'txbControle
        '
        Me.txbControle.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.txbControle.Location = New System.Drawing.Point(130, 58)
        Me.txbControle.Name = "txbControle"
        Me.txbControle.Size = New System.Drawing.Size(100, 21)
        Me.txbControle.TabIndex = 29
        '
        'labelControle
        '
        Me.labelControle.AutoSize = True
        Me.labelControle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelControle.Location = New System.Drawing.Point(128, 41)
        Me.labelControle.Name = "labelControle"
        Me.labelControle.Size = New System.Drawing.Size(69, 16)
        Me.labelControle.TabIndex = 31
        Me.labelControle.Text = "CONTROLE"
        '
        'txbValor
        '
        Me.txbValor.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.txbValor.Location = New System.Drawing.Point(8, 21)
        Me.txbValor.Name = "txbValor"
        Me.txbValor.Size = New System.Drawing.Size(100, 21)
        Me.txbValor.TabIndex = 25
        '
        'labelCNPJ
        '
        Me.labelCNPJ.AutoSize = True
        Me.labelCNPJ.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelCNPJ.Location = New System.Drawing.Point(5, 80)
        Me.labelCNPJ.Name = "labelCNPJ"
        Me.labelCNPJ.Size = New System.Drawing.Size(37, 16)
        Me.labelCNPJ.TabIndex = 33
        Me.labelCNPJ.Text = "CNPJ"
        '
        'labelValor
        '
        Me.labelValor.AutoSize = True
        Me.labelValor.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelValor.Location = New System.Drawing.Point(5, 6)
        Me.labelValor.Margin = New System.Windows.Forms.Padding(3)
        Me.labelValor.Name = "labelValor"
        Me.labelValor.Size = New System.Drawing.Size(47, 16)
        Me.labelValor.TabIndex = 24
        Me.labelValor.Text = "VALOR"
        '
        'labelParcela
        '
        Me.labelParcela.AutoSize = True
        Me.labelParcela.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelParcela.Location = New System.Drawing.Point(5, 41)
        Me.labelParcela.Name = "labelParcela"
        Me.labelParcela.Size = New System.Drawing.Size(61, 16)
        Me.labelParcela.TabIndex = 30
        Me.labelParcela.Text = "PARCELA"
        '
        'labelCupom
        '
        Me.labelCupom.AutoSize = True
        Me.labelCupom.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.labelCupom.Location = New System.Drawing.Point(128, 6)
        Me.labelCupom.Name = "labelCupom"
        Me.labelCupom.Size = New System.Drawing.Size(48, 16)
        Me.labelCupom.TabIndex = 26
        Me.labelCupom.Text = "CUPOM"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 514)
        Me.Controls.Add(Me.tabTipo)
        Me.Controls.Add(Me.panelParametros)
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exemplo TefClientMC - VB.Net"
        Me.tabTipo.ResumeLayout(False)
        Me.tabPageCartao.ResumeLayout(False)
        Me.tabPageCartao.PerformLayout()
        Me.tabCreditoDebito.ResumeLayout(False)
        Me.tabCredito.ResumeLayout(False)
        Me.tabDebito.ResumeLayout(False)
        Me.tabPageQRMultiplus.ResumeLayout(False)
        Me.tabPageQRMultiplus.PerformLayout()
        Me.tabPix.ResumeLayout(False)
        Me.tabPageQRPix.ResumeLayout(False)
        Me.tabPageLinkPago.ResumeLayout(False)
        Me.tabPageLinkPago.PerformLayout()
        Me.tabLinkPago.ResumeLayout(False)
        Me.tabPageLinkPagoLP.ResumeLayout(False)
        Me.tabPageLinkPagoLP.PerformLayout()
        Me.tabPageClient.ResumeLayout(False)
        Me.tabPageClient.PerformLayout()
        Me.tabClient.ResumeLayout(False)
        Me.tabPageClientClient.ResumeLayout(False)
        Me.tabPageOutros.ResumeLayout(False)
        Me.tabPageOutros.PerformLayout()
        Me.tabParceleMais.ResumeLayout(False)
        Me.tabPageOutrosParceleMais.ResumeLayout(False)
        Me.panelParametros.ResumeLayout(False)
        Me.panelParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabTipo As TabControl
    Private WithEvents tabPageCartao As TabPage
    Private WithEvents btnCancelarDebitoCredito As Button
    Private WithEvents tabCreditoDebito As TabControl
    Private WithEvents tabCredito As TabPage
    Private WithEvents btnCreditoAVista As Button
    Private WithEvents btnCreditoParcelaAdm As Button
    Private WithEvents btnCreditoParcelaLoja As Button
    Private WithEvents tabDebito As TabPage
    Private WithEvents btnVendeDebitoAVista As Button
    Private WithEvents btnVendeDebito As Button
    Private WithEvents lbCorOrientacaoCartao As Label
    Private WithEvents tabPageQRMultiplus As TabPage
    Private WithEvents btnCancelarPix As Button
    Private WithEvents tabPix As TabControl
    Private WithEvents tabPageQRPix As TabPage
    Private WithEvents btnEnviaPix As Button
    Private WithEvents lbCorOrientacaoQRMultiplus As Label
    Private WithEvents tabPageLinkPago As TabPage
    Private WithEvents lbCorOrientacaoLinkPago As Label
    Private WithEvents tabLinkPago As TabControl
    Private WithEvents tabPageLinkPagoLP As TabPage
    Private WithEvents btnListaLinkPago As Button
    Private WithEvents btnEnviaLinkPago As Button
    Private WithEvents tabPageClient As TabPage
    Private WithEvents lbCorOrientacaoClient As Label
    Private WithEvents tabClient As TabControl
    Private WithEvents tabPageClientClient As TabPage
    Private WithEvents btnRelatorio As Button
    Private WithEvents btnReimpressaoDireta As Button
    Private WithEvents btnReimpressao As Button
    Private WithEvents btnSolicitarCPF As Button
    Private WithEvents btnAtv As Button
    Private WithEvents btnAdm As Button
    Private WithEvents tabPageOutros As TabPage
    Private WithEvents lbCorOrientacaoOutros As Label
    Private WithEvents tabParceleMais As TabControl
    Private WithEvents tabPageOutrosParceleMais As TabPage
    Private WithEvents btnParceleMais As Button
    Private WithEvents panelParametros As Panel
    Private WithEvents textTexto As TextBox
    Private WithEvents textData As TextBox
    Private WithEvents textTelefone As TextBox
    Private WithEvents labelTexto As Label
    Private WithEvents txbCnpjParceiro As TextBox
    Private WithEvents labelData As Label
    Private WithEvents txbParcelas As TextBox
    Private WithEvents labelTelefone As Label
    Private WithEvents txbCnpj As TextBox
    Private WithEvents labelParceiro As Label
    Private WithEvents txbCupom As TextBox
    Private WithEvents txbControle As TextBox
    Private WithEvents labelControle As Label
    Private WithEvents txbValor As TextBox
    Private WithEvents labelCNPJ As Label
    Private WithEvents labelValor As Label
    Private WithEvents labelParcela As Label
    Private WithEvents labelCupom As Label
    Private WithEvents tbItens As TextBox
    Private WithEvents label1 As Label
    Private WithEvents tbQtdeItens As TextBox
    Private WithEvents label2 As Label
    Private WithEvents btnManutLink As Button
End Class
