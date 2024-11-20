using GenteTerra.API.Share.ShareDto;

namespace GenteTerra.API.Share.DomainShare
{
    public class MensagemTerminalBase
    {
        public long OrbcomID { get; set; }
        public string MobileID { get; set; }
        public int Ordem { get; set; } = 0;
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
        public DateTime DataHoraInclusao { get; set; }
        public DateTime? DataHoraGeracao { get; set; }
    }
}
