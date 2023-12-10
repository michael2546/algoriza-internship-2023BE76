using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Core.Entities.Identity
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Gender Gender { get; set; }

        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }




    }
}
