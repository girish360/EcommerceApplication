using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Picture")]
    public class Picture
    {
        public Picture()
        {
            Products = new HashSet<Product>();
        }
        public int PictureId { get; set; }
        public string FileName { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
