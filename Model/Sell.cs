using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBl.Model
{
    class Sell
    {
        public int SellId { get; set; }
        public int CheckId { get; set; }
        public int ProductId { get; set; }
        public virtual Check Check { get; set; }
        public virtual Product Product { get; set; }
    }
}
