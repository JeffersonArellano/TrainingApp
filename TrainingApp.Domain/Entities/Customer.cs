using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string PostalCode { get; set; }
         
        public int RoleId { get; set; }
         
        public virtual Roles Role { get; set; }

    }
}
