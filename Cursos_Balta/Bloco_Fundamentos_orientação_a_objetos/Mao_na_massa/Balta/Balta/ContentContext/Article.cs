using Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta
{
    internal class Article : Content
    {
        public IList<Notification> Notifications { get; set; }
        public Article(string title, string url)
            :base(title, url)
        {

        }
    }
}
