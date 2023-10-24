using FluentNHibernate.Mapping;
using LancamentoHoras.Domain.Models;

namespace LancamentoHoras.Infra.Data.Map
{
    public class ProjetoClassMap : ClassMap<Projeto>
    {
        public ProjetoClassMap()
        {
            Table("PROJETO");
            Id(x => x.IdProjeto).Column("ID_PROJETO").GeneratedBy.Identity();
            Map(x => x.Nome).Column("NOME");
        }
    }
}
