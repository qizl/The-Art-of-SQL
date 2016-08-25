using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheArtofSQL.Models
{
    public class FileDetail
    {
        [Key]
        public Guid ID { get; set; }
        public Guid FileID { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}