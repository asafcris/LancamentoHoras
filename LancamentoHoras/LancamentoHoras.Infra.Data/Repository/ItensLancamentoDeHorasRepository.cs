using Framework.NHibernate;
using LancamentoHoras.Domain.Intefaces;
using LancamentoHoras.Domain.Models;
using NHibernate;

namespace LancamentoHoras.Infra.Data.Repository
{
    public class ItensLancamentoDeHorasRepository : Repository<ItensLancamentoDeHoras>, IItensLancamentoDeHorasRepository
    {
        public ItensLancamentoDeHorasRepository(ISession session) : base(session) { }

    }
}
