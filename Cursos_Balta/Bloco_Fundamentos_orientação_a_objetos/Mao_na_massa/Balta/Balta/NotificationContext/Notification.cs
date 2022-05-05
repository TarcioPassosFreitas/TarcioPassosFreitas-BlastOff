using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.NotificationContext
{
    internal sealed class Notification
    {
        public Notification()
        {

        }
        public Notification(string property, string message)
        {
            property = property;
            message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}
