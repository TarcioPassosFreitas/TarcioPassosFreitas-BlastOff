using Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.SubscriptionContext
{
    internal class Student : Base
    {
        public Student()
        {
            subscriptions = new List<Subscription>();    
        }
        public string Name { get; set; }

        public string Email { get; set; }
        public User user { get; set; }

        public IList<Subscription > subscriptions { get; set; }

        //public bool IsPremium => Subscription.AndDate <= DateTime.Now;

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new NotificationContext.Notification("Premium", "O aluno já tem assinatura ativa"));
                return;
            }

            subscriptions.Add(subscription); 
        }

        public bool IsPremium => subscriptions.Any(x => !x.IsNactive);

       // public bool Ispremiun { get; private set; }
    }
}
