using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheArtofSQL.Models
{
    public class TAOSDBContext : DbContext
    {
        public TAOSDBContext(string cname) : base(cname) { }

        public DbSet<File> Files { get; set; }
        public DbSet<FileDetail> FileDetails { get; set; }
    }
}