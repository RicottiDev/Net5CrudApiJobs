using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5CrudApiJobs.Infrastructure.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }
        public List<Person> Persons { get; set; }
    }
}
