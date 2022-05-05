using Balta.ContentContext;
using Balta.SubscriptionContext;
using System;

//https://github.com/andrebaltieri/flunt
//dotnet add package flunt

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var course = new Course();
            //course.level = ContentContext.Enum.EContentLevel.Beginner;
            //foreach(var item in course.modules)
            //{
            //    Console.WriteLine(item);
            //}
            //var career = new Career();
            //career.Items.Add(new CareerItem());
            //Console.WriteLine(career.totalCourses);

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientação-objetos"));
            articles.Add(new Article("Artigo sobre c#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);

            }

            var courses = new List<Course>();
            var courseOOP = new Course("Artigo sobre OOP", "Orientação-objetos");
            var coursecsharp = new Course("Artigo sobre c#", "csharp");
            var courseDotnet = new Course("Artigo sobre .Net", "dotnet");

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .Net", "Especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", coursecsharp);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem3 = new CareerItem(3, "Aprenda .Net", "", courseDotnet);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x=>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.level);

                    foreach(var notification in item.Course.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message} ");
                    }
                }
            }
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();

            student.subscriptions.Add(payPalSubscription);























        }
    }
}
