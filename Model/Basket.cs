using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Basket
    {
        public int BasketId { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<BasketItem> BasketItems { get; set; }
    }
}
