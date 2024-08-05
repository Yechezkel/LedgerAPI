using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LedgerAPI;
using LedgerAPI.Models;

namespace LedgerAPI.Data
{
    public class LedgerAPIContext : DbContext
    {
        public LedgerAPIContext (DbContextOptions<LedgerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<LedgerAPI.User> User { get; set; } = default!;
        public DbSet<LedgerAPI.Models.Ledger> Ledger { get; set; } = default!;
    }
}
