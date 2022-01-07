using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Domain.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
