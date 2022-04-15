using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Yapilacaklar.Core.Models
{
    [Table("BlogPost", Schema = "dbo")] // Tablo şeması db de bulamadığında eklendi.
    public partial class BlogPost
    {
        public int BlogPostId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}
