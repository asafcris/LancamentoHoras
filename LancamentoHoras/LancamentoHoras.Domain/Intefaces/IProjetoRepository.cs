using Framework.NHibernate;
using LancamentoHoras.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancamentoHoras.Domain.Intefaces
{
    public interface IProjetoRepository : IRepository<Projeto>
    {
    }
}
