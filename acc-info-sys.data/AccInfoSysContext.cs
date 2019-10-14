using acc_info_sys.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace acc_info_sys.data
{
    public class AccInfoSysContext:DbContext
    {
        public AccInfoSysContext(DbContextOptions<AccInfoSysContext> options)
            : base(options) { }

        public DbSet<Account> Accounts { get; set; }
    }
}
