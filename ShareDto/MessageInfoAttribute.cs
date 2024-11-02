
namespace GenteTerra.API.Share.ShareDto
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class MensagemInfoAttribute : Attribute
    {
        public string Descricao { get; }

        public MensagemInfoAttribute(string descricao)
        {
            Descricao = descricao;
        }
    }
}
