using Net5CrudApiJobs.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5CrudApiJobs.Infrastructure.IRepositories
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
