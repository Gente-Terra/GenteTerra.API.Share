namespace GenteTerra.API.Share.ShareDto
{
    public enum MessageEnumMIN
    {
        [MensagemInfo("System")]
        System = 0,

        [MensagemInfo("Posição Status Temp. SAT")]
        PosicaoStatusTempSAT = 1,

        [MensagemInfo("Posição Status Temp. CELL")]
        PosicaoStatusTempCELL = 2,

        [MensagemInfo("Posição Status Cell LOG")]
        PosicaoStatusTempCELLLog = 3,

        [MensagemInfo("Posição Status Alteração Alimentação")]
        PosicaoStatusAlterAlim = 4,

        [MensagemInfo("Posição Status Energia Crítica")]
        PosicaoStatusEnergiaCritica = 5,

        [MensagemInfo("Posição Status Botão de Emergência Ativo")]
        PosicaoStatusEvenBotEmerg = 6,

        [MensagemInfo("Posição Status Início de Operação")]
        PosicaoStatusEvenINOPERDentroCerca = 7,

        [MensagemInfo("Posição Status Início de Operação Fora Cerca")]
        PosicaoStatusEvenINOPERForaCerca = 8,

        [MensagemInfo("Posição Status Fim de Operação")]
        PosicaoStatusEvenPARADAOPER = 9,

        [MensagemInfo("Posição Status Caixa de Automação Aberta")]
        PosicaoStatusEvenABERTCaixaAutom = 10,

        [MensagemInfo("Posição Status Caixa de Automação Fechada")]
        PosicaoStatusEvenFECHAMCaixaAutom = 11,

        [MensagemInfo("Posição Status Operação Dentro de Cerca")]
        PosicaoStatusEvenOPERDENTROCERCA = 12,

        [MensagemInfo("Posição Status Operação Fora de Cerca")]
        PosicaoStatusEvenOPERFORACERCA = 13,

        [MensagemInfo("Posição Status Padrão")]
        PosicaoStatusPadrao = 14,

        [MensagemInfo("Mensagem Bateria")]
        MensBateria = 15,

        [MensagemInfo("Mensagem Restart")]
        MensRestart = 16,

        [MensagemInfo("Mensagem Erro Comunicação MODBUS")]
        MensErrComMODBUS = 17,

        [MensagemInfo("Mensagem Status Config. Aplicação")]
        MensStatusConfigAplicacao = 18,

        [MensagemInfo("Mensagem Leitura Propriedade")]
        MensLeituraPropriedade = 19,

        [MensagemInfo("Mensagem Teste Comunicação MODBUS")]
        MensTesteComMODBUS = 20,

        [MensagemInfo("Posição Status Operação em Cerca Desconhecida")]
        PosicaoStatusEvenOperStatusCercaDesconhecido = 21,

        [MensagemInfo("Mensagem Alerta Restart Timer")]
        MensAlertaRestartTimer = 22,

        [MensagemInfo("Mensagem Alerta Intermitência SAT")]
        MensAlertaIntermitenciaSAT = 23,

        [MensagemInfo("Mensagem Alerta Jamming GNSS")]
        AlertaGNSSJamming = 50,

        [MensagemInfo("Mensagem Alerta Jamming GNSS IDP")]
        AlertaGNSSIDPJamming = 51,

        [MensagemInfo("Mensagem Alerta GNSS Bloqueado")]
        AlertaGNSSBlocked = 52,

        [MensagemInfo("Mensagem Alerta Antena CUT IDP")]
        AlertaAntennaCutIDP = 53,

        [MensagemInfo("Mensagem Alerta Antena CUT CELL")]
        AlertaAntennaCutCELL = 54,

        [MensagemInfo("Mensagem Alerta IDP Bloqueado")]
        AlertaIDPBlocked = 55,

        [MensagemInfo("Mensagem Alerta Jamming CELL")]
        AlertaCELLJamming = 56,

        [MensagemInfo("Mensagem Alerta Mensagem Bloqueada")]
        AlertaMsgBlocked = 57,

        [MensagemInfo("Mensagem Alerta Mens. LOG Acima Ref.")]
        AlertaMsgLOGsUploadAcimaRef = 58,

        [MensagemInfo("Mensagem Alerta Naveg. Falhas Coord.")]
        AlertaNavegadorFalhasCoorNMEAAcimaRef = 59

    }
}
