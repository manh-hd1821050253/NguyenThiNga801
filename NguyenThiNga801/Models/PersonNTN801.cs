using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiNga801.Models
{
    public class PersonNTN801
    {
        [Key]
        [StringLength(20)]
        public string PersonId { get; set; }
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}
