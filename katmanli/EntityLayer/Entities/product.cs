using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class product
    {
        [Key]
        public int productId { get; set; }

        [StringLength(50)]
        public string productName { get; set; }

        public string stock { get; set; }

        public virtual categories Categories { get; set; }
    }
}
