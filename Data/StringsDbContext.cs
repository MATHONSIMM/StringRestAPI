using StringRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StringRestAPI.Data
{
    public class StringsDbContext: DbContext
    {
        public DbSet<Strings> Strings { get; set; }
    }
}