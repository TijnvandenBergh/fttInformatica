using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFTInformatica.Models
{
    public class ResponseContext : DbContext
    {
        public ResponseContext(DbContextOptions<ResponseContext> options)
            : base(options)
        {
        }

        public DbSet<Response> Responses { get; set; }
    }
}
