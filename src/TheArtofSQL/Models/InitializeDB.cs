using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheArtofSQL.Models
{
    public class InitializeDB : DropCreateDatabaseIfModelChanges<TAOSDBContext>
    {
        protected override void Seed(TAOSDBContext context)
        {
            var files = new List<File>() { 
                new File(){ID=Guid.NewGuid(),Name="F1",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new File(){ID=Guid.NewGuid(),Name="F2",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new File(){ID=Guid.NewGuid(),Name="F3",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
            };
            files.ForEach(f => context.Files.Add(f));

            var fileDetails = new List<FileDetail>() { 
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[0].ID,Name="F11",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[0].ID,Name="F12",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[0].ID,Name="F13",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[1].ID,Name="F21",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[1].ID,Name="F22",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[1].ID,Name="F23",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[2].ID,Name="F31",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[2].ID,Name="F32",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                new FileDetail(){ID=Guid.NewGuid(),FileID=files[2].ID,Name="F33",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
            };
            fileDetails.ForEach(f => context.FileDetails.Add(f));

            context.SaveChanges();
        }
    }
}