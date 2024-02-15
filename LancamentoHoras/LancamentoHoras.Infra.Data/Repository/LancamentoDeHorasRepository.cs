using Framework.NHibernate;
using LancamentoHoras.Domain.Intefaces;
using LancamentoHoras.Domain.Models;
using NHibernate;

namespace LancamentoHoras.Infra.Data.Repository
{
    public class LancamentoDeHorasRepository : Repository<LancamentoDeHoras>, ILancamentoDeHorasRepository
    {
        public LancamentoDeHorasRepository(ISession session) : base(session) { }

    }
}
