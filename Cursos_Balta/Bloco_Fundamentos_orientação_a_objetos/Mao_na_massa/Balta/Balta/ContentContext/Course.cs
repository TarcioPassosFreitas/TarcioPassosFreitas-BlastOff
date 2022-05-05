using Balta.ContentContext;
using Balta.ContentContext.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta
{
    internal class Course : Content
    {
        public Course(string title, string url)
            : base(title, url)
        {
            modules = new List<Module>();
        }
        public string Tag { get; set; }

        public IList<Module> modules { get; set; }
        public int DurationInMinutes { get; set; }

        public EContentLevel level { get; set; }
    }
}
