using Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    internal class CareerItem
    {
        public CareerItem(int Order, string title, string description, Course course)
        {
            if(course == null)
            {
                AddNotification(new Notification("Course", "Curso inválido"));
                //throw new System.Exception("O curso não pode ser nulo");
            }  
            Order = Order;
            Title = title;
            Description = description;
            Course = course;
        }

        private void AddNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
