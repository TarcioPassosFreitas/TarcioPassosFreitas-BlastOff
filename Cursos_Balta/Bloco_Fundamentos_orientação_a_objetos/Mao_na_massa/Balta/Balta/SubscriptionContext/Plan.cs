using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.SubscriptionContext
{
    internal class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Days { get; set; }
    }
}
