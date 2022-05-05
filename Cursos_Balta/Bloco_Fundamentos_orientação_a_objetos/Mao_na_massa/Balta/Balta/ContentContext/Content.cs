using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta
{
    internal abstract class Content : Base
    {
        public Content(string title, string url)
        {
            //Id = Guid.NewGuid(); //Spof planos de falha
            Title = title;
            Url = url;
            
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
