namespace GenteTerra.API.Share.EnumShare
{
    public enum MenssageTerminalMINEnum
    {
        [MensagemInfo("System")]
        System = 0,

        [MensagemInfo("Posição Status Temp. SAT")]
        PosicaoStatusTempSAT = 1,

        [MensagemInfo("Posição Status Temp. CELL")]
        PosicaoStatusTempCELL = 2,

        [MensagemInfo("Log")]
        Log = 3,

        [MensagemInfo("Posição Status Alteração Alimentação")]
        PosicaoStatusAlterAlim = 4,

        [MensagemInfo("Posição Status Energia Crítica")]
        PosicaoStatusEnergiaCritica = 5,

        [MensagemInfo("Posição Status Botão de Emergência Ativo")]
        PosicaoStatusEvenBotEmerg = 6,

        [MensagemInfo("Posição Status Início de Operação")]
        PosicaoStatusEvenINOPERDentroCerca = 7,

        [MensagemInfo("TerminalRegistration")]
        TerminalRegistration = 8,

        [MensagemInfo("Posição Status Fim de Operação")]
        PosicaoStatusEvenPARADAOPER = 9,

        [MensagemInfo("Posição Status Caixa de Automação Aberta")]
        PosicaoStatusEvenABERTCaixaAutom = 10,

        [MensagemInfo("Posição Status Caixa de Automação Fechada")]
        PosicaoStatusEvenFECHAMCaixaAutom = 11,

        [MensagemInfo("Posição Status Padrão")]
        PosicaoStatusPadrao = 14,

        [MensagemInfo("Mensagem Bateria")]
        MensBateria = 15,

        [MensagemInfo("Mensagem Restart")]
        MensRestart = 16,

        [MensagemInfo("Mensagem Erro Comunicação MODBUS")]
        MensErrComMODBUS = 17
    }

}

