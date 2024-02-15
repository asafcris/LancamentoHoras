using FluentNHibernate.Mapping;
using LancamentoHoras.Domain.Models;

namespace LancamentoHoras.Infra.Data.Map
{
    public class ItensLancamentoDeHoraClassMap : ClassMap<ItensLancamentoDeHoras>
    {
        public ItensLancamentoDeHoraClassMap()
        {
            Table("ITENS_LANCAMENTOS_HORAS");
            Id(x => x.IdItem).Column("ID_LANCAMENTO_HORAS").GeneratedBy.Identity();
            Map(x => x.DataInicio).Column("DATA_INICIO");
            Map(x => x.DataFim).Column("DATA_FINAL");
            Map(x => x.NumeroOs).Column("NUMERO_OS");
            Map(x => x.AtividadeDescricao).Column("DESCRICAO_ATIVIDADE");
            Map(x => x.Observacao).Column("OBSERVACAO");

            References(x => x.LancamentoDeHoras).Column("ID_LANCAMENTO_HORAS");
            References(x => x.Projeto).Column("ID_PROJETO");

        }
    }
}
     