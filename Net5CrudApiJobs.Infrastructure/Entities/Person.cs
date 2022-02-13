using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5CrudApiJobs.Infrastructure.Entities
{
    public class Person
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
        public Job Job { get; set; }
    }
}
