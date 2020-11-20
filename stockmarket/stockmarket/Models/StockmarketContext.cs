using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Stockmarket.Models
{
    public class StockmarketContext : DbContext
    {
        public StockmarketContext() : base ("StockmarketContext")
        {

        }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
    }
}