using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.SubscriptionContext
{
    internal class Subscription : Base
    {
        public static DateTime AndDate { get; internal set; }
        public Plan plan { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsNactive { get; set; }
    }
}
