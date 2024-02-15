using FluentNHibernate.Mapping;
using LancamentoHoras.Domain.Models;

namespace LancamentoHoras.Infra.Data.Map
{
    public class LancamentoDeHorasClassMap : ClassMap<LancamentoDeHoras>
    {
        public LancamentoDeHorasClassMap()
        {
            Table("LANCAMENTOS_HORAS");
            Id(x => x.IdLancamento).Column("ID_LANCAMENTO_HORAS").GeneratedBy.Identity();
            Map(x => x.Nome).Column("NOME");
            Map(x => x.Mes).Column("MES_REFERENCIA");
            Map(x => x.Hora).Column("VALOR_HORA");
        }
    }
}