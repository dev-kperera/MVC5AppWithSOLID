using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BasketItem
    {
        public int BasketItemId { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
