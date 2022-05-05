using Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.SharedContext
{
    internal abstract class Base : Notifiable
    {
        public Base()
        {
            id = Guid.NewGuid();
        }
        public Guid id { get; set; }
    }
}
