using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities
{
    public class Stock
    {
        public int StockId { get; set; }
        public DateTime DateAjout { get; set; }
        public string Barcode { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
