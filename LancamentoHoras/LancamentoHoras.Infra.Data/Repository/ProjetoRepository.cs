using Framework.NHibernate;
using LancamentoHoras.Domain.Intefaces;
using LancamentoHoras.Domain.Models;
using NHibernate;

namespace LancamentoHoras.Infra.Data.Repository
{
    public class ProjetoRepository :Repository<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(ISession session): base(session) { }

    }
}
