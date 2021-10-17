using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiNga801.Models;

namespace NguyenThiNga801.Data
{
    public class NguyenThiNga801Context : DbContext
    {
        public NguyenThiNga801Context (DbContextOptions<NguyenThiNga801Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiNga801.Models.PersonNTN801> PersonNTN801 { get; set; }
    }
}
