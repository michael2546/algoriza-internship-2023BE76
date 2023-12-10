using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Core.Entities.Identity;

namespace Vezeeta.Core.Entities
{
    public class Address : BaseEntity
    {
        public string Government { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }


    }
}
