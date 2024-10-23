namespace GenteTerra.API.Share.ShareDto
{
    public enum MessageEnumMIN
    {
        [MensagemInfo("Modem")]
        modem = 000,

        [MensagemInfo("System")]
        system = 016,

        [MensagemInfo("Log")]
        log = 023,

        [MensagemInfo("Shell")]
        shell = 026,

        [MensagemInfo("Serviço de Mensagens")]
        ServMensagens = 158,

    }
}
