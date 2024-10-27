namespace GenteTerra.API.Share.ShareDto
{
    public enum MessageEnumSIN
    {
        [MensagemInfo("Modem")]
        MODEM = 0,

        [MensagemInfo("System")]
        SYSTEM = 16,

        [MensagemInfo("Log")]
        LOG = 23,

        [MensagemInfo("Shell")]
        SHELL = 26,

        [MensagemInfo("Serviço de Mensagens")]
        SERV_MENSAGEM = 158,

    }
}
