using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Core.Entities.Identity;

namespace Vezeeta.Core.Entities
{
    public class Specialization : BaseEntity
    {
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
