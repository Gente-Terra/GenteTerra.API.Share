using GenteTerra.API.Share.ShareDto;

namespace GenteTerra.API.Share.DomainShare
{
    public class MensagemAlertaTerminalBase
    {
        public long OrbcomID { get; set; }
        public int Order { get; set; }
        public string MobileID { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }
        public MessageEnumSIN SIN { get; set; }
        public MessageEnumMIN MIN { get; set; }
        public DateTime MessageUTC { get; set; }
        public DateTime ReceiveUTC { get; set; }
        public long DataHoraMensagem { get; set; }
        public int? VelocKmh { get; set; }
        public int? SinCell { get; set; }
        public int? VoltTerminal { get; set; }
        public string? TipoEnergia { get; set; }
        public int? VoltAlimExterna { get; set; }
        public int? VoltBatBackup { get; set; }
        public int? OperacaoAtiva { get; set; }
        public int? CaixaAutomAberta { get; set; }
        public int? SireneAtiva { get; set; }
        public int? BtnEmergAtivo { get; set; }
        public int? ContatarGTAtivo { get; set; }
        public int? AlertaCercaElAtivo { get; set; }
        public string? OperacaoForaArea { get; set; }
        public int? BloqueioOperAtivo { get; set; }
        public int? NumErrWriteDigOut { get; set; }
        public int? NumErrReadDigOut { get; set; }
        public int? NumErrReadDigInp { get; set; }
        public int? NumErrReadAnaInp { get; set; }
        public DateTime? DataHoraGeracao { get; set; }
        public int? Propr { get; set; }
        public string? ValProp { get; set; }
        public int? Servico { get; set; }
        public string? Timer { get; set; }
        public string? FlagTimerMonitorado { get; set; }
        public int? DelayLimSeg { get; set; }
        public int? TimeLastProcessQ { get; set; }
        public string? RestartAplicado { get; set; }
        public int? TimeLastRestartStorageg { get; set; }
        public int? Sin_Vinculado { get; set; }
        public string? FlagStatusIntermitenciaSAT { get; set; }
        public string? TipoAlerta { get; set; }
        public string? FlagAtivar { get; set; }
        public string? StatusGNSSJamming { get; set; }
        public string? StatusGNSSIdpJamming { get; set; }
        public string? StatusCellJamming { get; set; }
        public int? PercFalhasCoordNMEA { get; set; }
    }
}
