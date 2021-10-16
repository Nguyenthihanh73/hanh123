using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NTHanh777.Models
{
    public class NVN123
    {
        [Key]
        [StringLength(20)]
        public string NVNId { get; set; }
        [StringLength(50)]
        public string NVNName { get; set; }
        public string Gender { get; set; }
    }
}
